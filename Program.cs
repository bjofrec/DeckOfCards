// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(){
        Carta miCarta = new Carta("As", "Corazones", 1);
        miCarta.Print();
        Console.WriteLine("---------");
        Console.WriteLine("Las cartas del mazo son: ");
        Mazo miMazo = new Mazo();
        miMazo.PrintMazo();
        Console.WriteLine("--------------------------------------------------------------------------------");
        Console.WriteLine("Baraja Original:");
        miMazo.PrintMazo();

        Carta cartaRepartida = miMazo.Repartir();
        Console.WriteLine("\nCarta Repartida:");
        cartaRepartida.Print();

        Console.WriteLine("\nBaraja Después de Repartir:");
        miMazo.PrintMazo();

        miMazo.Reiniciar();
        Console.WriteLine("\nBaraja Después de Reiniciar:");
        miMazo.PrintMazo();

        miMazo.Barajar();
        Console.WriteLine("\nBaraja Después de Barajar:");
        miMazo.PrintMazo();


        Mazo mazo = new Mazo();
        mazo.Barajar();
        Jugador jugador1 = new Jugador("Jugador 1");

        Console.WriteLine("Robando tres cartas para Jugador 1:");
        for (int i = 0; i < 3; i++)
        {
            Carta cartaRobada = jugador1.Robar(mazo);
            if (cartaRobada != null)
            {
                cartaRobada.Print();
            }
        }

        jugador1.PrintMano();

        Console.WriteLine("\nDescartando la segunda carta de la mano de Jugador 1:");
        Carta cartaDescartada = jugador1.Descartar(1);
        if (cartaDescartada != null)
        {
            cartaDescartada.Print();
        }

        jugador1.PrintMano();
    }
}
