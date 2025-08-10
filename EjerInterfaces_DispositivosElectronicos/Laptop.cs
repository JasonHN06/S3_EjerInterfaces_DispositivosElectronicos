namespace EjerInterfaces_DispositivosElectronicos
{
    public class Laptop
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public bool EstaEncendida { get; set; }
        public int NivelBateria { get; set; }
        public void Encender()
        {
            EstaEncendida = true;
            Console.WriteLine($"La laptop {Marca} {Modelo} está encendida.");
        }

        public void Apagar()
        {
            EstaEncendida = false;
            Console.WriteLine($"La laptop {Marca} {Modelo} está apagada.");
        }

        public void MostrarEstado()
        {
            string estado = EstaEncendida ? "encendida" : "apagada";
            Console.WriteLine($"La laptop {Marca} {Modelo} está {estado} con un nivel de batería del {NivelBateria}%.");
        }
    }
}
