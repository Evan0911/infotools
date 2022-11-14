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
using System.Windows.Forms;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Projet_infotools_CSharp
{
    /// <summary>
    /// Logique d'interaction pour FenetreCommerciaux.xaml
    /// </summary>
    public partial class FenetreCommerciaux : Window
    {
        //Ajout d'une liste pour pouvoir stocker les données des clients dans le datagrid.
        ObservableCollection<commercial> commerciaux = new ObservableCollection<commercial>();
        public FenetreCommerciaux()
        {
            InitializeComponent();
            bdd.Initialize();
            commerciaux = bdd.SelectCommercial();
            DtgCom.ItemsSource = commerciaux;
        }



        private void BtnAjouter_Click(object sender, RoutedEventArgs e)
        {




            if (!Regex.Match(TxtPrenom.Text, "^[A-Z][a-zA-Z]*$|^[A-Z][a-zA-Zéèàêùçâîôû][-a-zA-Zéèàêùçâîôû]*$").Success)
            {
                // Le regex n'inclue ni les accents ni les tirets de manière naturelle donc il faut les ajouter comme présenté ci-dessus.
                MessageBox.Show("Ce prénom est incorrect", "Message", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Error);
                TxtPrenom.Focus();
                return;
            }
            else
            {
                if (!Regex.Match(TxtNom.Text, "^[A-Z]*$|^[A-Z][-A-Z]*$").Success)
                {
                    // Le regex n'inclue ni les accents ni les tirets de manière naturelle donc il faut les ajouter comme présenté ci-dessus.  
                    MessageBox.Show("Ce nom est incorrect", "Message", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Error);
                    TxtNom.Focus();
                    return;
                }
                else
                {
                    if (!Regex.Match(TxtMail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,4})+)$").Success)
                    {
                        //Cette condition vérifie que l'utilisateur tape une adresse mail conventionnelle.
                        MessageBox.Show("Vous n'avez pas inséré une adresse mail conventionnellle.", "Nom d'adresse mail incorrect", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Error);
                        TxtMail.Focus(); // Le curseur se met sur TxtMail  
                        return;
                    }
                    else
                    {
                        if (TxtMdp.Text == "")
                        {
                            MessageBox.Show("Vous n'avez pas entrer de mot de passe.", "Mot de passe incorrecte", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Error);
                            TxtMdp.Focus(); // Le curseur se met sur TxtMail  
                            return;
                        }
                        else
                        {
                            commercial unCom = new commercial(0, TxtPrenom.Text, TxtNom.Text, TxtAdresse.Text, TxtCP.Text, TxtVille.Text, TxtMail.Text);
                            unCom.id = bdd.InsertCommercial(unCom, TxtMdp.Text);
                            commerciaux.Add(unCom);
                            DtgCom.Items.Refresh();
                            //Le datagrid puise ses données à partir des informations saisies sur les TextBoxs.
                        }
                    }
                }
            }
        }

        private void BtnModifier_Click(object sender, RoutedEventArgs e)
        {

            commerciaux[DtgCom.SelectedIndex].prenom = TxtPrenom.Text;
            commerciaux[DtgCom.SelectedIndex].nom = TxtNom.Text;
            commerciaux[DtgCom.SelectedIndex].adresse = TxtAdresse.Text;
            commerciaux[DtgCom.SelectedIndex].cp = TxtCP.Text;
            commerciaux[DtgCom.SelectedIndex].ville = TxtVille.Text;
            commerciaux[DtgCom.SelectedIndex].email = TxtMail.Text;
            bdd.UpdateCommercial(commerciaux[DtgCom.SelectedIndex]);
            DtgCom.Items.Refresh();
        }

        private void BtnSupprimer_Click(object sender, RoutedEventArgs e)
        {
            bdd.DeleteCom(commerciaux[DtgCom.SelectedIndex].id);
            commerciaux.Remove((commercial)DtgCom.SelectedItem);
            DtgCom.Items.Refresh();
        }

        private void DTG_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DtgCom.SelectedIndex >= 0)
            {
                commercial unCom = (commercial)DtgCom.SelectedItem;
                TxtPrenom.Text = unCom.prenom;
                TxtNom.Text = unCom.nom;
                TxtMail.Text = unCom.email;
                TxtAdresse.Text = unCom.adresse;
                TxtCP.Text = unCom.cp;
                TxtVille.Text = unCom.ville;
            }
        }
    }
}
