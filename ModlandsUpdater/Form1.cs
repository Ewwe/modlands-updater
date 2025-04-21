using System.ComponentModel;
using System.Net;

namespace ModlandsUpdater
{
    public partial class Form1 : Form
    {

        String url = "https://modlands.cz/mods.zip";
        String? selectedPath = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void choosePathButton_click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            System.Windows.Forms.DialogResult dr = fbd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                this.pathResult.Text = fbd.SelectedPath;
                this.selectedPath = fbd.SelectedPath;
                this.checkForUpdatesButton.Visible = true;
                this.pathLabel.Visible = true;
                this.pathResult.Visible = true;
            }
        }

        private void checkForUpdatesButton_Click(object sender, EventArgs e)
        {
            DialogResult confirmResult = MessageBox.Show("Tato akce smaže aktuální šložku mods a nahradí novou.",
                                     "Jsi si jistý že to chceš udìlat ?",
                                     MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                if (this.selectedPath != null)
                {
                    WebClient webClient = new WebClient();
                    if (File.Exists(this.selectedPath + "/mods.zip"))
                    {
                        File.Delete(this.selectedPath + "/mods.zip");
                    }
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                    webClient.DownloadFileAsync(new Uri(this.url), this.selectedPath + "/mods.zip");
                    this.updateProgress.Visible = true;
                    this.progressLabel.Visible = true;
                }
            }

        }


        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;
            this.progressLabel.Text = "Staženo " + Math.Round(bytesIn / Math.Pow(1024, 2)) + "mb z " + Math.Round(totalBytes / Math.Pow(1024, 2)) + "mb";
            this.updateProgress.Value = int.Parse(Math.Truncate(percentage).ToString());
        }

        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            this.updateProgress.Visible = false;
            this.progressLabel.Visible = false;
            try
            {
                if (Directory.Exists(this.selectedPath + "/mods"))
                {
                    Directory.Delete(this.selectedPath + "/mods", true);
                }

                System.IO.Compression.ZipFile.ExtractToDirectory(this.selectedPath + "/mods.zip", this.selectedPath);
                this.pathLabel.Visible = false;
                this.pathResult.Visible = false;
                this.checkForUpdatesButton.Visible = false;
                this.selectedPath = null;

                DialogResult confirmResult = MessageBox.Show("Aktualizace módù se povedla. Po kliknutí na OK se apka zavøe",
                                         "Aktualizace úspìšná",
                                         MessageBoxButtons.OK);
                if (confirmResult == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Aktualizace módù se nepovedla Chyba:" + ex.Message.ToString(),
                                         "Aktualizace úspìšná",
                                         MessageBoxButtons.OK);
            }


        }
    }
}
