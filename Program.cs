using System;
using System.Globalization;
namespace csharp_oo2{
    class Program{
        static void Main(string[] args){
            Product p = new Product();

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            p.Name = Console.ReadLine();
            Console.Write("Preço: ");
            p.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade em estoque: ");
            p.Quantity = int.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do produto: {p}");

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado no estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            p.Amount(qtd);
            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {p}");

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qtd = int.Parse(Console.ReadLine());
            p.Remove(qtd);
            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {p}");

        }
    }
}