﻿/*
1. ------------------- Супермаркет
   Створити ієрархію класів для продажу товарів Супермаркету
   	Продукт(назва, термін споживання, категорія - молочні. хлібобулочні та ін., ціна, кількість)
   	Товар (назва, категорія - побутова хімія, текстиль та ін., ціна, кількість)
   Створити програму для роботи Супермаркету
   	Додавання продукту(товару) у базу(врахувати, що товар у базі може бути наявний або ні )
   	Збереження бази товарів(у файл)
   	Завантаження бази товарів з файлу
   	Перегляд продуктів(товарів), впорядкованих по категоріях
   	Пошук певного товару(продукту) з видачею інформації про товар(продукт)
   	Видалення певного товару(продукту) з бази
   	Продаж товару(з видачею чеку)
*/

using System.ComponentModel;

Console.WriteLine("------------- Welcome to our Supermarket -------------");
Console.WriteLine("\tMenu:");
Console.WriteLine("1. Add Product");
Console.WriteLine("2. Save to file");
Console.WriteLine("3. Load from file");
Console.WriteLine("4. Show all products");
Console.WriteLine("5. Find product");
Console.WriteLine("6. Delete product");
Console.WriteLine("7. Sell product");

Console.Write("Your choice: ");
int choice = int.Parse(Console.ReadLine());

var product = new Product();

switch (choice)
{
	case 1:
		Console.Write("Enter product name:");
		product.name = Console.ReadLine();
		
		Console.Write("Enter product price:");
		product.price = double.Parse(Console.ReadLine());
		
		Console.Write("Enter product quantity:");
		product.quantity = int.Parse(Console.ReadLine());
		
		Console.Write("Enter product category:");
		product.category = Console.ReadLine();
		
		Console.Write("Enter product expiration date:");
		product.expirationDate = Console.ReadLine();
		
		break;
	case 4:
		Console.WriteLine("------ Product List --------");
		Console.WriteLine($"Name: {product.name}");
		Console.WriteLine($"Price: {product.price}");
		Console.WriteLine($"Quantity: {product.quantity}");
		Console.WriteLine($"Category: {product.category}");
		Console.WriteLine($"Expiration: {product.expirationDate}");
		break;
}

public class Product
{
	public string name;
	public int quantity;
	public double price;
	public string category;
	public string expirationDate;
}