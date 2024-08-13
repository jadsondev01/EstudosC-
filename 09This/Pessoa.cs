using System;

class Pessoa
{

// atributo Private

private string nome = "Luciana";

// construtor

public Pessoa (string nome ) 
{
Console.WriteLine (nome);
Console.WriteLine (this.nome);
}
}