namespace RefactoringGolf
{
    public class MoveInstruction : Instruction
    {
        private readonly int amount;

        public MoveInstruction(int amount)
        {
            this.amount = amount;
        }
    }
}
