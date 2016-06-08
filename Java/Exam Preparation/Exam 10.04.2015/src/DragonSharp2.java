import java.util.Arrays;
import java.util.Scanner;

public class DragonSharp2 {
    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);
        int length = Integer.parseInt(input.nextLine());

        Boolean condition = false;
        Boolean inputValid = true;

        //input checker
        for (int i = 0; i < length; i++) {

            String inputString = input.nextLine();
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

            if (inputValid == false) {
                System.out.println("Compile time error @ line " + (i + 1));
                break;
            }
        }

        //main logic
        if (inputValid == true) {




        }


    }
}
