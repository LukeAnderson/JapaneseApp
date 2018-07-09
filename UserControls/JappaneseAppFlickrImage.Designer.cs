﻿namespace JapaneseApp.UserControls
{
    partial class JappaneseAppFlickrImage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JappaneseAppFlickrImage));
            this.backTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.imageQualityTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.mediumRadioButton = new System.Windows.Forms.RadioButton();
            this.smallRadioButton = new System.Windows.Forms.RadioButton();
            this.thumbnailRadioButton = new System.Windows.Forms.RadioButton();
            this.ImageQualityLabel = new System.Windows.Forms.Label();
            this.backTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.imageQualityTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // backTableLayoutPanel
            // 
            this.backTableLayoutPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.backTableLayoutPanel.ColumnCount = 2;
            this.backTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.41463F));
            this.backTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.58537F));
            this.backTableLayoutPanel.Controls.Add(this.pictureBox, 1, 0);
            this.backTableLayoutPanel.Controls.Add(this.imageQualityTableLayoutPanel, 0, 0);
            this.backTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.backTableLayoutPanel.Name = "backTableLayoutPanel";
            this.backTableLayoutPanel.RowCount = 1;
            this.backTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.backTableLayoutPanel.Size = new System.Drawing.Size(820, 491);
            this.backTableLayoutPanel.TabIndex = 1;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Image = global::JapaneseApp.Properties.Resources.JapaneseAppVersion1_4;
            this.pictureBox.Location = new System.Drawing.Point(153, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(664, 485);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // imageQualityTableLayoutPanel
            // 
            this.imageQualityTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.imageQualityTableLayoutPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.imageQualityTableLayoutPanel.ColumnCount = 1;
            this.imageQualityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.imageQualityTableLayoutPanel.Controls.Add(this.mediumRadioButton, 0, 3);
            this.imageQualityTableLayoutPanel.Controls.Add(this.smallRadioButton, 0, 2);
            this.imageQualityTableLayoutPanel.Controls.Add(this.ImageQualityLabel, 0, 0);
            this.imageQualityTableLayoutPanel.Controls.Add(this.thumbnailRadioButton, 0, 1);
            this.imageQualityTableLayoutPanel.Location = new System.Drawing.Point(3, 368);
            this.imageQualityTableLayoutPanel.Name = "imageQualityTableLayoutPanel";
            this.imageQualityTableLayoutPanel.RowCount = 5;
            this.imageQualityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.imageQualityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.imageQualityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.imageQualityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.imageQualityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.imageQualityTableLayoutPanel.Size = new System.Drawing.Size(144, 120);
            this.imageQualityTableLayoutPanel.TabIndex = 2;
            // 
            // mediumRadioButton
            // 
            this.mediumRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mediumRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.mediumRadioButton.AutoSize = true;
            this.mediumRadioButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mediumRadioButton.BackgroundImage")));
            this.mediumRadioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mediumRadioButton.Checked = true;
            this.mediumRadioButton.Font = new System.Drawing.Font("Hanzel Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediumRadioButton.Location = new System.Drawing.Point(42, 93);
            this.mediumRadioButton.MaximumSize = new System.Drawing.Size(60, 0);
            this.mediumRadioButton.MinimumSize = new System.Drawing.Size(60, 0);
            this.mediumRadioButton.Name = "mediumRadioButton";
            this.mediumRadioButton.Size = new System.Drawing.Size(60, 24);
            this.mediumRadioButton.TabIndex = 4;
            this.mediumRadioButton.TabStop = true;
            this.mediumRadioButton.Text = "HQ";
            this.mediumRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mediumRadioButton.UseVisualStyleBackColor = true;
            // 
            // smallRadioButton
            // 
            this.smallRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.smallRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.smallRadioButton.AutoSize = true;
            this.smallRadioButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("smallRadioButton.BackgroundImage")));
            this.smallRadioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.smallRadioButton.Font = new System.Drawing.Font("Hanzel Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smallRadioButton.Location = new System.Drawing.Point(42, 63);
            this.smallRadioButton.MaximumSize = new System.Drawing.Size(60, 0);
            this.smallRadioButton.MinimumSize = new System.Drawing.Size(60, 0);
            this.smallRadioButton.Name = "smallRadioButton";
            this.smallRadioButton.Size = new System.Drawing.Size(60, 24);
            this.smallRadioButton.TabIndex = 3;
            this.smallRadioButton.TabStop = true;
            this.smallRadioButton.Text = "MQ";
            this.smallRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.smallRadioButton.UseVisualStyleBackColor = true;
            // 
            // thumbnailRadioButton
            // 
            this.thumbnailRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.thumbnailRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.thumbnailRadioButton.AutoSize = true;
            this.thumbnailRadioButton.BackgroundImage = global::JapaneseApp.Properties.Resources.JapaneseAppVersion1_4;
            this.thumbnailRadioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.thumbnailRadioButton.Font = new System.Drawing.Font("Hanzel Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thumbnailRadioButton.Location = new System.Drawing.Point(42, 33);
            this.thumbnailRadioButton.MaximumSize = new System.Drawing.Size(60, 0);
            this.thumbnailRadioButton.MinimumSize = new System.Drawing.Size(60, 0);
            this.thumbnailRadioButton.Name = "thumbnailRadioButton";
            this.thumbnailRadioButton.Size = new System.Drawing.Size(60, 24);
            this.thumbnailRadioButton.TabIndex = 0;
            this.thumbnailRadioButton.TabStop = true;
            this.thumbnailRadioButton.Text = "LQ";
            this.thumbnailRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.thumbnailRadioButton.UseVisualStyleBackColor = true;
            // 
            // ImageQualityLabel
            // 
            this.ImageQualityLabel.AutoSize = true;
            this.ImageQualityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImageQualityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImageQualityLabel.Location = new System.Drawing.Point(3, 0);
            this.ImageQualityLabel.Name = "ImageQualityLabel";
            this.ImageQualityLabel.Size = new System.Drawing.Size(138, 30);
            this.ImageQualityLabel.TabIndex = 1;
            this.ImageQualityLabel.Text = "Image Quality";
            this.ImageQualityLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // JappaneseAppFlickrImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backTableLayoutPanel);
            this.Name = "JappaneseAppFlickrImage";
            this.Size = new System.Drawing.Size(820, 491);
            this.backTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.imageQualityTableLayoutPanel.ResumeLayout(false);
            this.imageQualityTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel backTableLayoutPanel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TableLayoutPanel imageQualityTableLayoutPanel;
        private System.Windows.Forms.RadioButton mediumRadioButton;
        private System.Windows.Forms.RadioButton smallRadioButton;
        private System.Windows.Forms.RadioButton thumbnailRadioButton;
        private System.Windows.Forms.Label ImageQualityLabel;
    }
}
