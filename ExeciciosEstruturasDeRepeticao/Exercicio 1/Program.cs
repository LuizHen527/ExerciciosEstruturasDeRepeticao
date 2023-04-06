// - Insira uma nota de 0 a 10:
// - while ((nota < 0) && (nota > 10))
// 	- Insira uma nota valida, entre 0 e 10:
// 	- cr
// - if ((nota => 0) && (nota <= 10))
// - Nota recebida

Console.WriteLine($"Insira uma nota de 0 a 10:");
int nota = int.Parse(Console.ReadLine());

while ((nota < 0) || (nota > 10))
{
    Console.WriteLine($"Insira uma nota valida, entre 0 e 10:");
    nota = int.Parse(Console.ReadLine());
}

if ((nota >= 0) && (nota <= 10))
{
    Console.WriteLine($"Nota recebida");
}

