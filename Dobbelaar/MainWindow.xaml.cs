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
using Dobbelaar.Domain;
using Dobbelaar.Views;

namespace Dobbelaar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Cijfer _cijferWindow;
        private readonly Foto _fotoWindow;
        private readonly Stippen _stippenWindow;

        private int _waarde;
        private readonly Dobbelsteen _dobbelsteen;

        public MainWindow()
        {
            _dobbelsteen = new Dobbelsteen();

            InitializeComponent();
            Show();
            Left -= 150;
            Top -= 150;
            Closed += OnClosed;
            LocationChanged += OnLocationChanged;

            _cijferWindow = new Cijfer();
            _cijferWindow.Show();
            _cijferWindow.Left -= 125;
            _cijferWindow.Top += 100;
            _cijferWindow.Closed += OnClosed;

            _fotoWindow = new Foto();
            _fotoWindow.Show();
            _fotoWindow.Left += 125;
            _fotoWindow.Top += 150;
            _fotoWindow.Closed += OnClosed;

            _stippenWindow = new Stippen();
            _stippenWindow.Show();
            _stippenWindow.Left += 125;
            _stippenWindow.Top -= 100;
            _stippenWindow.Closed += OnClosed;

            Gooi();
        }

        void OnLocationChanged(object sender, EventArgs e)
        {

        }

        void OnClosed(object sender, EventArgs e)
        {
            _cijferWindow.Close();
            _fotoWindow.Close();
            _stippenWindow.Close();
            Close();
        }

        private void Gooi()
        {
            _dobbelsteen.Gooi();
            _cijferWindow.Waarde = _dobbelsteen.Waarde;
            _fotoWindow.Waarde = _dobbelsteen.Waarde;
            _stippenWindow.Waarde = _dobbelsteen.Waarde;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Gooi();
        }
    }
}
