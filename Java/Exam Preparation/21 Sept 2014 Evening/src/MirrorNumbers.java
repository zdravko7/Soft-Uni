import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class MirrorNumbers {

    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);

        int length = Integer.parseInt(input.nextLine());

        List<Integer> numbers = new ArrayList<>();

        int reverseCounter = 0;

        for(int i=0; i < length; i++) {
            numbers.add(input.nextInt());
        }

        for(int i=0; i < numbers.size(); i++) {

            for(int j = 0; j < numbers.size(); j++) {

                if (i == j) {
                    continue;
                }

                if (numbers.get(i) == ReverseNumber(numbers.get(j))) {
                    System.out.printf("%s<!>%s\n", numbers.get(i), numbers.get(j));
                    reverseCounter++;
                }
            }

            try {
                numbers.set(i, 0);
            } catch (Exception e) { }
        }

        if (reverseCounter == 0) {
            System.out.println("No");
        }
    }

    public static int ReverseNumber(int number) {

        int reverse = 0;

        while( number != 0 )
        {
            reverse = reverse * 10;
            reverse = reverse + number %10;
            number = number/10;
        }

        return reverse;
    }
}
