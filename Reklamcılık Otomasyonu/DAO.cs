using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reklamcılık_Otomasyonu
{
    class DAO
    {
        DataTable table;
        //BAĞLANTI METODLARI ve GENEL METODLAR
        public static SqlConnection OpenConnection()
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\ReklamDatabase.mdf;Integrated Security=True");
            try
            {
                con.Open();
                return con;

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Veritabanına erişilemedi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }

        public static void ConnectionClose(SqlConnection con)
        {
            con.Close();
        }

        public DataTable List(SqlDataAdapter adtr, string query)
        {
            SqlConnection con = OpenConnection();
            table = new DataTable();
            adtr = new SqlDataAdapter(query, con);
            adtr.Fill(table);
            ConnectionClose(con);
            return table;
        }

        public void Shown(string query, PictureBox pictureBox)
        {
            SqlConnection con = OpenConnection();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                pictureBox.ImageLocation = dr["rekGörünümü"].ToString();
            }
            dr.Close();
            ConnectionClose(con);
        }
        //MÜŞTERİ METODLARI
        public static void AddClient(Musteri m)
        {
            SqlConnection con = OpenConnection();
            SqlCommand cmd = new SqlCommand("INSERT INTO müşteri (müşKodu, müşAdı, müşTelNo, müşAdresi, müşTürü) VALUES (@müşKodu, @müşAdı, @müşTelNo, @müşAdresi, @müşTürü)", con);

            cmd.Parameters.AddWithValue("@müşKodu", m.getMusKod());
            cmd.Parameters.AddWithValue("@müşAdı", m.getMusAdi());
            cmd.Parameters.AddWithValue("@müşTelNo", m.getMusTel());
            cmd.Parameters.AddWithValue("@müşAdresi", m.getMusAdrs());
            cmd.Parameters.AddWithValue("@müşTürü", m.getMusTipi());

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Müşteri Eklerken Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ConnectionClose(con);
            }
        }

        public static void UpdateClient(Musteri m)
        {
            SqlConnection con = OpenConnection();
            SqlCommand cmd = new SqlCommand("UPDATE müşteri SET müşAdı=@müşAdı, müşTelNo=@müşTelNo, müşAdresi=@müşAdresi, müşTürü=@müşTürü WHERE müşKodu=@müşKodu", con);

            cmd.Parameters.AddWithValue("@müşKodu", m.getMusKod());
            cmd.Parameters.AddWithValue("@müşAdı", m.getMusAdi());
            cmd.Parameters.AddWithValue("@müşTelNo", m.getMusTel());
            cmd.Parameters.AddWithValue("@müşAdresi", m.getMusAdrs());
            cmd.Parameters.AddWithValue("@müşTürü", m.getMusTipi());

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Müşteriyi Güncellerken Hata Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                ConnectionClose(con);
            }
        }

        public static void DeleteClient(Musteri m)
        {
            string musteriKodu = m.getMusKod();
            SqlConnection con = OpenConnection();
            SqlCommand cmd = new SqlCommand("DELETE FROM müşteri WHERE müşKodu='" + musteriKodu + "'", con);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Müşteriyi Silerken Hata Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                ConnectionClose(con);
            }
        }
        //REKLAM METODLARI
        public static void AddAdvertisement(Reklam r)
        {
            SqlConnection con = OpenConnection();
            SqlCommand cmd = new SqlCommand(" IF ( (SELECT COUNT(rekKodu) FROM reklamyayın WHERE rekKodu = @rekKodu) = 0 ) INSERT INTO reklam (rekKodu, müşKodu, rekGörünümü, rekBoyutu) VALUES (@rekKodu, @müşKodu, @rekGörünümü, @rekBoyutu)", con);
            
            cmd.Parameters.AddWithValue("@rekKodu", r.getRekKod());
            cmd.Parameters.AddWithValue("@müşKodu", r.getMusKod());
            cmd.Parameters.AddWithValue("@rekGörünümü", r.getRekGor());
            cmd.Parameters.AddWithValue("@rekBoyutu", r.getRekBoy());

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Reklam Eklerken Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ConnectionClose(con);
            }
        }

        public static void UpdateAdvertisement(Reklam r)
        {
            SqlConnection con = OpenConnection();
            SqlCommand cmd = new SqlCommand("UPDATE reklam SET rekGörünümü=@rekGörünümü, rekBoyutu=@rekBoyutu WHERE rekKodu=@rekKodu AND müşKodu=@müşKodu ", con);

            cmd.Parameters.AddWithValue("@rekKodu", r.getRekKod());
            cmd.Parameters.AddWithValue("@müşKodu", r.getMusKod());
            cmd.Parameters.AddWithValue("@rekGörünümü", r.getRekGor());
            cmd.Parameters.AddWithValue("@rekBoyutu", r.getRekBoy());

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Reklam Eklerken Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                ConnectionClose(con);
            }
        }

        public static void DeleteAdvertisement(Reklam r)
        {
            string reklamKodu = r.getRekKod();
            string reklamBoyutu =r.getRekBoy();
            SqlConnection con = OpenConnection();
            SqlCommand cmd = new SqlCommand("DELETE FROM reklam WHERE (rekKodu='" + reklamKodu + "' AND rekBoyutu='" + reklamBoyutu + "' AND ( (SELECT COUNT(rekKodu) FROM reklamyayın WHERE rekKodu = '" + reklamKodu + "') < 2) )", con);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Reklam Silerken Hata Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ConnectionClose(con);
            }
        }
        //REKLAM-YAYIN METODLARI
        public static void AddAdvertisementPublication(ReklamYayin ry)
        {
            SqlConnection con = OpenConnection();
            SqlCommand cmd = new SqlCommand("INSERT INTO reklamyayın (rekKodu, yayKodu, sayıNo, rekSayısı, rekKonumu, rekÜcreti, ücrÖdeme) VALUES (@rekKodu, @yayKodu, @sayıNo, @rekSayısı, @rekKonumu, @rekÜcreti, @ücrÖdeme)", con);

            cmd.Parameters.AddWithValue("@rekKodu", ry.getRekKod());
            cmd.Parameters.AddWithValue("@yayKodu", ry.getYayKod());
            cmd.Parameters.AddWithValue("@sayıNo", ry.getSayNum());
            cmd.Parameters.AddWithValue("@rekSayısı", ry.getRekSay());
            cmd.Parameters.AddWithValue("@rekKonumu", ry.getRekKon());
            cmd.Parameters.AddWithValue("@rekÜcreti", ry.getRekUcr());
            cmd.Parameters.AddWithValue("@ücrÖdeme", ry.getOdeme());

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Reklam-yayın Eklerken Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ConnectionClose(con);
            }
        }

        public static void UpdateAdvertisementPublication(ReklamYayin ry)
        {
            SqlConnection con = OpenConnection();
            SqlCommand cmd = new SqlCommand("UPDATE reklamyayın SET rekSayısı=@rekSayısı, rekKonumu=@rekKonumu, rekÜcreti=@rekÜcreti, ücrÖdeme=@ücrÖdeme WHERE rekKodu=@rekKodu AND yayKodu=@yayKodu AND sayıNo=@sayıNo", con);

            cmd.Parameters.AddWithValue("@rekKodu", ry.getRekKod());
            cmd.Parameters.AddWithValue("@yayKodu", ry.getYayKod());
            cmd.Parameters.AddWithValue("@sayıNo", ry.getSayNum());
            cmd.Parameters.AddWithValue("@rekSayısı", ry.getRekSay());
            cmd.Parameters.AddWithValue("@rekKonumu", ry.getRekKon());
            cmd.Parameters.AddWithValue("@rekÜcreti", ry.getRekUcr());
            cmd.Parameters.AddWithValue("@ücrÖdeme", ry.getOdeme());

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Reklam-Yayın Eklerken Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ConnectionClose(con);
            }
        }

        public static void DeleteAdvertisementPublication(ReklamYayin ry)
        {
            string reklamKodu = ry.getRekKod();
            string yayinKodu = ry.getYayKod();
            int sayiNumarasi = ry.getSayNum();

            SqlConnection con = OpenConnection();
            SqlCommand cmd = new SqlCommand("DELETE FROM reklamyayın WHERE (rekKodu='" + reklamKodu + "' AND yayKodu='" + yayinKodu + "' AND sayıNo ='"+ sayiNumarasi + "')", con);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Reklam-Yayın Silerken Hata Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ConnectionClose(con);
            }
        }
        //YAYIN METODLARI
        public static void AddPublication(Yayin y)
        {
            SqlConnection con = OpenConnection();
            SqlCommand cmd = new SqlCommand("INSERT INTO yayın (yayKodu, yayAdı, yayAralığı, yayTürü) VALUES (@yayKodu, @yayAdı, @yayAralığı, @yayTürü)", con);

            cmd.Parameters.AddWithValue("@yayKodu", y.getYayKod());
            cmd.Parameters.AddWithValue("@yayAdı", y.getYayAdi());
            cmd.Parameters.AddWithValue("@yayAralığı", y.getYayAra());
            cmd.Parameters.AddWithValue("@yayTürü", y.getYayTur());

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Yayın Eklenirken Hata Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ConnectionClose(con);
            }
        }

        public static void UpdatePublication(Yayin y)
        {
            SqlConnection con = OpenConnection();
            SqlCommand cmd = new SqlCommand("UPDATE yayın SET yayKodu=@yayKodu, yayAdı=@yayAdı, yayAralığı=@yayAralığı, yayTürü=@yayTürü WHERE yayKodu=@yayKodu", con);

            cmd.Parameters.AddWithValue("@yayKodu", y.getYayKod());
            cmd.Parameters.AddWithValue("@yayAdı", y.getYayAdi());
            cmd.Parameters.AddWithValue("@yayAralığı", y.getYayAra());
            cmd.Parameters.AddWithValue("@yayTürü", y.getYayTur());

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Yayını Güncellerken Hata Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ConnectionClose(con);
            }
        }

        public static void DeletePublication(Yayin y)
        {
            string yayinkodu = y.getYayKod();
            SqlConnection con = OpenConnection();
            SqlCommand cmd = new SqlCommand("DELETE FROM yayın WHERE yayKodu='" + yayinkodu + "'", con);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Yayını Silerken Hata Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ConnectionClose(con);
            }
        }
        //SAYI METODLARI
        public static void AddIssue(Sayi s)
        {
            SqlConnection con = OpenConnection();
            SqlCommand cmd = new SqlCommand("INSERT INTO sayı (yayKodu, sayıNo, yayTarihi, sayfaSay) VALUES (@yayKodu, @sayıNo, @yayTarihi, @sayfaSay)", con);

            cmd.Parameters.AddWithValue("@yayKodu", s.getYayKod());
            cmd.Parameters.AddWithValue("@sayıNo", s.getSayNum());
            cmd.Parameters.AddWithValue("@yayTarihi", s.getYayTar());
            cmd.Parameters.AddWithValue("@sayfaSay", s.getSaySay());

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Sayı Eklenirken Hata Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ConnectionClose(con);
            }
        }

        public static void UpdateIssue(Sayi s)
        {
            SqlConnection con = OpenConnection();
            SqlCommand cmd = new SqlCommand("UPDATE sayı SET yayKodu=@yayKodu, sayıNo=@sayıNo, yayTarihi=@yayTarihi, sayfaSay=@sayfaSay WHERE yayKodu=@yayKodu AND sayıNo=@sayıNo", con);

            cmd.Parameters.AddWithValue("@yayKodu", s.getYayKod());
            cmd.Parameters.AddWithValue("@sayıNo", s.getSayNum());
            cmd.Parameters.AddWithValue("@yayTarihi", s.getYayTar());
            cmd.Parameters.AddWithValue("@sayfaSay", s.getSaySay());

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Sayıyı Güncellerken Hata Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ConnectionClose(con);
            }
        }

        public static void DeleteIssue(Sayi s)
        {
            string yayinkodu = s.getYayKod();
            int sayinumarasi = s.getSayNum();
            SqlConnection con = OpenConnection();
            SqlCommand cmd = new SqlCommand("DELETE FROM sayı WHERE (yayKodu='" + yayinkodu + "' AND sayıNo='" + sayinumarasi + "')", con);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Sayıyı Silerken Hata Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ConnectionClose(con);
            }
        }

        //Toplam Ücret
        public static void ShowTotalSum(SqlDataAdapter adtr, Label label, string query)
        {
            SqlConnection con = OpenConnection();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                label.Text = dr["toplamÜcret"].ToString();
            }
            else
            {
                label.Text = "0";
            }
            dr.Close();

            ConnectionClose(con);
        }
    }
}
