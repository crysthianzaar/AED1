using System;
using System.IO;

class calculadora {
private double soma2;
private double subtrai2;
private double multiplica2;
private double divide2;

 public void Setsoma2(){
   Console.WriteLine("Digite o primeiro número: ");
   double num1 = double.Parse(Console.ReadLine());
   Console.WriteLine("Digite o segundo número: ");
   double num2 = double.Parse(Console.ReadLine());
   soma2 = num1+num2;
   Console.WriteLine("O RESULTADO DA SOMA É: "+ soma2);
 }

 public void Setsubtrai2(){
   Console.WriteLine("Digite o primeiro número: ");
   double num1 = double.Parse(Console.ReadLine());
   Console.WriteLine("Digite o segundo número: ");
   double num2 = double.Parse(Console.ReadLine());
   subtrai2 = num1-num2;
   Console.WriteLine("O RESULTADO DA SUBTRAÇÃO É: "+ subtrai2);
 }

 public void SetMultiplica2(){
   Console.WriteLine("Digite o primeiro número: ");
   double num1 = double.Parse(Console.ReadLine());
   Console.WriteLine("Digite o segundo número: ");
   double num2 = double.Parse(Console.ReadLine());
   multiplica2 = num1*num2;
   Console.WriteLine("O RESULTADO DA Multiplicação É: "+ multiplica2);
 }
 public void SetDivide2(){
   Console.WriteLine("Digite o primeiro número: ");
   double num1 = double.Parse(Console.ReadLine());
   Console.WriteLine("Digite o segundo número: ");
   double num2 =double.Parse(Console.ReadLine());
   divide2 = num1/num2;
   Console.WriteLine("O RESULTADO DA DIVISÃO É: "+ divide2);
 }






}