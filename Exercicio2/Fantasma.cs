namespace Exercicio2;

public class Fantasma
{
    public string Habilidade = "";
    public string Nick = "";
    public string Cor = "";

    public void GerarFantasma()
    {
        Console.WriteLine($"Fantasma gerado -> Nick: {Nick} | Cor: {Cor} | Habilidade: {Habilidade}");
    }

    public void Mover(string direcao)
    {
        Console.WriteLine($"{Nick} se moveu para {direcao}");
    }
}
