using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Story_Cubes
{
    class Cube
    {
        public Cube(object img1, object img2, object img3, object img4, object img5, object img6)
        {

            this.ImagePaths[0] = img1;
            this.ImagePaths[1] = img2;
            this.ImagePaths[2] = img3;
            this.ImagePaths[3] = img4;
            this.ImagePaths[4] = img5;
            this.ImagePaths[5] = img6;


        }


        private object[] ImagePaths = new object[6];

        public object RandomPic()
        {
            return ImagePaths[RandomNumber(0, 6)];
        }

        private int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }








    }
}
