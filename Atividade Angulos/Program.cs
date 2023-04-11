using System.ComponentModel.Design;
using System.Net;
using System.Xml;

namespace Atividade_Angulos_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dados três valores X, Y, Z, verifiquem se eles podem ser os comprimentos dos lados de um triângulo e se forem escrever uma mensagem informando se é um triângulo eqüilátero, isósceles ou escaleno.

            //O comprimento de um lado do triângulo é sempre menor do que a soma dos outros dois.•Eqüilátero: Todos os lados iguais

            //•Isósceles: Dois lados iguais
            //Escaleno: Todos os lados diferentes

            


       
                Console.Clear();
                   Angulo novoangulo = new Angulo();

                Console.WriteLine("Bem vindo, programa para saber qual a classe do angulo!!!!");
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine();


                Console.WriteLine("Digite o lado A do seu angulo: ");
                novoangulo. ladoa = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();


                Console.WriteLine("Digite o lado B do seu angulo: ");
                novoangulo. ladob = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Digite o lado C do seu angulo: ");
                novoangulo. ladoc = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(novoangulo.Calculo());

                Console.Clear();
                Console.WriteLine();

             


            














            
        }
    }
}