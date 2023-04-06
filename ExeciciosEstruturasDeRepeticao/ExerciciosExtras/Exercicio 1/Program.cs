// For (pessoas = 0; pessoas <= 10; pessoas++)
// 	- Insira seu Sexo ('f' para feminino e 'm' para masculino)
// 		- if (sexo == 'f')
// 			- quantidadeMulher++
// 		- else
// 			- quantidadeHomem++
// 	- Insira sua resposta('s' para sim e 'n' para nao)
// 		- if(resposta == 's')
// 			- afirmativo++
// 		- if else((sexo == 'f') && (resposta == 's'))
// 			- int mulheresSim++
// 		- if else((sexo == 'm') && (resposta == 'n'))
// 			- int homensNao++
// 		- else(resposta == 'n')
// 			- negativo++
// -cwl- Numero de pessoas que responderam sim
// -cwl- Numero de pessoas que responderam nao
// -cwl- Numero de mulheres que responderam sim
// -cwl- Numero de homens que reponderam nao (homensNao*10)

int quantidadeMulher = 0;
int quantidadeHomem = 0;
int afirmativo = 0;
int mulheresSim = 0;
int homensNao = 0;
int negativo = 0;

for (int pessoas = 1; pessoas <= 10; pessoas++)
{
    Console.WriteLine($"Insira seu sexo ('f' para feminino e 'm' para masculino):");
    char sexo = char.Parse(Console.ReadLine());

    if(sexo == 'f')
    {
        quantidadeMulher++;
    }
    else
    {
        quantidadeHomem++;
    }

    Console.WriteLine($"Insira sua resposta ('s' para sim e 'n' para nao):");
    char resposta = char.Parse(Console.ReadLine());

    if(resposta == 's')
        afirmativo++;

    else
 		negativo++;

 	if((sexo == 'f') && (resposta == 's'))
 		mulheresSim++;

 	else if((sexo == 'm') && (resposta == 'n'))
    {
        homensNao++;
    }
}

Console.WriteLine($"Numero de pessoas que responderam sim: {afirmativo}");
Console.WriteLine($"Numero de pessoas que responderam nao: {negativo}");
Console.WriteLine($"Numero de mulheres que responderam sim: {mulheresSim}");
Console.WriteLine($"Numero de homens que reponderam nao: {homensNao*10}%");
Console.WriteLine($"Numero de homens analisados: {quantidadeHomem}");




