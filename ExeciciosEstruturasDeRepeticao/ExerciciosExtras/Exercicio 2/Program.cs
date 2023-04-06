// - For (pessoas = 1; pessoas <= 10; pessoas++)
// 	- Insira seu sexo ('f' para feminino e 'm' para masculino):
// 		- if (sexo == 'f')
// 			- mulher++
// 		- else
// 			- homem++
// 	- Insira sua idade:
// 		- if (sexo == 'm')
// 			- idadeHomem++
// 		- else
// 			- idadeMulher++
// 	- Insira seu peso: (NAO E UTILIZADO)

int mulher = 0;
int homem = 0;
int idadeHomem = 0;
int idadeMulher = 0;

for (int pessoas = 1; pessoas <= 10; pessoas++)
{
    Console.WriteLine($"Insira seu sexo ('f' para feminino e 'm' para masculino):");
    char sexo = char.Parse(Console.ReadLine().ToLower());
    
    if (sexo == 'f')
        mulher++;
    
    else
        homem++;

    Console.WriteLine($"Insira sua idade:");
    int idade = int.Parse(Console.ReadLine());

    if (sexo == 'm')
 		idadeHomem++;
 	else
 		idadeMulher++;
}

double mediaHomem = idadeHomem/homem;
double mediaMulher = idadeMulher/mulher;
mediaHomem = 0.00;
mediaMulher = 0.00; 

Console.WriteLine($"Total de homens: {homem}");
Console.WriteLine($"Total de mulheres: {mulher}");
Console.WriteLine($"Media de idade dos homens: {0:N2}", mediaHomem);
Console.WriteLine($"Media de idade das mulheres: {0:N2}", mediaMulher);


