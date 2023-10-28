class Jugador 
{
    public string Nombre {get; }

    public List<Carta> Mano {get;}

    public Jugador(string nombre)
    {
        Nombre = nombre;
        Mano = new List<Carta>(); 
    }

    public Carta Robar(Mazo mazo)
    {
        Carta cartaRobada = mazo.Repartir();
        if(cartaRobada == null){
            Console.WriteLine("El mazo está vacio, no se puede robar mas cartas");
        }
        else{
            Mano.Add(cartaRobada);
        }

        
        return cartaRobada;
    }
    public Carta Descartar(int indice){
        if(indice >= 0 && indice < Mano.Count){
            Carta cartaDescartada = Mano[indice];
            Mano.RemoveAt(indice);
            return cartaDescartada;
        }
        else{
            Console.WriteLine("Indice de descarte no válido");
            return null;
        }
    }

    public void PrintMano(){
        Console.WriteLine($"Mano de {Nombre}");
        foreach(Carta carta in Mano){
            carta.Print();
        }
    }
}