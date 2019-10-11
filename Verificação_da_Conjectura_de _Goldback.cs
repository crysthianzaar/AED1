using System;
namespace Goldbach_Conjectura
{
    /// Calcula todos os primos menor que N e tenta expressar N como uma soma de dois números primos
    /// A conjecture de Goldbach afirma que isto é sempre possível se N é par e maior que dois
    /// Quando N for impar ele é chamado de um primo par
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  ****** Verificação da Conjectura de Goldback  - CSharp *****\n ");
            while (true)
            {
                //o primeiro número que atende o critério definido
                int N = 4;
                int resto;
                Console.WriteLine("Digite um número inteiro PAR :");   // Prompt
                Console.WriteLine("Ou digite 'sair':");
                string numero = Console.ReadLine();                           // Pega a entrada do usuário
                if (numero == "sair")                                                  // verifica se quer sair
                {
                    break;
                }
                else
                {
                    //converte a entrada em um número inteiro
                    try 
                    {
                        N = Convert.ToInt32(numero);
                        //Sai se digitar um número impar 
                        //resto = (N % 2 );
                        //if ( resto != 0 )
                        //{
                        //    break;
                        //}
                    }
                    catch
                    {
                        break;
                    }
                }
                Boolean[] EPrimo = new Boolean[N];
                for (int i = 2; i < N; i++)
                    EPrimo[i] = true;
                // determina os primos < N usando o algoritimo de Crivo de Eratosthenes
                for (int i = 2; i * i < N; i++)
                {
                    if (EPrimo[i])
                    {
                        for (int j = i; i * j < N; j++)
                            EPrimo[i * j] = false;
                    }
                }
                // conta os primos
                int primos = 0;
                for (int i = 2; i < N; i++)
                {
                    if (EPrimo[i])
                    {
                        primos++;
                    }
                }
                Console.WriteLine("----------------------------------------------");
                // armazena os primos em uma lista
                int[] list = new int[primos];
                int n = 0;
                for (int i = 0; i < N; i++)
                {
                    if (EPrimo[i])
                    {
                        list[n++] = i;
                    }
                }
                // verifica se o numero N pode ser expresso como soma de dois primos
                int left = 0, right = primos - 1;
                while (left <= right)
                {
                    if (list[left] + list[right] == N)
                        break;
                    else if
                        (list[left] + list[right] < N) left++;
                    else
                        right--;
                }
                if (list[left] + list[right] == N)
                {
                    Console.WriteLine(N + " = " + list[left] + " + " + list[right]);
                    Console.WriteLine("----------------------------------------------");
                }
                else
                {
                    Console.WriteLine(N + " não pode ser expresso como soma de dois números primos");
                }
            }
        }
    }
}
