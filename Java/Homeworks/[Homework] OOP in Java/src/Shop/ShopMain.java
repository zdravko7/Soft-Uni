package Shop;

import Shop.Products.*;

import java.util.ArrayList;
import java.util.List;

public class ShopMain {

    public static void main(String[] args) {

        Product bread = new FoodProduct("bread", 1.0, 500, AgeType.NONE);
        Product lenovoPC = new Computer("Lenovo", 700.0, 10, AgeType.TEENAGER);
        Product washingMachine = new Appliance("Samsung", 1000.0, 5, AgeType.TEENAGER);
        Product alcohol = new FoodProduct("Johny", 20.0, 30, AgeType.ADULT);
        FoodProduct cigars = new FoodProduct("420 Blaze it fgt", 6.90, 1400, AgeType.ADULT);
        Customer pecata = new Customer("Pecata", 17, 30.00);

        List<Product> products = new ArrayList<>();
        products.add(bread);
        products.add(lenovoPC);
        products.add(washingMachine);
        products.add(alcohol);
        products.add(cigars);

        List<Product> adultProducts = new ArrayList<>();
        adultProducts.add(alcohol);
        adultProducts.add(cigars);
        adultProducts
                .stream()
                .sorted((p1,p2) -> Double.compare(p1.getPrice(), p2.getPrice()));

        adultProducts.forEach(p -> System.out.println(p));

        try {
            PurchaseManager.processPurchase(pecata, cigars);
        }
        catch (Exception e) { System.out.println(e.getMessage()); }

        Customer gopeto = new Customer("Gopeto", 18, 0.44);

        try {
            PurchaseManager.processPurchase(gopeto, cigars);
        }
        catch (Exception e) { System.out.println(e.getMessage()); }



    }
}
