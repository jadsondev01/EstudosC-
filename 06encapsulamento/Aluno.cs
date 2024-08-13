using System;


class Aluno{

//atributos do aluno
private double nota1, nota2; 

//cauculo de media
private double media (){

    return (nota1+nota2) /2;

    
}
public void mensagem ()
{
    Console.WriteLine("Informa a primeira nota ");
    nota1 = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("Informa a segunda nota ");
    nota2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("A média é "+media());
}
}