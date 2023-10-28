class Mazo
{
    public List<Carta> Cartas {get; }
    
    public Mazo()
    {
        Cartas = new List<Carta>();
        CrearMazo();
    }
    
    private void CrearMazo()
    {
        string[] pintas = {"Tréboles", "Picas", "Corazones", "Diamantes"};
        foreach(string pinta in pintas)
        {
            for(int valor = 1; valor <= 13; valor ++){
                string nombre = ObtNombreCarta(valor);
                Carta nuevaCarta = new Carta(nombre, pinta, valor);
                Cartas.Add(nuevaCarta);
            }
        }
    }

    private string ObtNombreCarta(int valor){
        switch(valor){
            case 1:
                return "As";
            case 11:
                return "J";
            case 12:
                return "Reina";
            case 13:
                return "Rey";
            default:
                return valor.ToString();        
        }

    }

    public void PrintMazo(){
        foreach(Carta carta in Cartas){
            carta.Print();
        }
    }

    public Carta Repartir()
{
    if (Cartas.Count > 0)
    {
        Carta cartaRepartida = Cartas[Cartas.Count - 1];
        Cartas.RemoveAt(Cartas.Count - 1);
        return cartaRepartida;
    }
    else
    {
        Console.WriteLine("El mazo está vacío, no se pueden repartir más cartas.");
        return new Carta("Carta Nula", "Sin Pinta", 0);
    }
}
    public void Reiniciar(){
        Cartas.Clear();
        CrearMazo();
    }

    public void Barajar()
    {
        Random rand = new Random();
        int n = Cartas.Count;
        for (int i = 0; i < n; i++)
        {
            int j = rand.Next(i, n);
            Carta temp = Cartas[i];
            Cartas[i] = Cartas[j];
            Cartas[j] = temp;
        }
    }
}