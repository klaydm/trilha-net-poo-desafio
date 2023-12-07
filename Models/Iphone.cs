namespace DesafioPOO.Models
{
    // Feat: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    { 
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }
        // Feat: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o app {nomeApp} no Iphone");
        }
    }
}