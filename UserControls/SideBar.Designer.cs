namespace JapaneseApp.UserControls
{
    partial class SideBar
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
            this.sideBarLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.sideBarDjtGuideButton = new System.Windows.Forms.Button();
            this.sideBarWordSearchButton = new System.Windows.Forms.Button();
            this.sideBarLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideBarLayoutPanel
            // 
            this.sideBarLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sideBarLayoutPanel.ColumnCount = 1;
            this.sideBarLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.sideBarLayoutPanel.Controls.Add(this.sideBarDjtGuideButton, 0, 1);
            this.sideBarLayoutPanel.Controls.Add(this.sideBarWordSearchButton, 0, 0);
            this.sideBarLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideBarLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.sideBarLayoutPanel.Name = "sideBarLayoutPanel";
            this.sideBarLayoutPanel.RowCount = 2;
            this.sideBarLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.sideBarLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.sideBarLayoutPanel.Size = new System.Drawing.Size(111, 659);
            this.sideBarLayoutPanel.TabIndex = 7;
            // 
            // sideBarDjtGuideButton
            // 
            this.sideBarDjtGuideButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideBarDjtGuideButton.Location = new System.Drawing.Point(3, 78);
            this.sideBarDjtGuideButton.Name = "sideBarDjtGuideButton";
            this.sideBarDjtGuideButton.Size = new System.Drawing.Size(105, 74);
            this.sideBarDjtGuideButton.TabIndex = 1;
            this.sideBarDjtGuideButton.Text = "DJT Guide";
            this.sideBarDjtGuideButton.UseVisualStyleBackColor = true;
            // 
            // sideBarWordSearchButton
            // 
            this.sideBarWordSearchButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideBarWordSearchButton.Location = new System.Drawing.Point(3, 3);
            this.sideBarWordSearchButton.Name = "sideBarWordSearchButton";
            this.sideBarWordSearchButton.Size = new System.Drawing.Size(105, 69);
            this.sideBarWordSearchButton.TabIndex = 0;
            this.sideBarWordSearchButton.Text = "Word Search";
            this.sideBarWordSearchButton.UseVisualStyleBackColor = true;
            // 
            // SideBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sideBarLayoutPanel);
            this.Name = "SideBar";
            this.Size = new System.Drawing.Size(111, 659);
            this.sideBarLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel sideBarLayoutPanel;
        private System.Windows.Forms.Button sideBarDjtGuideButton;
        private System.Windows.Forms.Button sideBarWordSearchButton;
    }
}
