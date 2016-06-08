package Shop.Products;

import Shop.AgeType;
import Shop.Interfaces.Expirable;

import java.util.Date;

public class FoodProduct extends Product implements Expirable {

    private Date expirationDate;

    public FoodProduct(String name, Double price, int quantity, AgeType ageRestriction) {
        super(name, price, quantity, ageRestriction);
    }

    @Override
    public Date getExpirationDate() {
        return this.expirationDate;
    }

    public void setExpirationDate(Date expirationDate) {
        this.expirationDate = expirationDate;
    }
}
