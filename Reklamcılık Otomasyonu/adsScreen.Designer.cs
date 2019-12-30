namespace Reklamcılık_Otomasyonu
{
    partial class adsScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adsScreen));
            this.ımageList = new System.Windows.Forms.ImageList(this.components);
            this.adNumLabel = new System.Windows.Forms.Label();
            this.issLabel = new System.Windows.Forms.Label();
            this.pubCodeLabel = new System.Windows.Forms.Label();
            this.clientCodeLabel = new System.Windows.Forms.Label();
            this.adCodeLabel = new System.Windows.Forms.Label();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.addLocLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.advSizeTextBox = new System.Windows.Forms.TextBox();
            this.advPriceTextBox = new System.Windows.Forms.TextBox();
            this.advLocTextBox = new System.Windows.Forms.TextBox();
            this.advNumTextBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.clientComboBox = new System.Windows.Forms.ComboBox();
            this.pubComboBox = new System.Windows.Forms.ComboBox();
            this.issNumComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.reklamDataSet = new Reklamcılık_Otomasyonu.ReklamDataSet();
            this.reklamDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.müşteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.müşteriTableAdapter = new Reklamcılık_Otomasyonu.ReklamDataSetTableAdapters.müşteriTableAdapter();
            this.addPictureButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reklamDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reklamDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.müşteriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ımageList
            // 
            this.ımageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList.ImageStream")));
            this.ımageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList.Images.SetKeyName(0, "turnbackButton1.png");
            this.ımageList.Images.SetKeyName(1, "addButton1.jpg");
            this.ımageList.Images.SetKeyName(2, "deleteButton2.png");
            this.ımageList.Images.SetKeyName(3, "updateButton1.png");
            this.ımageList.Images.SetKeyName(4, "editButton.png");
            // 
            // adNumLabel
            // 
            this.adNumLabel.AutoSize = true;
            this.adNumLabel.Location = new System.Drawing.Point(179, 10);
            this.adNumLabel.Name = "adNumLabel";
            this.adNumLabel.Size = new System.Drawing.Size(73, 13);
            this.adNumLabel.TabIndex = 25;
            this.adNumLabel.Text = "Reklam Sayısı";
            // 
            // issLabel
            // 
            this.issLabel.AutoSize = true;
            this.issLabel.Location = new System.Drawing.Point(3, 88);
            this.issLabel.Name = "issLabel";
            this.issLabel.Size = new System.Drawing.Size(74, 13);
            this.issLabel.TabIndex = 24;
            this.issLabel.Text = "Sayı Numarası";
            // 
            // pubCodeLabel
            // 
            this.pubCodeLabel.AutoSize = true;
            this.pubCodeLabel.Location = new System.Drawing.Point(3, 62);
            this.pubCodeLabel.Name = "pubCodeLabel";
            this.pubCodeLabel.Size = new System.Drawing.Size(61, 13);
            this.pubCodeLabel.TabIndex = 22;
            this.pubCodeLabel.Text = "Yayın Kodu";
            // 
            // clientCodeLabel
            // 
            this.clientCodeLabel.AutoSize = true;
            this.clientCodeLabel.Location = new System.Drawing.Point(3, 36);
            this.clientCodeLabel.Name = "clientCodeLabel";
            this.clientCodeLabel.Size = new System.Drawing.Size(69, 13);
            this.clientCodeLabel.TabIndex = 20;
            this.clientCodeLabel.Text = "Müşteri Kodu";
            // 
            // adCodeLabel
            // 
            this.adCodeLabel.AutoSize = true;
            this.adCodeLabel.Location = new System.Drawing.Point(3, 10);
            this.adCodeLabel.Name = "adCodeLabel";
            this.adCodeLabel.Size = new System.Drawing.Size(71, 13);
            this.adCodeLabel.TabIndex = 18;
            this.adCodeLabel.Text = "Reklam Kodu";
            // 
            // codeTextBox
            // 
            this.codeTextBox.AcceptsTab = true;
            this.codeTextBox.AllowDrop = true;
            this.codeTextBox.Location = new System.Drawing.Point(79, 8);
            this.codeTextBox.MaxLength = 7;
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(70, 20);
            this.codeTextBox.TabIndex = 17;
            // 
            // addLocLabel
            // 
            this.addLocLabel.AutoSize = true;
            this.addLocLabel.Location = new System.Drawing.Point(179, 36);
            this.addLocLabel.Name = "addLocLabel";
            this.addLocLabel.Size = new System.Drawing.Size(85, 13);
            this.addLocLabel.TabIndex = 26;
            this.addLocLabel.Text = "Reklam Konumu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Reklam Ücreti";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Reklam Boyutu";
            // 
            // advSizeTextBox
            // 
            this.advSizeTextBox.AcceptsTab = true;
            this.advSizeTextBox.AllowDrop = true;
            this.advSizeTextBox.Location = new System.Drawing.Point(268, 86);
            this.advSizeTextBox.MaxLength = 200;
            this.advSizeTextBox.Name = "advSizeTextBox";
            this.advSizeTextBox.Size = new System.Drawing.Size(57, 20);
            this.advSizeTextBox.TabIndex = 33;
            this.advSizeTextBox.TabStop = false;
            // 
            // advPriceTextBox
            // 
            this.advPriceTextBox.AcceptsTab = true;
            this.advPriceTextBox.AllowDrop = true;
            this.advPriceTextBox.Location = new System.Drawing.Point(268, 60);
            this.advPriceTextBox.MaxLength = 13;
            this.advPriceTextBox.Name = "advPriceTextBox";
            this.advPriceTextBox.Size = new System.Drawing.Size(57, 20);
            this.advPriceTextBox.TabIndex = 32;
            this.advPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.advPriceTextBox_KeyPress);
            // 
            // advLocTextBox
            // 
            this.advLocTextBox.AcceptsTab = true;
            this.advLocTextBox.AllowDrop = true;
            this.advLocTextBox.Location = new System.Drawing.Point(268, 34);
            this.advLocTextBox.MaxLength = 50;
            this.advLocTextBox.Name = "advLocTextBox";
            this.advLocTextBox.Size = new System.Drawing.Size(57, 20);
            this.advLocTextBox.TabIndex = 31;
            // 
            // advNumTextBox
            // 
            this.advNumTextBox.AcceptsTab = true;
            this.advNumTextBox.AllowDrop = true;
            this.advNumTextBox.Location = new System.Drawing.Point(268, 8);
            this.advNumTextBox.MaxLength = 5;
            this.advNumTextBox.Name = "advNumTextBox";
            this.advNumTextBox.Size = new System.Drawing.Size(57, 20);
            this.advNumTextBox.TabIndex = 30;
            this.advNumTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.advNumTextBox_KeyPress);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteButton.ImageKey = "deleteButton2.png";
            this.deleteButton.ImageList = this.ımageList;
            this.deleteButton.Location = new System.Drawing.Point(785, 76);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(80, 30);
            this.deleteButton.TabIndex = 37;
            this.deleteButton.TabStop = false;
            this.deleteButton.Text = "Sil";
            this.deleteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updateButton.ImageIndex = 3;
            this.updateButton.ImageList = this.ımageList;
            this.updateButton.Location = new System.Drawing.Point(785, 40);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(80, 30);
            this.updateButton.TabIndex = 36;
            this.updateButton.TabStop = false;
            this.updateButton.Text = "Güncelle";
            this.updateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addButton.ImageIndex = 1;
            this.addButton.ImageList = this.ımageList;
            this.addButton.Location = new System.Drawing.Point(785, 5);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(80, 30);
            this.addButton.TabIndex = 35;
            this.addButton.TabStop = false;
            this.addButton.Text = "Ekle";
            this.addButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // clientComboBox
            // 
            this.clientComboBox.FormattingEnabled = true;
            this.clientComboBox.Location = new System.Drawing.Point(79, 34);
            this.clientComboBox.Name = "clientComboBox";
            this.clientComboBox.Size = new System.Drawing.Size(70, 21);
            this.clientComboBox.TabIndex = 38;
            // 
            // pubComboBox
            // 
            this.pubComboBox.FormattingEnabled = true;
            this.pubComboBox.Location = new System.Drawing.Point(79, 60);
            this.pubComboBox.Name = "pubComboBox";
            this.pubComboBox.Size = new System.Drawing.Size(70, 21);
            this.pubComboBox.TabIndex = 39;
            this.pubComboBox.SelectedValueChanged += new System.EventHandler(this.pubComboBox_SelectedValueChanged);
            // 
            // issNumComboBox
            // 
            this.issNumComboBox.FormattingEnabled = true;
            this.issNumComboBox.Location = new System.Drawing.Point(79, 86);
            this.issNumComboBox.Name = "issNumComboBox";
            this.issNumComboBox.Size = new System.Drawing.Size(70, 21);
            this.issNumComboBox.TabIndex = 40;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Controls.Add(this.searchTextBox);
            this.panel1.Location = new System.Drawing.Point(6, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 172);
            this.panel1.TabIndex = 42;
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 34);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 30;
            this.dataGridView.Size = new System.Drawing.Size(836, 122);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // searchTextBox
            // 
            this.searchTextBox.AllowDrop = true;
            this.searchTextBox.Location = new System.Drawing.Point(12, 8);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(194, 20);
            this.searchTextBox.TabIndex = 0;
            this.searchTextBox.Text = "Arama";
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            this.searchTextBox.Enter += new System.EventHandler(this.searchTextBox_Enter);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // reklamDataSet
            // 
            this.reklamDataSet.DataSetName = "ReklamDataSet";
            this.reklamDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reklamDataSetBindingSource
            // 
            this.reklamDataSetBindingSource.DataSource = this.reklamDataSet;
            this.reklamDataSetBindingSource.Position = 0;
            // 
            // müşteriBindingSource
            // 
            this.müşteriBindingSource.DataMember = "müşteri";
            this.müşteriBindingSource.DataSource = this.reklamDataSet;
            // 
            // müşteriTableAdapter
            // 
            this.müşteriTableAdapter.ClearBeforeFill = true;
            // 
            // addPictureButton
            // 
            this.addPictureButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addPictureButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addPictureButton.Location = new System.Drawing.Point(365, 75);
            this.addPictureButton.Name = "addPictureButton";
            this.addPictureButton.Size = new System.Drawing.Size(30, 30);
            this.addPictureButton.TabIndex = 43;
            this.addPictureButton.Text = "...";
            this.addPictureButton.UseVisualStyleBackColor = true;
            this.addPictureButton.Click += new System.EventHandler(this.addPictureButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.ErrorImage")));
            this.pictureBox.Image = global::Reklamcılık_Otomasyonu.Properties.Resources.noImage;
            this.pictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.InitialImage")));
            this.pictureBox.Location = new System.Drawing.Point(9, 5);
            this.pictureBox.MaximumSize = new System.Drawing.Size(450, 100);
            this.pictureBox.MinimumSize = new System.Drawing.Size(350, 100);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(350, 100);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 34;
            this.pictureBox.TabStop = false;
            this.pictureBox.DoubleClick += new System.EventHandler(this.pictureBox_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.addPictureButton);
            this.panel2.Controls.Add(this.pictureBox);
            this.panel2.Location = new System.Drawing.Point(386, 1);
            this.panel2.MaximumSize = new System.Drawing.Size(500, 110);
            this.panel2.MinimumSize = new System.Drawing.Size(400, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 110);
            this.panel2.TabIndex = 43;
            // 
            // adsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 300);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.issNumComboBox);
            this.Controls.Add(this.pubComboBox);
            this.Controls.Add(this.clientComboBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.advSizeTextBox);
            this.Controls.Add(this.advPriceTextBox);
            this.Controls.Add(this.advLocTextBox);
            this.Controls.Add(this.advNumTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addLocLabel);
            this.Controls.Add(this.adNumLabel);
            this.Controls.Add(this.issLabel);
            this.Controls.Add(this.pubCodeLabel);
            this.Controls.Add(this.clientCodeLabel);
            this.Controls.Add(this.adCodeLabel);
            this.Controls.Add(this.codeTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(870, 300);
            this.Name = "adsScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reklamlar";
            this.Load += new System.EventHandler(this.adsScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reklamDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reklamDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.müşteriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList ımageList;
        private System.Windows.Forms.Label adNumLabel;
        private System.Windows.Forms.Label issLabel;
        private System.Windows.Forms.Label pubCodeLabel;
        private System.Windows.Forms.Label clientCodeLabel;
        private System.Windows.Forms.Label adCodeLabel;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Label addLocLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox advSizeTextBox;
        private System.Windows.Forms.TextBox advPriceTextBox;
        private System.Windows.Forms.TextBox advLocTextBox;
        private System.Windows.Forms.TextBox advNumTextBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ComboBox clientComboBox;
        private System.Windows.Forms.ComboBox pubComboBox;
        private System.Windows.Forms.ComboBox issNumComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.BindingSource reklamDataSetBindingSource;
        private ReklamDataSet reklamDataSet;
        private System.Windows.Forms.BindingSource müşteriBindingSource;
        private ReklamDataSetTableAdapters.müşteriTableAdapter müşteriTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button addPictureButton;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}