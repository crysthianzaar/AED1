using System;
using System.IO;

class calculadora {
private double soma2;
private double subtrai2;
private double multiplica2;
private double divide2;

 public void Setsoma2(){
   Console.WriteLine("Digite o primeiro n�mero: ");
   double num1 = double.Parse(Console.ReadLine());
   Console.WriteLine("Digite o segundo n�mero: ");
   double num2 = double.Parse(Console.ReadLine());
   soma2 = num1+num2;
   Console.WriteLine("O RESULTADO DA SOMA �: "+ soma2);
 }

 public void Setsubtrai2(){
   Console.WriteLine("Digite o primeiro n�mero: ");
   double num1 = double.Parse(Console.ReadLine());
   Console.WriteLine("Digite o segundo n�mero: ");
   double num2 = double.Parse(Console.ReadLine());
   subtrai2 = num1-num2;
   Console.WriteLine("O RESULTADO DA SUBTRA��O �: "+ subtrai2);
 }

 public void SetMultiplica2(){
   Console.WriteLine("Digite o primeiro n�mero: ");
   double num1 = double.Parse(Console.ReadLine());
   Console.WriteLine("Digite o segundo n�mero: ");
   double num2 = double.Parse(Console.ReadLine());
   multiplica2 = num1*num2;
   Console.WriteLine("O RESULTADO DA Multiplica��o �: "+ multiplica2);
 }
 public void SetDivide2(){
   Console.WriteLine("Digite o primeiro n�mero: ");
   double num1 = double.Parse(Console.ReadLine());
   Console.WriteLine("Digite o segundo n�mero: ");
   double num2 =double.Parse(Console.ReadLine());
   divide2 = num1/num2;
   Console.WriteLine("O RESULTADO DA DIVIS�O �: "+ divide2);
 }






}