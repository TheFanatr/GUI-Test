using MaterialDesignThemes.Wpf;
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

namespace MaterialDesignUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static int TabCount=0;
        public MainWindow()
        {
            InitializeComponent();
            TabablzControl.MouseDoubleClick += (s, e) =>
            {
                TabItem TestTabItem = new TabItem { Header = "Tab " + TabCount + 1 };
                TabablzControl.Items.Add(TestTabItem);
                TestTabItem.MouseDown += (s1, e1) => MessageBox.Show("Tab Item \"" + TestTabItem.Header.ToString() + "\" has been clicked.");
            };
        }
    }
}
