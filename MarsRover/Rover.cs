using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    internal class Rover
    {

        //Properties 
        //Storing the current position and direction of the rover
        public int X { get; set; }
        public int Y { get; set; }
        public char direction { get; set; }

        //Constructor
        //Initilising rover's starting position and direction
        public Rover(int x, int y, char direction)
        {
            this.X = x;
            this.Y = y;
            this.direction = direction;
        }

        /// <summary>
        /// This method rotates the rover 90° counterclockwise (left turn).
        /// </summary>
        public void leftTurn()
        {

            switch (direction)
            {
                case 'N':
                    direction = 'W';
                    break;
                case 'S':
                    direction = 'E';
                    break;
                case 'W':
                    direction = 'S';
                    break;
                case 'E':
                    direction = 'N';
                    break;
              
                default: direction = 'N';
                    break;      
            }     
        }
        /// <summary>
        /// This method rotates the rover 90° clockwise (left right)
        /// </summary>
        public void rightTurn() {
            switch (direction)
            {
                case 'N':
                    direction = 'E';
                    break;
                case 'S':
                    direction = 'W';
                    break;
                case 'W':
                direction = 'N';
                    break;
                case 'E':
                    direction = 'N';
                    break;
                default: direction = 'N';
                    break;
            }

        }
        /// <summary>
        /// This method is moving the rover forward by one grid from its current facing direction
        /// </summary>
    public void move() {
        switch (direction)
            {
                case 'N': Y += 1;
                    break;
                case 'S': Y -= 1;
                    break;
                case 'W': X -= 1;
                    break;
                case 'E': X += 1;
                    break;
                default: direction = 'N';
                    break;
            }
        }


    }
}
