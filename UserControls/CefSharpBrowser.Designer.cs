namespace JapaneseApp.UserControls
{
    partial class CefSharpBrowser
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backButton = new System.Windows.Forms.Button();
            this.forwardButton = new System.Windows.Forms.Button();
            this.chromeBrowserPanel = new System.Windows.Forms.Panel();
            this.chromeBrowserPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(56, 41);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // forwardButton
            // 
            this.forwardButton.Location = new System.Drawing.Point(65, 3);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(58, 40);
            this.forwardButton.TabIndex = 1;
            this.forwardButton.Text = "Forward";
            this.forwardButton.UseVisualStyleBackColor = true;
            this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
            // 
            // chromeBrowserPanel
            // 
            this.chromeBrowserPanel.Controls.Add(this.forwardButton);
            this.chromeBrowserPanel.Controls.Add(this.backButton);
            this.chromeBrowserPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chromeBrowserPanel.Location = new System.Drawing.Point(0, 0);
            this.chromeBrowserPanel.Name = "chromeBrowserPanel";
            this.chromeBrowserPanel.Size = new System.Drawing.Size(650, 590);
            this.chromeBrowserPanel.TabIndex = 2;
            // 
            // CefSharpBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chromeBrowserPanel);
            this.Name = "CefSharpBrowser";
            this.Size = new System.Drawing.Size(650, 590);
            this.chromeBrowserPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button forwardButton;
        private System.Windows.Forms.Panel chromeBrowserPanel;
    }
}
