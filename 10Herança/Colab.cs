using System;

class Colab : Pessoa 
{

    //atributos

    private double salario;

   //construtor

   public Colab (string nome,int idade,double salario)
   {
    this.nome = nome;
    this.idade = idade;
    this.salario = salario;

    mensagemPessoa();
    mensagemcolab();
 
   }
   
   //metodo

    private void mensagemcolab()
    {

        Console.WriteLine ("Salario " + salario);
    }

}
