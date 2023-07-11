using System;
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
    /// Interaction logic for AddingWindow.xaml
    /// </summary>
    public partial class AddingWindow : Window
    {
        mydbEntities8 _db = new mydbEntities8();
        object selektovano;
      private  List<nakit> nakitZaDodatiLIST = new List<nakit>();
        List<nakit> nakitList = new List<nakit>();
        private bool isANotherButtonClicked;
        string jmbgUlogovanog;
        int jezikPOM;
  
        public AddingWindow()
        {
            InitializeComponent();
            dodajUKorpuButton.IsEnabled = false;
            potvdiButton.IsEnabled = false;
            obrisiStavkuButton.IsEnabled = false;
            jmbgUlogovanog = MainWindow.Instance.jmbpom;
  
        }
        private void setButtonVisibility()
        {
            try
            {

            if (nazivTextBox.Text != string.Empty && cijenaTextBox.Text != string.Empty && gramazaTextBox.Text != string.Empty && kolicinaTextBox.Text != string.Empty)
            {
                dodajUKorpuButton.IsEnabled = true;
                if (isANotherButtonClicked == true)
                    potvdiButton.IsEnabled = true;
            }
            else
            {
                dodajUKorpuButton.IsEnabled = false;
                potvdiButton.IsEnabled = false;
            }
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);   
            }

        }

        private void potvdiButton_Click(object sender, RoutedEventArgs e)
        {
            try { 
                foreach(nakit k in nakitZaDodatiLIST)
                {
                    nakit noviNakit = new nakit()
                {
                   
                    naziv = k.naziv,
                    cijena = k.cijena,
                    gramaza=k.gramaza ,
                    ZAPOSLENI_JMBG = k.ZAPOSLENI_JMBG,
                    kolicina=k.kolicina,
                };
           

                    var nakitKojiVecPostoji = _db.nakit.Where(m => m.naziv==noviNakit.naziv && m.gramaza==noviNakit.gramaza && m.cijena==noviNakit.cijena && m.ZAPOSLENI_JMBG==noviNakit.ZAPOSLENI_JMBG).FirstOrDefault();
                    if(nakitKojiVecPostoji!=null)
                    {
                        nakitKojiVecPostoji.kolicina += noviNakit.kolicina;
                        _db.SaveChanges();
                    }
                    else {
                        _db.nakit.Add(noviNakit);
                        _db.SaveChanges();
                    }  

                 
            }

                potvdiButton.IsEnabled = false;
                isANotherButtonClicked = false;
                nakitZaDodatiLIST.Clear();
                korpaGrid.Items.Refresh();
                /*  WorkingWindow ww = new WorkingWindow();
                   ww.Show();
                   this.Close();*/
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
                podesiMessageBox();
                if(jezikPOM==1)
                {

                MessageBox.Show("Unos nije validan!");
                }
                if(jezikPOM==2)
                {
                    MessageBox.Show("Entry is invalid!");
                }    
            }

}

        private void dodajUKorpuButton_Click(object sender, RoutedEventArgs e)//unositi sa zarezom
        {
            try
            {
            isANotherButtonClicked = true;
                setButtonVisibility();
               // (string, decimal, double,string,int) trenutniUnos = (null, 0, 0,null,0);
                
                nakit nakitZaDodati=new nakit();

             decimal cijenaP = decimal.Parse(cijenaTextBox.Text);
             double gramazaP = double.Parse(gramazaTextBox.Text);
             int kolicinaP = int.Parse(kolicinaTextBox.Text);
             string pom = MainWindow.Instance.jmbpom;
             nakitZaDodati.naziv = nazivTextBox.Text;
                nakitZaDodati.cijena = cijenaP;
                nakitZaDodati.gramaza = gramazaP;
                nakitZaDodati.ZAPOSLENI_JMBG = pom;
                nakitZaDodati.kolicina = kolicinaP;
                nakitZaDodatiLIST.Add(nakitZaDodati);
                // korpa.Add(trenutniUnos);

                // korpaGrid.Items.Add(new MyData {  naziv = nazivTextBox.Text, cijena = cijenaP, gramaza = gramazaP, kolicina=kolicinaP });
                korpaGrid.ItemsSource = nakitZaDodatiLIST;
            korpaGrid.Items.Refresh();
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
                podesiMessageBox();
                if (jezikPOM == 1)
                {

                    MessageBox.Show("Unos nije validan!");
                }
                if (jezikPOM == 2)
                {
                    MessageBox.Show("Entry is invalid!");
                }
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
            }
        }

        private void nazivTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try { 
            setButtonVisibility();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cijenaTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {

            setButtonVisibility();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gramazaTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {

            setButtonVisibility();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void kolicinaTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {

            setButtonVisibility();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    
        private void obrisiStavkuButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {

            if(selektovano!=null)
            {
                nakit nakitZaObrisati =(nakit) selektovano;
                nakitZaDodatiLIST.Remove(nakitZaObrisati);
                korpaGrid.Items.Refresh();
                selektovano = null;
                obrisiStavkuButton.IsEnabled = false;
             
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void korpaGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {

            selektovano = korpaGrid.SelectedItem;
            obrisiStavkuButton.IsEnabled = true;
            if (nakitZaDodatiLIST.Count == 0)
            {
                potvdiButton.IsEnabled = false;
            }
            else
            {
                potvdiButton.IsEnabled = true;
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
