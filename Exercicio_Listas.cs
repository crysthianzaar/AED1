//Faça um Programa que leia 20 números inteiros e armazene-os num vetor. Armazene os números pares no vetor PAR e os números IMPARES no vetor impar. Imprima os três vetores.
using System;
class MainClass {
  public static void Main (string[] args) {
    int[] vetor= new int[20];
    int[] vetorPar= new int[20];
    int[] vetorImpar= new int[20];
    int j=0;
    int k=0;
      for(int i=0;i<20;i++){
      Console.WriteLine ("Digite um número: ");
      vetor[i]=int.Parse(Console.ReadLine());
        if(vetor[i]%2 == 0){
        vetorPar[j]=vetor[i];
        j= j+1;
        }
        if(vetor[i]%2 != 0){
        vetorImpar[k]=vetor[i];
        k= k+1;
        }
      }
      Console.WriteLine ("Os números são: ");
      for(int o=0;o<20;o++){
      Console.Write ( vetor[o]+" ");
      }
      Console.WriteLine ();
      Console.WriteLine ("Os números PARES são: ");
      for(int a=0;a<j;a++ ){
      Console.Write ( vetorPar[a]+" ");
      }
      Console.WriteLine ();
      Console.WriteLine ("Os números IMPARES são: ");
      for(int b=0;b<k;b++){
      Console.Write ( vetorImpar[b]+" ");
      }


  }
}
