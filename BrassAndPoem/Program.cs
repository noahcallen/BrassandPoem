//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.


//create a "productTypes" variable here with a List of ProductTypes, and add "Brass" and "Poem" types to the List. 

//put your greeting here

//implement your loop here

using Inventory;
using InventoryType;
using System;



int userChoice = 0;

List<Product> products = new List<Product>
{
    new Product {Name = "Trumpet", Price = 200.99M, ProductType = new ProductType {Name = "Brass", Id = 1}},
    new Product {Name = "Tuba", Price = 400.99M, ProductType = new ProductType {Name = "Brass", Id = 1}},
    new Product {Name = "Horn", Price = 300.99M, ProductType = new ProductType {Name = "Brass", Id = 1,}},
    new Product {Name = "Flower", Price = 20.99M, ProductType = new ProductType {Name = "Poem", Id = 2}},
    new Product {Name = "Dark", Price = 10.99M, ProductType = new ProductType {Name = "Poem", Id = 2}}
};

void DisplayMenu()
{
    Console.WriteLine("Welcome To Brass & Poem!");
    Console.WriteLine("=============Main Menu=============");
    Console.WriteLine(" 1. Display All Products \n 2. Delete a Product \n 3. Add a Product \n 4. Update a Product \n 5. Quit");
    Console.WriteLine("===================================");
    

    Console.Write("Enter a Number 1-5: ");
    userChoice = int.Parse(Console.ReadLine());
}

do
{
    switch (userChoice)
    {
        case 1:
        Console.WriteLine("");
        break;

        case 2:
        Console.WriteLine("");
        break;

        case 3:
        Console.WriteLine("");
        break;

        case 4: 
        Console.WriteLine("");
        break;
    }
} while (userChoice != 5);


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
