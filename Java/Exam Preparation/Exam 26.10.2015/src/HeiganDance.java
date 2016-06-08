import java.util.Scanner;

public class HeiganDance {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        Integer[][] matrix = new Integer[15][15];
        matrix = FillMatrix(matrix);
        //PrintMatrix(matrix);

        int playerRow = 7;
        int playerCol = 7;

        Double healthHeigan = 3000000d;
        int healthPlayer = 18500;

        Double playerAttack = Double.parseDouble(input.nextLine());

        Boolean playerIsDefeated = false;
        Boolean bossIsDefeated = false;
        Boolean isPlagued = false;

        String causeOfDeath = "";

        while (!playerIsDefeated && !bossIsDefeated) {

            healthHeigan -= playerAttack;

            if (isPlagued) {
                healthPlayer -= 3500;
                isPlagued = false;

                if (healthHeigan <= 0) {
                    bossIsDefeated = true;
                }

                if (healthPlayer <= 0) {
                    playerIsDefeated = true;
                    causeOfDeath = "Plague Cloud";
                    break;
                }
            }

            if (healthHeigan <= 0) {
                bossIsDefeated = true;
                break;
            }

           if (healthPlayer <= 0){
                playerIsDefeated = true;
                break;
            }

            //resets the matrix
            matrix = FillMatrix(matrix);

            String[] nextAttack = input.nextLine().split(" ");

            String attack = nextAttack[0];

            int attackRow = Integer.parseInt(nextAttack[1]);
            int attackCol = Integer.parseInt(nextAttack[2]);

            //damage area
            try {
                matrix[attackRow][attackCol] = 1;
            } catch (Exception e) {
            }

            //up
            try {
                matrix[attackRow - 1][attackCol] = 1;
            } catch (Exception e) {
            }

            //up-right
            try {
                matrix[attackRow - 1][attackCol + 1] = 1;
            } catch (Exception e) {
            }

            //right
            try {
                matrix[attackRow][attackCol + 1] = 1;
            } catch (Exception e) {
            }

            //down-right
            try {
                matrix[attackRow + 1][attackCol + 1] = 1;
            } catch (Exception e) {
            }

            //down
            try {
                matrix[attackRow + 1][attackCol] = 1;
            } catch (Exception e) {
            }

            //down-left
            try {
                matrix[attackRow + 1][attackCol - 1] = 1;
            } catch (Exception e) {
            }

            //left
            try {
                matrix[attackRow][attackCol - 1] = 1;
            } catch (Exception e) {
            }

            //up-left
            try {
                matrix[attackRow - 1][attackCol - 1] = 1;
            } catch (Exception e) {
            }

            //PrintMatrix(matrix);

            //player tries to evade
            if (matrix[playerRow][playerCol] == 1){

                //up
                try {
                    if (matrix[playerRow - 1][playerCol] != 1) {
                        playerRow -= 1;
                        continue;
                    }
                } catch (Exception e) {
                }

                //right
                try {
                    if (matrix[playerRow][playerCol + 1] != 1) {
                        playerCol += 1;
                        continue;
                    }
                } catch (Exception e) {
                }

                //down
                try {
                    if (matrix[playerRow + 1][playerCol] != 1) {
                        playerRow += 1;
                        continue;
                    }
                } catch (Exception e) {
                }

                //left
                try {
                    if (matrix[playerRow][playerCol - 1] != 1) {
                        playerCol -= 1;
                        continue;
                    }
                } catch (Exception e) {
                }
            }
            else {
                continue;
            }

            //player gets hit
            if (attack.equals("Eruption")) {
                healthPlayer -= 6000;

                if (healthPlayer <= 0) {
                    playerIsDefeated = true;
                    causeOfDeath = "Eruption";
                    break;
                }

            }
            else if (attack.equals("Cloud")) {
                healthPlayer -= 3500;
                isPlagued = true;

                if (healthPlayer <= 0) {
                    playerIsDefeated = true;
                    causeOfDeath = "Plague Cloud";
                    break;
                }
            }
        }

        //end output
        if (bossIsDefeated) {
            System.out.println("Heigan: Defeated!");
        }
        else {
            System.out.printf("Heigan: %.2f\n", healthHeigan);
        }

        if (playerIsDefeated) {
            System.out.printf("Player: Killed by %s\n", causeOfDeath);
        }
        else {
            System.out.printf("Player: %s\n", healthPlayer);
        }

        System.out.printf("Final position: %s, %s", playerRow, playerCol);
    }

    public static Integer[][] FillMatrix(Integer[][] matrix) {
        for (int row = 0; row < 15; row++) {
            for (int col = 0; col < 15; col++) {
                matrix[row][col] = 0;
            }
        }

        return matrix;
    }

    public static void PrintMatrix(Integer[][] matrix) {
        for (int row = 0; row < 15; row++) {
            for (int col = 0; col < 15; col++) {
                System.out.print(matrix[row][col] + " ");
            }
            System.out.println();
        }
    }
}
