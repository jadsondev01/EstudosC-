using System;

class Aluno
{
    public string nome;
    public double nota1, nota2;

    // Método para calcular a média
    public double Media()
    {
        return (nota1 + nota2) / 2;
    }

    // Método para determinar a situação do aluno
    public string Situacao(double media)
    {
        return media >= 7 ? "aprovado" : "reprovado";
    }

    // Método para exibir a mensagem
    public void Mensagem()
    {
        double obMedia = Media();
        string obSituacao = Situacao(obMedia);

        Console.WriteLine(nome + " está " + obSituacao + " com média " + obMedia);
    }
}
