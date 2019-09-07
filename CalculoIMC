using System;
class MainClass {
  public static void Main (string[] args) {
    string nome;
    double peso;
    double altura;
    double imc;
    Console.WriteLine ("Digite seu nome: ");
    nome= Console.ReadLine();
    Console.WriteLine ("Digite seu peso: ");
    peso= double.Parse(Console.ReadLine());
    Console.WriteLine ("Digite sua altura: ");
    altura= double.Parse(Console.ReadLine());
    imc= peso/(altura*altura);
      if(imc<18.5){
        Console.WriteLine ("***************************");
        Console.WriteLine ("Seu IMC é: "+ imc);
        Console.WriteLine (nome+" VOCÊ ESTÁ ABAIXO DO PESO");
      }
      if(imc>=18.5 && imc<24.9){
        Console.WriteLine ("***************************");
        Console.WriteLine (" Seu IMC é: "+ imc);
        Console.WriteLine (nome+ " VOCÊ ESTÁ NO PESO IDEAL,PARABÊNS!!");
      }
      if(imc>=25 && imc<29.9){
        Console.WriteLine ("***************************");
        Console.WriteLine (" Seu IMC é: "+ imc);
        Console.WriteLine (nome+ ", VOCÊ ESTÁ LEVEMENTE ACIMA DO PESO");
      }
      if(imc>=30 && imc<34.9){
        Console.WriteLine ("***************************");
        Console.WriteLine (" Seu IMC é: "+ imc);
        Console.WriteLine (nome+ " VOCÊ ESTÁ COM OBESIDADE GRAU 1");
      }
      if(imc>=35 && imc<39.9){
        Console.WriteLine ("***************************");
        Console.WriteLine (" Seu IMC é: "+ imc);
        Console.WriteLine (nome+ " VOCÊ ESTÁ COM OBESIDADE GRAU 2 (Severa)");
      }
      if(imc>=40){
      Console.WriteLine ("***************************");
        Console.WriteLine (" Seu IMC é: "+ imc);
        Console.WriteLine (nome+ " VOCÊ ESTÁ COM OBESIDADE GRAU 3 (Mórbida), CUIDADO!!! ");
      }
  }
}
