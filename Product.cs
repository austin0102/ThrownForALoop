public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public bool Sold { get; set; }
    public DateTime StockDate { get; set; }
    public int ManufactureYear { get; set; }
    public double Condition { get; set; }
}

// decimal deals with moneys and interests while double all other decimal numbers
// int is whole numbers