package mikesun.yueyangsun_comp304_002_finaltest;

public class Car {
    int manufacturerID;
    String brandName;
    String model;
    int year;
    double price;

    public Car() {
    }

    public Car(int manufacturerID, String brandName, String model, int year, double price) {
        this.manufacturerID = manufacturerID;
        this.brandName = brandName;
        this.model = model;
        this.year = year;
        this.price = price;
    }

    public int getManufacturerID() {
        return manufacturerID;
    }

    public void setManufacturerID(int manufacturerID) {
        this.manufacturerID = manufacturerID;
    }

    public String getBrandName() {
        return brandName;
    }

    public void setBrandName(String brandName) {
        this.brandName = brandName;
    }

    public String getModel() {
        return model;
    }

    public void setModel(String model) {
        this.model = model;
    }

    public int getYear() {
        return year;
    }

    public void setYear(int year) {
        this.year = year;
    }

    public double getPrice() {
        return price;
    }

    public void setPrice(double price) {
        this.price = price;
    }
}
