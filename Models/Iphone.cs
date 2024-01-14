namespace DesafioPOO.Models
{}

// Implementado!!!!!
public class Iphone

// Herdar da classe "Smartphone"
public class Iphone : Smartphone
    
    
 // TODO: Sobrescrever o método "InstalarAplicativo
 public Iphone(string numero, string, modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
 {

 }
 // Subscrever o método "InstalarAplicativo"
 public override void InstalarAplicativo (string nomeApp)
 {
  Console.WriteLine($"Instalando o aplicativo {nomeApp}");
 }



 