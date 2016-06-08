import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;

public class LegendaryFarmingNewApproach {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        TreeMap<String, Integer> items = new TreeMap<>();

        Boolean hasLegendary = false;

        items.put("fragments", 0);
        items.put("shards", 0);
        items.put("motes", 0);

        while(!hasLegendary) {
            String[] newItems = input.nextLine().split(" ");

            for (int i = 0; i < newItems.length; i+=2) {
                try {
                    String currentItem = newItems[i+1].toLowerCase();
                    Integer quantity = Integer.parseInt(newItems[i]);

                    if (!items.containsKey(currentItem)) {
                        items.put(currentItem, quantity);
                    }
                    else {
                        items.put(currentItem, items.get(currentItem) + quantity);
                    }

                    if (items.get("shards") >= 250) {
                        System.out.println("Shadowmourne obtained!");
                        hasLegendary = true;
                        items.put("shards", items.get("shards") - 250);
                        break;
                    }

                    if (items.get("fragments") >= 250) {
                        System.out.println("Valanyr obtained!");
                        hasLegendary = true;
                        items.put("fragments", items.get("fragments") - 250);
                        break;
                    }

                    if (items.get("motes") >= 250) {
                        System.out.println("Dragonwrath obtained!");
                        hasLegendary = true;
                        items.put("motes", items.get("motes") - 250);
                        break;
                    }
                } catch (Exception e) {}
            }
        }

        System.out.println("fragments: " + items.get("fragments"));
        System.out.println("shards: " + items.get("shards"));
        System.out.println("motes: " + items.get("motes"));

        //print rest of the objects
        items.remove("fragments");
        items.remove("shards");
        items.remove("motes");

        for (Map.Entry<String, Integer> entry : items.entrySet()) {
            System.out.print(entry.getKey() + ": " + entry.getValue() + " \n");
        }
    }
}
