package com.develogical.golf.hole6;

import java.util.Iterator;

public class Hole6After {

    public class NumberSequence {

        private final TermGenerator termGenerator;

        public NumberSequence(TermGenerator generator) {
            this.termGenerator = generator;
        }

        public Iterator<Integer> iterator() {
            return new Iterator<Integer>() {

                private int currentIndex = 0;

                public boolean hasNext() {
                    return true;
                }

                public Integer next() {
                    int result = termGenerator.term(currentIndex);
                    currentIndex++;
                    return result;
                }

                public void remove() {
                    throw new UnsupportedOperationException();
                }
            };
        }

        public int term(int n) {
            return termGenerator.term(n);
        }
    }

    public interface TermGenerator {

        public abstract int term(int n);

    }

    class TriangularTerm implements TermGenerator {
        @Override
        public int term(int n) {
            if (n < 0) {
                throw new IllegalArgumentException("Sequence undefined for negative index");
            }
            return (n + 2) * (n + 1) / 2;
        }
    }

    class FibonacciTerm implements TermGenerator {
        @Override
        public int term(int n) {
            if (n < 0) {
                throw new IllegalArgumentException("Sequence undefined for negative index");
            }
            if (n < 2) {
                return 1;
            }
            return term(n - 2) + term(n - 1);
        }
    }

    public void generate() {
        new NumberSequence(new FibonacciTerm()).term(3);
        new NumberSequence(new TriangularTerm()).term(3);
    }
}