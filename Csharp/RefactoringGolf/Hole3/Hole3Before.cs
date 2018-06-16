using System;
using System.Collections.Generic;

namespace RefactoringGolf.Hole3
{
    public class Hole3Before
    {
        private IList<Instruction> instructions = new List<Instruction>();

        public void parseCommand(String command)
        {
            String[] parts = command.Split(" ");
            String direction = parts[0];
            int amount = int.Parse(parts[1]);

            Instruction instruction = null;
            if (direction.Equals("foward"))
            {
                instruction = new MoveInstruction(amount);
            }
            if (direction.Equals("left"))
            {
                instruction = new TurnInstruction(amount);
            }
            if (direction.Equals("right"))
            {
                instruction = new TurnInstruction(-1 * amount);
            }

            instructions.Add(instruction);
        }
    }
}
