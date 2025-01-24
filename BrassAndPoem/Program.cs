using System.Data.Common;
using Inventory;
using InventoryType;

int userChoice = 0;

// create a "productTypes" variable here with a List of ProductTypes, 
    // and add "Brass" and "Poem" types to the List.
    List<ProductType> productTypes = new List<ProductType>
    {
        new ProductType { Id = 1, Name = "Brass" },
        new ProductType { Id = 2, Name = "Poem" }
    };

    // create a "products" variable here to include at least five Product instances. 
    // Give them appropriate ProductTypeIds by referencing the "productTypes" list.
    List<Product> products = new List<Product>
    {
        new Product { Name = "Trumpet", Price = 200.99M, ProductType = productTypes[0], ProductTypeId = 987 },
        new Product { Name = "Tuba", Price = 400.99M, ProductType = productTypes[0], ProductTypeId = 568 },
        new Product { Name = "Horn", Price = 300.99M, ProductType = productTypes[0], ProductTypeId = 345 },
        new Product { Name = "Flower", Price = 20.99M, ProductType = productTypes[1], ProductTypeId = 456 },
        new Product { Name = "Dark", Price = 10.99M, ProductType = productTypes[1], ProductTypeId = 567 }
    };

void DisplayMenu()
{
    // Console.WriteLine("Welcome To Brass & Poem!");
    Console.WriteLine("=============Main Menu=============");
    Console.WriteLine(" 1. Display All Products \n 2. Delete a Product \n 3. Add a Product \n 4. Update a Product \n 5. Quit");
    Console.WriteLine("===================================");
    

    Console.Write("Enter a Number 1-5: ");
    userChoice = int.Parse(Console.ReadLine());
}

DisplayMenu();

do
{
    switch (userChoice)
    {
        case 1:
        DisplayAllProducts(products, productTypes);
        DisplayMenu();
        break;

        case 2:
        DeleteProduct(products, productTypes);
        DisplayMenu();
        break;

        case 3:
        AddProduct(products, productTypes);
        DisplayMenu();
        break;

        case 4: 
        Console.WriteLine("");
        DisplayMenu();
        break;
    }
} while (userChoice != 5);


void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
{
    Console.WriteLine("Products:" );

    foreach (var product in products)
    {
        
        Console.WriteLine($"- {product.Name}");

    }//close for loop

} // Close Display All Products

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    Console.WriteLine("Which Product would you like to delete?");
    foreach (var product in products)
    {
        Console.WriteLine($"- {product.Name} [ID: {product.ProductTypeId}]");
    }//close for loop

    Console.Write("Enter the ProductTypeId Here: ");
    int remove = int.Parse(Console.ReadLine());

    bool item = false;

    for (int i = 0;i<products.Count; i++)
    {
        if (products[i].ProductTypeId.Equals(remove))
        {
            products.RemoveAt(i);
            item = true;
            Console.WriteLine($"{remove} has been removed from the list.");
            break;
        }//close if

    }// close for loop

}// close Delete Product

void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    Console.Write("Enter the Name of the Product: ");
    string name = Console.ReadLine();

    Console.Write("Enter the Price of the Product(x.xx): ");
    decimal price = decimal.Parse(Console.ReadLine());;

    Console.Write("Enter Product Type (Brass = 1|Poem = 2): ");
    int productTypeNew = int.Parse(Console.ReadLine());

    Console.Write("Enter a ProductTypeId(xxx): ");
    int productTypeId = int.Parse(Console.ReadLine());

    string productTypeName;
    int productId;

    if (productTypeNew == 1)
    {
        productTypeName = "Brass";
        productId = 1;
    }
    else
    {
        productTypeName = "Poem";
        productId = 2;
    }

    ProductType productType = new ProductType
    {
        Name = productTypeName,
        Id = productId
    };

    Product newProduct = new Product
    {
        Name = name,
        Price = price,
        ProductType = productType,
        ProductTypeId = productTypeId
    };

    products.Add(newProduct);

    Console.WriteLine("New Product added!");

}//close AddProduct

void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

// don't move or change this!
public partial class Program { }
