using System;
using System.Collections.Generic;
using System.Globalization;
using Atividade_Herança_Polimorfismo.Entitis;


namespace Atividade_Herança_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com a quantidade de funcionarios");
            int func = int.Parse(Console.ReadLine());

            List<Funcionarios> list = new List<Funcionarios>();

            for (int i = 1; i <= func; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"funcionario #{i}.");
                Console.Write("este funcionarios é tercerizado?(s/n): ");
                char opcao = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Hora: ");
                double hora = double.Parse(Console.ReadLine());
                Console.Write("Valor hora: ");
                double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                if (opcao == 's')
                {
                    Console.WriteLine("Adicionar bonus: ");
                    double bonus = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Funcionarios_Tercerizados(nome, hora, valorHora, bonus));

                }
                else
                {
                    list.Add(new Funcionarios(nome, hora, valorHora));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Pagamentos: ");
            foreach (Funcionarios emp in list)
            {
                Console.WriteLine(emp.Nome + "-$ " + emp.Pagamento().ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
