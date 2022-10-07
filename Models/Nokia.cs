namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }

        public override void InstalarAplicativo(string nomeApp)
        {
            if (Memoria >= 1)
            {
                Memoria -= 1;
                Console.WriteLine($"Instalando o App {nomeApp} no seu celular Nokia {Modelo}");
            }
            else { Console.WriteLine($"Voce não tem espaço para instalar o app {nomeApp}, voce precisa de 1 GB livre e possui livre no momento somente {Memoria} "); }
        }
    }
}