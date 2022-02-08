namespace challenge_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = new int[4];

            for(int i = 0; i < values.Length; i++)
            {
                values[i] = int.Parse(Console.ReadLine());
            }

            int A = values[0];
            int B = values[1];
            int C = values[2];
            int D = values[3];

            if(B > C && D > A && (C + D) > (A + B) && C > 0 && D > 0 && A % 2 == 0)
            {
                System.Console.WriteLine("Valores Aceitos");
            }
            else
            {
                System.Console.WriteLine("Valores não aceitos");
            }

        }
    }
}