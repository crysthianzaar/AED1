//Faça um Programa que pergunte quanto você ganha por hora e o número de horas trabalhadas no mês. Calcule e mostre o total do seu salário no referido mês, sabendo-se que são descontados 11% para o Imposto de Renda, 8% para o INSS e 5% para o sindicato, faça um programa que nos dê:
//salário bruto.
//quanto pagou ao INSS.
//quanto pagou ao sindicato.
//o salário líquido.
//calcule os descontos e o salário líquido, conforme a tabela abaixo:
//+ Salário Bruto : R$
//- IR (11%) : R$
//- INSS (8%) : R$
//- Sindicato ( 5%) : R$
//= Salário Liquido : R$
//Obs.: Salário Bruto - Descontos = Salário Líquido.
using System;
class MainClass {
  public static void Main (string[] args) {
    double trab_hora;
    double qtd_hora;
    double salario;
    double IR;
    double INSS;
    double sindicato;
    double salarioliquido;
    Console.WriteLine ("Quanto você ganha por hora? ");
    trab_hora = double.Parse(Console.ReadLine());
    Console.WriteLine ("Quantas horas você trabalha por mês? ");
    qtd_hora=double.Parse(Console.ReadLine());
    salario= trab_hora*qtd_hora;
    IR=salario*0.11;
    INSS=salario*0.08;
    sindicato=salario*0.05;
    salarioliquido=salario - (IR+INSS+sindicato);
    Console.WriteLine ("************************************");
    Console.WriteLine ("*Salario Bruto: R$"+ salario);
    Console.WriteLine ("*IR (11%): R$"+ IR);
    Console.WriteLine ("*INSS (8%): R$"+ INSS);
    Console.WriteLine ("*Sindicato (5%): R$"+sindicato);
    Console.WriteLine ("__________________________ ");
    Console.WriteLine ("Salario Liquido: R$"+ salarioliquido);
  }
}
