import java.util.*;

public class OfficeStuff {
    public static void main(String[] args) {
        //You are given a sequence of n companies in format |<company> - <amount> - <product>|. Example:
        Scanner input = new Scanner(System.in);
        int length = Integer.parseInt(input.nextLine());

        TreeMap<String, LinkedHashMap<String, Integer>> companies = new TreeMap<String, LinkedHashMap<String, Integer>>();

        for (int i = 0; i < length; i++) {

            String newInfo = input.nextLine();

            String[] splitInfo = newInfo.split(" +|\\||-");

            splitInfo = CleanArray(splitInfo);

            /*for (String element : splitInfo) {
                System.out.println(element);
            }*/

            String company = splitInfo[0];
            String product = splitInfo[2];
            int amount = Integer.parseInt(splitInfo[1]);

            if (companies.containsKey(company)) {

                if (!companies.get(company).containsKey(product)) {

                    companies.get(company).put(product, amount);
                }
                else {
                    companies.get(company).put(product, companies.get(company).get(product) + amount);
                }
            }
            else {
                companies.put(company, new LinkedHashMap<String, Integer>());
                companies.get(company).put(product, amount);
            }
        }

        StringBuilder currentPortfolio = new StringBuilder();

        for ( Map.Entry<String, LinkedHashMap<String,Integer>> company : companies.entrySet() ) {

            LinkedHashMap<String, Integer> products = company.getValue();
            String key = company.getKey();

            currentPortfolio.append(String.format("%s: ", key));

            for ( Map.Entry<String, Integer> product : products.entrySet() ) {

                String productKey = product.getKey();
                int productQuantity = product.getValue();

                currentPortfolio.append(String.format("%s-%s, ", productKey, productQuantity));

            }
            currentPortfolio.deleteCharAt(currentPortfolio.length()-1);
            currentPortfolio.deleteCharAt(currentPortfolio.length()-1);
            currentPortfolio.append("\n");
        }
        System.out.println(currentPortfolio.toString());

    }

    public static String[] CleanArray(final String[] array) {
        List<String> list = new ArrayList<String>(Arrays.asList(array));
        list.removeAll(Collections.singleton(""));
        return list.toArray(new String[list.size()]);
    }

    private static String removeLastChar(String str) {
        return str.substring(0, str.length() - 1);
    }
}
