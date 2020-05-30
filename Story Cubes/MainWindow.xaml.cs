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

namespace Story_Cubes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Cube[] Cubes = new Cube[9];

        
    string[,] Cube2 = new string[,]{
  { Properties.Resource.Cs,"" },
  { "","" },
  { "","" },
  { "",""  },
  { "","" }
};


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Box1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private Cube CreateCubes(int number, string img1, string img2, string img3, string img4, string img5, string img6, string img7, string img8, string img9)
        {
            Cubes[number] = new Cube(img1, img2, img3, img4, img5, img6);
        }


        private void Window_Loaded(object sender, RoutedEventArgs e) ½1r2t3e5
        {
            
        }
}
}
