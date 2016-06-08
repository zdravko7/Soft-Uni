package Shop.Products;

import Shop.AgeType;

public class Computer extends ElectronicsProduct {

    public Computer(String name, Double price, int quantity, AgeType ageRestriction) {
        super(name,price,quantity,ageRestriction);
        this.setGuaranteePeriod(24);
    }

    @Override
    public Double getPrice() {

        if (super.getQuantity() > 1000) {
            return super.getPrice() * 0.95;
        } else {
            return super.getPrice();
        }
    }
}
