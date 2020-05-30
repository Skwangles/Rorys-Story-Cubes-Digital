using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
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
        object[] DisplayImg = new object[9];
        public MainWindow()
        {
            InitializeComponent();

        }
        ComboBox[] ComboBoxes;
        Image[] ImageBox;



        private void Box1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private bool IsFull(int index)
        {
            return !(ComboBoxes[index].SelectedItem == null);

        }
        private bool IsCorrectSelections()
        {
            bool temp = false;
            for (int AmountComboBox = ComboBoxes.Length-1; AmountComboBox > 0; AmountComboBox -= 1)
            {
                if (AmountComboBox == ComboBoxes.Length)
                {
                    temp = IsFull(AmountComboBox);
                }
                else
                {
                    if (!IsFull(AmountComboBox) && temp)
                    {
                        return false;
                    }
                    temp = IsFull(AmountComboBox);
                }

            }

            return true;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (IsCorrectSelections())
            {

                int AmountOfCubesInUse = -1;
                foreach (ComboBox combo in ComboBoxes)
                {
                    if (combo.SelectedItem != null)
                    {
                        AmountOfCubesInUse++;
                    }
                }

                for (int i = 0; i <= AmountOfCubesInUse; i++)
                {
                    Console.WriteLine(ComboBoxes[i].SelectedItem);
                   DisplayImg[i] = Cubes[int.Parse(ComboBoxes[i].SelectedItem.ToString())].RandomPic();
                }
                int counter = 0;
                foreach(object obj in DisplayImg)
                {
                    ImageBox[counter] = (Image)obj;
                }




            }
            else
            {
                MessageBox.Show("Make sure slots are filled left to right. (Slot 1 can't be empty, while Slot 2 has a number)");
            }
        }

        
        private void CreateCubes(string prefix, int number)
        {

            object[] tempImage = new object[6];
            ResourceSet resourceSet = Properties.Resources.ResourceManager.GetResourceSet(CultureInfo.CurrentUICulture, true, true);
            int counter = 0;
            foreach (DictionaryEntry entry in resourceSet)
            {

                string resourceKey = entry.Key.ToString();
                var resource = entry.Value;
                if (resourceKey.Contains(prefix))//Uses prefix to find which photo to put for this cube
                {
                    tempImage[counter] = entry.Value;
                    counter++;
                }

            }
            Cubes[number] = new Cube(tempImage[0], tempImage[1], tempImage[2], tempImage[3], tempImage[4], tempImage[5]);
            //Cubes[number] = new Cube();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
            ComboBoxes = new ComboBox[] { this.Box1, this.Box2, this.Box3, this.Box4, this.Box5, this.Box6, this.Box7, this.Box8, this.Box9 };
            ImageBox = new Image[] { this.pb1, this.pb2, this.pb3, this.pb4, this.pb5, this.pb6, this.pb7, this.pb8, this.pb9 };
            CreateCubes("C1", 0);
            CreateCubes("C2", 1);
            CreateCubes("C3", 2);
            CreateCubes("C4", 3);
            CreateCubes("C5", 4);
            CreateCubes("C6", 5);
            CreateCubes("C7", 6);
            CreateCubes("C8", 7);
            CreateCubes("C9", 8);
        }
        #region Boxs
        private void Box3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Box2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Box4_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Box5_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Box6_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Box7_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Box8_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Box9_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        #endregion
    }
}
