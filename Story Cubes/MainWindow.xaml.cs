using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
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
        Bitmap[] DisplayImg = new Bitmap[9];
        System.Windows.Controls.Image[] ImageBox;
        public MainWindow()
        {
            InitializeComponent();

        }
        ComboBox[] ComboBoxes;




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
            for (int AmountComboBox = ComboBoxes.Length - 1; AmountComboBox > 0; AmountComboBox -= 1)
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


        /// <summary>
        /// Takes a bitmap and converts it to an image that can be handled by WPF ImageBrush
        /// </summary>
        /// <param name="src">A bitmap image</param>
        /// <returns>The image as a BitmapImage for WPF</returns>
        public BitmapImage Convert(Bitmap src)
        {
            MemoryStream ms = new MemoryStream();
            ((System.Drawing.Bitmap)src).Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            ms.Seek(0, SeekOrigin.Begin);
            image.StreamSource = ms;
            image.EndInit();
            return image;
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
                foreach (Bitmap obj in DisplayImg)
                {
                    if (obj != null)
                    {
                        ImageBox[counter].Source = Convert(obj);
                        counter++;
                    }
                }




            }
            else
            {
                MessageBox.Show("Make sure slots are filled left to right. (Slot 1 can't be empty, while Slot 2 has a number)");
            }
        }


        private void CreateCubes()
        {

            Cubes[0] = new Cube(Properties.Resources.C1S1, Properties.Resources.C1S2, Properties.Resources.C1S3, Properties.Resources.C1S4, Properties.Resources.C1S5, Properties.Resources.C1S6);
            Cubes[1] = new Cube(Properties.Resources.C2S1, Properties.Resources.C2S2, Properties.Resources.C2S3, Properties.Resources.C2S4, Properties.Resources.C2S5, Properties.Resources.C2S6);
            Cubes[2] = new Cube(Properties.Resources.C3S1, Properties.Resources.C3S2, Properties.Resources.C3S3, Properties.Resources.C3S4, Properties.Resources.C3S5, Properties.Resources.C3S6);
            Cubes[3] = new Cube(Properties.Resources.C4S1, Properties.Resources.C4S2, Properties.Resources.C4S3, Properties.Resources.C4S4, Properties.Resources.C4S5, Properties.Resources.C4S6);
            Cubes[4] = new Cube(Properties.Resources.C5S1, Properties.Resources.C5S2, Properties.Resources.C5S3, Properties.Resources.C5S4, Properties.Resources.C5S5, Properties.Resources.C5S6);
            Cubes[5] = new Cube(Properties.Resources.C6S1, Properties.Resources.C6S2, Properties.Resources.C6S3, Properties.Resources.C6S4, Properties.Resources.C6S5, Properties.Resources.C6S6);
            Cubes[6] = new Cube(Properties.Resources.C7S1, Properties.Resources.C7S2, Properties.Resources.C7S3, Properties.Resources.C7S4, Properties.Resources.C7S5, Properties.Resources.C7S6);
            Cubes[7] = new Cube(Properties.Resources.C8S1, Properties.Resources.C8S2, Properties.Resources.C8S3, Properties.Resources.C8S4, Properties.Resources.C8S5, Properties.Resources.C8S6);
            Cubes[8] = new Cube(Properties.Resources.C9S1, Properties.Resources.C9S2, Properties.Resources.C9S3, Properties.Resources.C9S4, Properties.Resources.C9S5, Properties.Resources.C9S6);
            //Cubes[number] = new Cube();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            ComboBoxes = new ComboBox[] { this.Box1, this.Box2, this.Box3, this.Box4, this.Box5, this.Box6, this.Box7, this.Box8, this.Box9 };
            ImageBox = new System.Windows.Controls.Image[] { this.pb1, this.pb2, this.pb3, this.pb4, this.pb5, this.pb6, this.pb7, this.pb8, this.pb9 };
            CreateCubes();

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
