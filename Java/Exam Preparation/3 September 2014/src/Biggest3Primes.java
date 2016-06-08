import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Biggest3Primes {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        String[] numbersString = input.nextLine().split(" ");
        Integer[] numbers = new Integer[numbersString.length];

        for (int i = 0; i < numbers.length; i++) {
            numbers[i] = Integer.parseInt(numbersString[i]);
        }

        List<Integer> primes = new ArrayList<Integer>();

        for (int i = 0; i < numbers.length; i++) {
            if (isPrime(numbers[i])) {
                primes.add(numbers[i]);
            }
        }

        Integer maxSum = Integer.MIN_VALUE;
        Integer currentSum = 0;
        Integer[] largestPrimes = new Integer[3];

        for (int i = 0; i < primes.size(); i++) {
            try {
                currentSum = primes.get(i) + primes.get(i+1) + primes.get(i+2);

                if (currentSum > maxSum) {
                    maxSum = currentSum;
                    largestPrimes[0] = primes.get(i);
                    largestPrimes[1] = primes.get(i+1);
                    largestPrimes[2] = primes.get(i+2);
                }
            }
            catch (Exception e) { }
        }

        if (maxSum == Integer.MIN_VALUE) {
            System.out.println("No");
        }
        else {
            System.out.println(maxSum);
        }
    }

    public static Boolean isPrime (Integer number) {

        if ((number == 2) || number == 3 || number == 5 || number == 7) {
            return true;
        }

        if ((number % 2 != 0) && (number % 3 != 0) && (number % 5 !=0) && (number % 7 != 0)) {
            return true;
        }
        return false;
    }
}
