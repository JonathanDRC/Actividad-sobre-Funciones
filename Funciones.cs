using System;

namespace clases
{
    class Program
    {
        
        static void Main(string[] args)
        {
            double pi = 3.14;
            while (true)
            {
               string str = new string('*', 50);
                Console.WriteLine(str);
                
                Console.WriteLine(" PROGRAMA PARA GEOMETRIA ");

               
                Console.WriteLine(str);

                Console.WriteLine("¿Qué area desea Calcular?: {0}  (c) Circulo{0}  (r) Rectángulo{0}  (t) triángulo{0}  (s) Salir{0}",Environment.NewLine);


                string opcion = Console.ReadLine();


                if (opcion == "s"){

                    break;

                }

               else if( opcion == "c"){

                    Circulo(pi);
                    
                    
                }

               else if( opcion == "r"){

                    Rectangulo (pi);

                    
                }

                else {

                    Triangulo();
                    
                }
                

                
                
            }
        }
    
        public static void Circulo (double pi){

             Console.WriteLine("Ingrese Radio:");

                    double vradio = Convert.ToSingle(Console.ReadLine());

                    double resultado = pi * (vradio * vradio);

                    Console.WriteLine("resultado es: "+ resultado);



        }



        public static void Rectangulo(double pi){

          Console.WriteLine("Ingrese base:");

                    double vbase = Convert.ToSingle(Console.ReadLine());

                    Console.WriteLine("Ingrese la Altura:");

                    double valtura = Convert.ToSingle(Console.ReadLine());

                    double resultado = pi * (vbase *valtura);

                    Console.WriteLine("resultado es: "+ resultado);      



        }

        public static void Triangulo(){


            Console.WriteLine("Ingrese base:");

                    double vbase = Convert.ToSingle(Console.ReadLine());

                    Console.WriteLine("Ingrese la Altura:");

                    double valtura = Convert.ToSingle(Console.ReadLine());

                    double resultado = (vbase *valtura)/2;

                    Console.WriteLine("resultado es: "+ resultado);

        }


    }


    
}
