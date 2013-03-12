using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for Photo.xaml
    /// </summary>
    public partial class Photo : Window
    {
        private int _waarde;

        public Photo()
        {
            InitializeComponent();
        }

        public int Waarde
        {
            set
            {
                _waarde = value;

                Image.Source = (ImageSource) FindResource("Image"+value);
            }
        }
    }
}
