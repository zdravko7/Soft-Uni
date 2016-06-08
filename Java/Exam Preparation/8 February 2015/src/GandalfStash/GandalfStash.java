package GandalfStash;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class GandalfStash {
    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);
        Integer startResult = Integer.parseInt(input.nextLine());
        String inputString = input.nextLine();
        long result = startResult;

        String patternString = "[a-zA-Z]+";
        Pattern pattern = Pattern.compile(patternString);
        Matcher matcher = pattern.matcher(inputString);

        List<String> allMatches = new ArrayList<>();

        while (matcher.find()) {
            allMatches.add(matcher.group());
        }

        int currentNumber = 0;

        for (int i = 0; i < allMatches.size(); i++) {
            currentNumber = happinessGenerator(allMatches.get(i).toLowerCase());

            //System.out.println(allMatches.get(i));
            //System.out.println(currentNumber);
            result += currentNumber;
        }

        System.out.println(result);

        if (result < -5) {
            System.out.println("Angry");
        } else if (result >= -5 && result < 0) {
            System.out.println("Sad");
        } else if (result >= 0 && result < 15) {
            System.out.println("Happy");
        } else {
            System.out.println("Special JavaScript mood");
        }
    }

    public static int happinessGenerator(String input) {
        switch (input) {
            case "cram":
                return 2;

            case "lembas":
                return 3;

            case "apple":
                return 1;

            case "melon":
                return 1;

            case "honeycake":
                return 5;

            case "mushrooms":
                return -10;

            default:
                return -1;
        }
    }
}
