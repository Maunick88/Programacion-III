using System;
using System.Collections.Generic;
using System.Text;
namespace Figuras
{
    class Circulo
    {
        
        float radio;
        public Circulo()
        {
        }
        public Circulo(float radio)
        {
            this.Radio = radio;
        }
        public float Radio { get => radio; set => radio = value; }
        public float area()
        {
            return (float)(Math.PI * Math.Pow(this.radio, 2));

        }
        public float perimetro()
        {
            return (float)(2 * Math.PI * this.radio);
        }
        public float diametro()
        {
            return (float)(this.radio*2);
        }
        //4/3 * π* r3
        public float volumen()
        {
            return (float)(4/3* Math.PI * Math.Pow(this.radio, 3));
        }

        class Program
        {
            static void Main(string[] args)
            {
                int op;

                Console.WriteLine("Diagrama de Entrada y salida");
                Console.WriteLine("Este programa calcula el área, circunferencia, diámetro y volumen.");
                Console.WriteLine("Ingresa el radio del circulo");
                Circulo cir = new Circulo();
                cir.Radio = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Que opcion desea realizar?");
                Console.WriteLine("1)Area del circulo");
                Console.WriteLine("2)Circunferencia");
                Console.WriteLine("3)Diametro");
                Console.WriteLine("4)Volumen de la esfera");
                Console.WriteLine("5)Salir");
                Console.WriteLine("Digite su eleccion: ");
                op = Convert.ToInt32(Console.ReadLine());

                
                switch (op)
                {
                    case 1:
                        Console.WriteLine("1)Area del circulo");
                        Console.WriteLine("El área del Circulo es: " + cir.area());
                        break;
                    case 2:
                        Console.WriteLine("2)Circunferencia");
                        Console.WriteLine("El perímetro del circulo es: " + cir.perimetro());
                        break;
                    case 3:
                        Console.WriteLine("3)Diametro");
                        Console.WriteLine("El diametro del Circulo es: " + cir.diametro());
                        break;
                    case 4:
                        Console.WriteLine("4)Volumen de la esfera");
                        Console.WriteLine("El volumen del Circulo es: " + cir.volumen());
                        break;
                    case 5:
                        
                        break;
                }
                

               // Console.WriteLine("El área del Circulo es: " + cir.area());
                //Console.WriteLine("El perímetro del circulo es: " + cir.perimetro());
                Console.ReadKey();
            }
        }
    }
}