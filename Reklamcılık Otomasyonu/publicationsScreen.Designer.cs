namespace Reklamcılık_Otomasyonu
{
    partial class publicationsScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(publicationsScreen));
            this.ımageListClients = new System.Windows.Forms.ImageList(this.components);
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.publicationsDataGridView = new System.Windows.Forms.DataGridView();
            this.searchPubTextBox = new System.Windows.Forms.TextBox();
            this.deletePubButton = new System.Windows.Forms.Button();
            this.updatePubButton = new System.Windows.Forms.Button();
            this.addPubButton = new System.Windows.Forms.Button();
            this.pubTypeComboBox = new System.Windows.Forms.ComboBox();
            this.pubFreqComboBox = new System.Windows.Forms.ComboBox();
            this.pubNameTextBox = new System.Windows.Forms.TextBox();
            this.pubCodeTextBox = new System.Windows.Forms.TextBox();
            this.pubTypeLabel = new System.Windows.Forms.Label();
            this.pubFreqLabel = new System.Windows.Forms.Label();
            this.pubNameLabel = new System.Windows.Forms.Label();
            this.punCodeLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.issuesDataGridView = new System.Windows.Forms.DataGridView();
            this.searchIssTextBox = new System.Windows.Forms.TextBox();
            this.deleteIssButton = new System.Windows.Forms.Button();
            this.updateIssButton = new System.Windows.Forms.Button();
            this.addIssButton = new System.Windows.Forms.Button();
            this.pageNumberTextBox = new System.Windows.Forms.TextBox();
            this.pubDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.issNoTextBox = new System.Windows.Forms.TextBox();
            this.pnLabel = new System.Windows.Forms.Label();
            this.relaseDateLabel = new System.Windows.Forms.Label();
            this.pubCodeComboBox = new System.Windows.Forms.ComboBox();
            this.issNoLabel = new System.Windows.Forms.Label();
            this.pubCodeLabel = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.publicationsDataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.issuesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ımageListClients
            // 
            this.ımageListClients.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageListClients.ImageStream")));
            this.ımageListClients.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageListClients.Images.SetKeyName(0, "addButton1.jpg");
            this.ımageListClients.Images.SetKeyName(1, "updateButton1.png");
            this.ımageListClients.Images.SetKeyName(2, "deleteButton2.png");
            this.ımageListClients.Images.SetKeyName(3, "turnbackButton1.png");
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(870, 300);
            this.tabControl.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.deletePubButton);
            this.tabPage1.Controls.Add(this.updatePubButton);
            this.tabPage1.Controls.Add(this.addPubButton);
            this.tabPage1.Controls.Add(this.pubTypeComboBox);
            this.tabPage1.Controls.Add(this.pubFreqComboBox);
            this.tabPage1.Controls.Add(this.pubNameTextBox);
            this.tabPage1.Controls.Add(this.pubCodeTextBox);
            this.tabPage1.Controls.Add(this.pubTypeLabel);
            this.tabPage1.Controls.Add(this.pubFreqLabel);
            this.tabPage1.Controls.Add(this.pubNameLabel);
            this.tabPage1.Controls.Add(this.punCodeLabel);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(862, 274);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Yayınlar";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.publicationsDataGridView);
            this.panel1.Controls.Add(this.searchPubTextBox);
            this.panel1.Location = new System.Drawing.Point(-4, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 237);
            this.panel1.TabIndex = 19;
            // 
            // publicationsDataGridView
            // 
            this.publicationsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.publicationsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.publicationsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.publicationsDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.publicationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.publicationsDataGridView.Location = new System.Drawing.Point(10, 34);
            this.publicationsDataGridView.Name = "publicationsDataGridView";
            this.publicationsDataGridView.RowHeadersWidth = 30;
            this.publicationsDataGridView.Size = new System.Drawing.Size(853, 195);
            this.publicationsDataGridView.TabIndex = 1;
            this.publicationsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.publicationsDataGridView_CellClick);
            // 
            // searchPubTextBox
            // 
            this.searchPubTextBox.AllowDrop = true;
            this.searchPubTextBox.Location = new System.Drawing.Point(10, 8);
            this.searchPubTextBox.Name = "searchPubTextBox";
            this.searchPubTextBox.Size = new System.Drawing.Size(194, 20);
            this.searchPubTextBox.TabIndex = 0;
            this.searchPubTextBox.Text = "Arama";
            this.searchPubTextBox.TextChanged += new System.EventHandler(this.searchPubTextBox_TextChanged);
            this.searchPubTextBox.Enter += new System.EventHandler(this.searchPubTextBox_Enter);
            // 
            // deletePubButton
            // 
            this.deletePubButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deletePubButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deletePubButton.ImageKey = "deleteButton2.png";
            this.deletePubButton.ImageList = this.ımageListClients;
            this.deletePubButton.Location = new System.Drawing.Point(780, 5);
            this.deletePubButton.Name = "deletePubButton";
            this.deletePubButton.Size = new System.Drawing.Size(80, 30);
            this.deletePubButton.TabIndex = 17;
            this.deletePubButton.TabStop = false;
            this.deletePubButton.Text = "Sil";
            this.deletePubButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deletePubButton.UseVisualStyleBackColor = true;
            this.deletePubButton.Click += new System.EventHandler(this.deletePubButton_Click);
            // 
            // updatePubButton
            // 
            this.updatePubButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updatePubButton.ImageIndex = 1;
            this.updatePubButton.ImageList = this.ımageListClients;
            this.updatePubButton.Location = new System.Drawing.Point(700, 5);
            this.updatePubButton.Name = "updatePubButton";
            this.updatePubButton.Size = new System.Drawing.Size(80, 30);
            this.updatePubButton.TabIndex = 16;
            this.updatePubButton.TabStop = false;
            this.updatePubButton.Text = "Güncelle";
            this.updatePubButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.updatePubButton.UseVisualStyleBackColor = true;
            this.updatePubButton.Click += new System.EventHandler(this.updatePubButton_Click);
            // 
            // addPubButton
            // 
            this.addPubButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addPubButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addPubButton.ImageIndex = 0;
            this.addPubButton.ImageList = this.ımageListClients;
            this.addPubButton.Location = new System.Drawing.Point(620, 5);
            this.addPubButton.Name = "addPubButton";
            this.addPubButton.Size = new System.Drawing.Size(80, 30);
            this.addPubButton.TabIndex = 15;
            this.addPubButton.TabStop = false;
            this.addPubButton.Text = "Ekle";
            this.addPubButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addPubButton.UseVisualStyleBackColor = true;
            this.addPubButton.Click += new System.EventHandler(this.addPubButton_Click);
            // 
            // pubTypeComboBox
            // 
            this.pubTypeComboBox.FormattingEnabled = true;
            this.pubTypeComboBox.Location = new System.Drawing.Point(533, 10);
            this.pubTypeComboBox.Name = "pubTypeComboBox";
            this.pubTypeComboBox.Size = new System.Drawing.Size(68, 21);
            this.pubTypeComboBox.TabIndex = 7;
            // 
            // pubFreqComboBox
            // 
            this.pubFreqComboBox.FormattingEnabled = true;
            this.pubFreqComboBox.Location = new System.Drawing.Point(395, 10);
            this.pubFreqComboBox.Name = "pubFreqComboBox";
            this.pubFreqComboBox.Size = new System.Drawing.Size(68, 21);
            this.pubFreqComboBox.TabIndex = 6;
            // 
            // pubNameTextBox
            // 
            this.pubNameTextBox.Location = new System.Drawing.Point(195, 10);
            this.pubNameTextBox.Name = "pubNameTextBox";
            this.pubNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.pubNameTextBox.TabIndex = 5;
            // 
            // pubCodeTextBox
            // 
            this.pubCodeTextBox.Location = new System.Drawing.Point(77, 10);
            this.pubCodeTextBox.MaxLength = 4;
            this.pubCodeTextBox.Name = "pubCodeTextBox";
            this.pubCodeTextBox.Size = new System.Drawing.Size(52, 20);
            this.pubCodeTextBox.TabIndex = 4;
            // 
            // pubTypeLabel
            // 
            this.pubTypeLabel.AutoSize = true;
            this.pubTypeLabel.Location = new System.Drawing.Point(469, 13);
            this.pubTypeLabel.Name = "pubTypeLabel";
            this.pubTypeLabel.Size = new System.Drawing.Size(58, 13);
            this.pubTypeLabel.TabIndex = 3;
            this.pubTypeLabel.Text = "Yayın Türü";
            // 
            // pubFreqLabel
            // 
            this.pubFreqLabel.AutoSize = true;
            this.pubFreqLabel.Location = new System.Drawing.Point(322, 13);
            this.pubFreqLabel.Name = "pubFreqLabel";
            this.pubFreqLabel.Size = new System.Drawing.Size(67, 13);
            this.pubFreqLabel.TabIndex = 2;
            this.pubFreqLabel.Text = "Yayın Aralığı:";
            // 
            // pubNameLabel
            // 
            this.pubNameLabel.AutoSize = true;
            this.pubNameLabel.Location = new System.Drawing.Point(135, 13);
            this.pubNameLabel.Name = "pubNameLabel";
            this.pubNameLabel.Size = new System.Drawing.Size(54, 13);
            this.pubNameLabel.TabIndex = 1;
            this.pubNameLabel.Text = "Yayın Adı:";
            // 
            // punCodeLabel
            // 
            this.punCodeLabel.AutoSize = true;
            this.punCodeLabel.Location = new System.Drawing.Point(7, 13);
            this.punCodeLabel.Name = "punCodeLabel";
            this.punCodeLabel.Size = new System.Drawing.Size(64, 13);
            this.punCodeLabel.TabIndex = 0;
            this.punCodeLabel.Text = "Yayın Kodu:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.deleteIssButton);
            this.tabPage2.Controls.Add(this.updateIssButton);
            this.tabPage2.Controls.Add(this.addIssButton);
            this.tabPage2.Controls.Add(this.pageNumberTextBox);
            this.tabPage2.Controls.Add(this.pubDateTimePicker);
            this.tabPage2.Controls.Add(this.issNoTextBox);
            this.tabPage2.Controls.Add(this.pnLabel);
            this.tabPage2.Controls.Add(this.relaseDateLabel);
            this.tabPage2.Controls.Add(this.pubCodeComboBox);
            this.tabPage2.Controls.Add(this.issNoLabel);
            this.tabPage2.Controls.Add(this.pubCodeLabel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(862, 274);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sayılar";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.issuesDataGridView);
            this.panel2.Controls.Add(this.searchIssTextBox);
            this.panel2.Location = new System.Drawing.Point(-4, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(870, 237);
            this.panel2.TabIndex = 21;
            // 
            // issuesDataGridView
            // 
            this.issuesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.issuesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.issuesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.issuesDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.issuesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.issuesDataGridView.Location = new System.Drawing.Point(10, 34);
            this.issuesDataGridView.Name = "issuesDataGridView";
            this.issuesDataGridView.RowHeadersWidth = 30;
            this.issuesDataGridView.Size = new System.Drawing.Size(853, 195);
            this.issuesDataGridView.TabIndex = 1;
            this.issuesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.issuesDataGridView_CellClick);
            // 
            // searchIssTextBox
            // 
            this.searchIssTextBox.AllowDrop = true;
            this.searchIssTextBox.Location = new System.Drawing.Point(10, 8);
            this.searchIssTextBox.Name = "searchIssTextBox";
            this.searchIssTextBox.Size = new System.Drawing.Size(194, 20);
            this.searchIssTextBox.TabIndex = 0;
            this.searchIssTextBox.Text = "Arama";
            this.searchIssTextBox.TextChanged += new System.EventHandler(this.searchIssTextBox_TextChanged);
            this.searchIssTextBox.Enter += new System.EventHandler(this.searchIssTextBox_Enter);
            // 
            // deleteIssButton
            // 
            this.deleteIssButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteIssButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteIssButton.ImageKey = "deleteButton2.png";
            this.deleteIssButton.ImageList = this.ımageListClients;
            this.deleteIssButton.Location = new System.Drawing.Point(780, 5);
            this.deleteIssButton.Name = "deleteIssButton";
            this.deleteIssButton.Size = new System.Drawing.Size(80, 30);
            this.deleteIssButton.TabIndex = 20;
            this.deleteIssButton.TabStop = false;
            this.deleteIssButton.Text = "Sil";
            this.deleteIssButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteIssButton.UseVisualStyleBackColor = true;
            this.deleteIssButton.Click += new System.EventHandler(this.deleteIssButton_Click);
            // 
            // updateIssButton
            // 
            this.updateIssButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updateIssButton.ImageIndex = 1;
            this.updateIssButton.ImageList = this.ımageListClients;
            this.updateIssButton.Location = new System.Drawing.Point(700, 5);
            this.updateIssButton.Name = "updateIssButton";
            this.updateIssButton.Size = new System.Drawing.Size(80, 30);
            this.updateIssButton.TabIndex = 19;
            this.updateIssButton.TabStop = false;
            this.updateIssButton.Text = "Güncelle";
            this.updateIssButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.updateIssButton.UseVisualStyleBackColor = true;
            this.updateIssButton.Click += new System.EventHandler(this.updateIssButton_Click);
            // 
            // addIssButton
            // 
            this.addIssButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addIssButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addIssButton.ImageIndex = 0;
            this.addIssButton.ImageList = this.ımageListClients;
            this.addIssButton.Location = new System.Drawing.Point(620, 5);
            this.addIssButton.Name = "addIssButton";
            this.addIssButton.Size = new System.Drawing.Size(80, 30);
            this.addIssButton.TabIndex = 18;
            this.addIssButton.TabStop = false;
            this.addIssButton.Text = "Ekle";
            this.addIssButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addIssButton.UseVisualStyleBackColor = true;
            this.addIssButton.Click += new System.EventHandler(this.addIssButton_Click);
            // 
            // pageNumberTextBox
            // 
            this.pageNumberTextBox.Location = new System.Drawing.Point(506, 10);
            this.pageNumberTextBox.Name = "pageNumberTextBox";
            this.pageNumberTextBox.Size = new System.Drawing.Size(47, 20);
            this.pageNumberTextBox.TabIndex = 9;
            this.pageNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pageNumberTextBox_KeyPress);
            // 
            // pubDateTimePicker
            // 
            this.pubDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pubDateTimePicker.Location = new System.Drawing.Point(318, 10);
            this.pubDateTimePicker.Name = "pubDateTimePicker";
            this.pubDateTimePicker.Size = new System.Drawing.Size(94, 20);
            this.pubDateTimePicker.TabIndex = 8;
            this.pubDateTimePicker.Value = new System.DateTime(2019, 12, 18, 0, 0, 0, 0);
            // 
            // issNoTextBox
            // 
            this.issNoTextBox.Location = new System.Drawing.Point(181, 10);
            this.issNoTextBox.Name = "issNoTextBox";
            this.issNoTextBox.Size = new System.Drawing.Size(47, 20);
            this.issNoTextBox.TabIndex = 7;
            this.issNoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.issNoTextBox_KeyPress);
            // 
            // pnLabel
            // 
            this.pnLabel.AutoSize = true;
            this.pnLabel.Location = new System.Drawing.Point(441, 14);
            this.pnLabel.Name = "pnLabel";
            this.pnLabel.Size = new System.Drawing.Size(67, 13);
            this.pnLabel.TabIndex = 6;
            this.pnLabel.Text = "Sayfa Sayısı:";
            // 
            // relaseDateLabel
            // 
            this.relaseDateLabel.AutoSize = true;
            this.relaseDateLabel.Location = new System.Drawing.Point(255, 14);
            this.relaseDateLabel.Name = "relaseDateLabel";
            this.relaseDateLabel.Size = new System.Drawing.Size(65, 13);
            this.relaseDateLabel.TabIndex = 5;
            this.relaseDateLabel.Text = "Yayın Tarihi:";
            // 
            // pubCodeComboBox
            // 
            this.pubCodeComboBox.FormattingEnabled = true;
            this.pubCodeComboBox.Location = new System.Drawing.Point(68, 10);
            this.pubCodeComboBox.Name = "pubCodeComboBox";
            this.pubCodeComboBox.Size = new System.Drawing.Size(53, 21);
            this.pubCodeComboBox.TabIndex = 4;
            // 
            // issNoLabel
            // 
            this.issNoLabel.AutoSize = true;
            this.issNoLabel.Location = new System.Drawing.Point(136, 14);
            this.issNoLabel.Name = "issNoLabel";
            this.issNoLabel.Size = new System.Drawing.Size(47, 13);
            this.issNoLabel.TabIndex = 3;
            this.issNoLabel.Text = "Sayı No:";
            // 
            // pubCodeLabel
            // 
            this.pubCodeLabel.AutoSize = true;
            this.pubCodeLabel.Location = new System.Drawing.Point(7, 14);
            this.pubCodeLabel.Name = "pubCodeLabel";
            this.pubCodeLabel.Size = new System.Drawing.Size(64, 13);
            this.pubCodeLabel.TabIndex = 2;
            this.pubCodeLabel.Text = "Yayın Kodu:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // publicationsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 300);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(870, 300);
            this.Name = "publicationsScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yayınlar";
            this.Load += new System.EventHandler(this.publicationsScreen_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.publicationsDataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.issuesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox pubTypeComboBox;
        private System.Windows.Forms.ComboBox pubFreqComboBox;
        private System.Windows.Forms.TextBox pubNameTextBox;
        private System.Windows.Forms.TextBox pubCodeTextBox;
        private System.Windows.Forms.Label pubTypeLabel;
        private System.Windows.Forms.Label pubFreqLabel;
        private System.Windows.Forms.Label pubNameLabel;
        private System.Windows.Forms.Label punCodeLabel;
        private System.Windows.Forms.Button deletePubButton;
        private System.Windows.Forms.Button updatePubButton;
        private System.Windows.Forms.Button addPubButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView publicationsDataGridView;
        private System.Windows.Forms.TextBox searchPubTextBox;
        private System.Windows.Forms.Label issNoLabel;
        private System.Windows.Forms.Label pubCodeLabel;
        private System.Windows.Forms.ComboBox pubCodeComboBox;
        private System.Windows.Forms.TextBox pageNumberTextBox;
        private System.Windows.Forms.DateTimePicker pubDateTimePicker;
        private System.Windows.Forms.TextBox issNoTextBox;
        private System.Windows.Forms.Label pnLabel;
        private System.Windows.Forms.Label relaseDateLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView issuesDataGridView;
        private System.Windows.Forms.TextBox searchIssTextBox;
        private System.Windows.Forms.Button deleteIssButton;
        private System.Windows.Forms.Button updateIssButton;
        private System.Windows.Forms.Button addIssButton;
        private System.Windows.Forms.ImageList ımageListClients;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}