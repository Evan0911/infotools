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
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using CryptSharp;
using BCrypt.Net;


namespace Projet_infotools_CSharp
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();

            bdd.Initialize();
            
        }

        private void BtnConnecter_Click(object sender, RoutedEventArgs e)
        {



            if (Psw.Password == "" || TxtIdentifiant.Text == "")
            {
                //Un message va apparaître pour dire à l'utilisateur de mettre quelque chose dans 
                //le textbox et le mdpBox

                MessageBox.Show("Veuillez écrire votre identifiant et/ou votre mot de passe", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                TxtIdentifiant.Focus(); // Le curseur se met sur TxtIdentifiant  
                return;
            }

            if (!Regex.Match(TxtIdentifiant.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,4})+)$").Success)
            {
                //Cette condition vérifie que l'utilisateur tape une adresse mail conventionnelle.
                MessageBox.Show("Votre identifiant est votre adresse mail.", "Nom d'identifiant incorrect", MessageBoxButton.OK, MessageBoxImage.Error);
                TxtIdentifiant.Focus(); // Le curseur se met sur TxtIdentifiant  
                return;
            }

            List<users> cUsers = bdd.SearchUser(TxtIdentifiant.Text);
            if (cUsers.Count != 0)
            {
                var md5 = new MD5CryptoServiceProvider();
                if (BCrypt.Net.BCrypt.Verify(Psw.Password.ToString(), cUsers[0].MdpUser))
                {
                    FenêtreAccueilPro wnd = new FenêtreAccueilPro();
                    TxtIdentifiant.Text = "";
                    Psw.Password = "";
                    wnd.Show();
                    this.Close();
                    //Ce bouton permet à l'utilisateur de se rendre à la page d'accueil une fois 
                    //qu'il aura saisi son identifiant et son mot de passe.

                    //Regex mail = new Regex(@"^([\w\.\-]+)@([w\-]+)((\.w){2,4}+)$");
                    //mail = Convert.ToChar(TxtIdentifiant.Text);
                }
            }
            
        }

        private void BtnQuitter_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
            //Grâce à cette commande, appuyer sur le bouton ferme l'application
        }

        private void BtnCréerCompte_Click(object sender, RoutedEventArgs e)
        {
            CréerCompteClient wnd = new CréerCompteClient();
            wnd.ShowDialog();
            // Ce bouton permet à l'utilisateur de créer un compte.
        }

        private void BtnMdpOublié_Click(object sender, RoutedEventArgs e)
        {
            FenêtreMDPOublié wnd = new FenêtreMDPOublié();
            wnd.ShowDialog();
            // Si l'utilisateur a oublié son mot de passe, il peut toujours compter sur ce bouton
            //pour en avoir un autre.
        }

        private void TxtIdentifiant_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}