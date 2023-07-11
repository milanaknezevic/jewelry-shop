using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
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

namespace HCI_PRODAVNICA_NAKITAnew
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
       mydbEntities8 _db = new mydbEntities8();
        
        public static MainWindow Instance;
        public static bool zaposleni=false;
        public static bool kupac = false;
        public String korisnickoImePom="";
        public String lozinkaPom="";
        public static DataGrid datagrid;
        public bool bioUSettings = false;
        public string jmbpom = "";
        public int id_Ulogovanog;
        public int jezik;
        public int tema;
        public int jezikPOM;
        public int temaPOM;

        public static ResourceDictionary ThemeDictionary
        {
            get { return Application.Current.Resources.MergedDictionaries[4]; }
        }
        public static ResourceDictionary LanguageDictionary
        {
            get { return Application.Current.Resources.MergedDictionaries[5]; }
        }
        public MainWindow()
        {
            InitializeComponent();
            Instance = this;
           btnLogin.IsEnabled = false;
           
        }

      
        private void setButtonVisibility()
        {
            try
            {

            if (txtUsername.Text != string.Empty && txtPassword.Password != string.Empty)
            {
                btnLogin.IsEnabled = true;
              
            }
            else
            {
                btnLogin.IsEnabled = false; 
              
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

     

        private void passwordTextBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            try
            {

            lozinkaPom=txtPassword.Password;
         
            setButtonVisibility();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtUsername_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {

            korisnickoImePom = txtUsername.Text;

            setButtonVisibility();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                var user = _db.zaposleni.Where(m => m.username == korisnickoImePom && m.pasword == lozinkaPom).FirstOrDefault();
                var userKupac = _db.kupac.Where(m => m.username == korisnickoImePom && m.pasword == lozinkaPom).FirstOrDefault();
                
                if (user != null)
                {
                    zaposleni = true;
                    jmbpom = user.JMBG;
                    PodesiTemu();
                    PodesiJezik();
                    WorkingWindow ww = new WorkingWindow();
                    ww.Show();
                    this.Close();
                }
                if (userKupac != null)
                {
                    kupac = true;
                    id_Ulogovanog = userKupac.kupac_id;
                    PodesiTemu();
                    PodesiJezik();
                    // jmbpom = userKupac.kupac_id;
                    ProfilWindow kw = new ProfilWindow();//moze neki drugi prozor otvoriti al aj ya sad nek bude xd
                    kw.Show();
                    this.Close();
                }
                if (user == null && userKupac == null)
                {
                    /* podesiMessageBox();
                     if(jezikPOM==1 || jezikPOM ==0)//provjeri
                     {
                     }
                     if(jezikPOM==2)
                     {
                     }*/
                    if (btnLogin.Content.Equals("Prijavite se"))
                    {
                         MessageBox.Show("Nepostojeci korisnik!");

                    }
                    else
                    {
                         MessageBox.Show("User does not exist!");

                    }
                }

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

            Application.Current.Shutdown();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
      public void  podesiMessageBox()
        {
            try
            {

            var user = _db.zaposleni.Where(m => m.JMBG == jmbpom).FirstOrDefault();
            var userKupac = _db.kupac.Where(m => m.kupac_id == id_Ulogovanog).FirstOrDefault();
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
        public void PodesiJezik ()
        {
            try
            {
                var user = _db.zaposleni.Where(m => m.JMBG == jmbpom).FirstOrDefault();
                var userKupac = _db.kupac.Where(m => m.kupac_id == id_Ulogovanog).FirstOrDefault();
                if (user != null)
                {
                     jezik = user.jezik;//1 je srpski
                    if (jezik == 1)
                    {
                        LanguageDictionary.MergedDictionaries.Clear();
                        LanguageDictionary.MergedDictionaries.Add(new ResourceDictionary
                        {
                            Source = new Uri("pack://application:,,,/HCI_PRODAVNICA_NAKITAnew;component/Srpski.xaml")
                        });
                    }
                    if (jezik == 2)
                    {
                        LanguageDictionary.MergedDictionaries.Clear();
                        LanguageDictionary.MergedDictionaries.Add(new ResourceDictionary
                        {
                            Source = new Uri("pack://application:,,,/HCI_PRODAVNICA_NAKITAnew;component/Engleski.xaml")
                        });
                    }
                }
                if (userKupac != null)
                {
                     jezik = userKupac.jezik;//1 je srpski
                    if (jezik == 1)
                    {
                        LanguageDictionary.MergedDictionaries.Clear();
                        LanguageDictionary.MergedDictionaries.Add(new ResourceDictionary
                        {
                            Source = new Uri("pack://application:,,,/HCI_PRODAVNICA_NAKITAnew;component/Srpski.xaml")
                        });
                    }
                    if (jezik == 2)
                    {
                        LanguageDictionary.MergedDictionaries.Clear();
                        LanguageDictionary.MergedDictionaries.Add(new ResourceDictionary
                        {
                            Source = new Uri("pack://application:,,,/HCI_PRODAVNICA_NAKITAnew;component/Engleski.xaml")
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Unos nije validan");
            }
        }
        public void PodesiTemu()
        {
            try
            {
                var user = _db.zaposleni.Where(m => m.JMBG == jmbpom).FirstOrDefault();
                var userKupac = _db.kupac.Where(m => m.kupac_id == id_Ulogovanog).FirstOrDefault();
                
                if(user !=null)
                {
                 tema = user.tema;
                    if (tema == 1)//dark.xaml 
                    {
                        ThemeDictionary.MergedDictionaries.Clear();
                        ThemeDictionary.MergedDictionaries.Add(new ResourceDictionary
                        {
                            Source = new Uri("pack://application:,,,/HCI_PRODAVNICA_NAKITAnew;component/Dark.xaml")


                        });
                    }
                    if (tema == 2)//light.xaml 
                    {
                        ThemeDictionary.MergedDictionaries.Clear();
                        ThemeDictionary.MergedDictionaries.Add(new ResourceDictionary
                        {
                            Source = new Uri("pack://application:,,,/HCI_PRODAVNICA_NAKITAnew;component/Light.xaml")


                        });
                    }
                    if (tema == 3)//Rose.xaml 
                    {
                        ThemeDictionary.MergedDictionaries.Clear();
                        ThemeDictionary.MergedDictionaries.Add(new ResourceDictionary
                        {
                            Source = new Uri("pack://application:,,,/HCI_PRODAVNICA_NAKITAnew;component/Rose.xaml")


                        });
                    }

                }
                if (userKupac != null)
                {
                     tema = userKupac.tema;
                    if (tema == 1)//dark.xaml 
                    {
                        ThemeDictionary.MergedDictionaries.Clear();
                        ThemeDictionary.MergedDictionaries.Add(new ResourceDictionary
                        {
                            Source = new Uri("pack://application:,,,/HCI_PRODAVNICA_NAKITAnew;component/Dark.xaml")


                        });
                    }
                    if (tema == 2)//light.xaml 
                    {
                        ThemeDictionary.MergedDictionaries.Clear();
                        ThemeDictionary.MergedDictionaries.Add(new ResourceDictionary
                        {
                            Source = new Uri("pack://application:,,,/HCI_PRODAVNICA_NAKITAnew;component/Light.xaml")


                        });
                    }
                    if (tema == 3)//Rose.xaml 
                    {
                        ThemeDictionary.MergedDictionaries.Clear();
                        ThemeDictionary.MergedDictionaries.Add(new ResourceDictionary
                        {
                            Source = new Uri("pack://application:,,,/HCI_PRODAVNICA_NAKITAnew;component/Rose.xaml")


                        });
                    }
                }
                if(bioUSettings==true)
                {

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

            SettingsWindow kw = new SettingsWindow();//moze neki drugi prozor otvoriti al aj ya sad nek bude xd
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
