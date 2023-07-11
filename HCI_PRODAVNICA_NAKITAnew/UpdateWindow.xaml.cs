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
    /// Interaction logic for UpdateWindow.xaml
    /// </summary>
    public partial class UpdateWindow : Window
    {
        mydbEntities8 _db = new mydbEntities8();
        decimal cijena;
        int kolicina;
        int id;
        string jmbgUlogovanog;
        int jezikPOM;
       
        public UpdateWindow()
        {
            InitializeComponent();
            Load();
            izvrsiButton.IsEnabled = false;
            jmbgUlogovanog = MainWindow.Instance.jmbpom;
        }




        public void Load()
        {


            try
            {
            var query = from x in _db.nakit
                        orderby x.nakit_id
                        select x;
            nakitGrid.ItemsSource = query.ToList();

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

            if ((novaCijenaTextBox.Text != string.Empty || novaKolicinaTextBox.Text != string.Empty) && nakitGrid.SelectedItem != null)
            {
                izvrsiButton.IsEnabled = true;
                return;
            }
            izvrsiButton.IsEnabled = false;
            return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void nakitGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try { 

            if (nakitGrid.SelectedItem != null)
            {
                setButtonVisibility();
                if (nakitGrid.SelectedItem is nakit)
                {
                    var row = (nakit)nakitGrid.SelectedItem;
                    id = (nakitGrid.SelectedItem as nakit).nakit_id;


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
       
        private void izvrsiButton_Click(object sender, RoutedEventArgs e)
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

                        nakit nakitZaPromjeniti = _db.nakit.Where(m => m.nakit_id == id).FirstOrDefault();

                        if(novaCijenaTextBox.Text != string.Empty && novaKolicinaTextBox.Text != string.Empty)
                        {

                        nakitZaPromjeniti.cijena = cijena;
                            nakitZaPromjeniti.kolicina = kolicina;
                        }
                        else if(novaCijenaTextBox.Text != string.Empty)
                        {
                            nakitZaPromjeniti.cijena = cijena;
                        }
                        else if (novaKolicinaTextBox.Text != string.Empty)
                        {
                            nakitZaPromjeniti.kolicina = kolicina;
                        }

                        _db.SaveChanges();
                        nakitGrid.ItemsSource = _db.nakit.ToList();

                       izvrsiButton.IsEnabled = false;
                        novaCijenaTextBox.Text ="";
                        novaKolicinaTextBox.Text = string.Empty;
                       
                        
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

                            nakit nakitZaPromjeniti = _db.nakit.Where(m => m.nakit_id == id).FirstOrDefault();

                            if (novaCijenaTextBox.Text != string.Empty && novaKolicinaTextBox.Text != string.Empty)
                            {

                                nakitZaPromjeniti.cijena = cijena;
                                nakitZaPromjeniti.kolicina = kolicina;
                            }
                            else if (novaCijenaTextBox.Text != string.Empty)
                            {
                                nakitZaPromjeniti.cijena = cijena;
                            }
                            else if (novaKolicinaTextBox.Text != string.Empty)
                            {
                                nakitZaPromjeniti.kolicina = kolicina;
                            }

                            _db.SaveChanges();
                            nakitGrid.ItemsSource = _db.nakit.ToList();

                            izvrsiButton.IsEnabled = false;
                            novaCijenaTextBox.Text = "";
                            novaKolicinaTextBox.Text = string.Empty;


                            break;
                        case MessageBoxResult.No:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.Message);
               // MessageBox.Show("Unos nije validan");
            }

        }

        private void goBackButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {

            WorkingWindow ww = new WorkingWindow();
            ww.Show();
            this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Unos nije validan");
            }
        }

        private void novaCijenaTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
            setButtonVisibility();

                if(novaCijenaTextBox.Text !=string.Empty)
                {
            cijena = decimal.Parse(novaCijenaTextBox.Text);

                }    

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Unos nije validan");
            }
        }

        private void novaKolicinaTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {

                setButtonVisibility();
                if (novaKolicinaTextBox.Text != string.Empty)
                {
                    

                kolicina = int.Parse(novaKolicinaTextBox.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Unos nije validan");
            }
        }
    }
}
