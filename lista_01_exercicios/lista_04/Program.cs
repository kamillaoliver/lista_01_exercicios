﻿/*
Ex.04 - Faixa de valor

 
Objetivo: Familiarizar - se com a verificação de intervalos numéricos. 
Descrição: Crie um programa que verifique se um número inserido pelo usuário está dentro do intervalo de 1 a 100. Use uma condição if para verificar se o número está dentro do intervalo e exiba uma mensagem informando o resultado. 
Exemplo de saída: "O número está entre 1 e 100." ou "O número não está entre 1 e 100."
*/

Console.WriteLine("Digite um número: ");
    int numero = int.Parse(Console.ReadLine());

if (numero >= 1 && numero <= 100)
{
    Console.WriteLine("O numero está entre 1 e 100");
}
else
{
    Console.WriteLine("O número não está entre 1 e 100");
}

        