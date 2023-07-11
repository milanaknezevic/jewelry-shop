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

namespace HCI_PRODAVNICA_NAKITAnew
{
    /// <summary>
    /// Interaction logic for ProfilWindow.xaml
    /// </summary>
    public partial class ProfilWindow : Window
    {
        public static ProfilWindow Instance;
        mydbEntities8 _db = new mydbEntities8();
        public ProfilWindow()
        {
            InitializeComponent();
            Instance = this;
        }

        private void Kupovine_Click(object sender, RoutedEventArgs e)
        {
            //dosadasnje kupovine
            try
            {

            ZatvoriButton.Visibility = Visibility.Visible;
            int pom = MainWindow.Instance.id_Ulogovanog;
            var query1 = from x in _db.kupovina_stavka //stavkeeee sa tim id koji zelim
                         orderby x.KUPAC_kupac_id
                         where x.KUPAC_kupac_id == pom
                         select x;
            int countx = query1.Count();
            grid1.Visibility = Visibility.Visible;
                List<nakit> nakitLista1 = new List<nakit>();
            for (int i=0;i<countx;i++)
            { 

                var stavka = query1.ToList();
              int idNakitaPom=  stavka[i].NAKIT_nakit_id;


                nakitLista1.Add(_db.nakit.Where(m => m.nakit_id == idNakitaPom).FirstOrDefault());
               
                
              
            
            }
            grid1.ItemsSource = nakitLista1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void grid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }
      /*

        private void Rezervacije_Click(object sender, RoutedEventArgs e)
        {

        }*/
        private void Zatvori_Click(object sender, RoutedEventArgs e)
        {
            try
            {

            grid1.Visibility = Visibility.Hidden;
            ZatvoriButton.Visibility = Visibility.Hidden;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MojProfil_Click(object sender, RoutedEventArgs e)
        {
            try
            {

            OkupcuWindoe kw = new OkupcuWindoe();//moze neki drugi prozor otvoriti al aj ya sad nek bude xd
            kw.Show();
            this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

     

        private void border_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Nakit_Click(object sender, RoutedEventArgs e)
        {
            try
            {

            grid1.Visibility = Visibility.Hidden;
            KupacKupujeWindow kkw = new KupacKupujeWindow();
            kkw.Show();
            this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void logoutButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {

            MainWindow kw = new MainWindow();//moze neki drugi prozor otvoriti al aj ya sad nek bude xd
            kw.Show();
            this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
