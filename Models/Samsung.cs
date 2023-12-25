
namespace projeto.Models
{
    public class Samsung : Smartphone
    {
        public Samsung(string numero, string modelo, string imei, int memoria) 
            : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp}!");
        }
    }
}