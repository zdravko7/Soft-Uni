import java.lang.reflect.Array;
import java.text.MessageFormat;
import java.util.*;

public class DragonArmy {
    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);
        int length = Integer.parseInt(input.nextLine());

        LinkedHashMap<String, TreeMap<String, Double[]>> dragons = new LinkedHashMap<>();

        for (int i = 0; i < length; i++) {

            String inputString = input.nextLine();
            String[] splitInput = inputString.split(" ");
            Double[] currentDragonStats = new Double[3];

            String dragonType = splitInput[0];
            String dragonName = splitInput[1];
            Double damage = 0d;
            Double health = 0d;
            Double armor = 0d;

            try {
                damage = Double.parseDouble(splitInput[2]);
            }
            catch (Exception e) {
                damage = 45d;
            }

            try {
                health = Double.parseDouble(splitInput[3]);
            }
            catch (Exception e) {
                health = 250d;
            }

            try {
                armor = Double.parseDouble(splitInput[4]);
            }
            catch (Exception e) {
                armor = 10d;
            }

            currentDragonStats[0] = damage;
            currentDragonStats[1] = health;
            currentDragonStats[2] = armor;

            //HashMap<String, Double[]> currentDragon = new

            //checks for dragon type
            if (!dragons.containsKey(dragonType)) {
                dragons.put(dragonType, new TreeMap<String, Double[]>());
            }

            dragons.get(dragonType).put(dragonName, currentDragonStats);

        }

        for (Map.Entry<String,TreeMap<String, Double[]>> entry : dragons.entrySet()) {
            String key = entry.getKey();
            TreeMap<String, Double[]> value = entry.getValue();

            ArrayList<Double> healths = new ArrayList<>();
            ArrayList<Double> attacks = new ArrayList<>();
            ArrayList<Double> armors = new ArrayList<>();

            //loop to generate average sums
            for (Map.Entry<String,Double[]> entry2 : value.entrySet()) {

                Double[] stats = entry2.getValue();

                healths.add(stats[0]);
                attacks.add(stats[1]);
                armors.add(stats[2]);
            }

            Double averageHealth = healths.stream().mapToDouble(val -> val).average().getAsDouble();
            Double averageAttack = attacks.stream().mapToDouble(val -> val).average().getAsDouble();
            Double averageArmor = armors.stream().mapToDouble(val -> val).average().getAsDouble();

            System.out.printf("%s::(%.2f/%.2f/%.2f)", key, averageHealth, averageAttack, averageArmor);
            System.out.println();

            //loop inside dragons
            for (Map.Entry<String,Double[]> entry2 : value.entrySet()) {

                String internalKey = entry2.getKey();
                Double[] stats = entry2.getValue();
                Integer dragonDamage = stats[0].intValue();
                Integer dragonHealth = stats[1].intValue();
                Integer dragonArmor = stats[2].intValue();

                System.out.printf("-%s -> damage: %s, health: %s, armor: %s", internalKey, dragonDamage, dragonHealth, dragonArmor);
                System.out.println();
                //System.out.println(MessageFormat.format("-{0} -> damage: {1}, health: {2}, armor: {3}",
                //        internalKey, dragonDamage, dragonHealth, dragonArmor));

            }
        }
    }
}
