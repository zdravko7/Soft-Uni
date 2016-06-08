import java.util.*;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class FindUniqueWord {

    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);
        String text = input.nextLine().toLowerCase();

        Pattern pattern = Pattern.compile("\\w+");
        Matcher matcher = pattern.matcher(text);
        ArrayList<String> matches = new ArrayList<String>();

        while (matcher.find()) {
            matches.add(matcher.group());
        }

        Set<String> uniqueMatches = new TreeSet<String>();
        //HashSet<String> uniqueMatches = new HashSet<String>();
        uniqueMatches.addAll(matches);

        for (String match : uniqueMatches) {
            System.out.print(match + " ");
        }
    }
}
