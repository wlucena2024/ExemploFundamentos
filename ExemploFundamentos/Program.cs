using ExemploFundamentos.Common.Models;

// Pessoa p = new Pessoa();

// string nomes = {"Janeiro","Fevereiro","Março","Abril","Maio","Junho","Julho","Agosto","Setembro","Outubro","Novembro","Dezembro"}

int[] arrayInteiros = new int[3];

arrayInteiros[0] = 42;
arrayInteiros[1] = 43;
arrayInteiros[2] = 44;

for (int contador = 0; contador < arrayInteiros.Length; contador++)
{
    Console.WriteLine($"Posição no Array N°{contador} - {arrayInteiros[contador]}");
} 
