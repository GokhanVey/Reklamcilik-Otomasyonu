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
    public partial class adsScreen : Form
    {
        DAO dao = new DAO();
        public adsScreen()
        {
            InitializeComponent();
        }
        private void adsScreen_Load(object sender, EventArgs e)
        {
            RefreshList();
            //Müşteri Kosu ComboBox Tercihleri
            FillComboBox(clientComboBox, "müşKodu", "select * from müşteri");

            //Yayın Kodu ComboBox Tercihleri
            FillComboBox(pubComboBox, "yayKodu", "select * from yayın");
        }
        //YENİLEME ve DÜZEN METODLARI
        public void FillComboBox(ComboBox combobox, string by, string query)
        {
            SqlConnection con = DAO.OpenConnection();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                combobox.Items.Add(read[by]);
            }
            DAO.ConnectionClose(con);
        }
        //Sayı Numarası ComboBox Tercihleri
        private void pubComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            issNumComboBox.Items.Clear();
            FillComboBox(issNumComboBox, "sayıNo", "SELECT * FROM sayı WHERE yayKodu='"+ pubComboBox.Text + "' ");
        }

        private void RefreshList()
        {
            try
            {
                SqlDataAdapter adtr = new SqlDataAdapter();
                dataGridView.DataSource = dao.List(adtr, "SELECT reklam.rekKodu, reklam.müşKodu, reklamyayın.yayKodu, reklamyayın.SayıNo, reklamyayın.rekSayısı, reklamyayın.rekKonumu, reklam.rekBoyutu, reklamyayın.RekÜcreti, reklamyayın.ücrÖdeme FROM reklam INNER JOIN reklamyayın ON reklam.rekKodu = reklamyayın.rekKodu");
                dataGridView.Columns[0].HeaderText = "Reklam Kodu";
                dataGridView.Columns[1].HeaderText = "Müşteri Kodu";
                dataGridView.Columns[2].HeaderText = "Yayın Kodu";
                dataGridView.Columns[3].HeaderText = "Sayı Numarası";
                dataGridView.Columns[4].HeaderText = "Reklam Sayısı";
                dataGridView.Columns[5].HeaderText = "Reklam Konumu";
                dataGridView.Columns[6].HeaderText = "Reklam Boyutu";
                dataGridView.Columns[7].HeaderText = "Reklam Ücreti";
                dataGridView.Columns[8].HeaderText = "Ödeme Durumu";
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Reklamlar Listelenirken Hata Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow line = dataGridView.CurrentRow;
            codeTextBox.Text = line.Cells[0].Value.ToString();
            clientComboBox.Text = line.Cells[1].Value.ToString();
            pubComboBox.Text = line.Cells[2].Value.ToString();
            issNumComboBox.Text = line.Cells[3].Value.ToString();
            advNumTextBox.Text = line.Cells[4].Value.ToString();
            advLocTextBox.Text = line.Cells[5].Value.ToString();
            advSizeTextBox.Text = line.Cells[6].Value.ToString();
            advPriceTextBox.Text = line.Cells[7].Value.ToString();
            dao.Shown("SELECT *FROM Reklam WHERE rekKodu = '" + codeTextBox.Text + "'", pictureBox);
        }
        //TUŞ METODLARI
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainScreen mainScreen = new mainScreen();
            mainScreen.ShowDialog();
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (codeTextBox.Text.Length != 7 || clientComboBox.Text.Length < 1 || pubComboBox.Text.Length < 1 || issNumComboBox.Text.Length < 1 || advNumTextBox.Text.Length < 1 || advLocTextBox.Text.Length < 1 || advPriceTextBox.Text.Length < 1 || advSizeTextBox.Text.Length < 1 || pictureBox.ImageLocation.Length < 1)
            {
                if (codeTextBox.Text.Length != 7)
                {
                    errorProvider.SetError(codeTextBox, "Reklam kodu 7 karakterli ve özgün olmalıdır!");
                }
                if (clientComboBox.Text.Length < 1)
                {
                    errorProvider.SetError(clientComboBox, "Lütfen müşterinin kodunu giriniz!");
                }
                if (pubComboBox.Text.Length < 1)
                {
                    errorProvider.SetError(pubComboBox, "Lütfen yayının kodunu giriniz!");
                }
                if (issNumComboBox.Text.Length < 1)
                {
                    errorProvider.SetError(issNumComboBox, "Lütfen sayı numarasını giriniz!");
                }
                if (advNumTextBox.Text.Length < 1)
                {
                    errorProvider.SetError(advNumTextBox, "Lütfen reklam sayısını giriniz!");
                }
                if(advLocTextBox.Text.Length < 1)
                {
                    errorProvider.SetError(advLocTextBox, "Lütfen reklam konumunu giriniz!");
                }
                if( advPriceTextBox.Text.Length < 1 )
                {
                    errorProvider.SetError(advPriceTextBox, "Lütfen reklam fiyatını giriniz!");
                }
                if (advSizeTextBox.Text.Length < 1 )
                {
                    errorProvider.SetError(advSizeTextBox, "Lütfen reklam boyutunu giriniz!");
                }/* Resim seçilmediğinde hata veriyor, neden?
                if (pictureBox.ImageLocation.Length < 1 || pictureBox.ImageLocation == "")
                {
                    errorProvider.SetError(pictureBox, "Lütfen reklam resmini seçiniz");
                }*/
            }
            else
            {
                Reklam r = new Reklam();
                ReklamYayin ry = new ReklamYayin();
                r.setRekKod(codeTextBox.Text); r.setMusKod(clientComboBox.Text); r.setRekGor(pictureBox.ImageLocation); r.setRekBoy(advSizeTextBox.Text);
                ry.setRekKod(codeTextBox.Text); ry.setYayKod(pubComboBox.Text); ry.setSayNum(int.Parse(issNumComboBox.Text)); ry.setRekSay(int.Parse(advNumTextBox.Text));
                ry.setRekKon(advLocTextBox.Text); ry.setRekUcr(int.Parse(advPriceTextBox.Text)); ry.setOdeme(false);

                DAO.AddAdvertisement(r);
                DAO.AddAdvertisementPublication(ry);
                foreach (Control item in Controls) if (item is TextBox) item.Text = "";
                foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
                RefreshList();
            }
        }

        private void addPictureButton_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            pictureBox.ImageLocation = openFileDialog.FileName;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (codeTextBox.Text.Length != 7 || clientComboBox.Text.Length < 1 || pubComboBox.Text.Length < 1 || issNumComboBox.Text.Length < 1 || advNumTextBox.Text.Length < 1 || advLocTextBox.Text.Length < 1 || advPriceTextBox.Text.Length < 1 || advSizeTextBox.Text.Length < 1 || pictureBox.ImageLocation.Length < 1)
            {
                if (codeTextBox.Text.Length != 7)
                {
                    errorProvider.SetError(codeTextBox, "Reklam kodu 6 karakterli ve özgün olmalıdır!");
                }
                if (clientComboBox.Text.Length < 1)
                {
                    errorProvider.SetError(clientComboBox, "Lütfen müşterinin kodunu giriniz!");
                }
                if (pubComboBox.Text.Length < 1)
                {
                    errorProvider.SetError(pubComboBox, "Lütfen yayının kodunu giriniz!");
                }
                if (issNumComboBox.Text.Length < 1)
                {
                    errorProvider.SetError(issNumComboBox, "Lütfen sayı numarasını giriniz!");
                }
                if (advNumTextBox.Text.Length < 1)
                {
                    errorProvider.SetError(advNumTextBox, "Lütfen reklam sayısını giriniz!");
                }
                if (advLocTextBox.Text.Length < 1)
                {
                    errorProvider.SetError(advLocTextBox, "Lütfen reklam konumunu giriniz!");
                }
                if (advPriceTextBox.Text.Length < 1)
                {
                    errorProvider.SetError(advPriceTextBox, "Lütfen reklam fiyatını giriniz!");
                }
                if (advSizeTextBox.Text.Length < 1)
                {
                    errorProvider.SetError(advSizeTextBox, "Lütfen reklam boyutunu giriniz!");
                }
                if (pictureBox.ImageLocation.Length < 1)
                {
                    errorProvider.SetError(pictureBox, "Lütfen reklam resmini seçiniz");
                }
            }
            else
            {
                Reklam r = new Reklam();
                ReklamYayin ry = new ReklamYayin();
                r.setRekKod(codeTextBox.Text); r.setMusKod(clientComboBox.Text); r.setRekGor(pictureBox.ImageLocation); r.setRekBoy(advSizeTextBox.Text);
                ry.setRekKod(codeTextBox.Text); ry.setYayKod(pubComboBox.Text); ry.setSayNum(int.Parse(issNumComboBox.Text)); ry.setRekSay(int.Parse(advNumTextBox.Text));
                ry.setRekKon(advLocTextBox.Text); ry.setRekUcr(int.Parse(advPriceTextBox.Text)); ry.setOdeme(bool.Parse(dataGridView.CurrentRow.Cells[8].Value.ToString()));

                DAO.UpdateAdvertisement(r);
                DAO.UpdateAdvertisementPublication(ry);
                foreach (Control item in Controls) if (item is TextBox) item.Text = "";
                foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
                RefreshList();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Reklam r = new Reklam();
            ReklamYayin ry = new ReklamYayin();

            r.setRekKod(codeTextBox.Text);
            r.setRekBoy(advSizeTextBox.Text);
            ry.setRekKod(codeTextBox.Text);
            ry.setYayKod(pubComboBox.Text);
            ry.setSayNum(int.Parse(issNumComboBox.Text));

            DAO.DeleteAdvertisement(r);
            DAO.DeleteAdvertisementPublication(ry);
            RefreshList();
        }
        //ARAMA İŞLEVLERİ
        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter adtr = new SqlDataAdapter();
            dataGridView.DataSource = dao.List(adtr, "SELECT Reklam.RekKodu, Reklam.MüşKodu, ReklamYayın.YayKodu, ReklamYayın.SayıNo, ReklamYayın.RekSayısı, ReklamYayın.RekKonumu, ReklamYayın.RekÜcreti, Reklam.RekBoyutu FROM Reklam INNER JOIN ReklamYayın ON Reklam.RekKodu = ReklamYayın.RekKodu WHERE (Reklam.RekKodu LIKE '%" + searchTextBox.Text + "%' OR Reklam.MüşKodu LIKE '%" + searchTextBox.Text + "%' OR ReklamYayın.YayKodu LIKE '%" + searchTextBox.Text + "%')");
        }

        private void searchTextBox_Enter(object sender, EventArgs e)
        {
            searchTextBox.Text = "";
        }

        private void pictureBox_DoubleClick(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            pictureBox.ImageLocation = openFileDialog.FileName;
        }
        //KISITLAMALAR
        private void advPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) == true)
            {
                e.Handled = false;
                errorProvider.Clear();
            }
            else
            {
                e.Handled = true;
                errorProvider.SetError(advPriceTextBox, "Lütfen rakam giriniz!");
            }
        }

        private void advNumTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) == true)
            {
                e.Handled = false;
                errorProvider.Clear();
            }
            else
            {
                e.Handled = true;
                errorProvider.SetError(advNumTextBox, "Lütfen rakam giriniz!");
            }
        }
    }
}
