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
using System.Text.RegularExpressions;

namespace Projet_infotools_CSharp
{
    /// <summary>
    /// Logique d'interaction pour CréerCompteClient.xaml
    /// </summary>
    public partial class CréerCompteClient : Window
    {
        public CréerCompteClient()
        {
            InitializeComponent();
        }


        private void btnConfirmer_Click(object sender, RoutedEventArgs e)
        {
            if (pwMDP.Password == "" || TxtNom.Text == ""|| Txtprénom.Text == ""|| TxtNumTel.Text == ""|| Txtidentifiant.Text == "" || pwMDP_Copy.Password == "")
            {
                //Un message va apparaître pour dire à l'utilisateur de mettre quelque chose dans 
                //le textbox et le mdpBox

                MessageBox.Show("Veuillez écrire votre identifiant et/ou votre mot de passe", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                TxtNom.Focus(); // Le curseur se met sur TxtNom  
                return;
            }



            if (!Regex.Match(Txtprénom.Text, "^[A-Z][a-zA-Z]*$|^[A-Z][a-zA-Zéèàêùçâîôû][-a-zA-Zéèàêùçâîôû]*$").Success)
            {
                // Le regex n'inclue ni les accents ni les tirets de manière naturelle donc il faut les ajouter
                // comme présenté ci-dessus.
                MessageBox.Show("Ce prénom est incorrect", "Message", MessageBoxButton.OK, MessageBoxImage.Error);
                Txtprénom.Focus();
                return;
            } // end if   

            if (!Regex.Match(TxtNom.Text, "^[A-Z]*$|^[A-Z][-A-Z]*$").Success)
            {
                // Le regex n'inclue ni les accents ni les tirets de manière naturelle donc il faut les ajouter
                // comme présenté ci-dessus.  
                MessageBox.Show("Ce nom est incorrect", "Message", MessageBoxButton.OK, MessageBoxImage.Error);
                TxtNom.Focus();
                return;
            } // end if   

            if (!Regex.Match(TxtNumTel.Text, @"^06[0-9]{8}$|^07[0-9]{8}$").Success)
                //Ici, lorsque l'utilisateur ne tape pas un numéro de téléphone commençant par '06' ou '07' et
                // ne composant pas 8 chiffres en plus des chiffres du début, 
                //alors un message apparaît pour indiquer une erreur.
            {
                MessageBox.Show("Numéro de téléphone incorrect", "Message", MessageBoxButton.OK, MessageBoxImage.Error);
                TxtNumTel.Focus(); //Le curseur se met sur TxtNumTel
                return;
            }


                if (!Regex.Match(Txtidentifiant.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,4})+)$").Success)
            {
                //Cette condition vérifie que l'utilisateur tape une adresse mail conventionnelle.
                MessageBox.Show("Votre identifiant est votre adresse mail.", "Nom d'identifiant incorrect", MessageBoxButton.OK, MessageBoxImage.Error);
                Txtidentifiant.Focus(); // Le curseur se met sur TxtIdentifiant  
                return;
            }
            this.Close();
            FenêtreAccueilPro wnd = new FenêtreAccueilPro();
            wnd.ShowDialog();
            //Ce bouton permet à l'utilisateur de se rendre à la page d'accueil une fois 
            //qu'il aura saisi son identifiant et son mot de passe. 
        }

        private void btnRetour_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
