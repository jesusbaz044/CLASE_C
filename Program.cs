using System;

namespace tarea
{
    class Program
    {
        static void Main(string[] args)
        {
            float pi = 3.14f;
            while (true){
                System.Console.WriteLine("\n************************");
                System.Console.WriteLine("PROGRAMA PARA GEOMETRIA");
                System.Console.WriteLine("************************");
                System.Console.WriteLine("\nQue desea calcular? \n(c)Ciculo \n(r)Rectangulo \n(t)Triangulo \n(s)Salir \n");
                char opcion = char.Parse(Console.ReadLine());
                if (opcion == 's')
                {
                    break;
                }
                if(opcion == 'c'){
                    System.Console.WriteLine("Ingrese el radio: ");
                    int vradiooo = Int32.Parse(Console.ReadLine());
                    circulo circulo1 = new circulo(vradiooo, pi);
                    System.Console.WriteLine(circulo1.areaCirculo());
                }
                if(opcion == 'r'){
                    System.Console.WriteLine("Ingrese la altura: ");
                    int valturaa = Int32.Parse(Console.ReadLine());
                    System.Console.WriteLine("Ingrese la base: ");
                    int vbasee = Int32.Parse(Console.ReadLine());
                    rectangulo rectangulo1 = new rectangulo(valturaa, vbasee);
                    System.Console.WriteLine(rectangulo1.areaRectangulo());
                }
                if(opcion == 't'){
                    System.Console.WriteLine("Ingrese la altura: ");
                    int valturaa = Int32.Parse(Console.ReadLine());
                    System.Console.WriteLine("Ingrese la base: ");
                    int vbasee = Int32.Parse(Console.ReadLine());
                    triangulo triangulo1 = new triangulo(vbasee, valturaa);
                    System.Console.WriteLine(triangulo1.areaTriangulo());
                }
                else{
                    System.Console.WriteLine("OPCION INCORRECTA!");
                }
            }
        }
    }
    class circulo
    {
        public circulo(int vradiooo, float pii){
            vradio = vradiooo;
            pi = pii;
        }
        public float areaCirculo(){
            float resultado;
            resultado = pi * (vradio * vradio);
            return resultado;
        }
        public int vradio;
        public float pi;
    }
    class rectangulo
    {
        public rectangulo(int valturaa, int vbasee){
            valtura = valturaa;
            vbase = vbasee;
        }
        public float areaRectangulo(){
            float resultado;
            resultado = vbase * valtura;
            return resultado;
        }
        public int valtura;
        public int vbase;
    }
    class triangulo
    {
        public triangulo(int vbasee, int valturaa){
            vbase = vbasee;
            valtura = valturaa;
        }
        public float areaTriangulo(){
            float resultado;
            resultado = (vbase * valtura)/2;
            return resultado;
        }
        public int valtura;
        public int vbase; 
    }
}