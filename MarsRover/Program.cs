using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover {
    class Program {

        static void Main(string[] args) {

          //  List<string> rover = new List<string>();


            Console.WriteLine("Please enter the plateau size: X and Y: ");

            //Reading user input for the plateau size
            string inputPlateau = Console.ReadLine();
            //Spliting the input into two parts X and Y
            string[] plateauSize = inputPlateau.Split(' ');


            //Converting string to integers using TryParse() and creating a list to store plateau size
            if (plateauSize.Length == 2)
                {
                try
                {
                    int upperX = Convert.ToInt32((plateauSize[0]));
                    int upperY = Convert.ToInt32((plateauSize[1]));
                    Plateau plateau = new Plateau(upperX, upperY);
                }
                catch
                {
                    Console.WriteLine("Invalid input! Please enter two numbers separated by a space.");
                    return;
                }
            }
               
      
           

            //Displaying a message to the user, asking for the input of the rover's position
            Console.WriteLine("Please enter the position of the rover : X Y D  ");
            //Reading the user's input 
            string inputRoverPosition = Console.ReadLine();
            //Spliting the input into three parts X, Y and D
            string[] roverPosition = inputRoverPosition.Split (' ');

            //Checking if the input is valid
            if (roverPosition.Length == 3)
            {
                try
                {
                    int x = Convert.ToInt32(roverPosition[0]);
                    int y = Convert.ToInt32(roverPosition[1]);
                    string d = roverPosition[2];
                    Rover rover = new Rover(x,y,d);

                }
                catch
                {
                    Console.WriteLine("Invalid input! Please enter X Y D (e.g.: 1 2 N).");
                    return;
                }
            }
            Console.WriteLine("The plateau size is : " + inputPlateau);
            Console.WriteLine("The rover's position is  " + inputRoverPosition);

        }
    }

}


