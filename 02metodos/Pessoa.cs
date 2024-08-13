using System;


class Pessoa 

{
    // Método sem parâmetros
    public void Apresentar()
    {
        Console.WriteLine("Olá"); 
    }

    // Método com um parâmetro
    public void Apresentar(string nome)
    {
        Console.WriteLine("Você se chama " + nome);
    }

    // Método com dois parâmetros
    public void Apresentar(string nome, int idade)
    {
        Console.WriteLine("Você se chama " + nome + " e sua idade é " + idade); 
    }




}