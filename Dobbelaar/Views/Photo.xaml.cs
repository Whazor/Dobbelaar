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
    /// Interaction logic for Foto.xaml
    /// </summary>
    public partial class Foto : Window
    {
        private int _waarde;

        public Foto()
        {
            InitializeComponent();
        }

        public int Waarde
        {
            set
            {
                _waarde = value;

                var thisExe = System.Reflection.Assembly.GetExecutingAssembly();
                var path = thisExe.Location;
                var dirInfo = new DirectoryInfo(path);
                if (dirInfo.Parent != null)
                {
                    var folderName= dirInfo.Parent.FullName;
                    var uri = new Uri(folderName + @"\Images\Image" + value + ".jpg");
                    var img = new BitmapImage(uri);
                    Image.Source = img;
                }
            }
        }
    }
}
