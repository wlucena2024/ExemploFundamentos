using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models
{
    public class Calculadora
    {  
       public void Somar (int x, int y)
       {
            Console.WriteLine($"O Resultado de {x} + {y} = {x + y}");
       } 

       public void Subtrair (int x, int y)
       {
            Console.WriteLine($"O Resultado de {x} - {y} = {x - y}");
       } 

       public void Multiplicar (int x, int y)
       {
            Console.WriteLine($"O Resultado de {x} * {y} = {x * y}");
       } 

       public void Dividir (int x, int y)
       {
            if(x == 0 || y == 0 )
            {
                Console.WriteLine("Impossível Dividir por Zero, operação Cancelada");
                Environment.Exit(0);
            }
            else 
            {
                Console.WriteLine($"O Resultado de {x} / {y} = {x / y}");
            }
       } 

       public void Potencia(int x, int y)
       {
            double potencia = Math.Pow(x,y);
            Console.WriteLine($"O resultado de {x}^{y} = {potencia}");
       }

       public void Seno(double angulo)
       {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);

            Console.WriteLine($"Seno de {angulo}° = {Math.Round(seno,2)}");
       }

       public void Coseno(double angulo)
       {
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);

            Console.WriteLine($"Seno de {angulo}° = {Math.Round(coseno,2)}");
       }

       public void Tangente(double angulo)
       {
            double radiano = angulo * Math.PI / 180;
            double tan = Math.Tan(radiano);

            Console.WriteLine($"Seno de {angulo}° = {Math.Round(tan,2)}");
       }

       public void RaizQuadrada(double x)
       {
           double raiz = Math.Sqrt(x);
           Console.WriteLine($"Raiz quadrada de {x} = {Math.Round(raiz,2)}");
       }
    }
}