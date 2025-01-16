/*
Ex.07 - Comparação de Números


o Objetivo: Praticar a comparação entre variáveis.
o Descrição: Escreva um programa que solicita dois números ao usuário e 
determina qual deles é maior. Utilize if, else if e else para exibir a mensagem 
adequada.
o Exemplo de Saída: "O primeiro número é maior.", "O segundo número é 
maior." ou "Os números são iguais
 */
Console.WriteLine("Digite o primeiro numero");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite 0 segundo numero");
int num2 = int.Parse(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine("O primeiro numero é maior");
}
else if (num1 < num2)
{
    Console.WriteLine("o segundo numero é maior");
}
else
    Console.WriteLine("os numeros são iguais");

