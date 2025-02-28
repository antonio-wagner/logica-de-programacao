//Ler uma palavra que será advinhada
Console.WriteLine("Digite a palavra pra ser advinhada: ");
String palavra = Console.ReadLine();
//Criar um vetor de Char do tamanho da palavra
Char[] palavra2 = new char[palavra.Length];
//Inserir o símbolo _ no 2o vetor
for (int i = 0; i < palavra2.Length; i++)
{
    palavra2[i] = '-';

}
//Criar variável tentativas com o valor 5
int tentativas = 5;
//Criar estrutura de repetição que repetirá enquanto a pessoa não acertar ou as tentativas acabarem
bool achou = false;
for( ;palavra != new String(palavra2) () && tentativas > 0;)
{
    Console.WriteLine(palavra2);
    Console.WriteLine(tentativas);
    Console.WriteLine("Escreva uma letra");
 

    String letra = Console.ReadLine();
    for (int i = 0; i < palavra.Length; i++)
    {
        if (letra[0] == palavra[i])
        {
            palavra2[i] = letra[0];
            achou = true;
        }
    }
    if(achou == false)
    {
        tentativas--;
        
    }
}
if(tentativas > 0)
{
    Console.WriteLine("Parabéns");
}
else
{
    Console.WriteLine("Você perdeu.");
}
//Ler um letra
//Verificar se a palavra contêm a letra
//Se sim, preencher o 20 vetor
//Se não, diminuir o número de tentativas
//Depois da estrutura de verificar se a pessoa ganhou