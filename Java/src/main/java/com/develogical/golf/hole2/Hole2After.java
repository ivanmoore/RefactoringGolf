package com.develogical.golf.hole2;

import com.develogical.golf.Instruction;
import com.develogical.golf.MoveInstruction;
import com.develogical.golf.TurnInstruction;

import java.util.ArrayList;
import java.util.List;

public class Hole2After {

    private List<Instruction> instructions = new ArrayList<Instruction>();

    public void parseCommand(String command) {

        String[] parts = command.split(" ");
        String direction = parts[0];
        int amount = Integer.parseInt(parts[1]);

        Instruction instruction = null;
        if (direction.equals("foward")) {
            instruction = new MoveInstruction(amount);
        }
        if (direction.equals("left")) {
            instruction = new TurnInstruction(amount);
        }
        if (direction.equals("right")) {
            instruction = new TurnInstruction(-1 * amount);
        }

        instructions.add(instruction);
    }

}

