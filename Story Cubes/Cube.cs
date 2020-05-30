using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Story_Cubes
{
    class Cube
    {
        public Cube(string img1, string img2, string img3, string img4, string img5, string img6)
        {
            
            this.ImagePaths[0] = img1;
            this.ImagePaths[1] = img2;
            this.ImagePaths[2] = img3;
            this.ImagePaths[3] = img4;
            this.ImagePaths[4] = img5;
            this.ImagePaths[5] = img6;
           

        }
        
        
        private string[] ImagePaths = new string[6];

        public string RandomPic()
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
