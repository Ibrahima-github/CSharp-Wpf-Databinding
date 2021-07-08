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
using WpfAppDataBindingObjet.Model;

namespace WpfAppDataBindingObjet
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Adherent adherent = new Adherent();
        public MainWindow()
        {
            InitializeComponent();

            //DataContext initialisation, Model: adherent
            this.DataContext = adherent;

            //Textboxes initialization
            adherent.Numero = 100; adherent.Nom = "Nom de l'adh 100";
            
        }

        //Click event method
        private void GenererAdherent_Click(object sender, RoutedEventArgs e)
        {
            Random r = new Random();
            int i = r.Next(1, 1001);
            adherent.Numero = i;
            adherent.Nom = $"Nom de l'adhérent {i} ";

        }
    }
}
