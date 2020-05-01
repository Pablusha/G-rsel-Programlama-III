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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FirstProject
{
	/// <summary>
	/// MainWindow.xaml etkileşim mantığı
	/// </summary>
	public partial class MainWindow : Window
	{
		List<Bilgiler> liste;
		public MainWindow()
		{
			InitializeComponent();
			liste = new List<Bilgiler>()
			{
				new Bilgiler() {Ad="Yasin",Soyad="Akdoğan",Cinsiyet="Erkek",OgrenciNo=181130072,Bolum="Bilgisayar Programcılığı(IO)" }

			};
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			tablo.ItemsSource = liste;
		}

		private void btnAdd_Click(object sender, RoutedEventArgs e)
		{
			Edit edit1 = new Edit();
			edit1.Show();
			this.Hide();
		}
	}

	public class Bilgiler
	{
		public string Ad { get; set; }
		public string Soyad { get; set; }
		public string Cinsiyet { get; set; }
		public int OgrenciNo { get; set; }
		public string Bolum { get; set; }

	}
}
