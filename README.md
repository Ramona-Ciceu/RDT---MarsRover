The step by step guide of what/how I did this assessment. I did in 3 hours. 

1. Capture and Validate User Input
	•	Read input from the user.
	•	Validated that the input is correctly formatted and within allowed bounds.
	•	Converted the input into usable data structures (e.g., integers for coordinates, switch for directions).


2. Maintain the Plateau (Grid)
	•	Stored the size of the plateau.
	•	Ensured rovers don’t move outside the grid.
	•	Used a Plateau class with properties for upperX and upperY(which represents the upper x,y coordinates.



3. Store and Manage Rover State
	•	Created a Rover class that stores:
	◦	Current Position: x and y coordinates.
	◦	Current Direction: One of N, E, S, W.
	•	The class should have methods for:
	◦	Rotating left (turnLeft).
	◦	Rotating right (turnRight).
	◦	Moving forward (move).


4. Process Movement Instructions
	•	Read the string of movement instructions (turnLeft, turnRight, move).
	•	Applyed each command sequentially.
	•	Used helper methods to handle movement and rotation.

Handling Rotation (turnLeft or turnRight Commands): used switch to track directions
	•	Use a mapping system to track direction changes: 
N -> turnLeft -> W
W -> turnLeft -> S
S -> turnLeft -> E
E -> turnLeft -> N

N -> turnRight -> E
E -> turnRight -> S
S -> turnRight -> W
W -> turnRight -> N

Implement a method that updates the direction based on input.
Handling Movement (M Command)
	•	Move forward based on the current direction: 
N -> (x, y+1)
S -> (x, y-1)
E -> (x+1, y)
W -> (x-1, y)

Before moving, check if the new position is within the plateau’s boundaries.
Example Execution: If a rover starts at (1, 2, N) and receives instructions LMLMLMLMM, process step by step:
	1	L → Turn left → W
	2	M → Move forward → (0,2)
	3	L → Turn left → S
	4	M → Move forward → (0,1)
	5	L → Turn left → E
	6	M → Move forward → (1,1)
	7	L → Turn left → N
	8	M → Move forward → (1,2)
	9	M → Move forward → (1,3)
Final output: 1 3 N

5. Output the Final Position

	•	After processing all movement commands, printed the final position and direction.
	•	Ensured the output format matches the expected format.


6. Handling Multiple Rovers Sequentially

	•	Processed one rover completely before starting the next.
	•	Read the next rover’s position and instructions only after finishing the previous rover.
	•	Storeed rover instances in a list to manage them.

7. Edge Cases to Consider
	1	Invalid Input Handling
	◦	Reject inputs that don’t match expected formats (e.g., missing coordinates, wrong characters in instructions).
	◦	Example of invalid input: 1 2 Z (invalid direction).
	2	Out-of-Bounds Movement
	◦	Prevent moving beyond the plateau’s limits.
	◦	Example: A rover at (0,0,S) cannot move forward.
	3	Overlapping Rovers
	◦	The problem does not specify whether rovers can collide, so decide if you want to implement collision handling.

Summary :
Functionality                               What it Does
Capture Input                    Read the plateau size, rover positions, and commands.
Validate Input                   Ensure data is correctly formatted and within bounds.
Plateau Class                    Store the grid size and check valid movements.
Rover Class                      Store position and direction; process moves and rotations.
Process Commands                 Loop through each instruction and update the rover’s state.
Handle Multiple Rovers           Process one rover at a time before starting the next.
Output Final State               Print the final position and direction of each rover.


