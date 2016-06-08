import java.util.*;
import java.util.stream.Collectors;

public class LegendaryFarming {
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
                        if (items.get("fragments") >= 255 || items.get("shards") >= 255 || items.get("motes") >= 255) {
                            hasLegendary = false;
                            break;
                        }
                    } catch (Exception e) {
                    }

                    try {
                        if (items.get("shards") >= 255) {
                            hasLegendary = false;
                            break;
                        }
                    } catch (Exception e) {
                    }

                    try {
                        if (items.get("motes") >= 255) {
                            hasLegendary = false;
                            break;
                        }
                    } catch (Exception e) {
                    }
                } catch (Exception e) {
                }
            }
        }

        HashMap<String, Integer> remainingMainItems = new HashMap<>();

        if (items.containsKey("fragments")) {
            if (items.get("fragments") >= 255) {
                System.out.println("Valanyr obtained!");

                items.put("fragments", items.get("fragments") - 250);

                remainingMainItems.put("fragments", items.get("fragments"));
                remainingMainItems.put("motes", items.get("motes"));
                remainingMainItems.put("shards", items.get("shards"));

                if (items.containsKey("shards") && items.containsKey("motes")) {
                    if (remainingMainItems.get("fragments") >= remainingMainItems.get("shards") &&
                            remainingMainItems.get("fragments") >= remainingMainItems.get("motes")) {
                        System.out.println("fragments: " + items.get("fragments"));

                        if (remainingMainItems.get("shards") > remainingMainItems.get("motes")) {
                            System.out.println("shards: " + items.get("shards"));
                            System.out.println("motes: " + items.get("motes"));
                        } else {
                            System.out.println("motes: " + items.get("motes"));
                            System.out.println("shards: " + items.get("shards"));
                        }
                    } else if (remainingMainItems.get("shards") >= remainingMainItems.get("fragments") &&
                            remainingMainItems.get("shards") >= remainingMainItems.get("motes")) {
                        System.out.println("shards: " + items.get("shards"));

                        if (remainingMainItems.get("fragments") >= remainingMainItems.get("motes")) {
                            System.out.println("fragments: " + items.get("fragments"));
                            System.out.println("motes: " + items.get("motes"));
                        } else {
                            System.out.println("motes: " + items.get("motes"));
                            System.out.println("fragments: " + items.get("fragments"));
                        }
                    } else if (remainingMainItems.get("motes") >= remainingMainItems.get("fragments") &&
                            remainingMainItems.get("motes") >= remainingMainItems.get("shards")) {
                        System.out.println("motes: " + items.get("motes"));

                        if (remainingMainItems.get("shards") > remainingMainItems.get("fragments")) {
                            System.out.println("shards: " + items.get("shards"));
                            System.out.println("fragments: " + items.get("fragments"));
                        } else {
                            System.out.println("fragments: " + items.get("fragments"));
                            System.out.println("shards: " + items.get("shards"));
                        }
                    }
                }

                   /* for (Map.Entry<String, Integer> entry : remainingMainItems.entrySet()) {
                    String key = entry.getKey();
                    Object value = entry.getValue();

                    System.out.printf("%s: %s\n", key, value);
                }*/
            }
        } else if (items.containsKey("motes")) {

            if (items.get("motes") >= 255) {
                System.out.println("Dragonwrath obtained!");

                items.put("motes", items.get("motes") - 250);

                remainingMainItems.put("fragments", items.get("fragments"));
                remainingMainItems.put("motes", items.get("motes"));
                remainingMainItems.put("shards", items.get("shards"));

                if (items.containsKey("fragments") && items.containsKey("shards")) {
                    if (remainingMainItems.get("fragments") >= remainingMainItems.get("shards") &&
                            remainingMainItems.get("fragments") >= remainingMainItems.get("motes")) {
                        System.out.println("fragments: " + items.get("fragments"));

                        if (remainingMainItems.get("shards") > remainingMainItems.get("motes")) {
                            System.out.println("shards: " + items.get("shards"));
                            System.out.println("motes: " + items.get("motes"));
                        } else {
                            System.out.println("motes: " + items.get("motes"));
                            System.out.println("shards: " + items.get("shards"));
                        }
                    } else if (remainingMainItems.get("shards") >= remainingMainItems.get("fragments") &&
                            remainingMainItems.get("shards") >= remainingMainItems.get("motes")) {
                        System.out.println("shards: " + items.get("shards"));

                        if (remainingMainItems.get("fragments") >= remainingMainItems.get("motes")) {
                            System.out.println("fragments: " + items.get("fragments"));
                            System.out.println("motes: " + items.get("motes"));
                        } else {
                            System.out.println("motes: " + items.get("motes"));
                            System.out.println("fragments: " + items.get("fragments"));
                        }
                    } else if (remainingMainItems.get("motes") >= remainingMainItems.get("fragments") &&
                            remainingMainItems.get("motes") >= remainingMainItems.get("shards")) {
                        System.out.println("motes: " + items.get("motes"));

                        if (remainingMainItems.get("shards") > remainingMainItems.get("fragments")) {
                            System.out.println("shards: " + items.get("shards"));
                            System.out.println("fragments: " + items.get("fragments"));
                        } else {
                            System.out.println("fragments: " + items.get("fragments"));
                            System.out.println("shards: " + items.get("shards"));
                        }
                    }
                }
            } else if (items.containsKey("shards")) {
                if (items.get("shards") >= 255) {
                    System.out.println("Shadowmourne obtained!");

                    items.put("shards", items.get("shards") - 250);

                    remainingMainItems.put("fragments", items.get("fragments"));
                    remainingMainItems.put("motes", items.get("motes"));
                    remainingMainItems.put("shards", items.get("shards"));

                    if (items.containsKey("fragments") && items.containsKey("motes")) {
                        if (remainingMainItems.get("fragments") >= remainingMainItems.get("shards") &&
                                remainingMainItems.get("fragments") >= remainingMainItems.get("motes")) {
                            System.out.println("fragments: " + items.get("fragments"));

                            if (remainingMainItems.get("shards") > remainingMainItems.get("motes")) {
                                System.out.println("shards: " + items.get("shards"));
                                System.out.println("motes: " + items.get("motes"));
                            } else {
                                System.out.println("motes: " + items.get("motes"));
                                System.out.println("shards: " + items.get("shards"));
                            }
                        } else if (remainingMainItems.get("shards") >= remainingMainItems.get("fragments") &&
                                remainingMainItems.get("shards") >= remainingMainItems.get("motes")) {
                            System.out.println("shards: " + items.get("shards"));

                            if (remainingMainItems.get("fragments") >= remainingMainItems.get("motes")) {
                                System.out.println("fragments: " + items.get("fragments"));
                                System.out.println("motes: " + items.get("motes"));
                            } else {
                                System.out.println("motes: " + items.get("motes"));
                                System.out.println("fragments: " + items.get("fragments"));
                            }
                        } else if (remainingMainItems.get("motes") >= remainingMainItems.get("fragments") &&
                                remainingMainItems.get("motes") >= remainingMainItems.get("shards")) {
                            System.out.println("motes: " + items.get("motes"));

                            if (remainingMainItems.get("shards") > remainingMainItems.get("fragments")) {
                                System.out.println("shards: " + items.get("shards"));
                                System.out.println("fragments: " + items.get("fragments"));
                            } else {
                                System.out.println("fragments: " + items.get("fragments"));
                                System.out.println("shards: " + items.get("shards"));
                            }
                        }
                    }
                }
            }
        }

        /*for (Map.Entry<String, Integer> entry : items.entrySet()) {
            String key = entry.getKey();
            Object value = entry.getValue();

            System.out.printf("%s - %s\n", key, value);
        }*/

        items.remove("motes");
        items.remove("shards");
        items.remove("fragments");

        for (Map.Entry<String, Integer> entry : items.entrySet()) {
            String key = entry.getKey();
            Integer value = entry.getValue();

            System.out.printf("%s: %s\n", key, value);
        }
    }


    public static LinkedHashMap sortHashMapByValuesD(HashMap passedMap) {
        List mapKeys = new ArrayList(passedMap.keySet());
        List mapValues = new ArrayList(passedMap.values());
        Collections.sort(mapValues);
        Collections.sort(mapKeys);

        LinkedHashMap sortedMap = new LinkedHashMap();

        Iterator valueIt = mapValues.iterator();
        while (valueIt.hasNext()) {
            Object val = valueIt.next();
            Iterator keyIt = mapKeys.iterator();

            while (keyIt.hasNext()) {
                Object key = keyIt.next();
                String comp1 = passedMap.get(key).toString();
                String comp2 = val.toString();

                if (comp1.equals(comp2)){
                    passedMap.remove(key);
                    mapKeys.remove(key);
                    sortedMap.put((String)key, (Integer)val);
                    break;
                }
            }
        }
        return sortedMap;
    }

}
