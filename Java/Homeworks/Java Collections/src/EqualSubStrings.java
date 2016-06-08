import java.util.Dictionary;
import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;

public class EqualSubStrings {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        String inputString = input.nextLine();

        String[] substrings = inputString.split(" ");

        Map<String, Integer> equals = new HashMap<String,Integer>();

        for (String substring : substrings) {

            if (!equals.containsKey(substring)) {
                equals.put(substring, 1);
            }
            else {
                equals.put(substring, equals.get(substring) + 1);
            }
        }

        for (Map.Entry<String, Integer> entry : equals.entrySet()) {
            String key = entry.getKey();
            Integer value = entry.getValue();

            for (int i = 0; i < value; i++) {
                System.out.print(key);
                System.out.print(' ');
                System.out.println();
            }
        }


    }

    public static Integer[] ConvertArrayToInt(String[] array) {
        Integer[] arrayOfInt = new Integer[array.length];

        for (int i = 0; i < array.length; i++) {
            arrayOfInt[i] = Integer.parseInt(array[i]);
        }

        return arrayOfInt;
    }
}
