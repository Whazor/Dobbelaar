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

namespace Dobbelaar.Views
{
    /// <summary>
    /// Interaction logic for Cijfer.xaml
    /// </summary>
    public partial class Cijfer : Window
    {
        private int _waarde;

        public Cijfer()
        {
            InitializeComponent();
        }

        public int Waarde
        {
            set
            {
                _waarde = value;
                Label.Content = value;
            }
        }
    }
}
