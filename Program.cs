internal class program
{
    private static void Main(string[] args)
    {
        float num1, num2, divisão;
        
        Console.Write("Digite um numero: ");
        num1 = float.Parse(Console.ReadLine());
        Console.Write("Digite outro numero: ");
        num2 = float.Parse(Console.ReadLine());

        divisão = num1 / num2;

        Console.Write($"A divisão dos 2 numeros é: {divisão}");


    }
}

