import java.util.Scanner;

public class TinySporebeat {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        int health = 5800;
        int glowcaps = 0;

        while(true) {
            String enemy = input.nextLine();

            if (enemy.equals("Sporeggar")) {
                break;
            }

            String currentGlowcapsString = "" + enemy.charAt(enemy.length()-1);
            int currentGlowcaps = Integer.parseInt(currentGlowcapsString);

            int totalDamage = 0;

            for (int i = 0; i < enemy.length()-1; i++) {

                if (enemy.charAt(i) != 'L') {
                    totalDamage += (int) enemy.charAt(i);
                } else {
                    totalDamage -= 200;
                }
            }

            health -= totalDamage;

            if (health > 0) {
                glowcaps += currentGlowcaps;
            }

            //System.out.println("damage: " + totalDamage);
            //System.out.println("health: " + health);
        }

        if (health <= 0) {
            System.out.printf("Died. Glowcaps: %s", glowcaps);
        }
        else {
            System.out.printf("Health left: %s\n", health);

            if (glowcaps >= 30) {

                System.out.print("Bought the sporebat. ");
                glowcaps -= 30;

                System.out.printf("Glowcaps left: %s", glowcaps);
            }
            else {
                int neededGlowcaps = 30 - glowcaps;
                System.out.printf("Safe in Sporeggar, but another %s Glowcaps needed.", neededGlowcaps);
            }
        }
    }
}

