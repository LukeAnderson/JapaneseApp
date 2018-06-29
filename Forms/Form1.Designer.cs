namespace JapaneseApp
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.KanjiColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KanaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RomajiColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartOfSpeechColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.japaneseTextBox = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.searchPanel = new System.Windows.Forms.TableLayoutPanel();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextbox = new System.Windows.Forms.RichTextBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanelEnglishWordsAndEnhance = new System.Windows.Forms.TableLayoutPanel();
            this.EnglishDefinitionTextBox = new System.Windows.Forms.RichTextBox();
            this.EnhanceTextBox = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TableLayoutBottomLeft = new System.Windows.Forms.TableLayoutPanel();
            this.ImageQualityTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.mediumRadioButton = new System.Windows.Forms.RadioButton();
            this.thumbnailRadioButton = new System.Windows.Forms.RadioButton();
            this.smallRadioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.topHalfFlickrImageSearcchTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.searchAndButtonTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.flickrImageSearchButton = new System.Windows.Forms.Button();
            this.imageTagSearchBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BottomHalfFlickrTable = new System.Windows.Forms.TableLayoutPanel();
            this.TableSuggestedSeach = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.onRadioButton = new System.Windows.Forms.RadioButton();
            this.offRadioButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishDefinitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.japaneseDefinitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanelEnglishWordsAndEnhance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TableLayoutBottomLeft.SuspendLayout();
            this.ImageQualityTableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.topHalfFlickrImageSearcchTableLayout.SuspendLayout();
            this.searchAndButtonTableLayout.SuspendLayout();
            this.BottomHalfFlickrTable.SuspendLayout();
            this.TableSuggestedSeach.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.japaneseTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(809, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 277);
            this.panel1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KanjiColumn,
            this.KanaColumn,
            this.RomajiColumn,
            this.PartOfSpeechColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(639, 249);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // KanjiColumn
            // 
            this.KanjiColumn.HeaderText = "Kanji";
            this.KanjiColumn.Name = "KanjiColumn";
            this.KanjiColumn.ReadOnly = true;
            // 
            // KanaColumn
            // 
            this.KanaColumn.HeaderText = "Kana";
            this.KanaColumn.Name = "KanaColumn";
            this.KanaColumn.ReadOnly = true;
            // 
            // RomajiColumn
            // 
            this.RomajiColumn.HeaderText = "Romaji";
            this.RomajiColumn.Name = "RomajiColumn";
            this.RomajiColumn.ReadOnly = true;
            // 
            // PartOfSpeechColumn
            // 
            this.PartOfSpeechColumn.HeaderText = "Part Of Speech";
            this.PartOfSpeechColumn.Name = "PartOfSpeechColumn";
            this.PartOfSpeechColumn.ReadOnly = true;
            // 
            // japaneseTextBox
            // 
            this.japaneseTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.japaneseTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.japaneseTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.japaneseTextBox.Location = new System.Drawing.Point(0, 0);
            this.japaneseTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.japaneseTextBox.Name = "japaneseTextBox";
            this.japaneseTextBox.ReadOnly = true;
            this.japaneseTextBox.Size = new System.Drawing.Size(639, 28);
            this.japaneseTextBox.TabIndex = 2;
            this.japaneseTextBox.Text = "Japanese Words:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.LightGray;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.89743F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.10257F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TableLayoutBottomLeft, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1448, 554);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.searchPanel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.15151F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.84848F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(809, 277);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // searchPanel
            // 
            this.searchPanel.ColumnCount = 4;
            this.searchPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.00888F));
            this.searchPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.66431F));
            this.searchPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.66248F));
            this.searchPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.66431F));
            this.searchPanel.Controls.Add(this.searchButton, 0, 0);
            this.searchPanel.Controls.Add(this.searchTextbox, 0, 0);
            this.searchPanel.Controls.Add(this.nextButton, 2, 0);
            this.searchPanel.Controls.Add(this.pictureBox2, 3, 0);
            this.searchPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchPanel.Location = new System.Drawing.Point(0, 180);
            this.searchPanel.Margin = new System.Windows.Forms.Padding(0);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.RowCount = 1;
            this.searchPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.searchPanel.Size = new System.Drawing.Size(809, 97);
            this.searchPanel.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(399, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(144, 91);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextbox
            // 
            this.searchTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextbox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.searchTextbox.Location = new System.Drawing.Point(3, 3);
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(390, 91);
            this.searchTextbox.TabIndex = 3;
            this.searchTextbox.Text = "Search Words";
            this.searchTextbox.GotFocus += new System.EventHandler(this.searchTextbox_GotFocus);
            // 
            // nextButton
            // 
            this.nextButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(549, 3);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(104, 91);
            this.nextButton.TabIndex = 5;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::JapaneseApp.Properties.Resources.JapaneseFlag;
            this.pictureBox2.Location = new System.Drawing.Point(656, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(153, 97);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanelEnglishWordsAndEnhance);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(809, 180);
            this.panel2.TabIndex = 2;
            // 
            // tableLayoutPanelEnglishWordsAndEnhance
            // 
            this.tableLayoutPanelEnglishWordsAndEnhance.ColumnCount = 2;
            this.tableLayoutPanelEnglishWordsAndEnhance.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelEnglishWordsAndEnhance.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelEnglishWordsAndEnhance.Controls.Add(this.EnglishDefinitionTextBox, 0, 0);
            this.tableLayoutPanelEnglishWordsAndEnhance.Controls.Add(this.EnhanceTextBox, 1, 0);
            this.tableLayoutPanelEnglishWordsAndEnhance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelEnglishWordsAndEnhance.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelEnglishWordsAndEnhance.Name = "tableLayoutPanelEnglishWordsAndEnhance";
            this.tableLayoutPanelEnglishWordsAndEnhance.RowCount = 1;
            this.tableLayoutPanelEnglishWordsAndEnhance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelEnglishWordsAndEnhance.Size = new System.Drawing.Size(809, 180);
            this.tableLayoutPanelEnglishWordsAndEnhance.TabIndex = 7;
            // 
            // EnglishDefinitionTextBox
            // 
            this.EnglishDefinitionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnglishDefinitionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnglishDefinitionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnglishDefinitionTextBox.Location = new System.Drawing.Point(0, 0);
            this.EnglishDefinitionTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.EnglishDefinitionTextBox.Name = "EnglishDefinitionTextBox";
            this.EnglishDefinitionTextBox.ReadOnly = true;
            this.EnglishDefinitionTextBox.Size = new System.Drawing.Size(404, 180);
            this.EnglishDefinitionTextBox.TabIndex = 5;
            this.EnglishDefinitionTextBox.Text = "English Words:";
            // 
            // EnhanceTextBox
            // 
            this.EnhanceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnhanceTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnhanceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnhanceTextBox.Location = new System.Drawing.Point(404, 0);
            this.EnhanceTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.EnhanceTextBox.Name = "EnhanceTextBox";
            this.EnhanceTextBox.ReadOnly = true;
            this.EnhanceTextBox.Size = new System.Drawing.Size(405, 180);
            this.EnhanceTextBox.TabIndex = 6;
            this.EnhanceTextBox.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::JapaneseApp.Properties.Resources.Japanese_App_Ver_1_2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(809, 277);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(639, 277);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // TableLayoutBottomLeft
            // 
            this.TableLayoutBottomLeft.ColumnCount = 2;
            this.TableLayoutBottomLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.99448F));
            this.TableLayoutBottomLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.00553F));
            this.TableLayoutBottomLeft.Controls.Add(this.ImageQualityTableLayoutPanel, 1, 0);
            this.TableLayoutBottomLeft.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.TableLayoutBottomLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutBottomLeft.Location = new System.Drawing.Point(0, 277);
            this.TableLayoutBottomLeft.Margin = new System.Windows.Forms.Padding(0);
            this.TableLayoutBottomLeft.Name = "TableLayoutBottomLeft";
            this.TableLayoutBottomLeft.RowCount = 1;
            this.TableLayoutBottomLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutBottomLeft.Size = new System.Drawing.Size(809, 277);
            this.TableLayoutBottomLeft.TabIndex = 6;
            // 
            // ImageQualityTableLayoutPanel
            // 
            this.ImageQualityTableLayoutPanel.ColumnCount = 1;
            this.ImageQualityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ImageQualityTableLayoutPanel.Controls.Add(this.mediumRadioButton, 0, 4);
            this.ImageQualityTableLayoutPanel.Controls.Add(this.thumbnailRadioButton, 0, 2);
            this.ImageQualityTableLayoutPanel.Controls.Add(this.smallRadioButton, 0, 3);
            this.ImageQualityTableLayoutPanel.Controls.Add(this.label2, 0, 1);
            this.ImageQualityTableLayoutPanel.Controls.Add(this.button1, 0, 5);
            this.ImageQualityTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImageQualityTableLayoutPanel.Location = new System.Drawing.Point(577, 3);
            this.ImageQualityTableLayoutPanel.Name = "ImageQualityTableLayoutPanel";
            this.ImageQualityTableLayoutPanel.RowCount = 6;
            this.ImageQualityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.ImageQualityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.ImageQualityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ImageQualityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ImageQualityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ImageQualityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.ImageQualityTableLayoutPanel.Size = new System.Drawing.Size(229, 271);
            this.ImageQualityTableLayoutPanel.TabIndex = 7;
            // 
            // mediumRadioButton
            // 
            this.mediumRadioButton.AutoSize = true;
            this.mediumRadioButton.Checked = true;
            this.mediumRadioButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.mediumRadioButton.Location = new System.Drawing.Point(152, 147);
            this.mediumRadioButton.Name = "mediumRadioButton";
            this.mediumRadioButton.Size = new System.Drawing.Size(74, 25);
            this.mediumRadioButton.TabIndex = 2;
            this.mediumRadioButton.TabStop = true;
            this.mediumRadioButton.Text = "Medium    ";
            this.mediumRadioButton.UseVisualStyleBackColor = true;
            this.mediumRadioButton.CheckedChanged += new System.EventHandler(this.mediumRadioButton_CheckedChanged);
            // 
            // thumbnailRadioButton
            // 
            this.thumbnailRadioButton.AutoSize = true;
            this.thumbnailRadioButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.thumbnailRadioButton.Location = new System.Drawing.Point(152, 85);
            this.thumbnailRadioButton.Name = "thumbnailRadioButton";
            this.thumbnailRadioButton.Size = new System.Drawing.Size(74, 25);
            this.thumbnailRadioButton.TabIndex = 0;
            this.thumbnailRadioButton.Text = "Thumbnail";
            this.thumbnailRadioButton.UseVisualStyleBackColor = true;
            this.thumbnailRadioButton.CheckedChanged += new System.EventHandler(this.thumbnailRadioButton_CheckedChanged);
            // 
            // smallRadioButton
            // 
            this.smallRadioButton.AutoSize = true;
            this.smallRadioButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.smallRadioButton.Location = new System.Drawing.Point(152, 116);
            this.smallRadioButton.Name = "smallRadioButton";
            this.smallRadioButton.Size = new System.Drawing.Size(74, 25);
            this.smallRadioButton.TabIndex = 1;
            this.smallRadioButton.Text = "Small        ";
            this.smallRadioButton.UseVisualStyleBackColor = true;
            this.smallRadioButton.CheckedChanged += new System.EventHandler(this.smallRadioButton_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Image Quality";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 90);
            this.button1.TabIndex = 4;
            this.button1.Text = "Jappanese Resources";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.topHalfFlickrImageSearcchTableLayout, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.BottomHalfFlickrTable, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.55039F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.44961F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(574, 277);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // topHalfFlickrImageSearcchTableLayout
            // 
            this.topHalfFlickrImageSearcchTableLayout.ColumnCount = 1;
            this.topHalfFlickrImageSearcchTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.29586F));
            this.topHalfFlickrImageSearcchTableLayout.Controls.Add(this.searchAndButtonTableLayout, 0, 1);
            this.topHalfFlickrImageSearcchTableLayout.Controls.Add(this.label1, 0, 0);
            this.topHalfFlickrImageSearcchTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topHalfFlickrImageSearcchTableLayout.Location = new System.Drawing.Point(0, 0);
            this.topHalfFlickrImageSearcchTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.topHalfFlickrImageSearcchTableLayout.Name = "topHalfFlickrImageSearcchTableLayout";
            this.topHalfFlickrImageSearcchTableLayout.RowCount = 2;
            this.topHalfFlickrImageSearcchTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.71631F));
            this.topHalfFlickrImageSearcchTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.28369F));
            this.topHalfFlickrImageSearcchTableLayout.Size = new System.Drawing.Size(574, 142);
            this.topHalfFlickrImageSearcchTableLayout.TabIndex = 0;
            // 
            // searchAndButtonTableLayout
            // 
            this.searchAndButtonTableLayout.ColumnCount = 3;
            this.searchAndButtonTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.81818F));
            this.searchAndButtonTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.18182F));
            this.searchAndButtonTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.searchAndButtonTableLayout.Controls.Add(this.flickrImageSearchButton, 0, 0);
            this.searchAndButtonTableLayout.Controls.Add(this.imageTagSearchBox, 0, 0);
            this.searchAndButtonTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchAndButtonTableLayout.Location = new System.Drawing.Point(0, 56);
            this.searchAndButtonTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.searchAndButtonTableLayout.Name = "searchAndButtonTableLayout";
            this.searchAndButtonTableLayout.RowCount = 1;
            this.searchAndButtonTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.searchAndButtonTableLayout.Size = new System.Drawing.Size(574, 86);
            this.searchAndButtonTableLayout.TabIndex = 1;
            // 
            // flickrImageSearchButton
            // 
            this.flickrImageSearchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flickrImageSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flickrImageSearchButton.Location = new System.Drawing.Point(392, 3);
            this.flickrImageSearchButton.Name = "flickrImageSearchButton";
            this.flickrImageSearchButton.Size = new System.Drawing.Size(147, 80);
            this.flickrImageSearchButton.TabIndex = 3;
            this.flickrImageSearchButton.Text = "Searc h";
            this.flickrImageSearchButton.UseVisualStyleBackColor = true;
            this.flickrImageSearchButton.Click += new System.EventHandler(this.flickrImageSearchButton_Click);
            // 
            // imageTagSearchBox
            // 
            this.imageTagSearchBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageTagSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageTagSearchBox.Location = new System.Drawing.Point(3, 3);
            this.imageTagSearchBox.Name = "imageTagSearchBox";
            this.imageTagSearchBox.Size = new System.Drawing.Size(383, 80);
            this.imageTagSearchBox.TabIndex = 2;
            this.imageTagSearchBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(568, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flickr Image Search";
            // 
            // BottomHalfFlickrTable
            // 
            this.BottomHalfFlickrTable.ColumnCount = 1;
            this.BottomHalfFlickrTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BottomHalfFlickrTable.Controls.Add(this.TableSuggestedSeach, 0, 1);
            this.BottomHalfFlickrTable.Controls.Add(this.label3, 0, 0);
            this.BottomHalfFlickrTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomHalfFlickrTable.Location = new System.Drawing.Point(3, 145);
            this.BottomHalfFlickrTable.Name = "BottomHalfFlickrTable";
            this.BottomHalfFlickrTable.RowCount = 2;
            this.BottomHalfFlickrTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.53125F));
            this.BottomHalfFlickrTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.46875F));
            this.BottomHalfFlickrTable.Size = new System.Drawing.Size(568, 129);
            this.BottomHalfFlickrTable.TabIndex = 1;
            // 
            // TableSuggestedSeach
            // 
            this.TableSuggestedSeach.ColumnCount = 1;
            this.TableSuggestedSeach.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.48649F));
            this.TableSuggestedSeach.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.TableSuggestedSeach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableSuggestedSeach.Location = new System.Drawing.Point(3, 28);
            this.TableSuggestedSeach.Name = "TableSuggestedSeach";
            this.TableSuggestedSeach.RowCount = 1;
            this.TableSuggestedSeach.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableSuggestedSeach.Size = new System.Drawing.Size(562, 98);
            this.TableSuggestedSeach.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.onRadioButton, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.offRadioButton, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.26229F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.73771F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(556, 92);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(550, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Suggested Search";
            // 
            // onRadioButton
            // 
            this.onRadioButton.AutoSize = true;
            this.onRadioButton.Checked = true;
            this.onRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.onRadioButton.Location = new System.Drawing.Point(3, 31);
            this.onRadioButton.Name = "onRadioButton";
            this.onRadioButton.Size = new System.Drawing.Size(550, 29);
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
            this.offRadioButton.Size = new System.Drawing.Size(550, 23);
            this.offRadioButton.TabIndex = 2;
            this.offRadioButton.Text = "Off";
            this.offRadioButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(562, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Suggested Image Search";
            this.label3.UseWaitCursor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1448, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(0)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1448, 578);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Japanese Dictionary App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Exit);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.searchPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanelEnglishWordsAndEnhance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TableLayoutBottomLeft.ResumeLayout(false);
            this.ImageQualityTableLayoutPanel.ResumeLayout(false);
            this.ImageQualityTableLayoutPanel.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.topHalfFlickrImageSearcchTableLayout.ResumeLayout(false);
            this.topHalfFlickrImageSearcchTableLayout.PerformLayout();
            this.searchAndButtonTableLayout.ResumeLayout(false);
            this.BottomHalfFlickrTable.ResumeLayout(false);
            this.BottomHalfFlickrTable.PerformLayout();
            this.TableSuggestedSeach.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox japaneseTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel searchPanel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.RichTextBox searchTextbox;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishDefinitionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem japaneseDefinitionToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel TableLayoutBottomLeft;
        private System.Windows.Forms.TableLayoutPanel ImageQualityTableLayoutPanel;
        private System.Windows.Forms.RadioButton mediumRadioButton;
        private System.Windows.Forms.RadioButton thumbnailRadioButton;
        private System.Windows.Forms.RadioButton smallRadioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel topHalfFlickrImageSearcchTableLayout;
        private System.Windows.Forms.TableLayoutPanel searchAndButtonTableLayout;
        private System.Windows.Forms.Button flickrImageSearchButton;
        private System.Windows.Forms.RichTextBox imageTagSearchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel BottomHalfFlickrTable;
        private System.Windows.Forms.TableLayoutPanel TableSuggestedSeach;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton onRadioButton;
        private System.Windows.Forms.RadioButton offRadioButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn KanjiColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn KanaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RomajiColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartOfSpeechColumn;
        private System.Windows.Forms.RichTextBox EnhanceTextBox;
        private System.Windows.Forms.RichTextBox EnglishDefinitionTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelEnglishWordsAndEnhance;
        private System.Windows.Forms.Button button1;
    }
}

