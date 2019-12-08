static void Main(string[] args)
{
    // carregando dados hipotéticos, para fins didáticos apenas
    double[] xValues = { 5.1, 5.5, 5.9, 6.5, 6.8, 7.6, 8.3, 8.5, 9.1, 9.5 };  // horas de estudo
    double[] yValues = { 2.0, 2.9, 4.0, 5.9, 6.0, 6.9, 8.0, 9.0, 9.9, 11.0 }; // pontuaçao alcançada

    // encontrando a média do valor das variáveis independentes (eixo x) e dependentes (eixo y)
    double xMedia = 0;
    double yMedia = 0;
    for (int index = 0; index < xValues.Length; index++)
    {
        xMedia += xValues[index];
        yMedia += yValues[index];
    }
    xMedia = xMedia / xValues.Length;
    yMedia = yMedia / yValues.Length;


    // codificando a fórmula para calcular a inclinação
    double dividendo = 0; 
    double divisor = 0; 
    for (int index = 0; index < xValues.Length; index++)
    {
        // a soma do produto da dispersão das variáveis independentes e dependentes = distâncias entre cada um dos valores e o valor médio daquele eixo = covariância de x e y
        dividendo += (xValues[index] - xMedia) * (yValues[index] - yMedia);
        // a soma do quadrado da dispersão das variáveis independentes (do eixo x)
        divisor += Math.Pow(xValues[index] - xMedia, 2);
    }
    // encontrando a inclinação
    double a = dividendo / divisor;

    // codificando a fórmula para encontrar o ponto onde a linha de tendência intercepta o eixo y
    // a média das variáveis dependentes, subtraido o produto da inclinação com a média das variáveis independentes
    double b = yMedia - a * xMedia;

    // imprimindo os valores
    Console.WriteLine("Implementando fórmula manualmente no C#");
    Console.WriteLine("y = ax + b");
    Console.WriteLine("a = {0} = a inclinação da linha de tendência.", Math.Round(a, 2));
    Console.WriteLine("b = {0} = o ponto onde a linha de tendência atinge o eixo y.", Math.Round(b, 2));
}
