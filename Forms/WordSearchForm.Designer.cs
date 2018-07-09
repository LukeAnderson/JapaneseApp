namespace JapaneseApp
{
    partial class WordSearchForm
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

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordSearchForm));
            this.backTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pagePanel = new System.Windows.Forms.Panel();
            this.page1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.jishoDataGridView = new JapaneseApp.UserControls.JishoDataGridView();
            this.upperLeftTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelEnglishWordsAndEnhance = new System.Windows.Forms.TableLayoutPanel();
            this.EnglishDefinitionTextBox = new System.Windows.Forms.RichTextBox();
            this.EnhanceTextBox = new System.Windows.Forms.RichTextBox();
            this.jishoSearch = new JapaneseApp.UserControls.JishoSearch();
            this.flickrImageSearch = new JapaneseApp.FlickrImageSearch();
            this.FlickrImage = new JapaneseApp.UserControls.JappaneseAppFlickrImage();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishDefinitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.japaneseDefinitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.sideBar1 = new JapaneseApp.UserControls.SideBar();
            this.backTableLayoutPanel.SuspendLayout();
            this.pagePanel.SuspendLayout();
            this.page1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.upperLeftTableLayoutPanel.SuspendLayout();
            this.tableLayoutPanelEnglishWordsAndEnhance.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // backTableLayoutPanel
            // 
            this.backTableLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.backTableLayoutPanel.ColumnCount = 2;
            this.backTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.backTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.backTableLayoutPanel.Controls.Add(this.pagePanel, 1, 0);
            this.backTableLayoutPanel.Controls.Add(this.sideBar1, 0, 0);
            this.backTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backTableLayoutPanel.Location = new System.Drawing.Point(0, 24);
            this.backTableLayoutPanel.Name = "backTableLayoutPanel";
            this.backTableLayoutPanel.RowCount = 1;
            this.backTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.backTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 388F));
            this.backTableLayoutPanel.Size = new System.Drawing.Size(887, 388);
            this.backTableLayoutPanel.TabIndex = 7;
            // 
            // pagePanel
            // 
            this.pagePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pagePanel.Controls.Add(this.page1);
            this.pagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pagePanel.Location = new System.Drawing.Point(103, 3);
            this.pagePanel.Name = "pagePanel";
            this.pagePanel.Size = new System.Drawing.Size(781, 382);
            this.pagePanel.TabIndex = 7;
            // 
            // page1
            // 
            this.page1.BackColor = System.Drawing.Color.LightGray;
            this.page1.ColumnCount = 2;
            this.page1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.28302F));
            this.page1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.71698F));
            this.page1.Controls.Add(this.panel2, 1, 0);
            this.page1.Controls.Add(this.upperLeftTableLayoutPanel, 0, 0);
            this.page1.Controls.Add(this.flickrImageSearch, 0, 1);
            this.page1.Controls.Add(this.FlickrImage, 1, 1);
            this.page1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page1.Location = new System.Drawing.Point(0, 0);
            this.page1.Margin = new System.Windows.Forms.Padding(0);
            this.page1.Name = "page1";
            this.page1.RowCount = 2;
            this.page1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.page1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.page1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.page1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.page1.Size = new System.Drawing.Size(781, 382);
            this.page1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.jishoDataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(353, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(428, 191);
            this.panel2.TabIndex = 3;
            // 
            // jishoDataGridView
            // 
            this.jishoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jishoDataGridView.Location = new System.Drawing.Point(0, 0);
            this.jishoDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.jishoDataGridView.Name = "jishoDataGridView";
            this.jishoDataGridView.Size = new System.Drawing.Size(428, 191);
            this.jishoDataGridView.TabIndex = 0;
            // 
            // upperLeftTableLayoutPanel
            // 
            this.upperLeftTableLayoutPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.upperLeftTableLayoutPanel.ColumnCount = 1;
            this.upperLeftTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.upperLeftTableLayoutPanel.Controls.Add(this.tableLayoutPanelEnglishWordsAndEnhance, 0, 0);
            this.upperLeftTableLayoutPanel.Controls.Add(this.jishoSearch, 0, 1);
            this.upperLeftTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.upperLeftTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.upperLeftTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.upperLeftTableLayoutPanel.Name = "upperLeftTableLayoutPanel";
            this.upperLeftTableLayoutPanel.RowCount = 2;
            this.upperLeftTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.15151F));
            this.upperLeftTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.84848F));
            this.upperLeftTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.upperLeftTableLayoutPanel.Size = new System.Drawing.Size(353, 191);
            this.upperLeftTableLayoutPanel.TabIndex = 4;
            // 
            // tableLayoutPanelEnglishWordsAndEnhance
            // 
            this.tableLayoutPanelEnglishWordsAndEnhance.ColumnCount = 2;
            this.tableLayoutPanelEnglishWordsAndEnhance.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelEnglishWordsAndEnhance.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelEnglishWordsAndEnhance.Controls.Add(this.EnglishDefinitionTextBox, 0, 0);
            this.tableLayoutPanelEnglishWordsAndEnhance.Controls.Add(this.EnhanceTextBox, 1, 0);
            this.tableLayoutPanelEnglishWordsAndEnhance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelEnglishWordsAndEnhance.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelEnglishWordsAndEnhance.Name = "tableLayoutPanelEnglishWordsAndEnhance";
            this.tableLayoutPanelEnglishWordsAndEnhance.RowCount = 1;
            this.tableLayoutPanelEnglishWordsAndEnhance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelEnglishWordsAndEnhance.Size = new System.Drawing.Size(347, 118);
            this.tableLayoutPanelEnglishWordsAndEnhance.TabIndex = 7;
            // 
            // EnglishDefinitionTextBox
            // 
            this.EnglishDefinitionTextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.EnglishDefinitionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnglishDefinitionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnglishDefinitionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnglishDefinitionTextBox.Location = new System.Drawing.Point(3, 3);
            this.EnglishDefinitionTextBox.Name = "EnglishDefinitionTextBox";
            this.EnglishDefinitionTextBox.ReadOnly = true;
            this.EnglishDefinitionTextBox.Size = new System.Drawing.Size(167, 112);
            this.EnglishDefinitionTextBox.TabIndex = 5;
            this.EnglishDefinitionTextBox.Text = "English Words:";
            // 
            // EnhanceTextBox
            // 
            this.EnhanceTextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.EnhanceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnhanceTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnhanceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnhanceTextBox.Location = new System.Drawing.Point(176, 3);
            this.EnhanceTextBox.Name = "EnhanceTextBox";
            this.EnhanceTextBox.ReadOnly = true;
            this.EnhanceTextBox.Size = new System.Drawing.Size(168, 112);
            this.EnhanceTextBox.TabIndex = 6;
            this.EnhanceTextBox.Text = "";
            // 
            // jishoSearch
            // 
            this.jishoSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jishoSearch.Location = new System.Drawing.Point(3, 127);
            this.jishoSearch.Name = "jishoSearch";
            this.jishoSearch.Size = new System.Drawing.Size(347, 61);
            this.jishoSearch.TabIndex = 3;
            // 
            // flickrImageSearch
            // 
            this.flickrImageSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flickrImageSearch.Location = new System.Drawing.Point(0, 191);
            this.flickrImageSearch.Margin = new System.Windows.Forms.Padding(0);
            this.flickrImageSearch.Name = "flickrImageSearch";
            this.flickrImageSearch.Size = new System.Drawing.Size(353, 191);
            this.flickrImageSearch.TabIndex = 9;
            // 
            // FlickrImage
            // 
            this.FlickrImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlickrImage.Location = new System.Drawing.Point(353, 191);
            this.FlickrImage.Margin = new System.Windows.Forms.Padding(0);
            this.FlickrImage.Name = "FlickrImage";
            this.FlickrImage.Size = new System.Drawing.Size(428, 191);
            this.FlickrImage.TabIndex = 10;
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.menuToolStripMenuItem.Text = "Sidebar";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishDefinitionToolStripMenuItem,
            this.japaneseDefinitionToolStripMenuItem});
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // englishDefinitionToolStripMenuItem
            // 
            this.englishDefinitionToolStripMenuItem.Name = "englishDefinitionToolStripMenuItem";
            this.englishDefinitionToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.englishDefinitionToolStripMenuItem.Text = "English Definition";
            this.englishDefinitionToolStripMenuItem.Click += new System.EventHandler(this.englishDefinitionToolStripMenuItem_Click);
            // 
            // japaneseDefinitionToolStripMenuItem
            // 
            this.japaneseDefinitionToolStripMenuItem.Name = "japaneseDefinitionToolStripMenuItem";
            this.japaneseDefinitionToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.japaneseDefinitionToolStripMenuItem.Text = "Japanese Definition";
            this.japaneseDefinitionToolStripMenuItem.Click += new System.EventHandler(this.japaneseDefinitionToolStripMenuItem_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.fontToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(887, 24);
            this.menuStrip.TabIndex = 6;
            this.menuStrip.Text = "menuStrip1";
            // 
            // sideBar1
            // 
            this.sideBar1.Location = new System.Drawing.Point(3, 3);
            this.sideBar1.Name = "sideBar1";
            this.sideBar1.Size = new System.Drawing.Size(94, 382);
            this.sideBar1.TabIndex = 8;
            // 
            // WordSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(0)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(887, 412);
            this.Controls.Add(this.backTableLayoutPanel);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "WordSearchForm";
            this.Text = "Japanese App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.backTableLayoutPanel.ResumeLayout(false);
            this.pagePanel.ResumeLayout(false);
            this.page1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.upperLeftTableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanelEnglishWordsAndEnhance.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel backTableLayoutPanel;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishDefinitionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem japaneseDefinitionToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Panel pagePanel;
        private System.Windows.Forms.TableLayoutPanel page1;
        private System.Windows.Forms.Panel panel2;
        private UserControls.JishoDataGridView jishoDataGridView;
        private System.Windows.Forms.TableLayoutPanel upperLeftTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelEnglishWordsAndEnhance;
        private System.Windows.Forms.RichTextBox EnglishDefinitionTextBox;
        private System.Windows.Forms.RichTextBox EnhanceTextBox;
        private UserControls.JishoSearch jishoSearch;
        private FlickrImageSearch flickrImageSearch;
        private UserControls.JappaneseAppFlickrImage FlickrImage;
        private UserControls.SideBar sideBar1;
    }
}

