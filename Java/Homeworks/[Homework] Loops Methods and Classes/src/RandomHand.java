import java.util.*;

public class RandomHand {
    private static Scanner scanner;
    private static Random random;

    public static void main(String[] args) {
        scanner = new Scanner(System.in);
        random = new Random();

        String[] suits = {"\u2660", "\u2665", "\u2666", "\u2663"};
        String[] faces = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};

        System.out.print("Enter the number of hands you want:");
        int numberOfHands = Integer.parseInt(scanner.nextLine());

        for (int i = 0; i < numberOfHands; i++) {
            List<String> hand = new ArrayList<>();

            while (hand.size() < 5) {
                String face = faces[random.nextInt(13)];
                String suit = suits[random.nextInt(4)];

                hand.add(face + suit);
            }

            for (String card : hand) {
                System.out.print(card + " ");
            }
            System.out.println();
        }
    }
}