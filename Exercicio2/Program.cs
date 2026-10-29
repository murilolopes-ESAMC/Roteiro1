using Exercicio2;

Console.WriteLine("--- Exercício 02: Fantasminhas do PAC-MAN ---");

Fantasma blinky = new Fantasma();
blinky.Nick = "Blinky";
blinky.Cor = "Vermelho";
blinky.Habilidade = "Persegue o PAC-MAN diretamente";

Fantasma pinky = new Fantasma();
pinky.Nick = "Pinky";
pinky.Cor = "Rosa";
pinky.Habilidade = "Tenta emboscar à frente do PAC-MAN";

blinky.GerarFantasma();
pinky.GerarFantasma();

Console.WriteLine();

blinky.Mover("cima");
pinky.Mover("esquerda");
