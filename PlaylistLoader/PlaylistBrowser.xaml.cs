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

namespace PlaylistLoader
{
    /// <summary>
    /// Interaction logic for PlaylistBrowser.xaml
    /// </summary>
    public partial class PlaylistBrowser : Window
    {
        public PlaylistBrowser()
        {
            InitializeComponent();
            this.WebBrowser.Navigate("https://music.google.com");
        }
    }
}
