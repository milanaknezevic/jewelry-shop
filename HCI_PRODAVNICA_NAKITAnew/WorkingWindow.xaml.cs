using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for WorkingWindow.xaml
    /// </summary>
    
    public partial class WorkingWindow : Window
    {
        mydbEntities8 _db = new mydbEntities8();

        string jmbgUlogovanog;
        int idUlogovani;
        DataRowView rowForDeletion;
        int id;
        int jezikPOM;
        public static ResourceDictionary ThemeDictionary
        {
            get { return Application.Current.Resources.MergedDictionaries[4]; }
        }
        public WorkingWindow()
        {
            InitializeComponent();
            obrisiButton.IsEnabled = false;
            jmbgUlogovanog = MainWindow.Instance.jmbpom;
            idUlogovani = MainWindow.Instance.id_Ulogovanog;
           
            Load();
           // PodesiTemu();
           

        }
        public void podesiMessageBox()
        {
            try
            {

            var user = _db.zaposleni.Where(m => m.JMBG == jmbgUlogovanog).FirstOrDefault();
            if (user != null)
            {
                jezikPOM = user.jezik;
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        public void PodesiTemu()
        {
            try { 
            var user = _db.zaposleni.Where(m => m.JMBG==jmbgUlogovanog).FirstOrDefault();
            int tema = user.tema;
            if(tema==1)//light.xaml 
            {
                ThemeDictionary.MergedDictionaries.Clear();
                ThemeDictionary.MergedDictionaries.Add(new ResourceDictionary
                {
                    Source = new Uri("pack://application:,,,/HCI_PRODAVNICA_NAKITAnew;component/Light.xaml")


                });
            }
            if (tema == 2)//light.xaml 
            {
                ThemeDictionary.MergedDictionaries.Clear();
                ThemeDictionary.MergedDictionaries.Add(new ResourceDictionary
                {
                    Source = new Uri("pack://application:,,,/HCI_PRODAVNICA_NAKITAnew;component/Dark.xaml")


                });
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Unos nije validan");
            }

        }
        public void Load()
        {
            try
            {///trebam staviti i ako  ije u stavka

            var query = from x in _db.nakit
                        orderby x.nakit_id
                        where x.kolicina>0
                        select x;
            
            grid1.ItemsSource = query.ToList();
            }   
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Unos nije validan");
            }
        }

        private void setButtonVisibility()
        {
            try
            {

            if (grid1.SelectedItem != null)
            {
                obrisiButton.IsEnabled = true;
            }
            else obrisiButton.IsEnabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void obrisiButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
               
                podesiMessageBox();
                if(jezikPOM==1)
                {
                    MessageBoxResult mbr = MessageBox.Show("Da li ste sigurni?", "", MessageBoxButton.YesNo);
                    switch (mbr)
                    {
                        case MessageBoxResult.Yes:
                            var deleteNakit = _db.nakit.Where(m => m.nakit_id == id).FirstOrDefault();
                            //var stavkeKupovina = _db.kupovina_stavka.Where(m => m.NAKIT_nakit_id == id).FirstOrDefault();
                            int stanje = deleteNakit.kolicina;

                            if (stanje > 0)
                            {
                                deleteNakit.kolicina -= 1;
                                _db.SaveChanges();
                                Load();

                            }

                            else
                            {
                                MessageBox.Show("Nakit nije raspoloziv na stanju");
                            }


                            break;
                        case MessageBoxResult.No:
                            break;
                    }

                }
                if (jezikPOM == 2)
                {
                    MessageBoxResult mbr = MessageBox.Show("Are you sure?", "", MessageBoxButton.YesNo);
                    switch (mbr)
                    {
                        case MessageBoxResult.Yes:
                            var deleteNakit = _db.nakit.Where(m => m.nakit_id == id).FirstOrDefault();
                            //var stavkeKupovina = _db.kupovina_stavka.Where(m => m.NAKIT_nakit_id == id).FirstOrDefault();
                            int stanje = deleteNakit.kolicina;

                            if (stanje > 0)
                            {
                                deleteNakit.kolicina -= 1;
                                _db.SaveChanges();
                                Load();

                            }

                            else
                            {
                                MessageBox.Show("There is no available jewerly");
                            }


                            break;
                        case MessageBoxResult.No:
                            break;
                    }

                }

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Unos nije validan");
            }


        }
        private void grid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {

           setButtonVisibility();

            if (grid1.SelectedItem != null)
            {
                if (grid1.SelectedItem is nakit)
                {
                    var row = (nakit)grid1.SelectedItem;
                    //id = row.id;
                    id = (grid1.SelectedItem as nakit).nakit_id;


                }
            }
            return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Unos nije validan");
            }
        }
        private void dodajNakitButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {

            AddingWindow aw = new AddingWindow();
            aw.Show();
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

            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AzurirajButton_Click(object sender, RoutedEventArgs e)
        { try
            {

            UpdateWindow uw = new UpdateWindow();
            uw.Show();
            this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {

            SettingsWindow sw = new SettingsWindow();
             sw.Show();
             this.Close();
            
            //  new SettingsWindow().Show();  Close();
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

            OkupcuWindoe ok = new OkupcuWindoe(jmbgUlogovanog);
            ok.Show();
            this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }









    }

}
