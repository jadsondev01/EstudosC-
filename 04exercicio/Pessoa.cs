using System;

class Pessoa
{
    public double altura, peso;

    // Método para calcular o IMC
    public double Calculo()
    {
        return peso / (altura * altura);
    }

    // Método para determinar a situação com base no IMC
    public string Situacao(double imc)
    {
        string retorno;

        if (imc < 18.5)
        {
            retorno = "Abaixo do peso";
        }
        else if (imc < 25)
        {
            retorno = "Peso normal";
        }
        else if (imc < 30)
        {
            retorno = "Acima do peso";
        }
        else if (imc < 35)
        {
            retorno = "Obesidade I";
        }
        else if (imc < 40)
        {
            retorno = "Obesidade II";
        }
        else
        {
            retorno = "Obesidade III";
        }

        return retorno;
    }
    
    public void Mensagem()
    {
        double obCalculo = Calculo();
        string obSituacao = Situacao(obCalculo);

        Console.WriteLine("Seu IMC é de " + obCalculo);
        Console.WriteLine("Sua situação é " + obSituacao);
    }
}
    