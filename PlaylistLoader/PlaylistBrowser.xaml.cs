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
using PlaylistLoader.Resources;
using mshtml;

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
            this.ExportButton.Click += ExportButton_Click;
        }

        void ExportButton_Click(object sender, RoutedEventArgs e)
        {
            var scriptSource = ProjectResources.Extractor;
            var base64 = Convert.ToBase64String(scriptSource);

            var doc = WebBrowser.Document as IHTMLDocument3;
            var head = (doc.getElementsByTagName("head") as IHTMLElementCollection).item(index: 0);

            
            var scriptTag = (doc as IHTMLDocument2).createElement("script");

            scriptTag.setAttribute("src", "data:text/javascript;base64," + base64);
            head.appendChild(scriptTag as IHTMLDOMNode);

        }
    }
}
