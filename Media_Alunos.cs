//Fazer um programa em C# para ler notas de 10 alunos. Ler 2 notas para cada um deles e calcular a média aritmética das notas. 
//Contar quantos alunos estão com a média acima de 5.0. Se nenhum aluno tirou nota acima de 5.0, imprimir mensagem: Não há nenhum aluno com nota acima de 5.
// Não utilizar vetores.
using System;

class MainClass {
  public static void Main (string[] args) {
    int num=0;
    double n1;
    double n2;
    double media;
    double mediafinal=0;
    int cont=0;
    while(num<10){
    Console.WriteLine ("Digite a nota 1:");
    n1= double.Parse(Console.ReadLine());
    Console.WriteLine ("Digite a nota 2:");
    n2= double.Parse(Console.ReadLine());
    media= (n1+n2)/2;
    mediafinal= mediafinal+media;
    if(media>5){
      cont = cont+1;
    }
    num=num+1;
    }
    Console.WriteLine ("*************************************");
    if(cont==0){
    Console.WriteLine ("Não há nenhum aluno com nota acima de 5.");
    }
    if(cont!=0){
    Console.WriteLine ("Tem "+cont+ " alunos acima da média.");
    }
    Console.WriteLine ("A média das notas foi: "+mediafinal/num);
    
  }
}
