using System;

class Gerente : Imposto
{
//metodos

public override void ValeAlimentacao (double salario)
{
    Console.WriteLine ("Desconto Gerente do vale alimentação "+(salario * 0.15));
}
}