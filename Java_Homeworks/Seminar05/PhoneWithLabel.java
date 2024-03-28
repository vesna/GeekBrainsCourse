package Java_Homeworks.Seminar05;

public class PhoneWithLabel {
    private String label;
    private Integer phone;
	public PhoneWithLabel(String label, Integer phone) {
		this.label = label;
		this.phone = phone;
	}
	@Override
	public String toString() {
		return "PhoneWithLabel [label=" + label + ", phone=" + phone + "]";
	}
	public String getLabel() {
		return label;
	}
	public Integer getPhone() {
		return phone;
	}

    
}
