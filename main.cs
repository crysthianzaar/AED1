using System;
using System.IO;

class MainClass {
  public static void Main (string[] args) {
    
  calculadora a = new calculadora ();
  Console.WriteLine("ESCOLHA UMA OPÇÃO:");
  Console.WriteLine("1 - SOMA DE 2 NÚMEROS");
  Console.WriteLine("2 - SUBTRAÇÃO DE 2 NÚMEROS");
  Console.WriteLine("3 - MULTIPLICAÇÃO DE 2 NÚMEROS");
  Console.WriteLine("4 - DIVISÃO DE 2 NÚMEROS");
  Console.WriteLine("5 - SAIR DO PROGRAMA");
  string result = Console.ReadLine();
    if(result == "1"){
      a.Setsoma2();
    }
    if(result == "2"){
      a.Setsubtrai2();
    }
    if(result == "3"){
      a.SetMultiplica2();

    }
    if(result == "4"){
      a.SetDivide2();
    }
  
  }
}