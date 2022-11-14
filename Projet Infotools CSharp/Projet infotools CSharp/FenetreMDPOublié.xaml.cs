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
    /// Logique d'interaction pour FenêtreMDPOublié.xaml
    /// </summary>
    public partial class FenêtreMDPOublié : Window
    {
        public FenêtreMDPOublié()
        {
            InitializeComponent();
        }


        private void BtnConfirmer_Click(object sender, RoutedEventArgs e)
        {

            if (TxtIdentifiant.Text == "")
            {
                MessageBox.Show("Veuillez mettre votre adresse mail", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                TxtIdentifiant.Focus(); // Le curseur se met sur TxtIdentifiant  
                return;
            }
            else
            {
                if (!Regex.Match(TxtIdentifiant.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,4})+)$").Success)
                {
                    //Cette condition vérifie que l'utilisateur tape une adresse mail conventionnelle.
                    MessageBox.Show("Votre identifiant est votre adresse mail.", "Nom d'identifiant incorrect", MessageBoxButton.OK, MessageBoxImage.Error);
                    TxtIdentifiant.Focus(); // Le curseur se met sur TxtIdentifiant  
                    return;
                }
            }



            if (PSW1.Password == "")
            {
                //Un message va apparaître pour dire à l'utilisateur de mettre quelque chose dans 
                //le textbox et le mdpBox

                MessageBox.Show("Veuillez écrire votre mot de passe", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                PSW1.Focus(); // Le curseur se met sur TxtNom  
                return;
            }
            else
            {
                if (PSW2.Password == "")
                {
                    //Un message va apparaître pour dire à l'utilisateur de mettre quelque chose dans 
                    //le textbox et le mdpBox

                    MessageBox.Show("Veuillez réecrire votre mot de passe", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                    PSW2.Focus(); // Le curseur se met sur TxtNom  
                    return;
                }
                else
                {
                    MessageBox.Show("Mot de passe confirmé");
                    this.Close();
                }
            }
            
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void TxtIdentifiant_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
