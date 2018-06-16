package com.develogical.golf.hole1;

import com.develogical.golf.Instruction;
import com.develogical.golf.MoveInstruction;
import com.develogical.golf.TurnInstruction;

import java.util.ArrayList;
import java.util.List;

public class Hole1Before {

    private List<Instruction> instructions = new ArrayList<Instruction>();

    public void parseCommand(String command) {

        String[] parts = command.split(" ");
        String direction = parts[0];
        String amount = parts[1];

        if (direction.equals("foward")) {
            instructions.add(new MoveInstruction(Integer.parseInt(amount)));
        }
        if (direction.equals("left")) {
            instructions.add(new TurnInstruction(Integer.parseInt(amount)));
        }
        if (direction.equals("right")) {
            instructions.add(new TurnInstruction(-1 * Integer.parseInt(amount)));
        }

    }

}

