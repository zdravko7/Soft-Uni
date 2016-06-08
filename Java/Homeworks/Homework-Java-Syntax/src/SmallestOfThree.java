import java.util.Arrays;
import java.util.Scanner;

public class SmallestOfThree {

    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);

        int[] numbers = new int[3];
        numbers[0]= input.nextInt();
        numbers[1] = input.nextInt();
        numbers[2] = input.nextInt();

        Arrays.sort(numbers);

        System.out.println(numbers[0]);
    }
}
