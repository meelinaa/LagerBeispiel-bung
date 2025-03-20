using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace LagerBeispielÜbung
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

        private void AuftragBtn_Click(object sender, RoutedEventArgs e)
        {
            var artikelName = this.ArtikelNameText.Text;
            var artikelAnzahl = this.ArtikelAnzahlText.Text;

            var anrede = this.AnredeCB.Text;
            var vorname = this.VornameText.Text;
            var nachname = this.NachnameText.Text;  
            var name = anrede + " " + vorname + " " + nachname;

            var straße = this.StraßeText.Text;
            var hausnummer = this. HausnummerText.Text;
            var postleitzahl = this.PostleitZahlText.Text;
            var stadt = this.StadtText.Text;
            var anschrift = straße + " " + hausnummer + ". " + postleitzahl + " " + stadt;

            var datum = this.DatumDP.Text;
            var istVersichert = " ";
            if (this.VersichertCB.IsChecked == true)
            {
                istVersichert = "Die Lieferung ist versichert.";
            }
            else
            {
                istVersichert = "Die Lieferung ist nicht versichert.";
            }
            var hinweis = this.HinweiseText.Text;

            

            this.ZusammenfassungArtikelText.Text += " " + artikelName;
            this.ZusammenfassungAnzahlText.Text += " " + artikelAnzahl;
            this.ZusammenfassungLieferungVersichert.Text += " " + istVersichert;
            this.ZusammenfassungLieferdatumText.Text += " " + datum;
            this.ZusammenfassungNameText.Text += " " + name;
            this.ZusammenfassungAdresseText.Text += " " + anschrift;
            this.ZusammenfassungHinweisText.Text += " " + hinweis;
            this.ZusammenfassungPanel.Visibility = Visibility.Visible;
        }

        private void ResetBtn_Click(object sender, RoutedEventArgs e)
        {
            this.ArtikelAnzahlText.Text = this.ArtikelNameText.Text = this.VornameText.Text = this.NachnameText.Text = this.StraßeText.Text = this.HausnummerText.Text = this. PostleitZahlText.Text = this.StadtText.Text = this.HinweiseText.Text = "";
            this.ZusammenfassungArtikelText.Text = this.ZusammenfassungLieferungVersichert.Text = this.ZusammenfassungLieferdatumText.Text = this.ZusammenfassungAnzahlText.Text = this.ZusammenfassungNameText.Text = this.ZusammenfassungAdresseText.Text = this.ZusammenfassungHinweisText.Text = " ";
            this.VersichertCB.IsChecked = false;
           
            this.DatumDP.Text = "";
            this.ZusammenfassungPanel.Visibility = Visibility.Collapsed;
        }
    }
}