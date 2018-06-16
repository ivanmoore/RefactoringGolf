package com.develogical.golf.hole4;

public class Hole4After {

    public void printLabelAndReceipt() {
        new Label().print();
        new Receipt().print();
    }

    class Receipt {

        private void print() {
            System.out.println("1 Book, 5.99");
            System.out.println("1 CD, 9.99");
            System.out.println("Total: 15.98 ");
        }
    }

    class Label {

        private void print() {
            System.out.println("Mr J Smith");
            System.out.println("34 High Street");
            System.out.println("Oxford");
            System.out.println("OX1 1TT");
        }
    }

}
