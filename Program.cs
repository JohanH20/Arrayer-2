using System;

namespace Arrayer_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] temperatur = { 4.5, 3.2, 6.7, 6.1, 2.1, 1.6, 2.9 };
            double temp = Math.Round(Medelvärde(temperatur),1);
            Console.WriteLine("Medelvärdet är:" + temp);
        }
        static double Medelvärde(double[] t)
        {
            double summa = 0;
            for(int i = 0; i < t.GetLength(0); i++)
                summa += t[i];
            return (summa / t.Length);
        }
    }
}
