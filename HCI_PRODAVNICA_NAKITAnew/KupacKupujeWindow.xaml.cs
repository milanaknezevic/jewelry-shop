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
    /// Interaction logic for KupacKupujeWindow.xaml
    /// </summary>
    public partial class KupacKupujeWindow : Window
    {
        mydbEntities8 _db = new mydbEntities8();
        int id;
        int idKupca;
        string rijecZaPretragu;
        int idUlogoanog;
        int jezikPOM;
        public KupacKupujeWindow()
        {
            InitializeComponent();
            Load();
            idKupca = MainWindow.Instance.id_Ulogovanog;
            idUlogoanog = MainWindow.Instance.id_Ulogovanog;
            PretraziButton.IsEnabled = false;
            rijecZaPretragu = "";
        }


        public void Load()
        {
            try
            {

            var query = from x in _db.nakit
                        orderby x.nakit_id
                        where x.kolicina > 0
                        select x;

            grid1.ItemsSource = query.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            try
            {

            ProfilWindow sw = new ProfilWindow();
            sw.Show();
            this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void podesiMessageBox()
        {
            try
            {

            var user = _db.kupac.Where(m => m.kupac_id == idUlogoanog).FirstOrDefault();
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
        private void KupiButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                podesiMessageBox();
                if (jezikPOM == 1)
                {
                    MessageBoxResult mbr = MessageBox.Show("Da li ste sigurni?", "", MessageBoxButton.YesNo);
                    switch (mbr)
                    {
                        case MessageBoxResult.Yes:
                            var deleteNakit = _db.nakit.Where(m => m.nakit_id == id).FirstOrDefault();

                            deleteNakit.kolicina -= 1;// _db.nakit.Remove(deleteNakit);
                            _db.SaveChanges();

                            Load();
                            kupovina_stavka novaStavka = new kupovina_stavka()
                            {

                                //gramaza = gramazaTextBox.Text;
                                KUPAC_kupac_id = idKupca,
                                NAKIT_nakit_id = id


                            };
                            _db.kupovina_stavka.Add(novaStavka);
                            _db.SaveChanges();
                            // pretraziTextBox.Text = "";

                          //  if (rijecZaPretragu != string.Empty || rijecZaPretragu != null)
                          if(rijecZaPretragu != string.Empty)
                            {
                                var query = from x in _db.nakit
                                            orderby x.nakit_id
                                            where x.naziv.Contains(rijecZaPretragu) && x.kolicina > 0
                                            select x;

                                grid1.ItemsSource = query.ToList();
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

                            deleteNakit.kolicina -= 1;// _db.nakit.Remove(deleteNakit);
                            _db.SaveChanges();

                            Load();
                            kupovina_stavka novaStavka = new kupovina_stavka()
                            {

                                //gramaza = gramazaTextBox.Text;
                                KUPAC_kupac_id = idKupca,
                                NAKIT_nakit_id = id


                            };
                            _db.kupovina_stavka.Add(novaStavka);
                            _db.SaveChanges();
                            // pretraziTextBox.Text = "";

                            if (rijecZaPretragu != string.Empty)
                            {
                                var query = from x in _db.nakit
                                            orderby x.nakit_id
                                            where x.naziv.Contains(rijecZaPretragu) && x.kolicina > 0
                                            select x;

                                grid1.ItemsSource = query.ToList();
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

            //setButtonVisibility();

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

        private void PretraziButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
               if(rijecZaPretragu!=string.Empty)
                {
                    var query = from x in _db.nakit
                                orderby x.nakit_id
                                where x.naziv.Contains(rijecZaPretragu) && x.kolicina>0
                                select x;

                    grid1.ItemsSource = query.ToList();
                }
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Unos nije validan");
            }
        }

        public void setButtonVisibility()
        {
            try
            {

            if(pretraziTextBox.Text!=null)
            {
                PretraziButton.IsEnabled = true;
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Unos nije validan");
            }
        }
        private void pretraziTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                setButtonVisibility();
                rijecZaPretragu = pretraziTextBox.Text;
                if (rijecZaPretragu == string.Empty)
                {
                    var query = from x in _db.nakit
                                orderby x.nakit_id
                                where x.kolicina > 0
                                select x;

                    grid1.ItemsSource = query.ToList();
                    PretraziButton.IsEnabled = false;
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
