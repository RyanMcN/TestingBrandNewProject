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

using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace TestingBrandNewProject
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

        private void buttonOne_Click(object sender, RoutedEventArgs e)
        {
            int A = Int32.Parse(Tboxx1.Text);
            int B = Int32.Parse(Tboxx1.Text);
            TestCase justATest = new TestCase();
            //MessageBox.Show("HelloWorld!!!");
        }
    }
}
