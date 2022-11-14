
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
    /// Logique d'interaction pour FenêtreProduits.xaml
    /// </summary>
    public partial class FenetreProduits : Window
    {
        //Ajout d'une liste pour pouvoir stocker les données des produits dans le datagrid.
        ObservableCollection<Produit> produits = new ObservableCollection<Produit>();

        public FenetreProduits()
        {
            InitializeComponent();
            bdd.Initialize();
            produits = bdd.SelectProduit();
            DtgProduit.ItemsSource = produits;
        }

        private void DtgProduit_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DtgProduit.SelectedIndex != -1)
            {
                // On récupère l'objet selectionné dans le datagrid et on le "cast" pour lui donner un type précis (Contrat, Magazine, Pigiste)
                Produit produitSelected = (Produit)DtgProduit.SelectedItem;

                // On met des valeurs dans les composants de l'interface via les valeurs de l'objet contratSelected
                TxtNomProd.Text = Convert.ToString(produitSelected.NomProd);
                string Prix = Convert.ToString(produitSelected.Prix);
                Prix = Prix.Replace(',', '.');
                TxtPrixProd.Text = Prix;
            }
        }

        private void BtnAjouterProd_Click(object sender, RoutedEventArgs e)
        {
            if (!Regex.Match(TxtPrixProd.Text, "\\d+?[\\.\\.]\\d+?").Success)
            {
                // Regex pour nombre décimal
                MessageBox.Show("C'EST PAS UN NOMBRE DECIMAL AAAAAAAAAAAAA MET DES POINTS TAAAIIIINNNNN", "Message", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Error);
                TxtPrixProd.Focus();
            }
            else
            {
                string Prix = TxtPrixProd.Text;
                Prix = Prix.Replace('.', ',');
                Produit unProd = new Produit(0, TxtNomProd.Text, Convert.ToDecimal(Prix));
                unProd.NumProd = bdd.InsertProduit(unProd);
                produits.Add(unProd);
                //Le datagrid puise ses données à partir des informations saisies sur les TextBoxs.
            }
            TxtNomProd.Text = "";
            TxtPrixProd.Text = "";
        }

        private void BtnModifierProd_Click(object sender, RoutedEventArgs e)
        {
            produits[DtgProduit.SelectedIndex].NomProd = TxtNomProd.Text;
            produits[DtgProduit.SelectedIndex].Prix = Convert.ToDecimal(TxtPrixProd.Text.Replace('.', ','));
            bdd.UpdateProduit(produits[DtgProduit.SelectedIndex]);
            TxtNomProd.Text = "";
            TxtPrixProd.Text = "";
            DtgProduit.ItemsSource = produits;
            DtgProduit.Items.Refresh();
        }

        private void BtnSupprimerProd_Click(object sender, RoutedEventArgs e)
        {
            bdd.DeleteProduit(produits[DtgProduit.SelectedIndex].NumProd);
            produits.RemoveAt(DtgProduit.SelectedIndex);
            TxtNomProd.Text = "";
            TxtPrixProd.Text = "";
        }
    }

}