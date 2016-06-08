import java.util.*;

public class LegendaryFarmingNEW {
    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);
        TreeMap<String, Integer> items = new TreeMap<String, Integer>();
        Boolean hasLegendary = true;

        while (hasLegendary) {
            String[] itemsString = input.nextLine().split(" ");

            for (int i = 0; i < itemsString.length; i += 2) {
                try {
                    String currentItem = itemsString[i + 1].toLowerCase();
                    int quantity = Integer.parseInt(itemsString[i]);

                    if (!items.containsKey(currentItem)) {
                        items.put(currentItem, quantity);
                    } else {
                        items.put(currentItem, items.get(currentItem) + quantity);
                    }

                    //breaks the loop
                    try {
                        if (items.get("fragments") >= 250) {
                            System.out.println("Valanyr obtained!");
                            items.put("fragments", items.get("fragments") - 250);
                            hasLegendary = false;
                            break;
                        }
                    } catch (Exception e) {
                    }

                    try {
                        if (items.get("shards") >= 250) {
                            System.out.println("Shadowmourne obtained!");
                            items.put("shards", items.get("shards") - 250);
                            hasLegendary = false;
                            break;
                        }
                    } catch (Exception e) {
                    }

                    try {
                        if (items.get("motes") >= 250) {
                            System.out.println("Dragonwrath obtained!");
                            items.put("motes", items.get("motes") - 250);
                            hasLegendary = false;
                            break;
                        }
                    } catch (Exception e) {
                    }
                } catch (Exception e) {
                }
            }
        }

        TreeMap<String, Integer> mainItems = new TreeMap<>();

        if (items.containsKey("fragments")) {
            mainItems.put("fragments", items.get("fragments"));
        }
        else {
            mainItems.put("fragments", 0);
        }

        if (items.containsKey("shards")) {
            mainItems.put("shards", items.get("shards"));
        }
        else {
            mainItems.put("shards", 0);
        }

        if (items.containsKey("motes")) {
            mainItems.put("motes", items.get("motes"));
        }
        else {
            mainItems.put("motes", 0);
        }

        List<Double> result = new ArrayList<Double>();
        Double type = 0d;

        for (Map.Entry<String, Integer> entry : mainItems.entrySet()) {
            String key = entry.getKey();
            Integer value = entry.getValue();

            if (key.equals("fragments")) {
                type = 0.03;
            }
            else if (key.equals("motes")) {
                type = 0.02;
            }
            else if (key.equals("shards")) {
                type = 0.01;
            }

            result.add(value + type);
        }

        Collections.sort(result, Collections.reverseOrder());

        for (int i = 0; i < result.size(); i++) {
            String findType = result.get(i).toString();
            Double finalNumberDouble = result.get(i);
            String material = "";

            switch(findType.charAt(findType.length()-1)) {
                case '1':
                    material = "shards";
                    finalNumberDouble = result.get(i) - 0.01d;
                    break;

                case '2':
                    material = "motes";
                    finalNumberDouble = result.get(i) - 0.02d;
                    break;

                case '3':
                    material = "fragments";
                    finalNumberDouble = result.get(i) - 0.03d;
                    break;
            }

            System.out.printf("%s: %s\n", material, finalNumberDouble.intValue());
        }

        //prints the other items
        items.remove("motes");
        items.remove("shards");
        items.remove("fragments");

        for (Map.Entry<String, Integer> entry : items.entrySet()) {
            String key = entry.getKey();
            Integer value = entry.getValue();

            System.out.printf("%s: %s\n", key, value);
        }
    }
}
