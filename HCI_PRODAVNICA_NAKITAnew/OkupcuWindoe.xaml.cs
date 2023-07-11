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
    /// Interaction logic for OkupcuWindoe.xaml
    /// </summary>
    public partial class OkupcuWindoe : Window
    {
        mydbEntities8 _db = new mydbEntities8();
        public static OkupcuWindoe Instance;
        int idKupca;
        string usernamePom;
        string passwordPom;
        string mejlPom;
        string brojTelPom;
       //int temaPom;
        string jmbgZaposlenog;
        bool kupac = false;
        bool zaposleni = false;
        int srpski;
        int engleski;
        int jezikPOM;
        int idUlogovanog;
        string jmbgUlogovanog;
        public static ResourceDictionary ThemeDictionary
        {
            get { return Application.Current.Resources.MergedDictionaries[4]; }
        }
        public OkupcuWindoe() //ulazi kupac
        {
            InitializeComponent();

            Instance = this;
            idKupca = MainWindow.Instance.id_Ulogovanog;
            idUlogovanog = MainWindow.Instance.id_Ulogovanog;
            kupac = true;
            zaposleni = false;
            BrojTelLabel.Visibility = Visibility.Hidden;
            txtBrojtel.Visibility = Visibility.Hidden;
            podesiMessageBox();
           if(jezikPOM==1)
            {
            heading.Text = "Kupac";

            }
            if (jezikPOM== 2)
            {
                heading.Text = "Buyer";

            }
            postaviPromjenjive();
        }


        public OkupcuWindoe(string jmb)//ulazi zaposleni
        {
            InitializeComponent();

            Instance = this;
            jmbgZaposlenog = jmb;
            zaposleni = true;
            kupac = false;
            BrojTelLabel.Visibility = Visibility.Visible;
            txtBrojtel.Visibility = Visibility.Visible;
            jmbgUlogovanog = jmb;
            podesiMessageBox();
            if (jezikPOM == 1)
            {
                heading.Text = "Zaposleni";

            }
            if (jezikPOM == 2)
            {
                heading.Text = "Employee";

            }
            postaviPromjenjive();
        }


        public void postaviPromjenjive()
        {
            try
            {

            txtPersonName.IsEnabled = false;
            txtPassword.IsEnabled = false;
            txtEmail.IsEnabled = false;
          //  txtTema.IsEnabled = false;
                txtBrojtel.IsEnabled = false;
                if (kupac==true && zaposleni==false)
                {
                    var userKupac = _db.kupac.Where(m => m.kupac_id == idKupca).FirstOrDefault();
                    txtPersonName.Text = userKupac.username;
                    txtPassword.Text = userKupac.pasword;
                    txtEmail.Text = userKupac.email;
                  //  txtTema.Text = userKupac.tema.ToString();

                    usernamePom = userKupac.username;
                    passwordPom = userKupac.pasword;
                    mejlPom = userKupac.email;
                  //  temaPom = userKupac.tema;
                }
                if (zaposleni == true && kupac == false)
                {
                    var userZaposleni = _db.zaposleni.Where(m => m.JMBG == jmbgZaposlenog).FirstOrDefault();
                    txtPersonName.Text = userZaposleni.username;
                    txtPassword.Text =   userZaposleni.pasword;
                    txtEmail.Text =      userZaposleni.email;
                   // txtTema.Text =       userZaposleni.tema.ToString();
                    txtBrojtel.Text = userZaposleni.broj_telefona;

                    usernamePom = userZaposleni.username;
                    passwordPom = userZaposleni.pasword;
                    mejlPom = userZaposleni.email;
                  //  temaPom = userZaposleni.tema;
                    brojTelPom = userZaposleni.broj_telefona;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Unos nije validan");
            }
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            try
            {

            txtPersonName.IsEnabled = true;
            txtPassword.IsEnabled =   true;
            txtEmail.IsEnabled =      true;
          //  txtTema.IsEnabled =       true;
            txtBrojtel.IsEnabled =    true;
                SaveButton.Visibility = Visibility.Visible;
                EditButton.IsEnabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Unos nije validan");
            }
        }

        private void txtPersonName_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {

            usernamePom = txtPersonName.Text;
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
            var userKupac = _db.kupac.Where(m => m.kupac_id == idUlogovanog).FirstOrDefault();
            if (user != null)
            {
                jezikPOM = user.jezik;
            }
            if (userKupac != null)
            {
                jezikPOM = userKupac.jezik;
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(kupac==true && zaposleni==false)
                {
                    podesiMessageBox();
                if(jezikPOM==1)
                    {
                        if (txtPersonName.Text != string.Empty && txtPassword.Text != string.Empty && txtEmail.Text != string.Empty)
                        {
                            MessageBoxResult mbr = MessageBox.Show("Da li ste sigurni?", "", MessageBoxButton.YesNo);
                            switch (mbr)
                            {
                                case MessageBoxResult.Yes:

                                    var userKupac = _db.kupac.Where(m => m.kupac_id == idKupca).FirstOrDefault();
                                    userKupac.username = usernamePom;
                                    userKupac.pasword = passwordPom;
                                    // userKupac.tema = temaPom;
                                    //  podesiTemu();

                                    userKupac.email = mejlPom;
                                    _db.SaveChanges();
                                    SaveButton.Visibility = Visibility.Hidden;
                                    EditButton.IsEnabled = true;
                                    postaviPromjenjive();
                                    break;
                                case MessageBoxResult.No:
                                    break;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Forma nije ispravno popunjena. Popunite sva polja.");
                        }
                    }
                if(jezikPOM==2)
                    {
                        if (txtPersonName.Text != string.Empty && txtPassword.Text != string.Empty && txtEmail.Text != string.Empty)
                        {
                            MessageBoxResult mbr = MessageBox.Show("Are you sure?", "", MessageBoxButton.YesNo);
                            switch (mbr)
                            {
                                case MessageBoxResult.Yes:

                                    var userKupac = _db.kupac.Where(m => m.kupac_id == idKupca).FirstOrDefault();
                                    userKupac.username = usernamePom;
                                    userKupac.pasword = passwordPom;
                                    // userKupac.tema = temaPom;
                                    //  podesiTemu();

                                    userKupac.email = mejlPom;
                                    _db.SaveChanges();
                                    SaveButton.Visibility = Visibility.Hidden;
                                    postaviPromjenjive();
                                    break;
                                case MessageBoxResult.No:
                                    break;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Form is incorrect. Fill all entries.");
                        }
                    }



                }
                if (zaposleni == true && kupac == false)
                {
                    podesiMessageBox();
                    if(jezikPOM==1)
                    {
                        if (txtPersonName.Text != string.Empty && txtPassword.Text != string.Empty && txtEmail.Text != string.Empty && txtBrojtel.Text != string.Empty)
                        {
                            MessageBoxResult mbr = MessageBox.Show("Da li ste sigurni?", "", MessageBoxButton.YesNo);
                            switch (mbr)
                            {
                                case MessageBoxResult.Yes:

                                    var userZaposleni = _db.zaposleni.Where(m => m.JMBG == jmbgZaposlenog).FirstOrDefault();
                                    userZaposleni.username = usernamePom;
                                    userZaposleni.pasword = passwordPom;
                                    //  userZaposleni.tema = temaPom;
                                    //  podesiTemu();
                                    userZaposleni.email = mejlPom;
                                    userZaposleni.broj_telefona = brojTelPom;
                                    _db.SaveChanges();
                                    SaveButton.Visibility = Visibility.Hidden;
                                    postaviPromjenjive();
                                    break;
                                case MessageBoxResult.No:
                                    break;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Forma nije ispravno popunjena. Popunite sva polja.");
                        }
                    }   
                    if(jezikPOM==2)
                    {
                        if (txtPersonName.Text != string.Empty && txtPassword.Text != string.Empty && txtEmail.Text != string.Empty && txtBrojtel.Text != string.Empty)
                        {
                            MessageBoxResult mbr = MessageBox.Show("Are you sure?", "", MessageBoxButton.YesNo);
                            switch (mbr)
                            {
                                case MessageBoxResult.Yes:

                                    var userZaposleni = _db.zaposleni.Where(m => m.JMBG == jmbgZaposlenog).FirstOrDefault();
                                    userZaposleni.username = usernamePom;
                                    userZaposleni.pasword = passwordPom;
                                    //  userZaposleni.tema = temaPom;
                                    //  podesiTemu();
                                    userZaposleni.email = mejlPom;
                                    userZaposleni.broj_telefona = brojTelPom;
                                    _db.SaveChanges();
                                    SaveButton.Visibility = Visibility.Hidden;
                                    postaviPromjenjive();
                                    break;
                                case MessageBoxResult.No:
                                    break;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Form is incorrect. Fill all entries.");
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Unos nije validan");
            }
        }

        private void txtPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {

            passwordPom = txtPassword.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Unos nije validan");
            }
        }

        private void txtEmail_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {

            mejlPom = txtEmail.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Unos nije validan");
            }
        }
      
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(kupac==true && zaposleni==false)
                {
                    ProfilWindow ww = new ProfilWindow();
                    ww.Show();
                    this.Close();
                }
                if (zaposleni == true && kupac == false)
                {
                    WorkingWindow ww = new WorkingWindow();
                    ww.Show();
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Unos nije validan");
            }
        }

        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {

          SettingsWindow ww = new SettingsWindow(zaposleni,kupac,jmbgZaposlenog);
            ww.Show();
            this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtBrojtel_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {

              brojTelPom = txtBrojtel.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Unos nije validan");
            }
        }
    }
}
