using System;

class Imposto 
{
    // Métodos
    public virtual void ValeAlimentacao(double salario)
    {
        Console.WriteLine("Desconto padrão do vale alimentação: "+(salario * 0.1));
    }

    public virtual void ValeTransporte(double salario) 
    {
        Console.WriteLine("Desconto padrão do vale transporte: "+(salario * 0.06));
    }
}