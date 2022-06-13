using System;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------ CÁLCULO DO SALÁRIO -------");

            Console.WriteLine("Digite o número de horas trabalhadas: ");
            double numeroHoras = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Valor salário-hora: ");
            double salarioHora = Convert.ToInt32(Console.ReadLine());

            double salario = numeroHoras * salarioHora;

            Console.WriteLine("O salário do funcionário é: R$ " + (salario));
        }
    }
}
