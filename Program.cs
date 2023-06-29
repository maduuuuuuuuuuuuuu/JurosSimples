double capital;
double taxa;
double meses;
double juros;
double montante;

    Console.WriteLine("");
    Console.WriteLine("descubra o valor dos seus juros");
    Console.WriteLine("e de sua montante aqui!");
    Console.WriteLine("");
    Console.WriteLine("digite seu capital (C)");
         capital = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("digite a taxa de juros sem o");
    Console.WriteLine("símbolo %");
         taxa = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("digite o total de meses");

         meses = Convert.ToDouble(Console.ReadLine());
   
        juros = capital * (taxa / 100) * meses;
        montante = capital + juros;

    Console.WriteLine("");
    Console.WriteLine($"seu juros é de {juros} reais");
    Console.WriteLine("");
    Console.WriteLine($"sua montamte é de {montante} reais");
   

