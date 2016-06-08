package Shop;

import Shop.Exceptions.AgeRestrictedException;
import Shop.Exceptions.NoMoneyException;
import Shop.Exceptions.NoQuantityException;
import Shop.Products.Customer;
import Shop.Products.Product;

public final class PurchaseManager {

    public static void processPurchase(Customer customer, Product product) throws NoMoneyException, NoQuantityException, AgeRestrictedException {

        if (customer.getBalance() < product.getPrice()) {
            throw new NoMoneyException("Shop.Products.Customer has insufficient money");
        }

        if (product.getQuantity() < 1) {
            throw new NoQuantityException("Shop.Products.Product is not in stock");
        }

        if (product.getAgeRestriction() == AgeType.ADULT && customer.getAge() < 18) {
            throw new AgeRestrictedException("Shop.Products.Customer does not meet the age restrictions of the product");
        }

        if (product.getAgeRestriction() == AgeType.TEENAGER && customer.getAge() < 13) {
            throw new AgeRestrictedException("Shop.Products.Customer does not meet the age restrictions of the product");
        }

        customer.setBalance(customer.getBalance() - product.getPrice());
        product.setQuantity(product.getQuantity() - 1);
    }
}
