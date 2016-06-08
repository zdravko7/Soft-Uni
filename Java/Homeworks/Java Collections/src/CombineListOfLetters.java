import java.util.ArrayList;
import java.util.Scanner;

public class CombineListOfLetters {

    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);
        String[] firstList = input.nextLine().split(" ");
        String[] secondList = input.nextLine().split(" ");

        ArrayList<Character> combinedList = new ArrayList<Character>();

        for (String character : firstList) {
            combinedList.add(character.charAt(0));
        }

        for (String character : secondList) {

            if (!combinedList.contains(character.charAt(0))) {

                combinedList.add(character.charAt(0));
            }
        }

        for (Character character : combinedList) {
            System.out.print(character + " ");
        }
    }
}
