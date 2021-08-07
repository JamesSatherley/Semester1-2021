package assignment1;

import java.io.Serial;
import java.io.Serializable; // imports need items
import java.util.Objects;

public class Address implements Serializable {
    @Serial
    private static final long serialVersionUID = 3L; // defines all needed privates, including serial number
    private String town, street, post_code;
    private int house_number;

    public Address(String town, String street, String post_code, int house_number) { // constructor function
        this.town = town;
        this.street = street;
        this.post_code = post_code;
        this.house_number = house_number;
    }

    @Override
    public boolean equals(Object o) { // auto equals definition
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        Address address = (Address) o;
        return house_number == address.house_number && Objects.equals(town, address.town) && Objects.equals(street, address.street) && Objects.equals(post_code, address.post_code);
    }

    @Override // auto hash definition
    public int hashCode() { return Objects.hash(town, street, post_code, house_number); }

    public Address clone(){ // deep clones items from this.address variables to keep memory addresses
        Address clone = new Address(this.town, this.street, this.post_code, this.house_number);
        return clone;
    }

    public String getTown() { return town; }

    public void setTown(String town) { this.town = town; }

    public String getStreet() { return street; }

    public void setStreet(String street) { this.street = street; }

    public String getPost_code() { return post_code; }

    public void setPost_code(String post_code) { this.post_code = post_code; } // setters and getters

    public int getHouse_number() { return house_number; }

    public void setHouse_number(int house_number) { this.house_number = house_number; }
}
