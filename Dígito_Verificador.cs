/*Para melhorar a segurança do sistema de informação da UCL vamos criar um dígito verificador para a matrícula de cada aluno. Um dígito verificador é um (às vezes mais de um) dígito que é calculado em função dos dígitos do número principal. Por exemplo, o CPF é formado por 11 dígitos, os últimos 2 são dígitos verificadores que são calculados a partir dos 9 primeiros.
Faça um programa em C# que calcule um dígito verificador para a matrícula de um aluno. O cálculo deve ser realizado da seguinte forma:
Em primeiro lugar deve-se calcular um somatório da seguinte forma: 1º dígito multiplicado por 2 + 2º dígito multiplicado por 3 + 3º dígito multiplicado por 4 + 4º dígito multiplicado por 3 + 5º dígito multiplicado por 2 + 6º dígito + 7º dígito + 8º dígito
Após o somatório deve-se obter o resto da divisão inteira do somatório por 10
O programa deve solicitar ao usuário a entrada do número de matrícula um a um. 
Ao fim da execução o programa deve imprimir a matrícula completa do aluno com o seu dígito verificador. Ex.: 34578123-1
Exemplo de cálculo: seja a matrícula do aluno igual a 34578123, então.
Somatório = 3 x 2 + 4 x 3 + 5 x 4 + 7 x 3 + 8 x 2 +1+2+3 = 6 + 12 + 20 + 21 + 16 + 6 = 81
Dígito = Resto da divisão de 81 por 10 que é igual a 1.
Assim, a matrícula com o dígito verificador seria 34578123-1.
*/
using System;

class MainClass {
  public static void Main (string[] args) {
    int soma =0;
    Console.WriteLine ("***CODIGO DE VALIDAÇÃO DE NÚMERO DE MATRICULA***");
    Console.WriteLine ("Digite o 1º número da matricula: ");
    int n1= int.Parse(Console.ReadLine());
    soma= n1*2;
    Console.WriteLine ("Digite o 2º número da matricula: ");
    int n2= int.Parse(Console.ReadLine());
     soma= soma + n2*3;
    Console.WriteLine ("Digite o 3º número da matricula: ");
    int n3= int.Parse(Console.ReadLine());
    soma= soma + n3*4;
    Console.WriteLine ("Digite o 4º número da matricula: ");
    int n4= int.Parse(Console.ReadLine());
    soma= soma + n4*3;
    Console.WriteLine ("Digite o 5º número da matricula: ");
    int n5= int.Parse(Console.ReadLine());
    soma= soma+ n5*2;
    Console.WriteLine ("Digite o 6º número da matricula: ");
    int n6= int.Parse(Console.ReadLine());
    soma= soma+n6;
    Console.WriteLine ("Digite o 7º número da matricula: ");
    int n7= int.Parse(Console.ReadLine());
    soma= soma+n7;
    Console.WriteLine ("Digite o 8º número da matricula: ");
    int n8= int.Parse(Console.ReadLine());
    soma= soma+n8;
    int digito = soma%10;
    Console.WriteLine ("*************************************************");
    Console.WriteLine ("O número de sua matricula é: "+n1+n2+n3+n4+n5+n6+n7+n8+"-"+digito);


  }
}
