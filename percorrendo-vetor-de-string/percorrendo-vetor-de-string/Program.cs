//Declarar uma variavél string e inserir uma palavra
Console.WriteLine("Digite uma palavra: ");
string nome = Console.ReadLine();

//Digitar uma letra
Console.WriteLine("Digite uma letra");
String letra = Console.ReadLine();
//Criar uma estrutura de repetição para percorrer o vetor de string
int cont = 0;
for (int i = 0; i < nome.Length; i++)
{
    //Escrever letra por letra da plavra separando por espaço
    //Console.Write(nome[i] + " ");
    if (letra[0] == nome[i])
    {
        //Console.WriteLine("(letra encontrada)");
        cont++;
    }
}
Console.WriteLine("A letra " + letra + " foi econtrada " + cont + " vezes.");

// Digite uma letra

//Verificar se a palavra possui esta letra