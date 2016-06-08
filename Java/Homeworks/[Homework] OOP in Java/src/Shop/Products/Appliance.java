package Shop.Products;

import Shop.AgeType;

public class Appliance extends ElectronicsProduct {

    public Appliance(String name, Double price, int quantity, AgeType ageRestriction) {
        super(name, price, quantity, ageRestriction);
        this.setGuaranteePeriod(6);
    }

    @Override
    public Double getPrice() {
        if (super.getQuantity() < 50) {
            return super.getPrice() * 1.05;
        } else {
            return super.getPrice();
        }
    }
}
