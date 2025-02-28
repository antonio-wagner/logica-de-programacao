String cpf; 
do
{
    Console.WriteLine("Digite seu números do seu CPF.");
    String cpf = Console.ReadLine();

}while(cpf.Length != 11);

Console.WriteLine("Escreva seu cpf");
String cpf = Console.ReadLine();


Char[] cpf2 = new Char[14];

for (int i = 0, j = 0; i < cpf.Length; i++, j++)
{
    if(i == 3 || i == 6)
    {
        cpf2[j] = '.';
        j++;
    }
    if (i == 9)
    {
        cpf2[j] = '-';
        j++;
    }
    cpf2[j] = Convert.ToChar(cpf[i]);

}
Console.WriteLine(cpf2);
//Esceva a segunda string.
