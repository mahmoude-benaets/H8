namespace opwarmers
{
    enum SchoolType { BSO, ASO, TSO, KSO }

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] getallen = new int[100];
            for (int i = 0; i < getallen.Length; i++)
            {
                getallen[i] = i + 1;
            }

            for (int i = 0; i < getallen.Length; i++)
            {
                Console.WriteLine(getallen[i]);
            }

            int[] evenGetallen = new int[51];
            for (int i = 0; i < evenGetallen.Length; i++)
            {
                evenGetallen[i] = i * 2;
            }

            for (int i = 0; i < evenGetallen.Length; i++)
            {
                Console.WriteLine(evenGetallen[i]);
            }

            int[] ingevoerdeGetallen = new int[3];
            for (int i = 0; i < ingevoerdeGetallen.Length; i++)
            {
                Console.WriteLine($"Geef getal {i + 1}:");
                ingevoerdeGetallen[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Ingevoerde getallen:");
            for (int i = 0; i < ingevoerdeGetallen.Length; i++)
            {
                Console.WriteLine(ingevoerdeGetallen[i]);
            }

            string[] vrienden = { "Tom", "Olaf", "Bill", "elion" };
            foreach (string n in vrienden) Console.Write(n + ", ");

            bool[] bools2 = new bool[20];
            for (int i = 0; i < bools2.Length; i++)
            {
                bools2[i] = i % 2 == 0;
            }

            for (int i = 0; i < bools2.Length; i++)
            {
                Console.WriteLine(bools2[i]);
            }

            Random r = new Random();
            for (int i = 0; i < bools2.Length; i++)
            {
                bools2[i] = r.Next(0, 2) == 1;
            }

            int positief = 0;
            int negatief = 0;
            for (int i = 0; i < bools2.Length; i++)
            {
                Console.WriteLine(bools2[i]);
                if (bools2[i])
                    positief++;
                else
                    negatief++;
            }

            Console.WriteLine($"Aantal true: {positief}");
            Console.WriteLine($"Aantal false: {negatief}");

            double[] randomGetallen = new double[10];
            for (int i = 0; i < randomGetallen.Length; i++)
            {
                randomGetallen[i] = r.NextDouble() * 10;
            }

            double gemiddelde = 0;
            for (int i = 0; i < randomGetallen.Length; i++)
            {
                gemiddelde += randomGetallen[i];
            }

            Console.WriteLine($"Gemiddelde is {gemiddelde / randomGetallen.Length}");

            SchoolType[] lijst = new SchoolType[20];

            for (int i = 0; i < lijst.Length; i++)
            {
                lijst[i] = (SchoolType)r.Next(0, 4);
            }

            int aantalBSO = 0, aantalASO = 0, aantalTSO = 0, aantalKSO = 0;

            for (int i = 0; i < lijst.Length; i++)
            {
                Console.WriteLine(lijst[i]);
                switch (lijst[i])
                {
                    case SchoolType.BSO:
                        aantalBSO++;
                        break;
                    case SchoolType.ASO:
                        aantalASO++;
                        break;
                    case SchoolType.TSO:
                        aantalTSO++;
                        break;
                    case SchoolType.KSO:
                        aantalKSO++;
                        break;
                }
            }

            Console.WriteLine($"Aantal BSO: {aantalBSO}");
            Console.WriteLine($"Aantal ASO: {aantalASO}");
            Console.WriteLine($"Aantal TSO: {aantalTSO}");
            Console.WriteLine($"Aantal KSO: {aantalKSO}");
        }
    }
}
