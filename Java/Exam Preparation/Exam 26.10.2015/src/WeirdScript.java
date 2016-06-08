import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class WeirdScript {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        Integer keyNum = Integer.parseInt(input.nextLine());

        while (keyNum >= 53) {
            keyNum -= 52;
        }

        if (keyNum > 0 && keyNum < 27) {
            keyNum += 96;
        }
        else if (keyNum > 26 && keyNum < 53) {
            keyNum += 38;
        }

        while (keyNum > 96 + 52) {
            keyNum -= 52;
        }

        StringBuilder keyBuilder = new StringBuilder();
        keyBuilder.append(Character.toChars(keyNum));
        keyBuilder.append(Character.toChars(keyNum));

        String key = keyBuilder.toString();
        String text = "";
        StringBuilder textBuilder = new StringBuilder();

        while(true) {
            String textNew = input.nextLine();

            if (textNew.equals("End")) {
                break;
            }

            textBuilder.append(textNew);
        }

        text = textBuilder.toString();
        //System.out.println(text);

        //String regex = "(?<=" + key + ").*?(?=" + key + ")";
        String regex = key + ".*?" + key;

        Pattern pattern = Pattern.compile(regex);//"(?<=AA).*?(?=AA)");
        Matcher matcher = pattern.matcher(text);

        List<String> allMatches = new ArrayList<String>();

        while (matcher.find()) {
            allMatches.add(matcher.group());
        }

        for (int i = 0; i < allMatches.size(); i++) {
            allMatches.get(i).replaceAll(key, "");
        }

        for (int i = 0; i < allMatches.size(); i++) {
            allMatches.set(i, removeLastChar(allMatches.get(i)));
            allMatches.set(i, removeLastChar(allMatches.get(i)));
            allMatches.set(i, allMatches.get(i).substring(1));
            allMatches.set(i, allMatches.get(i).substring(1));
        }

        allMatches.forEach(entry -> System.out.println(entry));
    }

    public static String RemoveLastCharacter(String str) {
        if (str.length() > 0 && str.charAt(str.length()-1)=='x') {
            str = str.substring(0, str.length()-1);
        }
        return str;
    }

    private static String removeLastChar(String str) {
        return str.substring(0,str.length()-1);
    }
}
