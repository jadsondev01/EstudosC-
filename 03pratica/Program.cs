using System;

namespace _03pratica
{
    class Program
{
    static void Main(string[] args)
    {
        Aluno a = new Aluno();

        // Exemplo de inicialização de valores
        a.nome = "João";
        a.nota1 = 8.5;
        a.nota2 = 6.7;

        a.Mensagem();
    }
}
}