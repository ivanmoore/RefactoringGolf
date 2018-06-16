using System;
using System.Collections;
using System.Collections.Generic;

namespace RefactoringGolf.Hole6
{
    public class Hole6After
    {
        public class NumberSequence
        {
            private readonly TermGenerator termGenerator;

            public NumberSequence(TermGenerator generator)
            {
                this.termGenerator = generator;
            }

            public IEnumerable<int> GetIterator()
            {
                return new Iterator(termGenerator);
            }

            internal class Iterator : IEnumerable<int>
            {
                private int currentIndex = 0;
                private readonly TermGenerator termGenerator;

                public Iterator(TermGenerator term)
                {
                    this.termGenerator = term;
                }

                private bool hasNext()
                {
                    return true;
                }

                public IEnumerator<int> GetEnumerator()
                {
                    while (hasNext())
                    {
                        yield return termGenerator.term(currentIndex++);
                    }
                }

                IEnumerator IEnumerable.GetEnumerator()
                {
                    return GetEnumerator();
                }
            }
            public int term(int n)
            {
                return termGenerator.term(n);
            }
        }

        public interface TermGenerator
        {
            int term(int n);
        }

        class TriangularTerm : TermGenerator
        {
            public int term(int n)
            {
                if (n < 0)
                {
                    throw new ArgumentOutOfRangeException("Sequence undefined for negative index");
                }
                return (n + 2) * (n + 1) / 2;
            }
        }

        class FibonacciTerm : TermGenerator
        {
            public int term(int n)
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

        public void generate()
        {
            new NumberSequence(new FibonacciTerm()).term(3);
            new NumberSequence(new TriangularTerm()).term(3);
        }
    }
}
