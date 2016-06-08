import java.util.*;

public class PossibleTriangles {
    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);
        int triangleCounter = 0;

        while(true) {
            String[] inputNumbers = input.nextLine().split(" ");

            if (inputNumbers[0].equals("End")) {
                break;
            }

            List<Double> numbers = new ArrayList<>();

            for (String number : inputNumbers ) {
                numbers.add(Double.parseDouble(number));
            }

            Collections.sort(numbers);

            if (numbers.get(0) + numbers.get(1) > numbers.get(2)) {
                System.out.printf("%.2f+%.2f>%.2f\n", numbers.get(0), numbers.get(1), numbers.get(2));
                triangleCounter++;
            }
        }

        if (triangleCounter == 0) {
            System.out.println("No");
        }
    }
}
