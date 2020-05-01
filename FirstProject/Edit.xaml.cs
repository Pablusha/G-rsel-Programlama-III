using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FirstProject
{
    /// <summary>
    /// Edit.xaml etkileşim mantığı
    /// </summary>
    public partial class Edit : Window
    {
        List<Bilgiler> bilgiler = new List<Bilgiler>();
        public Edit()
        {
            InitializeComponent();


        }

        private void btnKaydet_Click(object sender, RoutedEventArgs e)
        {
            if (txtAd.Text == "")
            {
                MessageBox.Show("İsim alanı boş geçilemez…");

            }

            else if (txtSoyad.Text == "")
            {
                MessageBox.Show("Soyisim alanı boş geçilemez…");
            }

            else if (cmbCinsiyet.Text == "")
            {
                MessageBox.Show("Cinsiyet alanı boş geçilemez…");
            }

            else if (txtOgrenciNo.Text == "")
            {
                MessageBox.Show("Öğrenci No alanı boş geçilemez…");
            }

            else if (cmbBolum.Text == "")
            {
                MessageBox.Show("Bölüm bilgisi boş geçilemez…");
            }

            else
            {
                Bilgiler kullanici = new Bilgiler();
                kullanici.Ad = txtAd.Text;
                kullanici.Soyad = txtSoyad.Text;
                kullanici.Cinsiyet = cmbCinsiyet.Text;
                kullanici.OgrenciNo = Convert.ToInt32(txtOgrenciNo.Text);
                kullanici.Bolum = cmbBolum.Text;
                bilgiler.Add(kullanici);
                tablo2.Items.Add(kullanici);
            }

        }

        private void cmbIndex_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var secilen = cmbIndex.SelectedIndex;
            MessageBox.Show(bilgiler[secilen].Ad + "\t" + bilgiler[secilen].Soyad + "\t" + bilgiler[secilen].Cinsiyet + "\t" + bilgiler[secilen].OgrenciNo + "\t" + bilgiler[secilen].Bolum);
        }
    }
}
    
