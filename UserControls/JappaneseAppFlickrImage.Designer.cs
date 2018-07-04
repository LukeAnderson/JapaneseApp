namespace JapaneseApp.UserControls
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
            this.backTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mediumRadioButton = new System.Windows.Forms.RadioButton();
            this.smallRadioButton = new System.Windows.Forms.RadioButton();
            this.thumbnailRadioButton = new System.Windows.Forms.RadioButton();
            this.ImageQualityLabel = new System.Windows.Forms.Label();
            this.backTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backTableLayoutPanel
            // 
            this.backTableLayoutPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.backTableLayoutPanel.ColumnCount = 2;
            this.backTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.41463F));
            this.backTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.58537F));
            this.backTableLayoutPanel.Controls.Add(this.pictureBox, 1, 0);
            this.backTableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 0);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.mediumRadioButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.smallRadioButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.thumbnailRadioButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ImageQualityLabel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 381);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(144, 107);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // mediumRadioButton
            // 
            this.mediumRadioButton.AutoSize = true;
            this.mediumRadioButton.Checked = true;
            this.mediumRadioButton.Location = new System.Drawing.Point(25, 78);
            this.mediumRadioButton.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.mediumRadioButton.Name = "mediumRadioButton";
            this.mediumRadioButton.Size = new System.Drawing.Size(52, 17);
            this.mediumRadioButton.TabIndex = 4;
            this.mediumRadioButton.TabStop = true;
            this.mediumRadioButton.Text = "Large";
            this.mediumRadioButton.UseVisualStyleBackColor = true;
            // 
            // smallRadioButton
            // 
            this.smallRadioButton.AutoSize = true;
            this.smallRadioButton.Location = new System.Drawing.Point(25, 53);
            this.smallRadioButton.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.smallRadioButton.Name = "smallRadioButton";
            this.smallRadioButton.Size = new System.Drawing.Size(50, 17);
            this.smallRadioButton.TabIndex = 3;
            this.smallRadioButton.TabStop = true;
            this.smallRadioButton.Text = "Small";
            this.smallRadioButton.UseVisualStyleBackColor = true;
            // 
            // thumbnailRadioButton
            // 
            this.thumbnailRadioButton.AutoSize = true;
            this.thumbnailRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thumbnailRadioButton.Location = new System.Drawing.Point(25, 28);
            this.thumbnailRadioButton.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.thumbnailRadioButton.Name = "thumbnailRadioButton";
            this.thumbnailRadioButton.Size = new System.Drawing.Size(116, 19);
            this.thumbnailRadioButton.TabIndex = 0;
            this.thumbnailRadioButton.TabStop = true;
            this.thumbnailRadioButton.Text = "Thumbnail";
            this.thumbnailRadioButton.UseVisualStyleBackColor = true;
            // 
            // ImageQualityLabel
            // 
            this.ImageQualityLabel.AutoSize = true;
            this.ImageQualityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImageQualityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImageQualityLabel.Location = new System.Drawing.Point(3, 0);
            this.ImageQualityLabel.Name = "ImageQualityLabel";
            this.ImageQualityLabel.Size = new System.Drawing.Size(138, 25);
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
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel backTableLayoutPanel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton mediumRadioButton;
        private System.Windows.Forms.RadioButton smallRadioButton;
        private System.Windows.Forms.RadioButton thumbnailRadioButton;
        private System.Windows.Forms.Label ImageQualityLabel;
    }
}
