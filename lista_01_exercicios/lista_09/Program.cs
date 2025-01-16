/* 
Ex.09 - Dia da semana (usando if-else)

 
Objetivo: Pratique o uso de várias condições com if, else if e else. 
Descrição: Desenvolva um programa que solicite um número de 1 a 7 e exiba o dia da semana correspondente (1 para "domingo", 2 para "segunda-feira", etc.). Se o número estiver fora desse intervalo, exiba uma mensagem de erro. 
Exemplo de saída: "Domingo", "Segunda-feira", etc., ou "Número inválido. Digite um número de 1 a 7."
 */

using System.ComponentModel.Design;

Console.WriteLine(" Digite um numero de 1 a 7");
int dia  = int.Parse(Console.ReadLine());

if (dia == 1) 
{
    Console.WriteLine("Domingo");
}
else if (dia == 2) 
{
    Console.WriteLine("Segunda-Feira");
}
else if (dia == 3) 
{
    Console.WriteLine("Terça-Feira");
}
else if (dia == 4)
{
    Console.WriteLine("Quarta-Feira");
}
else if (dia == 5)
{
    Console.WriteLine("Quinta-Feira");
}
else if (dia == 6)
{
    Console.WriteLine("Sexta-Feira");
}
else if (dia == 7)
{
    Console.WriteLine("Sabado-Feira");
}


