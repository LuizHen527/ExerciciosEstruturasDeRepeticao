// - Insira nome de usuario
// - Insira a senha
// - while (nome == senha)
// 	- A o nome de usuario e a senha sao iguais.
// 	  Insira novamente um nome de usuario:
// 	- Insira uma senha:
// - Usuario e senha recebidos

Console.WriteLine($"Insira um nome de usuario:");
string nome = Console.ReadLine();

Console.WriteLine($"Insira uma senha:");
string senha = Console.ReadLine();

while (nome == senha)
{
    Console.WriteLine(@$"O nome e a senha sao iguais.
    Insira novamente um nome de usuario:");
    nome = Console.ReadLine();
    
    Console.WriteLine($"Insira uma senha:");
    senha = Console.ReadLine();
}

Console.WriteLine($"Usuario e senha recebidos");
