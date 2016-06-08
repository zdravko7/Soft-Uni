import java.math.BigDecimal;
import java.util.ArrayList;
import java.util.DoubleSummaryStatistics;
import java.util.Scanner;

public class SimpleExpression {

    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);
        String inputString = input.nextLine();

        inputString = inputString.replaceAll("\\+", " + ");
        inputString = inputString.replaceAll("-", " - ");

        System.out.println(inputString);

        inputString = inputString.replaceAll("\\s+", " ");
        String[] numbers = inputString.split("\\s");
        BigDecimal result = new BigDecimal(numbers[0]);

        for (int i = 0; i < inputString.length(); i += 2) {

            try {
                switch (numbers[i+1]) {

                    case "+":
                        result = result.add(new BigDecimal(numbers[i+2]));
                        break;

                    case "-":
                        result = result.subtract(new BigDecimal(numbers[i + 2]));
                        break;
                }
            }

            catch (Exception e) { }
        }

        System.out.print(result);
    }
}
