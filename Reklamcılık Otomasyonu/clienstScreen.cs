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
    public partial class clientsScreen : Form
    {
        DAO dao = new DAO();
        public clientsScreen()
        {
            InitializeComponent();
        }

        private void clientsScreen_Load(object sender, EventArgs e)
        {
            individualRadioButton.Checked = true;
            RefreshList();

            toolTip.SetToolTip(codeTextBox, "Müşteri kodu 5 haneli olmalıdır.");
            toolTip.SetToolTip(telTextBox, "Telefon numarası 13 haneli ve boşluksuz olmalıdır. Örnek; +905000000000.");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow line = dataGridView1.CurrentRow;
            codeTextBox.Text = line.Cells[0].Value.ToString();
            nameTextBox.Text = line.Cells[1].Value.ToString();
            telTextBox.Text = line.Cells[2].Value.ToString();
            adresTextBox.Text = line.Cells[3].Value.ToString();
            if(line.Cells[4].Value.ToString() == "Bireysel")
            {
                individualRadioButton.Checked = true;
            }
            if(line.Cells[4].Value.ToString() == "Kurumsal")
            {
                corporateRadioButton.Checked = true;
            }
            //MÜŞTERİNİN BORCUNUN GÖSTERİMİ
            SqlDataAdapter adtr = new SqlDataAdapter();
            DAO.ShowTotalSum(adtr, sumLabel, "SELECT SUM(rekÜcreti) AS toplamÜcret FROM reklamyayın ry INNER JOIN reklam r ON r.müşKodu = '"+ codeTextBox.Text + "' AND r.rekKodu = ry.rekKodu AND ry.ücrÖdeme = 0 GROUP BY r.müşKodu");
        }

        private void RefreshList()
        {
            try
            {
                SqlDataAdapter adtr = new SqlDataAdapter();
                dataGridView1.DataSource = dao.List(adtr, "SELECT *FROM müşteri ORDER BY müşAdı ASC");
                dataGridView1.Columns[0].HeaderText = "Müşterinin Kodu";
                dataGridView1.Columns[1].HeaderText = "Müşterinin Adı";
                dataGridView1.Columns[2].HeaderText = "Müşterinin Telefon Numarası";
                dataGridView1.Columns[3].HeaderText = "Müşterinin Adresi";
                dataGridView1.Columns[4].HeaderText = "Müşterinin Türü";
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Müşteriler Listelenirken Hata Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        //TUŞ METODLARI

        private void addButton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (codeTextBox.Text.Length != 5 || nameTextBox.Text.Length < 1 || telTextBox.Text.Length < 1 || adresTextBox.Text.Length < 1)
            {
                if (codeTextBox.Text.Length != 5)
                {
                    errorProvider.SetError(codeTextBox, "Müşteri kodu 5 karakterli olmalıdır!");
                }
                else if (nameTextBox.Text.Length < 1)
                {
                    errorProvider.SetError(nameTextBox, "Lütfen müşterinin adını giriniz!");
                }
                else if (telTextBox.Text.Length < 1)
                {
                    errorProvider.SetError(telTextBox, "Lütfen müşterinin telefon bilgisini giriniz!");
                }
                else if (adresTextBox.Text.Length < 1)
                {
                    errorProvider.SetError(adresTextBox, "Lütfen müşterinin adres bilgisini giriniz!");
                }
            }
            else
            {
                Musteri m = new Musteri();
                m.setMusKod(codeTextBox.Text);
                m.setMusAdi(nameTextBox.Text);
                m.setMusTel(telTextBox.Text);
                m.setMusAdrs(adresTextBox.Text);
                if (individualRadioButton.Checked == true)
                {
                    m.setMusTipi("Bireysel");
                }
                if (corporateRadioButton.Checked == true)
                {
                    m.setMusTipi("Kurumsal");
                }

                DAO.AddClient(m);
                foreach (Control item in Controls) if (item is TextBox) item.Text = "";
                RefreshList();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Musteri m = new Musteri();
            m.setMusKod(codeTextBox.Text);
            m.setMusAdi(nameTextBox.Text);
            m.setMusTel(telTextBox.Text);
            m.setMusAdrs(adresTextBox.Text);
            if (individualRadioButton.Checked == true)
            {
                m.setMusTipi("Bireysel");
            }
            if (corporateRadioButton.Checked == true)
            {
                m.setMusTipi("Kurumsal");
            }

            DAO.UpdateClient(m);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            RefreshList();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Musteri m = new Musteri();
            m.setMusKod(codeTextBox.Text);
            DAO.DeleteClient(m);
            RefreshList();
        }
        //ARAMA METODLARI
        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter adtr = new SqlDataAdapter();
            dataGridView1.DataSource = dao.List(adtr, "SELECT *FROM müşteri WHERE (müşAdı LIKE '%"+ searchTextBox.Text+ "%' OR müşKodu LIKE '%" + searchTextBox.Text + "%' OR müşTürü LIKE '%" + searchTextBox.Text + "%')");
        }

        private void searchTextBox_Enter(object sender, EventArgs e)
        {
            searchTextBox.Text = "";
        }
        //KISITLAMALAR
        private void telTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
    }
}
