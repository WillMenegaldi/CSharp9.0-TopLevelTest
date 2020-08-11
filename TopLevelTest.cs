using System;

Console.Write("Entre com um número: ");

var valor = new Random().Next(-5, 16);

var mensagem = valor switch
{
    <= 0 => "Menor ou igual a 0!",
    > 0 and <= 10 => "Entre 0 e 10!",
    _ => "Maior do que 10!"
};

Console.WriteLine($"Número: {valor}\nMensagem: {mensagem}");