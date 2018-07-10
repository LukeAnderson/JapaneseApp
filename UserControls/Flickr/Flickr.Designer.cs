namespace JapaneseApp.UserControls.Flickr
{
    partial class Flickr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Flickr));
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.flickrImageSearchTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.suggestedImageSearchTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.suggestedImageSearchLabel = new System.Windows.Forms.Label();
            this.onRadioButton = new System.Windows.Forms.RadioButton();
            this.offRadioButton = new System.Windows.Forms.RadioButton();
            this.topHalfTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.searchAndButtonTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.flickrImageSearchButton = new System.Windows.Forms.Button();
            this.imageSearchRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.imageQualityTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.mediumRadioButton = new System.Windows.Forms.RadioButton();
            this.smallRadioButton = new System.Windows.Forms.RadioButton();
            this.thumbnailRadioButton = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel.SuspendLayout();
            this.flickrImageSearchTableLayoutPanel.SuspendLayout();
            this.suggestedImageSearchTableLayoutPanel.SuspendLayout();
            this.topHalfTableLayoutPanel.SuspendLayout();
            this.searchAndButtonTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.imageQualityTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanel.Controls.Add(this.flickrImageSearchTableLayoutPanel);
            this.flowLayoutPanel.Controls.Add(this.pictureBox);
            this.flowLayoutPanel.Controls.Add(this.imageQualityTableLayoutPanel);
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(668, 192);
            this.flowLayoutPanel.TabIndex = 6;
            // 
            // flickrImageSearchTableLayoutPanel
            // 
            this.flickrImageSearchTableLayoutPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flickrImageSearchTableLayoutPanel.ColumnCount = 1;
            this.flickrImageSearchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.flickrImageSearchTableLayoutPanel.Controls.Add(this.suggestedImageSearchTableLayoutPanel, 0, 1);
            this.flickrImageSearchTableLayoutPanel.Controls.Add(this.topHalfTableLayoutPanel, 0, 0);
            this.flickrImageSearchTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.flickrImageSearchTableLayoutPanel.Name = "flickrImageSearchTableLayoutPanel";
            this.flickrImageSearchTableLayoutPanel.RowCount = 2;
            this.flickrImageSearchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.flickrImageSearchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.flickrImageSearchTableLayoutPanel.Size = new System.Drawing.Size(381, 176);
            this.flickrImageSearchTableLayoutPanel.TabIndex = 4;
            // 
            // suggestedImageSearchTableLayoutPanel
            // 
            this.suggestedImageSearchTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.suggestedImageSearchTableLayoutPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.suggestedImageSearchTableLayoutPanel.ColumnCount = 1;
            this.suggestedImageSearchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.suggestedImageSearchTableLayoutPanel.Controls.Add(this.suggestedImageSearchLabel, 0, 0);
            this.suggestedImageSearchTableLayoutPanel.Controls.Add(this.onRadioButton, 0, 1);
            this.suggestedImageSearchTableLayoutPanel.Controls.Add(this.offRadioButton, 0, 2);
            this.suggestedImageSearchTableLayoutPanel.Location = new System.Drawing.Point(181, 91);
            this.suggestedImageSearchTableLayoutPanel.Name = "suggestedImageSearchTableLayoutPanel";
            this.suggestedImageSearchTableLayoutPanel.RowCount = 3;
            this.suggestedImageSearchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.suggestedImageSearchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.suggestedImageSearchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.suggestedImageSearchTableLayoutPanel.Size = new System.Drawing.Size(197, 82);
            this.suggestedImageSearchTableLayoutPanel.TabIndex = 3;
            // 
            // suggestedImageSearchLabel
            // 
            this.suggestedImageSearchLabel.AutoSize = true;
            this.suggestedImageSearchLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.suggestedImageSearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suggestedImageSearchLabel.Location = new System.Drawing.Point(3, 3);
            this.suggestedImageSearchLabel.Margin = new System.Windows.Forms.Padding(3);
            this.suggestedImageSearchLabel.Name = "suggestedImageSearchLabel";
            this.suggestedImageSearchLabel.Size = new System.Drawing.Size(191, 27);
            this.suggestedImageSearchLabel.TabIndex = 0;
            this.suggestedImageSearchLabel.Text = "Suggested Image Search";
            // 
            // onRadioButton
            // 
            this.onRadioButton.AutoSize = true;
            this.onRadioButton.Checked = true;
            this.onRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.onRadioButton.Location = new System.Drawing.Point(3, 36);
            this.onRadioButton.Name = "onRadioButton";
            this.onRadioButton.Size = new System.Drawing.Size(191, 24);
            this.onRadioButton.TabIndex = 1;
            this.onRadioButton.TabStop = true;
            this.onRadioButton.Text = "On";
            this.onRadioButton.UseVisualStyleBackColor = true;
            // 
            // offRadioButton
            // 
            this.offRadioButton.AutoSize = true;
            this.offRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.offRadioButton.Location = new System.Drawing.Point(3, 66);
            this.offRadioButton.Name = "offRadioButton";
            this.offRadioButton.Size = new System.Drawing.Size(191, 20);
            this.offRadioButton.TabIndex = 2;
            this.offRadioButton.Text = "Off";
            this.offRadioButton.UseVisualStyleBackColor = true;
            // 
            // topHalfTableLayoutPanel
            // 
            this.topHalfTableLayoutPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.topHalfTableLayoutPanel.ColumnCount = 1;
            this.topHalfTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.29586F));
            this.topHalfTableLayoutPanel.Controls.Add(this.searchAndButtonTableLayout, 0, 1);
            this.topHalfTableLayoutPanel.Controls.Add(this.label1, 0, 0);
            this.topHalfTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topHalfTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.topHalfTableLayoutPanel.Name = "topHalfTableLayoutPanel";
            this.topHalfTableLayoutPanel.RowCount = 2;
            this.topHalfTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.71631F));
            this.topHalfTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.28369F));
            this.topHalfTableLayoutPanel.Size = new System.Drawing.Size(375, 82);
            this.topHalfTableLayoutPanel.TabIndex = 1;
            // 
            // searchAndButtonTableLayout
            // 
            this.searchAndButtonTableLayout.ColumnCount = 2;
            this.searchAndButtonTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.81818F));
            this.searchAndButtonTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.18182F));
            this.searchAndButtonTableLayout.Controls.Add(this.flickrImageSearchButton, 0, 0);
            this.searchAndButtonTableLayout.Controls.Add(this.imageSearchRichTextBox, 0, 0);
            this.searchAndButtonTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchAndButtonTableLayout.Location = new System.Drawing.Point(0, 32);
            this.searchAndButtonTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.searchAndButtonTableLayout.Name = "searchAndButtonTableLayout";
            this.searchAndButtonTableLayout.RowCount = 1;
            this.searchAndButtonTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.searchAndButtonTableLayout.Size = new System.Drawing.Size(375, 50);
            this.searchAndButtonTableLayout.TabIndex = 1;
            // 
            // flickrImageSearchButton
            // 
            this.flickrImageSearchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flickrImageSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flickrImageSearchButton.Location = new System.Drawing.Point(272, 3);
            this.flickrImageSearchButton.Name = "flickrImageSearchButton";
            this.flickrImageSearchButton.Size = new System.Drawing.Size(100, 44);
            this.flickrImageSearchButton.TabIndex = 3;
            this.flickrImageSearchButton.Text = "Searc h";
            this.flickrImageSearchButton.UseVisualStyleBackColor = true;
            // 
            // imageSearchRichTextBox
            // 
            this.imageSearchRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageSearchRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageSearchRichTextBox.Location = new System.Drawing.Point(3, 3);
            this.imageSearchRichTextBox.Name = "imageSearchRichTextBox";
            this.imageSearchRichTextBox.Size = new System.Drawing.Size(263, 44);
            this.imageSearchRichTextBox.TabIndex = 2;
            this.imageSearchRichTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flickr Image Search";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::JapaneseApp.Properties.Resources.JapaneseAppVersion1_4;
            this.pictureBox.Location = new System.Drawing.Point(390, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(189, 180);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // imageQualityTableLayoutPanel
            // 
            this.imageQualityTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.imageQualityTableLayoutPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.imageQualityTableLayoutPanel.ColumnCount = 1;
            this.imageQualityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.imageQualityTableLayoutPanel.Controls.Add(this.mediumRadioButton, 0, 2);
            this.imageQualityTableLayoutPanel.Controls.Add(this.smallRadioButton, 0, 1);
            this.imageQualityTableLayoutPanel.Controls.Add(this.thumbnailRadioButton, 0, 0);
            this.imageQualityTableLayoutPanel.Location = new System.Drawing.Point(585, 87);
            this.imageQualityTableLayoutPanel.Name = "imageQualityTableLayoutPanel";
            this.imageQualityTableLayoutPanel.RowCount = 3;
            this.imageQualityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.imageQualityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.imageQualityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.imageQualityTableLayoutPanel.Size = new System.Drawing.Size(66, 96);
            this.imageQualityTableLayoutPanel.TabIndex = 5;
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
            this.mediumRadioButton.Location = new System.Drawing.Point(3, 63);
            this.mediumRadioButton.MaximumSize = new System.Drawing.Size(60, 0);
            this.mediumRadioButton.MinimumSize = new System.Drawing.Size(60, 0);
            this.mediumRadioButton.Name = "mediumRadioButton";
            this.mediumRadioButton.Size = new System.Drawing.Size(60, 29);
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
            this.smallRadioButton.Location = new System.Drawing.Point(3, 33);
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
            this.thumbnailRadioButton.Location = new System.Drawing.Point(3, 3);
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
            // Flickr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel);
            this.Name = "Flickr";
            this.Size = new System.Drawing.Size(668, 192);
            this.flowLayoutPanel.ResumeLayout(false);
            this.flickrImageSearchTableLayoutPanel.ResumeLayout(false);
            this.suggestedImageSearchTableLayoutPanel.ResumeLayout(false);
            this.suggestedImageSearchTableLayoutPanel.PerformLayout();
            this.topHalfTableLayoutPanel.ResumeLayout(false);
            this.topHalfTableLayoutPanel.PerformLayout();
            this.searchAndButtonTableLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.imageQualityTableLayoutPanel.ResumeLayout(false);
            this.imageQualityTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel flickrImageSearchTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel suggestedImageSearchTableLayoutPanel;
        private System.Windows.Forms.Label suggestedImageSearchLabel;
        private System.Windows.Forms.RadioButton onRadioButton;
        private System.Windows.Forms.RadioButton offRadioButton;
        private System.Windows.Forms.TableLayoutPanel topHalfTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel searchAndButtonTableLayout;
        private System.Windows.Forms.Button flickrImageSearchButton;
        private System.Windows.Forms.RichTextBox imageSearchRichTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TableLayoutPanel imageQualityTableLayoutPanel;
        private System.Windows.Forms.RadioButton mediumRadioButton;
        private System.Windows.Forms.RadioButton smallRadioButton;
        private System.Windows.Forms.RadioButton thumbnailRadioButton;
    }
}
