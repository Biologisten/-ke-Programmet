using System.Windows;

namespace Åke_programmet.Library
{
    /// <summary>
    /// Interaction logic for test.xaml
    /// </summary>
    public partial class test : Window
    {
        public test()
        {
            InitializeComponent();
        }

        public void get_str(string str)
        {
            debug.Text += str;
            debug.Text += "\n";
        }
    }
}