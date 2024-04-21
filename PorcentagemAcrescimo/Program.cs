float wage = 0, wageWhithIncrease = 0, increases = 0;

Console.WriteLine("Cálculo da porcentagem de acrescimo.\n");

do
{
    Console.Write("Digite o valor atual do seu salário: ");
    wage = float.Parse(Console.ReadLine());

    if (wage < 0)
    {
        Console.WriteLine("\nO salário deve ser um valor positivo.\n");
    }
} while (wage < 0);


do
{
    Console.Write("Digite o valor do seu salário com acrescimos: ");
    wageWhithIncrease = float.Parse(Console.ReadLine());

    if (wageWhithIncrease < wage)
    {
        Console.WriteLine("\nO salário com acrescimos deve ser maior que o salário sem acrescimos, tente novamente.\n");
    }
} while (wageWhithIncrease < wage);

increases = (wageWhithIncrease - wage) * 100 / wage;

Console.WriteLine($"\nOs acrescimos foram de {increases}%");

// Interação final
Console.ReadKey();