using InventoryType;

namespace Inventory;

public class Product
{
  public string Name { get; set; }
  public decimal Price { get; set; }
  public ProductType ProductType { get; set; }

  public int ProductTypeId  { get; set; }
  
} //close Product Class
