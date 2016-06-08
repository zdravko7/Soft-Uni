import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.time.temporal.ChronoUnit;
import java.util.Scanner;

public class DaysBetweenDates {
    private static Scanner scanner;

    public static void main(String[] args) {
        scanner = new Scanner(System.in);

        System.out.print("Enter the starting date:");
        String startDateAsString = scanner.nextLine();
        if (startDateAsString.length() == 9) {
            startDateAsString = "0" + startDateAsString;
        }

        System.out.print("Enter the end date:");
        String endDateAsString = scanner.nextLine();
        if (endDateAsString.length() == 9) {
            endDateAsString = "0" + endDateAsString;
        }

        DateTimeFormatter formatter = DateTimeFormatter.ofPattern("dd-MM-yyyy");

        LocalDate startingDate = LocalDate.parse(startDateAsString, formatter);
        LocalDate endDate = LocalDate.parse(endDateAsString, formatter);

        long daysBetweenTheTwoDates = ChronoUnit.DAYS.between(startingDate, endDate);

        System.out.println(daysBetweenTheTwoDates);
    }
}