using SistemaPedido.Entities;
using SistemaPedido.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace SistemaPedido
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("     ###### Order Product #####          ");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Enter cliente data: ");
            Console.Write("Name Client: ");
            string nameCli = Console.ReadLine();
            Console.Write("Birth Date: (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Client clients = new Client(nameCli, birthDate, email);
            Console.Write("Status order: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine()); //Convertendo um status que veio de uma classe Enum.

            Order order = new Order(DateTime.Now, status, clients); //adicionando a data, o status eo cliente no pedido
            Console.WriteLine();


            Console.Write("How many items to this order? "); //Adicionando o na lista de pedido os pedidos que foram cadastrados.
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Enter {i} item data: ");
                Console.Write("Product Name: ");
                string name = Console.ReadLine();
                Console.Write("Product Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Product product = new Product(name, price); //passando um construtor com dois argumentos
                Console.Write("Quantity product: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantity, price, product); // passando um construtor com 2 argumentos e um objeto

                order.AddItem(orderItem);

            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);









        }
    }
}
