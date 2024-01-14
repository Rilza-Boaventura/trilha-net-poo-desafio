namespace DesafioPOO.Models
{
    // Implementado!!!!!!!
    public class Nokia : Smartphone
   
   
}
    // TODO: Sobrescrever o método "InstalarAplicativo"
     public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria);
   {
       
   } 
   
     // Sobrescrever o metado "InstalarAplicativo"
    public override void InstalarAplicativo(string nomeApp)
{
    Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia.");
}         
         
