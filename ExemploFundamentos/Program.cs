using ExemploFundamentos.Common.Models;

List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("MG");
listaString.Add("SC");

for(int contador = 0; contador < listaString.Count(); contador ++){
    Console.WriteLine($"Posição n°{contador} - valor - {listaString[contador]}");
}
