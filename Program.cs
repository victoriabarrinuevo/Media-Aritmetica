Console.WriteLine("|Média Aritmética:|");
double numero1, numero2, numero3, média; 

Console.WriteLine("Digite seu primeiro número: ");
numero1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite seu segundo número: ");
numero2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite seu terceiro número: ");
numero3 = Convert.ToDouble(Console.ReadLine());

média = (numero1 + numero2 + numero3) /3;

Console.WriteLine($"A sua média é igual à: {média:N2}");


