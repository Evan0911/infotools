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

namespace Projet_infotools_CSharp
{
    /// <summary>
    /// Logique d'interaction pour FenêtreAccueil.xaml
    /// </summary>
    public partial class FenêtreAccueilPro : Window
    {
        public FenêtreAccueilPro()
        {
            InitializeComponent();
        }

       

        private void Menudéco_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow wnd = new MainWindow();
            wnd.ShowDialog();
            //Permet de se déconnecter

        }

        private void MenuRDV_Click(object sender, RoutedEventArgs e)
            //Permet la gestion des rendez-vous avec les clients
        {
            FenetreRDV wnd = new FenetreRDV();
            wnd.ShowDialog();
                
        }

        private void MenuProduit_Click(object sender, RoutedEventArgs e)
        {
            FenetreProduits wnd = new FenetreProduits();
            wnd.ShowDialog();
        }

        private void MenuClient_Click(object sender, RoutedEventArgs e)
        {
            FenetreClient wnd = new FenetreClient();
            wnd.ShowDialog();
        }

        private void MenuCom_Click(object sender, RoutedEventArgs e)
        {
            FenetreCommerciaux wnd = new FenetreCommerciaux();
            wnd.ShowDialog();
        }
    }
}
