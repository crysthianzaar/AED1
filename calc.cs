using System;

class calculadora{
  public static double[] numeros;

  public static double soma(){
    double res=0;
    for (int i=0;i<numeros.Length;i++){
      res+=numeros[i];
    }
    return res;
  } 
    public static double dividir(){
    double res=numeros[0];
    for (int i=1;i<numeros.Length;i++){
      if(numeros[i]==0){
        throw new DivideByZeroException("NAO DIVIDIRÁS POR ZERO!");
      }
      res/=numeros[i];
    }
    return res;
  }

  public static void instancia(int x){
    numeros = new double[x];
  }

}