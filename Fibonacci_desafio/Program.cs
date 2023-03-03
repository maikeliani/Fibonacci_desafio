internal class Program
{
    private static void Main(string[] args)
    {
        double anterior = 0, posicao, atual = 1;
        Console.WriteLine(" Informe ate qual posição da sequencia deseja ver: ");
        posicao = int.Parse(Console.ReadLine());

        do
        {
            Console.Write(atual + " ");
            atual = atual + anterior;
            anterior = atual - anterior;
        
        } while (atual <= posicao);

    }
}