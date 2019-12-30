namespace Reklamcılık_Otomasyonu
{
    partial class mainScreen
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainScreen));
            this.clientsButton = new System.Windows.Forms.Button();
            this.ımageListMain = new System.Windows.Forms.ImageList(this.components);
            this.adsButton = new System.Windows.Forms.Button();
            this.pubButton = new System.Windows.Forms.Button();
            this.panelControl = new System.Windows.Forms.Panel();
            this.panelForms = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // clientsButton
            // 
            resources.ApplyResources(this.clientsButton, "clientsButton");
            this.clientsButton.ImageList = this.ımageListMain;
            this.clientsButton.Name = "clientsButton";
            this.clientsButton.UseVisualStyleBackColor = true;
            this.clientsButton.Click += new System.EventHandler(this.clientsButton_Click);
            // 
            // ımageListMain
            // 
            this.ımageListMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageListMain.ImageStream")));
            this.ımageListMain.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageListMain.Images.SetKeyName(0, "clientsButton1.jpg");
            this.ımageListMain.Images.SetKeyName(1, "newsButton2.png");
            this.ımageListMain.Images.SetKeyName(2, "powerButton1.png");
            this.ımageListMain.Images.SetKeyName(3, "editButtonAlter.png");
            this.ımageListMain.Images.SetKeyName(4, "listButton1.png");
            // 
            // adsButton
            // 
            resources.ApplyResources(this.adsButton, "adsButton");
            this.adsButton.ImageList = this.ımageListMain;
            this.adsButton.Name = "adsButton";
            this.adsButton.UseVisualStyleBackColor = true;
            this.adsButton.Click += new System.EventHandler(this.adsButton_Click);
            // 
            // pubButton
            // 
            resources.ApplyResources(this.pubButton, "pubButton");
            this.pubButton.ImageList = this.ımageListMain;
            this.pubButton.Name = "pubButton";
            this.pubButton.UseVisualStyleBackColor = true;
            this.pubButton.Click += new System.EventHandler(this.pubButton_Click);
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.SystemColors.HotTrack;
            resources.ApplyResources(this.panelControl, "panelControl");
            this.panelControl.Name = "panelControl";
            // 
            // panelForms
            // 
            resources.ApplyResources(this.panelForms, "panelForms");
            this.panelForms.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelForms.Name = "panelForms";
            // 
            // mainScreen
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.panelForms);
            this.Controls.Add(this.pubButton);
            this.Controls.Add(this.adsButton);
            this.Controls.Add(this.clientsButton);
            this.Controls.Add(this.panelControl);
            this.IsMdiContainer = true;
            this.Name = "mainScreen";
            this.Load += new System.EventHandler(this.mainScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clientsButton;
        private System.Windows.Forms.Button adsButton;
        private System.Windows.Forms.ImageList ımageListMain;
        private System.Windows.Forms.Button pubButton;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Panel panelForms;
    }
}

