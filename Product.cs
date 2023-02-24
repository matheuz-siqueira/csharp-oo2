namespace csharp_oo2;

public class Product
{
    public string Name;
    public double Price;
    public int Quantity; 

    public double StockValue(){
        return Price * Quantity;
    }

    public void Amount(int quantity){
        Quantity += quantity; 
    }
    public void Remove(int quantity){
        Quantity -= quantity; 
    }

    public override string ToString()
    {
        return Name 
        + " | " 
        + Price.ToString("C") 
        + " | " + Quantity + " unidades | " 
        + "Total: "+ StockValue().ToString("C");
    }
}
