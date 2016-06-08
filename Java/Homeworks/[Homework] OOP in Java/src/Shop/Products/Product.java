package Shop.Products;

import Shop.AgeType;
import Shop.Interfaces.Buyable;

public abstract class Product implements Buyable {

    private String name;
    private Double price;
    private int quantity;
    private AgeType ageRestriction;

    public Product(String name, Double price, int quantity, AgeType ageRestriction) {
        this.setName(name);
        this.setPrice(price);
        this.setQuantity(quantity);
        this.setAgeRestriction(ageRestriction);
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public Double getPrice() {
        return price;
    }

    public void setPrice(Double price) {
        this.price = price;
    }

    public int getQuantity() {
        return quantity;
    }

    public void setQuantity(int quantity) {
        this.quantity = quantity;
    }

    public AgeType getAgeRestriction() {
        return ageRestriction;
    }

    public void setAgeRestriction(AgeType ageRestriction) {
        this.ageRestriction = ageRestriction;
    }

    @Override
    public String toString() {
        return String.format("Shop.Products.Product name: %s, price: %s, quantity: %s, Age restriction: %s",
                this.getName(), this.getPrice(), this.getQuantity(), this.getAgeRestriction());
    }
}
