using System;

class Assistente : Imposto
{
public override void ValeAlimentacao (double salario)
{
    Console.WriteLine ("Desconto Assistente do vale alimentação "+(salario * 0.12));

}
}
