import java.lang.reflect.Array;
import java.util.ArrayList;
import java.util.Scanner;

public class LargestIncreasingSequence {
    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);
        String[] inputStrings = input.nextLine().split(" ");
        Integer[] numbers = ConvertArrayToInt(inputStrings);

        int counter = 1;
        int maxCounter = 1;

        ArrayList<Integer> currentSequence = new ArrayList<Integer>();
        ArrayList<Integer> maxSequence = new ArrayList<Integer>();
        currentSequence.add(numbers[0]);

        for (int i = 0; i < numbers.length; i++) {

            try {

                if (numbers[i+1] > numbers[i]) {

                    counter++;
                    currentSequence.add(numbers[i+1]);
                }
                else {

                    for (Integer number : currentSequence) {
                        System.out.print(number + " ");

                    }

                    System.out.print(" \n");

                    if (maxCounter < counter) {

                        maxSequence = (ArrayList<Integer>)currentSequence.clone();
                        maxCounter = counter;
                    }

                    counter = 0;
                    currentSequence.clear();
                    currentSequence.add(numbers[i+1]);
                }
            }
            catch (Exception e) {
                for (Integer number : currentSequence) {
                    System.out.print(number);
                    System.out.print(" ");
                }

                System.out.println();
            }
        }

        System.out.print("The largest sequence is: ");

        for (Integer number : maxSequence) {
            System.out.print(number);
            System.out.print(' ');
        }

        if (maxSequence.size() == 0) {
            System.out.print(numbers[0]);
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
