using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class Plateau
    {
        //Properties for top-right boundaries
        //Storing the upper (x,y) coordinates
        public int upperX { get; set; }
        public int upperY { get; set; }

        //Constructor
        //Initialiasing the upper (x,y) coordinates
        public Plateau(int upperX, int upperY)
        {
            this.upperX = upperX;
            this.upperY = upperY;
        }


        /// <summary>
        /// This method is to check if a given (x,y) position is within bounds
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public bool IsWithinBounds(int x, int y)
        {
            // Check if position is within plateau boundaries
            return x >= 0 &&
                   y >= 0 &&
                   x <= upperX &&
                   y <= upperY;
        }

    }
}
