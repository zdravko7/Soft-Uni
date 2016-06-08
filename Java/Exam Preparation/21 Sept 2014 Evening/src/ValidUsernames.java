import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class ValidUsernames {
    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);

        String text = input.nextLine();

        List<String> allMatches = new ArrayList<String>();
        Matcher matcher = Pattern.compile("(?<=[ ()\\/])\\b[A-Za-z][A-Za-z0-9_]{3,25}")
                .matcher(text);

        while (matcher.find()) {
            allMatches.add(matcher.group());
        }

        int maxSum = 0;
        String firstUsername = "";
        String secondUsername = "";

        for (int i = 0; i < allMatches.size(); i++) {
            int currentSum = 0;

            try {
                currentSum = allMatches.get(i).length() + allMatches.get(i + 1).length();
            } catch (Exception e) { }

            if (currentSum > maxSum) {
                maxSum = currentSum;
                firstUsername = allMatches.get(i);
                secondUsername = allMatches.get(i+1);
            }
        }

        System.out.println(firstUsername);
        System.out.println(secondUsername);
    }
}
