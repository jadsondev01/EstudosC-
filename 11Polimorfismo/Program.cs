using System;

class Program
{
    static void Main(string[] args)
{   
  //instanciar estagiario 
  Imposto objetoE = new Imposto ();
  objetoE.ValeAlimentacao (1000);
  objetoE.ValeTransporte (1000);
  Console.WriteLine("*-----------------*");


  // Instanciar Gerente

  Imposto objetoG = new Gerente ();
  objetoG.ValeAlimentacao  (5000);
  objetoG.ValeTransporte  (5000);
  Console.WriteLine("*-----------------*");

   //insatanciar Assistente

  Imposto objetoA =  new Assistente ();
  objetoA.ValeAlimentacao (2000);
  objetoA.ValeTransporte (2000);
  Console.WriteLine("*-----------------*");

}
}