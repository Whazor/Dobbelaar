using System;
using System.Windows;
using Dobbelaar.Domain;
using Dobbelaar.Views;
using Interface;

namespace Dobbelaar.Interface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Text _textWindow;
        private readonly Photo _photoWindow;
        private readonly Dots _dotsWindow;
        private readonly Control _control;

        public MainWindow()
        {
            InitializeComponent();
            _control = new Control();

            Show();

            Left -= 125;
            Top -= 150;
            Closed += OnClosed;

            _textWindow = new Text();
            _textWindow.Show();
            _textWindow.Left -= 125;
            _textWindow.Top += 100;
            _textWindow.Closed += OnClosed;

            _photoWindow = new Photo();
            _photoWindow.Show();
            _photoWindow.Left += 125;
            _photoWindow.Top += 150;
            _photoWindow.Closed += OnClosed;

            _dotsWindow = new Dots();
            _dotsWindow.Show();
            _dotsWindow.Left += 125;
            _dotsWindow.Top -= 100;
            _dotsWindow.Closed += OnClosed;

            Gooi();
        }

        void OnClosed(object sender, EventArgs e)
        {
            _textWindow.Close();
            _photoWindow.Close();
            _dotsWindow.Close();
            Close();
        }

        private void Gooi()
        {
            var waarde = _control.Gooi();
            _textWindow.Waarde = waarde;
            _photoWindow.Waarde = waarde;
            _dotsWindow.Waarde = waarde;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Gooi();
        }
    }
}
