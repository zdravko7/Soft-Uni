import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class FindSpecificWord {

    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);
        String text = input.nextLine().toUpperCase();
        String word = input.nextLine().toUpperCase();

        Pattern pattern = Pattern.compile("\\b" + word + "\\b");
        Matcher matcher = pattern.matcher(text);
        List<String> matches = new ArrayList<String>();

        while (matcher.find()) {
            matches.add(matcher.group());
        }

        System.out.println(matches.size());
    }
}
