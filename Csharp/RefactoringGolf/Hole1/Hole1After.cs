using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringGolf.Hole1
{
    public class Hole1After
    {
        private IList<Instruction> instructions = new List<Instruction>();

        public void parseCommand(String command)
        {

            String[] parts = command.Split(" ");
            String direction = parts[0];
            int amount = int.Parse(parts[1]);

            if (direction.Equals("foward"))
            {
                instructions.Add(new MoveInstruction(amount));
            }
            if (direction.Equals("left"))
            {
                instructions.Add(new TurnInstruction(amount));
            }
            if (direction.Equals("right"))
            {
                instructions.Add(new TurnInstruction(-1 * amount));
            }

        }
    }
}
