namespace RefactoringGolf
{
    public class TurnInstruction : Instruction
    {
        private readonly int amount;

        public TurnInstruction(int amount)
        {
            this.amount = amount;
        }
    }
}
