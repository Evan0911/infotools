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
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Projet_infotools_CSharp
{
    /// <summary>
    /// Logique d'interaction pour FenetreClient.xaml
    /// </summary>
    public partial class FenetreClient : Window
    {
        //Ajout d'une liste pour pouvoir stocker les données des clients dans le datagrid.
        ObservableCollection<client> client = new ObservableCollection<client>();
        public FenetreClient()
        {
            InitializeComponent();
            bdd.Initialize();
            client = bdd.SelectClient();
            DtgClient.ItemsSource = client;
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
                    if (!Regex.Match(TxtTel.Text, @"^0[0-9]{9}$").Success)
                    //Ici, lorsque l'utilisateur ne tape pas un numéro de téléphone commençant par '06' ou '07' et ne composant pas 8 chiffres en plus des chiffres du début, alors un message apparaît pour indiquer une erreur.
                    {
                        MessageBox.Show("Numéro de téléphone incorrect", "Message", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Error);
                        TxtTel.Focus(); //Le curseur se met sur TxtNumTel
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

                            client unCli = new client(0, TxtPrenom.Text, TxtNom.Text, TxtTel.Text, TxtMail.Text, TxtAdresse.Text, TxtCP.Text, TxtVille.Text);
                            unCli.id = bdd.InsertClient(unCli);
                            client.Add(unCli);
                            DtgClient.Items.Refresh();
                            //Le datagrid puise ses données à partir des informations saisies sur les TextBoxs.
                        }
                    }
                }
            }
        }

        private void BtnModifier_Click(object sender, RoutedEventArgs e)
        {

            client[DtgClient.SelectedIndex].prenom = TxtPrenom.Text;
            client[DtgClient.SelectedIndex].nom = TxtNom.Text;
            client[DtgClient.SelectedIndex].telephone = TxtTel.Text;
            client[DtgClient.SelectedIndex].adresse = TxtAdresse.Text;
            client[DtgClient.SelectedIndex].cp = TxtCP.Text;
            client[DtgClient.SelectedIndex].ville = TxtVille.Text;
            client[DtgClient.SelectedIndex].email = TxtMail.Text;
            bdd.UpdateClient(client[DtgClient.SelectedIndex]);
            DtgClient.Items.Refresh();
        }

        private void BtnSupprimer_Click(object sender, RoutedEventArgs e)
        {
            bdd.DeleteClient(client[DtgClient.SelectedIndex].id);
            client.Remove((client)DtgClient.SelectedItem);
            DtgClient.Items.Refresh();
        }

        private void DTG_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DtgClient.SelectedIndex >= 0)
            {
                client unCli = (client)DtgClient.SelectedItem;
                TxtPrenom.Text = unCli.prenom;
                TxtNom.Text = unCli.nom;
                TxtTel.Text = unCli.telephone;
                TxtMail.Text = unCli.email;
                TxtAdresse.Text = unCli.adresse;
                TxtCP.Text = unCli.cp;
                TxtVille.Text = unCli.ville;
            }
        }
    }
}
