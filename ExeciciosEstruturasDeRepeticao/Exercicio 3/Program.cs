// - Insira um numero:
// - For (multiplicador = 1; multiplicador <= 10; multiplicador++)
// 	- produto = numero * multiplicador;
// 	- Cwl - operacao

Console.WriteLine($"Insira um numero:");
double numero = int.Parse(Console.ReadLine());

for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
{
    double produto = numero * multiplicador;
    Console.WriteLine($"{numero} x {multiplicador} = {produto}");
}