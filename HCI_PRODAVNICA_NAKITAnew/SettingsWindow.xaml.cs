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
    /// Interaction logic for SettingsWindow.xaml
    /// </summary>
    public partial class SettingsWindow : Window
    {
        mydbEntities8 _db = new mydbEntities8();
        public static SettingsWindow Instance;

        public string ime = "";
        public string lozinka = "";
        public bool change = false;
        bool kupac1 = false;
        bool zaposleni1 = false;
       // bool bioUSettings = false;
        string jmbgZaposlenog1;
        int darkPom;
        int lightPom;
        int rosePom;
        int idUlogovanog1;
       public int srpskiPom;
     public   int engleskiPom;
        public int jezik;
        public int tema;
        int idUlogovani;
        string jmbgUlogovanog;
     
            int jezikPOM;
        public static ResourceDictionary ThemeDictionary
        {
            get { return Application.Current.Resources.MergedDictionaries[4]; }
        }
        public static ResourceDictionary LanguageDictionary
        {
            get { return Application.Current.Resources.MergedDictionaries[5]; }
        }
        public SettingsWindow()
        {
            InitializeComponent();
            Instance = this;
            int tema = 1;
            int jezik = 1;
            sacuvajJezik();//po defoltu srpski jezik i gold tema
            sacuvajTeme();
            // MainWindow.Instance.bioUSettings = true;
            
            podesiButtone(tema);
            podesiButtoneZaJezik(jezik);

        }


        public void podesiButtone( int tema)
        {
            try { 
            if (tema == 1)
            {
                DarkButton.IsChecked = true;
                LightButton.IsChecked = false;
                RoseButton.IsChecked = false;
            }
            if (tema == 2)
            {
                LightButton.IsChecked = true;
                DarkButton.IsChecked = false;
                RoseButton.IsChecked = false;
            }
            if (tema == 3)
            {
                RoseButton.IsChecked = true;
                LightButton.IsChecked = false;
                DarkButton.IsChecked = false;
            }

             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Unos nije validan");
            }
        }
        public void podesiButtoneZaJezik(int jezik)
        {
            try
            {
                if (jezik == 1)//srpski
                {
                    SrpskiButton.IsChecked = true;
                    EngleskiButton.IsChecked = false;
                    
                }
                if (jezik == 2)//engleski
                {
                    EngleskiButton.IsChecked = true;
                    SrpskiButton.IsChecked = false;
                }
                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Unos nije validan");
            }
        }

        public SettingsWindow(bool zaposleniPom, bool kupacPom, string jmbgzap)//ovde ulazi i kupac i zaposleni
        {
            InitializeComponent();
            Instance = this;
            ime = MainWindow.Instance.korisnickoImePom;
            lozinka = MainWindow.Instance.lozinkaPom;
            idUlogovanog1 = MainWindow.Instance.id_Ulogovanog;
            kupac1 = kupacPom;
            zaposleni1 = zaposleniPom;
            jmbgZaposlenog1 = jmbgzap;
            jmbgUlogovanog = MainWindow.Instance.jmbpom;
            idUlogovani = MainWindow.Instance.id_Ulogovanog;


            var userZaposleni = _db.zaposleni.Where(m => m.JMBG == jmbgZaposlenog1).FirstOrDefault();
            var userKupac = _db.kupac.Where(m => m.kupac_id == idUlogovanog1).FirstOrDefault();
            if(userKupac!=null)
            {

            int tema = userKupac.tema;
                int jezik = userKupac.jezik;
            podesiButtone(tema);
                podesiButtoneZaJezik(jezik);
            }
            if (userZaposleni != null)
            {

                int tema = userZaposleni.tema;
                int jezik = userZaposleni.jezik;
                podesiButtone(tema);
                podesiButtoneZaJezik(jezik);
            }
        }

       


        public SettingsWindow(bool pom)
        {
            InitializeComponent();
            Instance = this;
             pom = change;
        }

       private void DarkButton_Checked(object sender, RoutedEventArgs e)// dark tema je broj 1 u bazi
        {
            try
            {
                DarkButton.IsChecked = true;
                LightButton.IsChecked = false;
                RoseButton.IsChecked = false;
                DarkButton.Foreground = Brushes.Black;
                DarkButton.Background = Brushes.Gold;
                LightButton.Foreground = Brushes.Black;
                LightButton.Background = Brushes.Gold;
                RoseButton.Foreground = Brushes.Black;
                RoseButton.Background = Brushes.Gold;
                SaveButton.Foreground = Brushes.Black;
                SaveButton.Background = Brushes.Gold;
                btnExit.Foreground = Brushes.Black;
                btnExit.Background = Brushes.Gold;
                TemeLabela.Foreground = Brushes.Gold;
                JezikLabela.Foreground = Brushes.Gold;
                SrpskiButton.Foreground = Brushes.Black;
                SrpskiButton.Background = Brushes.Gold;
                EngleskiButton.Foreground = Brushes.Black;
                EngleskiButton.Background = Brushes.Gold;

                darkPom = 1;

                rosePom = 0;
                lightPom = 0;
               


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Unos nije validan");
            }
        }

        private void LightButton_Checked(object sender, RoutedEventArgs e)//light tema je u bazi 2
        {
            try
            {
                LightButton.IsChecked = true;
                DarkButton.IsChecked = false;
               RoseButton.IsChecked = false;
                DarkButton.Foreground = Brushes.Black;
                DarkButton.Background = Brushes.DarkTurquoise;
                LightButton.Foreground = Brushes.Black;
                LightButton.Background = Brushes.DarkTurquoise;
                RoseButton.Foreground = Brushes.Black;
                RoseButton.Background = Brushes.DarkTurquoise;
                SaveButton.Foreground = Brushes.Black;
                SaveButton.Background = Brushes.DarkTurquoise;
                btnExit.Foreground = Brushes.Black;
                btnExit.Background = Brushes.DarkTurquoise;
                TemeLabela.Foreground = Brushes.DarkTurquoise;
                JezikLabela.Foreground = Brushes.DarkTurquoise;
                SrpskiButton.Foreground = Brushes.Black;
                SrpskiButton.Background = Brushes.DarkTurquoise;
                EngleskiButton.Foreground = Brushes.Black;
                EngleskiButton.Background = Brushes.DarkTurquoise;
                lightPom = 2;
                darkPom = 0;
                rosePom = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Unos nije validan");
            }
        }

        private void RoseButton_Checked(object sender, RoutedEventArgs e)//rose tema je u bazi 3
        {
            try
            {

            LightButton.IsChecked = false;
            DarkButton.IsChecked = false;
            RoseButton.IsChecked = true;
            DarkButton.Foreground = Brushes.Black;
            DarkButton.Background = Brushes.MistyRose;
            LightButton.Foreground = Brushes.Black;
            LightButton.Background = Brushes.MistyRose;
            RoseButton.Foreground = Brushes.Black;
            RoseButton.Background = Brushes.MistyRose;
            SaveButton.Foreground = Brushes.Black;
            SaveButton.Background = Brushes.MistyRose;
            btnExit.Foreground = Brushes.Black;
            btnExit.Background = Brushes.Pink;
               TemeLabela.Foreground = Brushes.Pink;
                JezikLabela.Foreground = Brushes.Pink;
                SrpskiButton.Foreground = Brushes.Black;
                SrpskiButton.Background = Brushes.MistyRose;
                EngleskiButton.Foreground = Brushes.Black;
                EngleskiButton.Background = Brushes.MistyRose;


                rosePom = 3;
            darkPom = 0;
            lightPom = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Unos nije validan");
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
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


                            sacuvajTeme();
                            sacuvajJezik();

                            break;
                        case MessageBoxResult.No:
                            break;
                    }
                }


                if (jezikPOM == 2)
                {
                    MessageBoxResult mbr = MessageBox.Show("Are u sure?", "", MessageBoxButton.YesNo);
                    switch (mbr)
                    {
                        case MessageBoxResult.Yes:


                            sacuvajTeme();
                            sacuvajJezik();
                           

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

        public void sacuvajJezik()
        {
            try
            {

                if (srpskiPom == 1 && engleskiPom==0)

                {
                    LanguageDictionary.MergedDictionaries.Clear();
                    LanguageDictionary.MergedDictionaries.Add(new ResourceDictionary
                    {
                        Source = new Uri("pack://application:,,,/HCI_PRODAVNICA_NAKITAnew;component/Srpski.xaml")
                    });
                   
                    var user = _db.zaposleni.Where(m => m.username == ime && m.pasword == lozinka).FirstOrDefault();
                    var userKupac = _db.kupac.Where(m => m.username == ime && m.pasword == lozinka).FirstOrDefault();

                    if (user != null)//yuta tema je 2
                    {
                        user.jezik = 1;
                        _db.SaveChanges();
                    }
                    if (userKupac != null)
                    {
                        userKupac.jezik = 1;
                        _db.SaveChanges();
                    }
                   
                    change = true;
                }


                if (srpskiPom == 0 && engleskiPom == 1)

                {
                    LanguageDictionary.MergedDictionaries.Clear();
                    LanguageDictionary.MergedDictionaries.Add(new ResourceDictionary
                    {
                        Source = new Uri("pack://application:,,,/HCI_PRODAVNICA_NAKITAnew;component/Engleski.xaml")
                    });
                    
                    var user = _db.zaposleni.Where(m => m.username == ime && m.pasword == lozinka).FirstOrDefault();
                    var userKupac = _db.kupac.Where(m => m.username == ime && m.pasword == lozinka).FirstOrDefault();

                    if (user != null)
                    {
                        user.jezik = 2;
                        _db.SaveChanges();
                    }
                    if (userKupac != null)
                    {
                        userKupac.jezik = 2;
                        _db.SaveChanges();
                    }
                    change = true;
                }

                if(srpskiPom==1)
                {
                    jezik = 1;
                }
                if(engleskiPom==1)
                {
                    jezik = 2;
                }



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
            var userKupac = _db.kupac.Where(m => m.kupac_id == idUlogovani).FirstOrDefault();

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
                //MessageBox.Show("Unos nije validan");
            }
        }
        public void sacuvajTeme()
        {
            try
            {
                if (darkPom == 1 && lightPom == 0 && rosePom == 0)

                {
                    tema = 1;
                    ThemeDictionary.MergedDictionaries.Clear();
                    ThemeDictionary.MergedDictionaries.Add(new ResourceDictionary
                    {
                        Source = new Uri("pack://application:,,,/HCI_PRODAVNICA_NAKITAnew;component/Dark.xaml")


                    });
                   
                    var user = _db.zaposleni.Where(m => m.username == ime && m.pasword == lozinka).FirstOrDefault();
                    var userKupac = _db.kupac.Where(m => m.username == ime && m.pasword == lozinka).FirstOrDefault();

                    if (user != null)//yuta tema je 2
                    {
                        user.tema = 1;
                        _db.SaveChanges();
                    }
                    if (userKupac != null)
                    {
                        userKupac.tema = 1;
                        _db.SaveChanges();
                    }
                    change = true;
                   
                }



                if (darkPom == 0 && lightPom == 2 && rosePom == 0)

                {
                    tema = 2;
                    ThemeDictionary.MergedDictionaries.Clear();
                    ThemeDictionary.MergedDictionaries.Add(new ResourceDictionary
                    {
                        Source = new Uri("pack://application:,,,/HCI_PRODAVNICA_NAKITAnew;component/Light.xaml")


                    });
                 
                    var user = _db.zaposleni.Where(m => m.username == ime && m.pasword == lozinka).FirstOrDefault();
                    var userKupac = _db.kupac.Where(m => m.username == ime && m.pasword == lozinka).FirstOrDefault();

                    if (user != null)//yuta tema je 2
                    {
                        user.tema = 2;
                        _db.SaveChanges();
                    }
                    if (userKupac != null)
                    {
                        userKupac.tema = 2;
                        _db.SaveChanges();
                    }
                    change = true;
                  
                }




                if (rosePom == 3 && darkPom == 0 && lightPom == 0)

                {
                    tema = 3;
                    ThemeDictionary.MergedDictionaries.Clear();
                    ThemeDictionary.MergedDictionaries.Add(new ResourceDictionary
                    {
                        Source = new Uri("pack://application:,,,/HCI_PRODAVNICA_NAKITAnew;component/Rose.xaml")


                    });
                    var user = _db.zaposleni.Where(m => m.username == ime && m.pasword == lozinka).FirstOrDefault();
                    var userKupac = _db.kupac.Where(m => m.username == ime && m.pasword == lozinka).FirstOrDefault();

                    if (user != null)//yuta tema je 2
                    {
                        user.tema = 3;
                        _db.SaveChanges();
                    }
                    if (userKupac != null)
                    {
                        userKupac.tema = 3;
                        _db.SaveChanges();
                    }
                    change = true;
                   
                }

              /*  if (zaposleni1 == true && kupac1 == false)
                {
                    WorkingWindow ww = new WorkingWindow();
                    ww.Show();
                    this.Hide();
                }

                if (kupac1 == true && zaposleni1 == false)
                {
                    ProfilWindow ww = new ProfilWindow();
                    ww.Show();
                    this.Hide();
                }*/
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

            if (zaposleni1 == true && kupac1 == false)
            {
                    /* WorkingWindow ww = new WorkingWindow();
                     ww.Show();
                     this.Hide();*/
                    OkupcuWindoe ww = new OkupcuWindoe(jmbgZaposlenog1);
                    ww.Show();
                    this.Hide();
                }

            if (kupac1 == true && zaposleni1 == false)
            {
                    /*ProfilWindow ww = new ProfilWindow();
                    ww.Show();
                    this.Hide();*/
                    OkupcuWindoe ww = new OkupcuWindoe();
                    ww.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Unos nije validan");
            }

        }

        private void EngleskiButton_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                SrpskiButton.IsChecked = false;
                EngleskiButton.IsChecked = true;
                DarkButton.Content = "Gold";
                LightButton.Content = "Blue";
                RoseButton.Content = "Rose";
                SrpskiButton.Content = "Serbian";
                EngleskiButton.Content = "English";
                SaveButton.Content = "Apply";

                TemeLabela.Content = "Theme:";
                JezikLabela.Content = "Languages:";
                srpskiPom = 0;
                engleskiPom = 1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Unos nije validan");
            }
        }

        private void SrpskiButton_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
               SrpskiButton.IsChecked = true;
                EngleskiButton.IsChecked = false;
                DarkButton.Content = "Zlatna";
                LightButton.Content = "Plava";
                RoseButton.Content = "Roza";
                SrpskiButton.Content = "Srpski";
                EngleskiButton.Content = "Engleski";
                SaveButton.Content="Sačuvaj";
               
                TemeLabela.Content = "Teme:";
                JezikLabela.Content = "Jezik:";
                srpskiPom = 1;
                engleskiPom = 0;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Unos nije validan");
            }
        }
    }
}
