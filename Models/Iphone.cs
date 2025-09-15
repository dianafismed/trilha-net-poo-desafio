namespace DesafioPOO.Models
{
    public class Iphone : Smartphone

    {
        // Construtor
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // Implementação do método abstrato
        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando o aplicativo {nome} no Iphone");
        }
    }
}