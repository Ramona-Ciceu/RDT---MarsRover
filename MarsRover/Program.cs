using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover {
    class Program {

        static void Main(string[] args) {

            //Storing plateau size
            Plateau plateau = null;
            //Plateau setup
            Console.WriteLine("Please enter the plateau size: X and Y: ");

            //Reading user input for the plateau size
            string inputPlateau = Console.ReadLine();
            //Spliting the input into two parts X and Y
            string[] plateauSize = inputPlateau.Split(' ');


            // Ensure valid plateau input
            if (plateauSize.Length == 2 && int.TryParse(plateauSize[0], out int upperX) && int.TryParse(plateauSize[1], out int upperY))
            {
                plateau = new Plateau(upperX, upperY);
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter two numbers separated by a space.");
                return;  
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
                Rover rover;
                try
                {
                    int x = Convert.ToInt32(roverPosition[0]);
                    int y = Convert.ToInt32(roverPosition[1]);
                    string d = roverPosition[2];
                   
                   rover = new Rover(x, y, d);
                }
                catch
                {
                    Console.WriteLine("Invalid input! Please enter X Y D (e.g.: 1 2 N).");
                    return;
                }
                Console.WriteLine("The plateau size is : " + inputPlateau);
                Console.WriteLine("The rover's position is  " + inputRoverPosition);

                // Prompt the user to enter movement commands
                Console.WriteLine("Enter movement commands for the rover (L, R, M): ");
                string commands = Console.ReadLine().ToUpper();

                // Process commands
                foreach (char command in commands)
                {
                    switch (command)
                    {
                        case 'L':
                            rover.leftTurn();
                            break;
                        case 'R':
                            rover.rightTurn();
                            break;
                        case 'M':
                            // Calculate next position without moving
                            int nextX = rover.X;
                            int nextY = rover.Y;

                            switch (rover.direction)
                            {
                                case "N": nextY++; break;
                                case "S": nextY--; break;
                                case "E": nextX++; break;
                                case "W": nextX--; break;
                            }

                            // Move only if within bounds
                            if (plateau.IsWithinBounds(nextX, nextY)) 
                            {
                                rover.move();
                            }
                            else
                            {
                                Console.WriteLine("Move ignored: Rover is at the boundary!");
                            }
                            break;

                        default:
                            Console.WriteLine($"Invalid command '{command}' ignored.");
                            break;
                    }
                }

                // Print final position
                Console.WriteLine($"Final Rover Position: {rover.X} {rover.Y} {rover.direction}");

            }

        }

    }
    

}


