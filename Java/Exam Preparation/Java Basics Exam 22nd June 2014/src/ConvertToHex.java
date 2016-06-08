import java.lang.System;
import java.util.Scanner;

public class ConvertToHex {

    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);

        int numberDecimal = input.nextInt();
        String numberHex = Integer.toHexString(numberDecimal);

        System.out.println(numberHex);
    }
}
