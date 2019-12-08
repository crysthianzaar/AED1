using System;

class MainClass {
  public static void Main (string[] args) {
    double termo1=0;
    double termo2=1;
    double termof;
    for(int i=0;i<1000;i++){
      termof= termo1+termo2;
      termo1=termo2;
      termo2=termof;
      Console.WriteLine (termof);
    }
    
  }
}
