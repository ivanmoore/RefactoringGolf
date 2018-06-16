using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringGolf.Hole4
{
   public class Hole4After
    {
        public void printLabelAndReceipt()
        {
            new Label().Print();
            new Receipt().Print();
        }

        class Receipt
        {
            public void Print()
            {
                Console.WriteLine("1 Book, 5.99");
                Console.WriteLine("1 CD, 9.99");
                Console.WriteLine("Total: 15.98 ");
            }
        }

        class Label
        {
            public void Print()
            {
                Console.WriteLine("Mr J Smith");
                Console.WriteLine("34 High Street");
                Console.WriteLine("Oxford");
                Console.WriteLine("OX1 1TT");
            }
        }
    }
}
