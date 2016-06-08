import java.util.Arrays;
import java.util.Scanner;

public class SortArrayOfNumbers {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        int length = input.nextInt();
        Integer[] numbers = new Integer[length];

        for (int i = 0; i < length; i++) {
            numbers[i] = input.nextInt();
        }

        Arrays.sort(numbers);
        PrintArray(numbers);
    }

    public static void PrintArray(Integer[] array) {
        for(int element : array) {
            System.out.print(element);
            System.out.print(' ');
        }
    }
}
