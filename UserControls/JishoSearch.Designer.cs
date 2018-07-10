namespace JapaneseApp.UserControls
{
    partial class JishoSearch
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
            this.searchButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.searchPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.searchTextbox = new System.Windows.Forms.RichTextBox();
            this.wordSearchLabel = new System.Windows.Forms.Label();
            this.searchPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(320, 32);
            this.searchButton.MaximumSize = new System.Drawing.Size(100, 50);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(76, 36);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // nextButton
            // 
            this.nextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(402, 32);
            this.nextButton.MaximumSize = new System.Drawing.Size(100, 50);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(51, 36);
            this.nextButton.TabIndex = 5;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            // 
            // searchPanel
            // 
            this.searchPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.searchPanel.ColumnCount = 3;
            this.searchPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.searchPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.searchPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.searchPanel.Controls.Add(this.nextButton, 2, 0);
            this.searchPanel.Controls.Add(this.searchButton, 1, 0);
            this.searchPanel.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.searchPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchPanel.Location = new System.Drawing.Point(0, 0);
            this.searchPanel.Margin = new System.Windows.Forms.Padding(0);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.RowCount = 1;
            this.searchPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.searchPanel.Size = new System.Drawing.Size(456, 71);
            this.searchPanel.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.searchTextbox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.wordSearchLabel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(311, 65);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // searchTextbox
            // 
            this.searchTextbox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.searchTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextbox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.searchTextbox.Location = new System.Drawing.Point(3, 26);
            this.searchTextbox.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(308, 36);
            this.searchTextbox.TabIndex = 9;
            this.searchTextbox.Text = "Search Words";
            this.searchTextbox.GotFocus += new System.EventHandler(this.searchTextbox_GotFocus);
            // 
            // wordSearchLabel
            // 
            this.wordSearchLabel.AutoSize = true;
            this.wordSearchLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.wordSearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordSearchLabel.Location = new System.Drawing.Point(3, 0);
            this.wordSearchLabel.Name = "wordSearchLabel";
            this.wordSearchLabel.Size = new System.Drawing.Size(305, 20);
            this.wordSearchLabel.TabIndex = 0;
            this.wordSearchLabel.Text = "Word Search";
            this.wordSearchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // JishoSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchPanel);
            this.Name = "JishoSearch";
            this.Size = new System.Drawing.Size(456, 71);
            this.searchPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.TableLayoutPanel searchPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox searchTextbox;
        private System.Windows.Forms.Label wordSearchLabel;
    }
}
