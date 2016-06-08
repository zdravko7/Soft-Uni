import com.sun.org.apache.xpath.internal.operations.Bool;

import java.util.ArrayList;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class DragonSharp {
    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);
        int length = Integer.parseInt(input.nextLine());
        Boolean condition = false;
        ArrayList<String> inputStrings = new ArrayList<>();
        //int length = 1; //MUST CHANGE

        Boolean inputValid = true;
        int lineCounter = 1;

        for (int i = 0; i < length; i++) {

            String inputString = input.nextLine();
            inputStrings.add(inputString);
            //checks input for errors
            //if (5==5) loop 3 out “gosho”;	    else out "pesho";    if (5==5) out “gosho”;	    else loop 3 out "pesho";
            String[] splitString = inputString.split(" ");

            /*for (String split : splitString) {
                System.out.println(split);
            }*/

            int counter = 0;

            for (String string4e : splitString) {

                if (string4e.contains("\"")) {
                    counter++;
                }
            }

            if (counter != 2 && counter != 1) {
                inputValid = false;
            }

            if (!splitString[splitString.length - 1].contains(";")) {
                inputValid = false;
            }

            if (!splitString[0].equals("if") && !splitString[0].equals("else")) {
                inputValid = false;
            }

            if (inputValid == false) {
                System.out.println("Compile time error @ line " + (i + 1));
                break;
            }
        }

        if (inputValid == false) {
            return;
        }

        //main logic
        for (int i = 0; i < length; i++) {

            String inputString = inputStrings.get(i);
            String[] splitInput = inputString.split("(.+?)\"(.+?)\";");
            String operation = splitInput[2];

            Pattern pattern = Pattern.compile("\"(.*?)\"");
            Matcher matcher = pattern.matcher(inputString);

            StringBuilder printStatementBuilder = new StringBuilder();

            if (matcher.find()) {
                printStatementBuilder.append(matcher.group(1));
            }

            //printStatement ready
            String printStatement = printStatementBuilder.toString();

            if (splitInput[1].contains("==")) {

                String[] numbers = splitInput[1].split("==");

                for (int k = 0; k < numbers.length; k++) {
                    numbers[k] = numbers[k].replaceAll("\\)", "");
                    numbers[k] = numbers[k].replaceAll("\\(", "");

                }

                int number1 = Integer.parseInt(numbers[0]);
                int number2 = Integer.parseInt(numbers[1]);

                if (number1 == number2) {
                    condition = true;
                }
                else {
                    condition = false;
                }
            }

            if (splitInput[1].contains(">")) {

                String[] numbers = splitInput[1].split(">");

                for (int k = 0; k < numbers.length; k++) {
                    numbers[k] = numbers[k].replaceAll("\\)", "");
                    numbers[k] = numbers[k].replaceAll("\\(", "");

                }

                int number1 = Integer.parseInt(numbers[0]);
                int number2 = Integer.parseInt(numbers[1]);

                if (number1 > number2) {
                    condition = true;
                }
                else {
                    condition = false;
                }
            }

            if (splitInput[1].contains("<")) {

                String[] numbers = splitInput[1].split("<");

                for (int k = 0; k < numbers.length; k++) {
                    numbers[k] = numbers[k].replaceAll("\\)", "");
                    numbers[k] = numbers[k].replaceAll("\\(", "");
                }

                int number1 = Integer.parseInt(numbers[0]);
                int number2 = Integer.parseInt(numbers[1]);

                if (number1 < number2) {
                    condition = true;
                }
                else {
                    condition = false;
                }
            }

            if (condition == true) {

                if (operation.equals("out")) {
                    System.out.print(printStatement);
                }
                else if (operation.equals("loop")) {
                    int loopLength = Integer.parseInt(splitInput[3]);

                    for (int j = 0; j < loopLength; j++) {
                        System.out.println(printStatement);
                    }
                }
            }
            else if (condition == false) {
                if (splitInput[0].equals("else")) {

                    if (splitInput[1].equals("out")) {

                        System.out.println(printStatement);
                    }
                    else if (splitInput[1].equals("loop")) {

                        int loopLength = Integer.parseInt(splitInput[2]);

                        for (int j = 0; j < loopLength;j++ ) {
                            System.out.println(printStatement);
                        }
                    }
                }
            }
        }
    }
}

