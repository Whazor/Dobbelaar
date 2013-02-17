using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
    /// Interaction logic for Stippen.xaml
    /// </summary>
    public partial class Stippen : Window
    {
        private int _waarde;
        public Stippen()
        {
            InitializeComponent();
        }

        public int Waarde
        {
            set
            {
                _waarde = value;

                var v1 = (new[] { 4, 5, 6 }).Contains(value) ? Visibility.Visible : Visibility.Hidden;
                var v2 = (new[] { 3, 4, 5, 6 }).Contains(value) ? Visibility.Visible : Visibility.Hidden;
                var v3 = (new[] { 1, 3, 5 }).Contains(value) ? Visibility.Visible : Visibility.Hidden;
                var v4 = (new[] { 2, 6 }).Contains(value) ? Visibility.Visible : Visibility.Hidden;

                E1.Visibility = v2; /*****************/ E5.Visibility = v1;
                E2.Visibility = v4; E4.Visibility = v3; E6.Visibility = v4;
                E3.Visibility = v1; /*****************/ E7.Visibility = v2;
            }
        }
    }
}
