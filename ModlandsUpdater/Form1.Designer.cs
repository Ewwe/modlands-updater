namespace ModlandsUpdater
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            checkForUpdatesButton = new Button();
            updateProgress = new ProgressBar();
            choosePathButton = new Button();
            pathLabel = new Label();
            pathResult = new Label();
            progressLabel = new Label();
            SuspendLayout();
            // 
            // checkForUpdatesButton
            // 
            checkForUpdatesButton.Location = new Point(248, 12);
            checkForUpdatesButton.Name = "checkForUpdatesButton";
            checkForUpdatesButton.Size = new Size(155, 35);
            checkForUpdatesButton.TabIndex = 0;
            checkForUpdatesButton.Text = "Nainstalovat aktualizace";
            checkForUpdatesButton.UseVisualStyleBackColor = true;
            checkForUpdatesButton.Visible = false;
            checkForUpdatesButton.Click += checkForUpdatesButton_Click;
            // 
            // updateProgress
            // 
            updateProgress.Location = new Point(12, 99);
            updateProgress.Name = "updateProgress";
            updateProgress.Size = new Size(391, 23);
            updateProgress.TabIndex = 1;
            updateProgress.Visible = false;
            // 
            // choosePathButton
            // 
            choosePathButton.Location = new Point(12, 12);
            choosePathButton.Name = "choosePathButton";
            choosePathButton.Size = new Size(199, 35);
            choosePathButton.TabIndex = 2;
            choosePathButton.Text = "Vyber cestu k modpacku";
            choosePathButton.UseVisualStyleBackColor = true;
            choosePathButton.Click += choosePathButton_click;
            // 
            // pathLabel
            // 
            pathLabel.AutoSize = true;
            pathLabel.Location = new Point(12, 81);
            pathLabel.Name = "pathLabel";
            pathLabel.Size = new Size(42, 15);
            pathLabel.TabIndex = 3;
            pathLabel.Text = "Cesta: ";
            pathLabel.Visible = false;
            // 
            // pathResult
            // 
            pathResult.AutoSize = true;
            pathResult.Location = new Point(50, 81);
            pathResult.Name = "pathResult";
            pathResult.Size = new Size(38, 15);
            pathResult.TabIndex = 6;
            pathResult.Text = "label4";
            pathResult.Visible = false;
            // 
            // progressLabel
            // 
            progressLabel.AutoSize = true;
            progressLabel.Location = new Point(12, 125);
            progressLabel.Name = "progressLabel";
            progressLabel.Size = new Size(38, 15);
            progressLabel.TabIndex = 7;
            progressLabel.Text = "label1";
            progressLabel.TextAlign = ContentAlignment.BottomCenter;
            progressLabel.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 146);
            Controls.Add(progressLabel);
            Controls.Add(pathResult);
            Controls.Add(pathLabel);
            Controls.Add(choosePathButton);
            Controls.Add(updateProgress);
            Controls.Add(checkForUpdatesButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = " Modlands Updater";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button checkForUpdatesButton;
        private ProgressBar updateProgress;
        private Button choosePathButton;
        private Label pathLabel;
        private Label pathResult;
        private Label progressLabel;
        private LinkLabel linkLabel1;
    }
}
