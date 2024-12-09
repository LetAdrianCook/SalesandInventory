public class Product
{
    public int ProductID { get; set; }
    public int SupplierID { get; set; }
    public string ProductName { get; set; }
    public string ProductType { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Quantity { get; set; }
    public decimal UnitCost { get; set; }
    public decimal SellingPrice { get; set; }
    public string SupplierName { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime DateUpdated { get; set; }
}

public class OrderItem
{
    public int ProductID { get; set; }        
    public string ProductName { get; set; }      
    public int Quantity { get; set; }           
    public decimal SellingPrice { get; set; }    
    public decimal UnitCost { get; set; }       
    public decimal Profit => SellingPrice - UnitCost; 
    public decimal TotalPrice => Quantity * SellingPrice; 
    public DateTime SoldDate { get; set; }     

 
}