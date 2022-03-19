using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Story_Cubes
{
    class Cube
    {
        Random random = new Random();
        public Cube(Bitmap img1, Bitmap img2, Bitmap img3, Bitmap img4, Bitmap img5, Bitmap img6)
        {
            this.ImagePaths[0] = img1;
            this.ImagePaths[1] = img2;
            this.ImagePaths[2] = img3;
            this.ImagePaths[3] = img4;
            this.ImagePaths[4] = img5;
            this.ImagePaths[5] = img6;
        }


        private Bitmap[] ImagePaths = new Bitmap[6];

        public Bitmap RandomPic()
        {
            return ImagePaths[random.Next(0, 6)];
        }
    }
}
