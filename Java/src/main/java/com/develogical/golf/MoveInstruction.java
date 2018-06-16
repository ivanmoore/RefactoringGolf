package com.develogical.golf;

public class MoveInstruction extends Instruction {
    private final int amount;

    public MoveInstruction(int amount) {
       this.amount = amount;
    }
}
