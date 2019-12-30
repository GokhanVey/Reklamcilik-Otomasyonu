using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reklamcılık_Otomasyonu
{
    public partial class publicationsScreen : Form
    {
        DAO dao = new DAO();
        public publicationsScreen()
        {
            InitializeComponent();
        }

        private void publicationsScreen_Load(object sender, EventArgs e)
        {
            RefreshPublicationsList();
            RefreshIssuessList();

            //Yayın Aralığı Combo Box Seçenekleri
            pubFreqComboBox.Items.Add("Günlük"); pubFreqComboBox.Items.Add("Haftalık"); pubFreqComboBox.Items.Add("Aylık"); pubFreqComboBox.Items.Add("Yıllık");

            //Yayın Türünün Seçimi
            pubTypeComboBox.Items.Add("Gazete"); pubTypeComboBox.Items.Add("Dergi"); pubTypeComboBox.Items.Add("Gazete Eki");

            //Yayın Tarihinin Ayarlanması
            DateTime time = DateTime.Now;
            int year = int.Parse(time.ToString("yyyy"));
            int month = int.Parse(time.ToString("MM"));
            int day = int.Parse(time.ToString("dd"));
            pubDateTimePicker.Value = new DateTime(year, month, day);

            //Sayı Eklemede Yayın Kodu Combo Boxunu Ayarlama /NOT: Metod yapmaya çalış
            SqlConnection con = DAO.OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM yayın", con);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                pubCodeComboBox.Items.Add(read["yayKodu"]);
            }
            DAO.ConnectionClose(con);
        }
        //YENİLEME METODLARI
        private void RefreshPublicationsList()
        {
            try
            {
                SqlDataAdapter adtr = new SqlDataAdapter();
                publicationsDataGridView.DataSource = dao.List(adtr, "SELECT *FROM yayın");
                publicationsDataGridView.Columns[0].HeaderText = "Yayın Kodu";
                publicationsDataGridView.Columns[1].HeaderText = "Yayın Adı";
                publicationsDataGridView.Columns[2].HeaderText = "Yayın Sıklığı";
                publicationsDataGridView.Columns[3].HeaderText = "Yayın Türü";
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Yayınlar Listelenirken Hata Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void RefreshIssuessList()
        {
            try
            {
                SqlDataAdapter adtr = new SqlDataAdapter();
                issuesDataGridView.DataSource = dao.List(adtr, "select *from sayı");
                issuesDataGridView.Columns[0].HeaderText = "Yayın Kodu";
                issuesDataGridView.Columns[1].HeaderText = "Sayı Numarası";
                issuesDataGridView.Columns[2].HeaderText = "Yayınlanma Tarihi";
                issuesDataGridView.Columns[3].HeaderText = "Sayfa Sayısı";
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Yayın Sayıları Listelenirken Hata Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //TUŞ METODLARI

        private void addPubButton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (pubCodeTextBox.Text.Length != 4 || pubNameTextBox.Text.Length < 1 || pubFreqComboBox.Text.Length < 1 || pubTypeComboBox.Text.Length < 1)
            {
                if (pubCodeTextBox.Text.Length != 4)
                {
                    errorProvider.SetError(pubCodeTextBox, "Yayın kodu 4 karakterli ve özgün olmalıdır!");
                }
                else if (pubNameTextBox.Text.Length < 1)
                {
                    errorProvider.SetError(pubNameTextBox, "Lütfen yayın adını giriniz!");
                }
                else if (pubFreqComboBox.Text.Length < 1)
                {
                    errorProvider.SetError(pubFreqComboBox, "Lütfen yayın sıklığını seçiniz!");
                }
                else if (pubTypeComboBox.Text.Length < 1)
                {
                    errorProvider.SetError(pubTypeComboBox, "Lütfen yayın tipi seçiniz!");
                }
            }
            else
            {
                Yayin y = new Yayin();
                y.setYayKod(pubCodeTextBox.Text);
                y.setYayAdi(pubNameTextBox.Text);
                y.setYayAra(pubFreqComboBox.Text);
                y.setYayTur(pubTypeComboBox.Text);

                DAO.AddPublication(y);
                foreach (Control item in Controls) if (item is TextBox) item.Text = "";
                foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
                RefreshPublicationsList();
            }
        }

        private void addIssButton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (pubCodeComboBox.Text == "" || issNoTextBox.Text.Length < 1 || pubDateTimePicker.Text == "" || pageNumberTextBox.Text.Length < 1)
            {
                if (pubCodeComboBox.Text == "")
                {
                    errorProvider.SetError(pubCodeComboBox, "Lüfen bir yayın kodu seçiniz!");
                }
                else if (issNoTextBox.Text.Length < 1)
                {
                    errorProvider.SetError(issNoTextBox, "Lütfen sayı numarasını giriniz!");
                }
                else if (pubDateTimePicker.Text == "")
                {
                    errorProvider.SetError(pubDateTimePicker, "Lütfen yayın tarihi seçiniz!");
                }
                else if (pageNumberTextBox.Text.Length < 1)
                {
                    errorProvider.SetError(pageNumberTextBox, "Lütfen sayının sayfa numarasını giriniz!");
                }
            }
            else
            {
                Sayi s = new Sayi();
                s.setYayKod(pubCodeComboBox.Text);
                s.setSayNum(int.Parse(issNoTextBox.Text));
                s.setYayTar(pubDateTimePicker.Value.Date);
                s.setSaySay(int.Parse(pageNumberTextBox.Text));

                DAO.AddIssue(s);
                foreach (Control item in Controls) if (item is TextBox) item.Text = "";
                foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
                RefreshIssuessList();
            }
        }

        private void updateIssButton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (pubCodeComboBox.Text == "" || issNoTextBox.Text.Length < 1 || pubDateTimePicker.Text == "" || pageNumberTextBox.Text.Length < 1)
            {
                if (pubCodeComboBox.Text == "")
                {
                    errorProvider.SetError(pubCodeComboBox, "Lüfen bir yayın kodu seçiniz!");
                }
                else if (issNoTextBox.Text.Length < 1)
                {
                    errorProvider.SetError(issNoTextBox, "Lütfen sayı numarasını giriniz!");
                }
                else if (pubDateTimePicker.Text == "")
                {
                    errorProvider.SetError(pubDateTimePicker, "Lütfen yayın tarihi seçiniz!");
                }
                else if (pageNumberTextBox.Text.Length < 1)
                {
                    errorProvider.SetError(pageNumberTextBox, "Lütfen sayının sayfa numarasını giriniz!");
                }
            }
            else
            {
                try
                {
                    Sayi s = new Sayi();
                    s.setYayKod(pubCodeComboBox.Text);
                    s.setSayNum(int.Parse(issNoTextBox.Text));
                    s.setYayTar(pubDateTimePicker.Value.Date);
                    s.setSaySay(int.Parse(pageNumberTextBox.Text));

                    DAO.UpdateIssue(s);
                    foreach (Control item in Controls) if (item is TextBox) item.Text = "";
                    foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
                    RefreshIssuessList();

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "YayınGüncellenirken Hata Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void updatePubButton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (pubCodeTextBox.Text.Length != 4 || pubNameTextBox.Text.Length < 1 || pubFreqComboBox.Text.Length < 1 || pubTypeComboBox.Text.Length < 1)
            {
                if (pubCodeTextBox.Text.Length != 4)
                {
                    errorProvider.SetError(pubCodeTextBox, "Yayın kodu 4 karakterli!");
                }
                else if (pubNameTextBox.Text.Length < 1)
                {
                    errorProvider.SetError(pubNameTextBox, "Lütfen yayın adını giriniz!");
                }
                else if (pubFreqComboBox.Text.Length < 1)
                {
                    errorProvider.SetError(pubFreqComboBox, "Lütfen yayın sıklığını seçiniz!");
                }
                else if (pubTypeComboBox.Text.Length < 1)
                {
                    errorProvider.SetError(pubTypeComboBox, "Lütfen yayın tipi seçiniz!");
                }
            }
            else
            {
                Yayin y = new Yayin();
                y.setYayKod(pubCodeTextBox.Text);
                y.setYayAdi(pubNameTextBox.Text);
                y.setYayAra(pubFreqComboBox.Text);
                y.setYayTur(pubTypeComboBox.Text);

                DAO.UpdatePublication(y);
                foreach (Control item in Controls) if (item is TextBox) item.Text = "";
                foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
                RefreshPublicationsList();
            }
        }

        private void deleteIssButton_Click(object sender, EventArgs e)
        {
            Sayi s = new Sayi();
            s.setYayKod(pubCodeComboBox.Text);
            s.setSayNum(int.Parse(issNoTextBox.Text));
            DAO.DeleteIssue(s);
            RefreshIssuessList();
        }
        
        private void deletePubButton_Click(object sender, EventArgs e)
        {
            Yayin y = new Yayin();
            y.setYayKod(pubCodeTextBox.Text);
            DAO.DeletePublication(y);
            RefreshPublicationsList();
        }
        //TABLO TIKLAMA METODLARI
        private void publicationsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow line = publicationsDataGridView.CurrentRow;
            pubCodeTextBox.Text = line.Cells[0].Value.ToString();
            pubNameTextBox.Text = line.Cells[1].Value.ToString();
            pubFreqComboBox.Text = line.Cells[2].Value.ToString();
            pubTypeComboBox.Text = line.Cells[3].Value.ToString();
        }

        private void issuesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow line = issuesDataGridView.CurrentRow;
            pubCodeComboBox.Text = line.Cells[0].Value.ToString();
            issNoTextBox.Text = line.Cells[1].Value.ToString();
            pageNumberTextBox.Text = line.Cells[3].Value.ToString();
            //Tarihin ayarlanması
            string[] time = line.Cells[2].Value.ToString().Split(' ');
            time = time[0].Split('.');
            int year = int.Parse(time[2]);
            int month = int.Parse(time[1]);
            int day = int.Parse(time[0]);
            pubDateTimePicker.Value = new DateTime(year, month, day);
        }
        //ARAMA İŞLEVLERİ
        private void searchIssTextBox_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter adtr = new SqlDataAdapter();
            issuesDataGridView.DataSource = dao.List(adtr, "SELECT *FROM sayı WHERE (yayKodu LIKE '%" + searchIssTextBox.Text + "%' OR sayıNo LIKE '%" + searchIssTextBox.Text + "%')");
        }

        private void searchPubTextBox_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter adtr = new SqlDataAdapter();
            publicationsDataGridView.DataSource = dao.List(adtr, "SELECT *FROM yayın WHERE (yayKodu LIKE '%" + searchPubTextBox.Text + "%' OR yayAdı LIKE '%" + searchPubTextBox.Text + "%' OR yayAralığı LIKE '%" + searchPubTextBox.Text + "%' OR yayTürü LIKE '%" + searchPubTextBox.Text + "%')");
        }

        private void searchPubTextBox_Enter(object sender, EventArgs e)
        {
            searchPubTextBox.Text = "";
        }

        private void searchIssTextBox_Enter(object sender, EventArgs e)
        {
            searchIssTextBox.Text = "";
        }
        //KISITLAMALAR
        private void issNoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) == true)
            {
                e.Handled = false;
                errorProvider.Clear();
            }
            else
            {
                e.Handled = true;
                errorProvider.SetError(issNoTextBox, "Lütfen rakam giriniz!");
            }
        }

        private void pageNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) == true)
            {
                e.Handled = false;
                errorProvider.Clear();
            }
            else
            {
                e.Handled = true;
                errorProvider.SetError(pageNumberTextBox, "Lütfen rakam giriniz!");
            }
        }
    }
}
