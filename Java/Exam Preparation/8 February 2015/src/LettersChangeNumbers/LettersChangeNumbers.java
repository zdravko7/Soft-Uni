package LettersChangeNumbers;

import com.sun.xml.internal.ws.commons.xmlutil.Converter;
import sun.plugin.com.Utils;

import java.security.AlgorithmParameterGenerator;
import java.text.DecimalFormat;
import java.util.Scanner;

public class LettersChangeNumbers {
    public static void main(String[] args) {

        //input
        Scanner input = new Scanner(System.in);
        String inputString = input.nextLine();
        inputString = inputString.replaceAll("\\s+", " ");
        String[] strings = inputString.split(" ");
        Double result = 0.0;

        //operations
        for (int i = 0; i < strings.length; i++) {

            char firstLetter = strings[i].charAt(0);
            char lastLetter = strings[i].charAt(strings[i].length() -1);
            StringBuilder numberString = new StringBuilder();

            for (int j = 1; j < strings[i].length() - 1; j++) {
                numberString.append(strings[i].charAt(j));
            }

            //System.out.println(numberString);
            long number = Long.parseLong(numberString.toString());

            //System.out.print((int)firstLetter + " " + (int) lastLetter);

            String operator1 = "";
            String operator2 = "";

            if (firstLetter >= 'a' && firstLetter <= 'z') {
                operator1 = "*";
            } else {
                operator1 = "/";
            }

            if (lastLetter >= 'a' && lastLetter <= 'z') {
                operator2 = "+";
            } else {
                operator2 = "-";
            }

            Double tempResult = 0.0;

            switch (operator1) {
                case "*":
                    tempResult += Alphabet(Character.toLowerCase(firstLetter)) * number;
                    break;

                case "/":
                    tempResult += number / Alphabet(Character.toLowerCase(firstLetter));
                    break;
            }

            //System.out.println(tempResult);
            //System.out.println(lastLetter);
            //System.out.println(Alphabet(Character.toLowerCase(lastLetter)));

            switch (operator2) {
                case "+":
                    tempResult = tempResult + Alphabet(Character.toLowerCase(lastLetter));
                    break;

                case "-":
                    tempResult = tempResult - Alphabet(Character.toLowerCase(lastLetter));
                    break;
            }

            //System.out.println(tempResult);

            result += tempResult;
        }

        System.out.printf("%.2f", result);
    }

    public static Double Alphabet(char letter) {

        switch (letter) {
            case 'a':
                return 1.00;

            case 'b':
                return 2.00;

            case 'c':
                return 3.00;

            case 'd':
                return 4.00;

            case 'e':
                return 5.00;

            case 'f':
                return 6.00;

            case 'g':
                return 7.00;

            case 'h':
                return 8.00;

            case 'i':
                return 9.00;

            case 'j':
                return 10.00;

            case 'k':
                return 11.00;

            case 'l':
                return 12.00;

            case 'm':
                return 13.00;

            case 'n':
                return 14.00;

            case 'o':
                return 15.00;

            case 'p':
                return 16.00;

            case 'q':
                return 17.00;

            case 'r':
                return 18.00;

            case 's':
                return 19.00;

            case 't':
                return 20.00;

            case 'u':
                return 21.00;

            case 'v':
                return 22.00;

            case 'w':
                return 23.00;

            case 'x':
                return 24.00;

            case 'y':
                return 25.00;

            case 'z':
                return 26.00;

            default:
                return 0.00;
        }
    }
}
