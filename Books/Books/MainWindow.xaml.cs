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

namespace Books
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AuthorSearch_OnClick(object sender, RoutedEventArgs e)
        {
            //Durchsuche Datenbank nach Büchern des Authors, Input falls kommata vorkommt nach diesem auf vorname & nachname auftrennen, andernfalls nur nachname!
        }

        private void TitelSearch_OnClick(object sender, RoutedEventArgs e)
        {
            //Durchsuche Datenbank nach Büchern "LIKE" %TITEL%
        }

        private void VerlagSearch_OnClick(object sender, RoutedEventArgs e)
        {
            //Durchsuche Datenbank nach Büchern "LIKE" %VERLAG%
        }

        private void ISBNSearch_OnClick(object sender, RoutedEventArgs e)
        {
            //Durchsuche Datenbank nach Büchern Input=ISBN!
        }

        private void AllSearch_OnClick(object sender, RoutedEventArgs e)
        {
            //Durchsuche Datenbank nach allen oben eingetragenen Werten, falls abweichend vom Standardtext oder ungleich leer!
        }

        private void AuthorTextbox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= AuthorTextbox_GotFocus;
        }

        private void TitelTextbox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= TitelTextbox_GotFocus;
        }

        private void ISBNTextbox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= ISBNTextbox_GotFocus;
        }

        private void VerlagTextbox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= VerlagTextbox_GotFocus;
        }

        private void NavigateToSearch_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void NavigateToAdd_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void NavigateToAdmin_OnClick(object sender, RoutedEventArgs e)
        {

        }
    }
}