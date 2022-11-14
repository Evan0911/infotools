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
using System.Data;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Projet_infotools_CSharp
{
    /// <summary>
    /// Logique d'interaction pour FenêtreRDV.xaml
    /// </summary>
    public partial class FenetreRDV : Window
    {
        //Ajout d'une liste pour pouvoir stocker les données des clients dans le datagrid.
        ObservableCollection<rdv> rdvs = new ObservableCollection<rdv>();
        ObservableCollection<client> cCli = new ObservableCollection<client>();
        ObservableCollection<commercial> cCom = new ObservableCollection<commercial>();
        public FenetreRDV()
        {
            InitializeComponent();
            bdd.Initialize();
            rdvs = bdd.SelectRDV();
            cCli = bdd.SelectClient();
            cCom = bdd.SelectCommercial();
            DtgRdv.ItemsSource = rdvs;
            CboCli.ItemsSource = cCli;
            CboCom.ItemsSource = cCom;
        }


        private void BtnAjouter_Click(object sender, RoutedEventArgs e)
        {
            if (DtpDateRdv.Text == "")
            {
                // Le regex n'inclue ni les accents ni les tirets de manière naturelle donc il faut les ajouter comme présenté ci-dessus.
                MessageBox.Show("Cette date est incorrecte", "Message", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Error);
                DtpDateRdv.Focus();
                return;
            }
            else
            {

                if (CboCli.SelectedIndex == -1)
                {
                    //Cette condition vérifie que l'utilisateur tape une adresse mail conventionnelle.
                    MessageBox.Show("Vous n'avez pas sélectionner de client.", "Nom d'adresse mail incorrect", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Error);
                    CboCli.Focus(); // Le curseur se met sur CboCli  
                    return;
                }

                else
                {
                    if (CboCom.SelectedIndex == -1)
                    {
                        //Cette condition vérifie que l'utilisateur tape une adresse mail conventionnelle.
                        MessageBox.Show("Vous n'avez pas sélectionner de commercial.", "Nom d'adresse mail incorrect", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Error);
                        CboCom.Focus(); // Le curseur se met sur CboCom  
                        return;
                    }
                    else
                    {
                        rdv unRdv = new rdv(0, Convert.ToDateTime(DtpDateRdv.Text), cCli[CboCli.SelectedIndex], cCom[CboCom.SelectedIndex]);
                        unRdv.id = bdd.InsertRDV(unRdv);
                        rdvs.Add(unRdv);
                        DtgRdv.Items.Refresh();
                        //Le datagrid puise ses données à partir des informations saisies sur les TextBoxs.
                    }
                }
            }
        }

        private void BtnModifier_Click(object sender, RoutedEventArgs e)
        {
            if (DtpDateRdv.Text == "")
            {
                // Le regex n'inclue ni les accents ni les tirets de manière naturelle donc il faut les ajouter comme présenté ci-dessus.
                MessageBox.Show("Cette date est incorrecte", "Message", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Error);
                DtpDateRdv.Focus();
                return;
            }
            else
            {

                if (CboCli.SelectedIndex == -1)
                {
                    //Cette condition vérifie que l'utilisateur tape une adresse mail conventionnelle.
                    MessageBox.Show("Vous n'avez pas sélectionner de client.", "Nom d'adresse mail incorrect", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Error);
                    CboCli.Focus(); // Le curseur se met sur CboCli  
                    return;
                }

                else
                {
                    if (CboCom.SelectedIndex == -1)
                    {
                        //Cette condition vérifie que l'utilisateur tape une adresse mail conventionnelle.
                        MessageBox.Show("Vous n'avez pas sélectionner de commercial.", "Nom d'adresse mail incorrect", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Error);
                        CboCom.Focus(); // Le curseur se met sur CboCom  
                        return;
                    }
                    else
                    {
                        rdvs[DtgRdv.SelectedIndex].dateRDV = Convert.ToDateTime(DtpDateRdv.Text);
                        rdvs[DtgRdv.SelectedIndex].cli = cCli[CboCli.SelectedIndex];
                        rdvs[DtgRdv.SelectedIndex].com = cCom[CboCom.SelectedIndex];
                        bdd.UpdateRDV(rdvs[DtgRdv.SelectedIndex]);
                        DtgRdv.Items.Refresh();
                    }
                }
            }
        }

        private void BtnSupprimer_Click(object sender, RoutedEventArgs e)
        {
            bdd.DeleteRDV(rdvs[DtgRdv.SelectedIndex].id);
            rdvs.Remove((rdv)DtgRdv.SelectedItem);
            DtgRdv.Items.Refresh();
        }

        private void DtgRdv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DtgRdv.SelectedIndex >= 0)
            {
                rdv unRdv = (rdv)DtgRdv.SelectedItem;
                DtpDateRdv.Text = unRdv.dateRDV.ToString();
                SelectionChanged_Client();
                SelectionChanged_Commercial();
            }
        }

        public void SelectionChanged_Client()
        {
            int i = 0;
            foreach(client unCli in cCli)
            {
                if (unCli == rdvs[DtgRdv.SelectedIndex].cli)
                {
                    CboCli.SelectedIndex = i;
                    return;
                }
                i++;
            }
        }
        public void SelectionChanged_Commercial()
        {
            int i = 0;
            foreach (commercial unCom in cCom)
            {
                if (unCom == rdvs[DtgRdv.SelectedIndex].com)
                {
                    CboCom.SelectedIndex = i;
                    return;
                }
                i++;
            }
        }
    }
}