namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria)
        {
           // TODO: Passar os parâmetros do construtor para as propriedades
            base.Numero = numero;
            base.Modelo = modelo;
            base.IMEI = imei;
            base.Memoria = memoria;
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo: {nomeApp} do Iphone!");
        }
    }
}