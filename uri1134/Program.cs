using System;

namespace uri1134
{
    class Program
    {
        static void Main(string[] args)
        {
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;
            
            int codigo = int.Parse(Console.ReadLine());

            while(codigo != 4)
            {
                if(codigo == 1)
                {
                    alcool++;
                }
                else if(codigo == 2)
                {
                    gasolina++;
                }
                else if(codigo == 3)
                {
                    diesel++;
                }
                codigo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Muito obrigado");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}
