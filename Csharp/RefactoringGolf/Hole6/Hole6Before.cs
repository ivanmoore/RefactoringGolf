using System;
using System.Collections;
using System.Collections.Generic;

namespace RefactoringGolf.Hole6
{
    public class Hole6Before
    {
        public class FibonacciSequence : NumberSequence
        {
            public override int term(int n)
            {
                if (n < 0)
                {
                    throw new ArgumentOutOfRangeException("Sequence undefined for negative index");
                }
                if (n < 2)
                {
                    return 1;
                }
                return term(n - 2) + term(n - 1);
            }
        }

        public class TriangularNumberSequence : NumberSequence
        {
            public override int term(int n)
            {
                if (n < 0)
                {
                    throw new ArgumentOutOfRangeException("Sequence undefined for negative index");
                }
                return (n + 2) * (n + 1) / 2;
            }
        }

        public abstract class NumberSequence
        {
            public abstract int term(int n);

            public IEnumerable<int> GetIterator()
            {
                return new Iterator(term);
            }

            internal class Iterator : IEnumerable<int>
            {
                private int currentIndex = 0;
                private readonly Func<int, int> term;

                public Iterator(Func<int, int> term)
                {
                    this.term = term;
                }

                private bool hasNext()
                {
                    return true;
                }

                public IEnumerator<int> GetEnumerator()
                {
                    while (hasNext())
                    {
                        yield return this.term(currentIndex++);
                    }
                }

                IEnumerator IEnumerable.GetEnumerator()
                {
                    return GetEnumerator();
                }
            }
        }

        public void generate()
        {
            new FibonacciSequence().term(3);
            new TriangularNumberSequence().term(3);
        }
    }
}
