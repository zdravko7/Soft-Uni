import java.util.Arrays;
import java.util.Scanner;

public class StraightFlush {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        String[] cards = input.nextLine().split(", ");
        String[] reversedCards = new String[cards.length];

        for (int i = 0; i < cards.length; i++) {
            reversedCards[i] = reverseOrder(cards[i]);
        }

        Arrays.sort(reversedCards);

        for (int i = 0; i < reversedCards.length; i++) {
            System.out.println(cards[i]);
            System.out.println(reversedCards[i]);
        }
    }

    public static String reverseOrder(String card) {
        String reversedCard = "" +  card.charAt(1) + card.charAt(0);
        return reversedCard;
    }
}
