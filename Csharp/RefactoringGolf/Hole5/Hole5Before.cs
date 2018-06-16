using System;
using System.Collections.Generic;

namespace RefactoringGolf.Hole5
{
    public class Hole5Before
    {
        class FibonacciSequence
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

            //public IEnumerator<int> iterator()
            //{
            //    //        return new IEnumerable<int>()
            //    //        {

            //    //        private int currentIndex = 0;

            //    //    public boolean hasNext()
            //    //    {
            //    //        return true;
            //    //    }

            //    //    public Integer next()
            //    //    {
            //    //        int result = term(currentIndex);
            //    //        currentIndex++;
            //    //        return result;
            //    //    }

            //    //    public void remove()
            //    //    {
            //    //        throw new InvalidOperationException();
            //    //    }
            //    //};
            //}
        }

        class TriangularNumberSequence
        {

            public int term(int n)
            {
                if (n < 0)
                {
                    throw new ArgumentOutOfRangeException("Sequence undefined for negative index");
                }
                return (n + 2) * (n + 1) / 2;
            }

            //    public Iterator<Integer> iterator()
            //    {
            //        return new Iterator<Integer>()
            //        {

            //                private int currentIndex = 0;

            //    public boolean hasNext()
            //    {
            //        return true;
            //    }

            //    public Integer next()
            //    {
            //        int result = term(currentIndex);
            //        currentIndex++;
            //        return result;
            //    }

            //    public void remove()
            //    {
            //        throw new UnsupportedOperationException();
            //    }
            //};
            //}
        }

        public void generate()
        {
            new FibonacciSequence().term(3);
            new TriangularNumberSequence().term(3);
        }

    }
}
