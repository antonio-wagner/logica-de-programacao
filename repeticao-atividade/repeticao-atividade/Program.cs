Console.Write("Digite o número: ");
int inicio = int.Parse(Console.ReadLine());
Console.Write("Digite a razão: ");
int razao = int.Parse(Console.ReadLine());
Console.Write("Digite a quantidade de números: ");
int quantidade = int.Parse(Console.ReadLine());

for (int i = 0; i < quantidade; i++)
{
    Console.Write(inicio + " ");
    inicio += razao;
}