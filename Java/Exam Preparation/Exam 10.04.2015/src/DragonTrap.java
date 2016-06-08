import org.omg.CORBA.PRIVATE_MEMBER;

import java.lang.reflect.Array;
import java.util.ArrayList;
import java.util.Scanner;

public class DragonTrap {
    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);
        int size = Integer.parseInt(input.nextLine());
        int symbolsChanged = 0;

        Character[][] matrix = new Character[size][size];

        //filling the matrix
        for (int row = 0; row < size; row++) {

            String inputString = input.nextLine();

            for (int ch = 0; ch < size; ch++) {

                matrix[row][ch] = inputString.charAt(ch);
            }
        }
        //input is tested

        while(true) {

            String inputString = input.nextLine();

            if (inputString.equals("End")) {
                break;
            }

            String[] operations = inputString.split(" ");

            operations[0] = operations[0].replaceAll("\\(", "");
            operations[1] = operations[1].replaceAll("\\)", "");

            /*for (String operation : operations) {
                System.out.println(operation);
            }*/

            int startRow = Integer.parseInt(operations[0]);
            int startCol = Integer.parseInt(operations[1]);
            int radius = Integer.parseInt(operations[2]);
            int rotations = Integer.parseInt(operations[3]);

            ArrayList<Character> charsChanged = new ArrayList<>();

            //up
            try {
                if (matrix[startRow - radius][startCol] != null) {
                    charsChanged.add(matrix[startRow - radius][startCol]);
                }
            }
            catch (Exception e) { }

            //up-right
            try {
                if (matrix[startRow - radius][startCol + radius] != null) {
                    charsChanged.add(matrix[startRow - radius][startCol + radius]);
                }
            }
            catch (Exception e) { }

            //right
            try {
                if (matrix[startRow][startCol + radius] != null) {
                    charsChanged.add(matrix[startRow][startCol + radius]);
                }
            }
            catch (Exception e) { }

            //down-right
            try {
                if (matrix[startRow + radius][startCol + radius] != null) {
                    charsChanged.add(matrix[startRow + radius][startCol + radius]);
                }
            }
            catch (Exception e) { }

            //down
            try {
                if (matrix[startRow + radius][startCol] != null) {
                    charsChanged.add(matrix[startRow + radius][startCol]);
                }
            }
            catch (Exception e) { }

            //down-left
            try {
                if (matrix[startRow + radius][startCol - radius] != null) {
                    charsChanged.add(matrix[startRow + radius][startCol - radius]);
                }
            }
            catch (Exception e) { }

            //left
            try {
                if (matrix[startRow][startCol - radius] != null) {
                    charsChanged.add(matrix[startRow][startCol - radius]);
                }
            }
            catch (Exception e) { }

            //up-left
            try {
                if (matrix[startRow - radius][startCol - radius] != null) {
                    charsChanged.add(matrix[startRow - radius][startCol - radius]);
                }
            }
            catch (Exception e) { }
            //chars to change saved

            for (Character charche : charsChanged) {
                System.out.print(charche + " ");
            }

            //rotations work correctly
            for (int rotate = 0; rotate < rotations; rotate++) {

                ArrayList<Character> rotatedChars = new ArrayList<>();
                rotatedChars.add(charsChanged.get(charsChanged.size() - 1));
                for (int i = 0; i < charsChanged.size() - 1; i++) {

                    rotatedChars.add(charsChanged.get(i));
                }

                charsChanged = rotatedChars;
            }

            symbolsChanged = charsChanged.size();

            //tests
            PrintMatrix(matrix);

            for (Character charche : charsChanged) {
                System.out.print(charche + " ");
            }

            System.out.println();



            //return chars
            //up
            try {
                if (matrix[startRow - radius][startCol] != null) {
                    matrix[startRow - radius][startCol] = charsChanged.get(0);
                }
            }
            catch (Exception e) { }

            //up-right
            try {
                if (matrix[startRow - radius][startCol + radius] != null) {
                    matrix[startRow - radius][startCol + radius] = charsChanged.get(1);
                }
            }
            catch (Exception e) { }

            //right
            try {
                if (matrix[startRow][startCol + radius] != null) {
                    matrix[startRow][startCol + radius] = charsChanged.get(2);
                }
            }
            catch (Exception e) { }

            //down-right
            try {
                if (matrix[startRow + radius][startCol + radius] != null) {
                    matrix[startRow + radius][startCol + radius] = charsChanged.get(3);
                }
            }
            catch (Exception e) { }

            //down
            try {
                if (matrix[startRow + radius][startCol] != null) {
                    matrix[startRow + radius][startCol] = charsChanged.get(4);
                }
            }
            catch (Exception e) { }

            //down-left
            try {
                if (matrix[startRow + radius][startCol - radius] != null) {
                    matrix[startRow + radius][startCol - radius] = charsChanged.get(5);
                }
            }
            catch (Exception e) { }

            //left
            try {
                if (matrix[startRow][startCol - radius] != null) {
                    matrix[startRow][startCol - radius] = charsChanged.get(6);
                }
            }
            catch (Exception e) { }

            //up-left
            try {
                if (matrix[startRow - radius][startCol - radius] != null) {
                    matrix[startRow - radius][startCol - radius] = charsChanged.get(7);
                }
            }
            catch (Exception e) { }
            //chars to change saved

            PrintMatrix(matrix);
            System.out.println("Symbols changed: " + symbolsChanged);
        }
    }

    public static void PrintMatrix (Character[][] matrix) {
        for (int row = 0; row < matrix.length; row++) {
            for (int col = 0; col < matrix[0].length; col++) {
                System.out.print(matrix[row][col]);
            }
            System.out.println();
        }
    }
}
