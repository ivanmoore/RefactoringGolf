using System;
using System.Collections.Generic;

namespace RefactoringGolf.Hole1
{
    public class Hole1Before
    {
        private IList<Instruction> instructions = new List<Instruction>();

        public void parseCommand(String command)
        {

            String[] parts = command.Split(" ");
            String direction = parts[0];
            String amount = parts[1];

            if (direction.Equals("foward"))
            {
                instructions.Add(new MoveInstruction(int.Parse(amount)));
            }
            if (direction.Equals("left"))
            {
                instructions.Add(new TurnInstruction(int.Parse(amount)));
            }
            if (direction.Equals("right"))
            {
                instructions.Add(new TurnInstruction(-1 * int.Parse(amount)));
            }

        }
    }
}
