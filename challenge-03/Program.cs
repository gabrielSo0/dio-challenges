using System.Globalization;

namespace challenge_03
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] values = new double[4];

            for(var i = 0; i < values.Length; i++)
            {
                values[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double n1 = values[0];
            double n2 = values[1];
            double n3 = values[2];
            double n4 = values[3];

            double avg = ((n1 * 2) + (n2 * 3) + (n3 * 4) + (n4 * 1)) / (1 + 2 + 3 + 4);

            System.Console.WriteLine($"Media: {avg.ToString("F1")}");

            if(avg >= 7.0)
            {
                System.Console.WriteLine("Aluno aprovado");
            }
            
            if(avg < 5.0)
            {
                System.Console.WriteLine("Aluno reprovado");
            }

            if(avg >= 5.0 && avg <= 6.9)
            {
                System.Console.WriteLine("Aluno em exame!");

                double exame = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                System.Console.WriteLine($"Nota do exame: {exame}");

                avg = (exame + avg) / 2;

                if(avg >= 5.0)
                {
                    System.Console.WriteLine("Aluno aprovado");
                }
                
                if(avg <= 4.9)
                {
                    System.Console.WriteLine("Aluno reprovado");
                }

                System.Console.WriteLine($"Media final: {avg.ToString("F1")}");
            }


        }
    }
}