namespace Reklamcılık_Otomasyonu
{
    partial class clientsScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clientsScreen));
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.codeLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.telLabel = new System.Windows.Forms.Label();
            this.telTextBox = new System.Windows.Forms.TextBox();
            this.adresLabel = new System.Windows.Forms.Label();
            this.adresTextBox = new System.Windows.Forms.TextBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.individualRadioButton = new System.Windows.Forms.RadioButton();
            this.corporateRadioButton = new System.Windows.Forms.RadioButton();
            this.addButton = new System.Windows.Forms.Button();
            this.ımageListClients = new System.Windows.Forms.ImageList(this.components);
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.totalSumLabel = new System.Windows.Forms.Label();
            this.sumLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // codeTextBox
            // 
            this.codeTextBox.AcceptsTab = true;
            this.codeTextBox.AllowDrop = true;
            this.codeTextBox.Location = new System.Drawing.Point(58, 5);
            this.codeTextBox.MaxLength = 5;
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(150, 20);
            this.codeTextBox.TabIndex = 0;
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.Location = new System.Drawing.Point(27, 9);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(29, 13);
            this.codeLabel.TabIndex = 1;
            this.codeLabel.Text = "Kod:";
            this.codeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(28, 48);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(28, 13);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "İsim:";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameTextBox
            // 
            this.nameTextBox.AcceptsTab = true;
            this.nameTextBox.AllowDrop = true;
            this.nameTextBox.Location = new System.Drawing.Point(58, 44);
            this.nameTextBox.MaxLength = 50;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(150, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // telLabel
            // 
            this.telLabel.AutoSize = true;
            this.telLabel.Location = new System.Drawing.Point(10, 87);
            this.telLabel.Name = "telLabel";
            this.telLabel.Size = new System.Drawing.Size(46, 13);
            this.telLabel.TabIndex = 5;
            this.telLabel.Text = "Telefon:";
            // 
            // telTextBox
            // 
            this.telTextBox.AcceptsTab = true;
            this.telTextBox.AllowDrop = true;
            this.telTextBox.Location = new System.Drawing.Point(58, 83);
            this.telTextBox.MaxLength = 13;
            this.telTextBox.Name = "telTextBox";
            this.telTextBox.Size = new System.Drawing.Size(150, 20);
            this.telTextBox.TabIndex = 4;
            this.telTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telTextBox_KeyPress);
            // 
            // adresLabel
            // 
            this.adresLabel.AutoSize = true;
            this.adresLabel.Location = new System.Drawing.Point(237, 7);
            this.adresLabel.Name = "adresLabel";
            this.adresLabel.Size = new System.Drawing.Size(37, 13);
            this.adresLabel.TabIndex = 7;
            this.adresLabel.Text = "Adres:";
            this.adresLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // adresTextBox
            // 
            this.adresTextBox.AcceptsTab = true;
            this.adresTextBox.AllowDrop = true;
            this.adresTextBox.Location = new System.Drawing.Point(276, 5);
            this.adresTextBox.MaxLength = 200;
            this.adresTextBox.Multiline = true;
            this.adresTextBox.Name = "adresTextBox";
            this.adresTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.adresTextBox.Size = new System.Drawing.Size(300, 70);
            this.adresTextBox.TabIndex = 6;
            this.adresTextBox.TabStop = false;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(247, 86);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(26, 13);
            this.typeLabel.TabIndex = 9;
            this.typeLabel.Text = "Tür:";
            this.typeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // individualRadioButton
            // 
            this.individualRadioButton.AutoSize = true;
            this.individualRadioButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.individualRadioButton.Location = new System.Drawing.Point(298, 86);
            this.individualRadioButton.Name = "individualRadioButton";
            this.individualRadioButton.Size = new System.Drawing.Size(61, 17);
            this.individualRadioButton.TabIndex = 10;
            this.individualRadioButton.Text = "Bireysel";
            this.individualRadioButton.UseVisualStyleBackColor = true;
            // 
            // corporateRadioButton
            // 
            this.corporateRadioButton.AutoSize = true;
            this.corporateRadioButton.Location = new System.Drawing.Point(380, 86);
            this.corporateRadioButton.Name = "corporateRadioButton";
            this.corporateRadioButton.Size = new System.Drawing.Size(68, 17);
            this.corporateRadioButton.TabIndex = 11;
            this.corporateRadioButton.Text = "Kurumsal";
            this.corporateRadioButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addButton.ImageIndex = 0;
            this.addButton.ImageList = this.ımageListClients;
            this.addButton.Location = new System.Drawing.Point(614, 5);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(80, 30);
            this.addButton.TabIndex = 12;
            this.addButton.TabStop = false;
            this.addButton.Text = "Ekle";
            this.addButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
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
            // updateButton
            // 
            this.updateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updateButton.ImageIndex = 1;
            this.updateButton.ImageList = this.ımageListClients;
            this.updateButton.Location = new System.Drawing.Point(614, 41);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(80, 30);
            this.updateButton.TabIndex = 13;
            this.updateButton.TabStop = false;
            this.updateButton.Text = "Güncelle";
            this.updateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteButton.ImageKey = "deleteButton2.png";
            this.deleteButton.ImageList = this.ımageListClients;
            this.deleteButton.Location = new System.Drawing.Point(614, 77);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(80, 30);
            this.deleteButton.TabIndex = 14;
            this.deleteButton.TabStop = false;
            this.deleteButton.Text = "Sil";
            this.deleteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.searchTextBox);
            this.panel1.Location = new System.Drawing.Point(6, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 235);
            this.panel1.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 30;
            this.dataGridView1.Size = new System.Drawing.Size(671, 193);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // searchTextBox
            // 
            this.searchTextBox.AllowDrop = true;
            this.searchTextBox.Location = new System.Drawing.Point(10, 8);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(194, 20);
            this.searchTextBox.TabIndex = 0;
            this.searchTextBox.Text = "Arama";
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            this.searchTextBox.Enter += new System.EventHandler(this.searchTextBox_Enter);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // totalSumLabel
            // 
            this.totalSumLabel.AutoSize = true;
            this.totalSumLabel.Location = new System.Drawing.Point(514, 88);
            this.totalSumLabel.Name = "totalSumLabel";
            this.totalSumLabel.Size = new System.Drawing.Size(32, 13);
            this.totalSumLabel.TabIndex = 17;
            this.totalSumLabel.Text = "Borç:";
            // 
            // sumLabel
            // 
            this.sumLabel.AutoSize = true;
            this.sumLabel.Location = new System.Drawing.Point(552, 88);
            this.sumLabel.Name = "sumLabel";
            this.sumLabel.Size = new System.Drawing.Size(13, 13);
            this.sumLabel.TabIndex = 18;
            this.sumLabel.Text = "0";
            // 
            // clientsScreen
            // 
            this.AcceptButton = this.addButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(700, 360);
            this.Controls.Add(this.sumLabel);
            this.Controls.Add(this.totalSumLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.corporateRadioButton);
            this.Controls.Add(this.individualRadioButton);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.adresLabel);
            this.Controls.Add(this.adresTextBox);
            this.Controls.Add(this.telLabel);
            this.Controls.Add(this.telTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.codeLabel);
            this.Controls.Add(this.codeTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 360);
            this.Name = "clientsScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteriler";
            this.Load += new System.EventHandler(this.clientsScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label telLabel;
        private System.Windows.Forms.TextBox telTextBox;
        private System.Windows.Forms.Label adresLabel;
        private System.Windows.Forms.TextBox adresTextBox;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.RadioButton individualRadioButton;
        private System.Windows.Forms.RadioButton corporateRadioButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ImageList ımageListClients;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label sumLabel;
        private System.Windows.Forms.Label totalSumLabel;
    }
}