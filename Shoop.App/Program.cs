using Shoop.Service.Impimentations;

ProductService productService = new ProductService();


productService.ShowMenu();
string request = Console.ReadLine();
while (request != "0")
{
    switch (request)
    {
        case "1":
            productService.CreateProduct();
            break;
        case "2":
            productService.ShowProduct();
            break;
        default:
            Console.WriteLine("please add valid option");
            break;
    }
    productService.ShowMenu();
    request = Console.ReadLine();
}

