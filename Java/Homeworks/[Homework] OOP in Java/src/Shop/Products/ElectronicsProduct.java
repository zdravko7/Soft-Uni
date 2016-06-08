package Shop.Products;

import Shop.AgeType;

public abstract class ElectronicsProduct extends Product {

    private int guaranteePeriod;

    public ElectronicsProduct(String name, Double price, int quantity, AgeType ageRestriction) {
        super(name,price,quantity,ageRestriction);
    }

    public int getGuaranteePeriod() {
        return guaranteePeriod;
    }

    public void setGuaranteePeriod(int guaranteePeriod) {
        this.guaranteePeriod = guaranteePeriod;
    }
}
