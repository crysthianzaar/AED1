using System;

class MainClass {
  public static void Main (string[] args) {
    int num;
    
    Console.WriteLine ("Quantos numeros?");
    num = int.Parse(Console.ReadLine());
    calculadora.instancia(num);
    //OPCAO1
    for (int x=0;x<num;x++){
      calculadora.numeros[x] = double.Parse(Console.ReadLine());
    }
   //OPCAO2
    Console.WriteLine ("Qual operacao?");
    string op = Console.ReadLine();
    if(op=="+"){
      Console.WriteLine(calculadora.soma());
    }
     if(op=="/"){
       try{
          Console.WriteLine(calculadora.dividir());
       }
       catch(DivideByZeroException e){
         Console.WriteLine(e.Message);
       }
        
      } 
      //OPCAO 3
      Console.WriteLine("DIGITE UMA POSICAO DO VETOR:");
      int pos = int.Parse(Console.ReadLine());
      //TODO
      Console.WriteLine(calculadora.numeros[pos]);
  }

}