class Jogo
{
    public void rodarIssoAqui()
    {

        Random aleatorio = new Random();
        int valor = aleatorio.Next(1, 10);

        do
        {
            Console.WriteLine("Digite um número entre 1 e 10: ");
            int chute = int.Parse(Console.ReadLine()!);

            if (chute == valor)
            {
                Console.WriteLine("Parabéns! Você acertou o número.");
                break;
            }
            else if (chute < valor)
            {
                Console.WriteLine("O número é maior.");
            }
            else
            {
                Console.WriteLine("O número é menor.");
            }
        } while (true);

        Console.WriteLine("O jogo acabou. Você acertou o número secreto!");
    }
}