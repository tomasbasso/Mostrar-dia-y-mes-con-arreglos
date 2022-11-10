using System;

namespace ACT4_
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] meses={"Enero","Febrero","Marzo","Abril","Mayo","Junio","Julio","Agosto","Septiembre","Octubre","Noviembre","Diciembre"};
            int [] dias={31,29,31,30,31,30,31,31,30,31,30,31};
            Console.WriteLine("Por favor ingrese el numero de mes que desea visualizar entre 1 y 12");
            int dia=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Su mes elegido es {0} y tiene {1} dias",meses[dia-1],dias[dia-1]);
        }
    }
}
