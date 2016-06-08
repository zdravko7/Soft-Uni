import java.util.Scanner;

public class CountOfBitsOne {

    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);
        int numberDecimal = input.nextInt();
        int counter = 0;

        String binaryNumber = Integer.toBinaryString(numberDecimal);

        for (char letter : binaryNumber.toCharArray()) {
            if (letter == '1')
            {
                counter++;
            }
        }

        System.out.println(counter);
    }
}
