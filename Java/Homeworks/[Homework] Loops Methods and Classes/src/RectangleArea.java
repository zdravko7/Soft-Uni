import java.util.Scanner;

public class RectangleArea {

    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);

        int firstSide = input.nextInt();
        int secondSide = input.nextInt();
        int result = firstSide * secondSide;

        System.out.println(result);

    }
}
