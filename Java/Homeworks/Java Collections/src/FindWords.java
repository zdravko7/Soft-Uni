import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import java.util.regex.Pattern;
import java.util.regex.Matcher;

public class FindWords {
    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);
        String text = input.nextLine();

        Pattern pattern = Pattern.compile("\\w+");

        List<String> matches = new ArrayList<String>();
        Matcher matcher = pattern.matcher(text);
        while (matcher.find()) {
            matches.add(matcher.group());
        }

        System.out.println(matches.size());
        /*for (String match : matches) {
            System.out.println(match);
        }*/
    }
}
