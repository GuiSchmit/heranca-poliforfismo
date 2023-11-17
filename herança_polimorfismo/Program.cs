using System;
using System.Collections.Generic;
using System.Globalization;
using herança_polimorfismo.Entities;

//Inicia a lista
List<Product> list = new List<Product>();

//Coleta o dado para controle de repetições
Console.Write("Enter the number of products: ");
int x = int.Parse(Console.ReadLine());

//Preenchimento da lista
for (int i = 0; i < x; i++)
{
    Console.WriteLine($"Product #{i+1} data:");

    Console.Write("Common, used or imported (c/u/i)? ");
    char ch = char.Parse(Console.ReadLine());

   
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Price: ");
        double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    //Testa o tipo de produto
    if (ch == 'c')
    {
        Product p = new Product(name, price);

        list.Add(p);
    }
    else if (ch == 'u')
    {
        Console.Write("Manufacture data (DD/MM/YYYY): ");
        string date = Console.ReadLine();

        UsedProduct p = new UsedProduct(name, price, date);

        list.Add(p);
    }
    else
    {
        Console.Write("Customs fee: ");
        double customsFee = double.Parse(Console.ReadLine());

        ImportedProduct p = new ImportedProduct(name, price, customsFee);

        list.Add(p);
    }

}

//Exibição dos dados coletados
Console.WriteLine("");
foreach (Product p in list)
{
    Console.WriteLine(p.priceTag());
}

