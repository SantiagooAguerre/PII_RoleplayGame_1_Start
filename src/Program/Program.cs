
namespace roleplay
{
    class Program
    {
        static void Main(string[] args)
        {
            Elfo elfo = new Elfo("Link");
            Enano enano = new Enano("Darunia");
            Mago mago = new Mago("Zelda");
            
            Item espada = Item.MasterSword;
            Item escudo = Item.EscudoHyliano;
            Item botas = Item.BotasDeHierro;
            Item tunica = Item.TunicaZora;

            elfo.AgregarItem(espada);
            elfo.AgregarItem(escudo);

            enano.AgregarItem(botas);
            enano.AgregarItem(tunica);

            mago.AgregarItem(tunica);
            mago.AgregarHabilidad(Habilidades.Agi);
            mago.AgregarHabilidad(Habilidades.Ziodyne);
            mago.Estudio(20);

            Console.WriteLine("Ataques y habilidades:");

            int ataqueElfo = elfo.Atacar(item: espada);
            enano.Defender(ataqueElfo, elfo.Nombre);
            
            int ataqueEnano = enano.Atacar();
            mago.Defender(ataqueEnano, enano.Nombre);

            Habilidades habilidades = Habilidades.Ziodyne;
            int ataqueMago = mago.Atacar(habilidades: habilidades);
            elfo.Defender(ataqueMago, mago.Nombre);

            elfo.Curacion(30);
        }
    }
}