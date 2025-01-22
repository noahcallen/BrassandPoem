
//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.

//create a "productTypes" variable here with a List of ProductTypes, and add "Brass" and "Poem" types to the List. 

//put your greeting here

//implement your loop here

using Inventory;
using InventoryType;

namespace Program;

List <Product> products = new List<Product>
{
    new Product {Name = "Trumpet", Price = 200.99M, ProductType = new ProductType{Name = "Brass", Id = 1,}},
    new Product {Name = "Tuba", Price = 400.99M, ProductType = new ProductType{Name = "Brass", Id = 1,}},
    new Product {Name = "Horn", Price = 300.99M, ProductType = new ProductType{Name = "Brass", Id = 1,}},
    new Product {Name = "Flower", Price = 20.99M, ProductType = new ProductType{Name = "Poem", Id = 2,}},
    new Product {Name = "Dark", Price = 10.99M, ProductType = new ProductType{Name = "Poem", Id = 2,}}
};

void DisplayMenu()
{
    throw new NotImplementedException();
}

void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

// don't move or change this!
public partial class Program { }
