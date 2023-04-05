class Program
{
    static void Main(string[] args)
    {
        Console.Write("Uzunluk: ");
        int kenaruzunluğu = int.Parse(Console.ReadLine());
        Console.Write("Bir harf giriniz: ");
        string harf = Console.ReadLine();
        
        int ortanokta = kenaruzunluğu - 1;
        int taban = kenaruzunluğu * 2 - 1;

        for (int i = 0; i < taban; i++)
        {
            for (int j = 0; j < taban; j++)
            {
                if ((i + j == ortanokta || j - i == ortanokta))
                    {
                        Console.Write(harf);
                    }
                    else if ((i + j >= ortanokta && j - i <= ortanokta))
                    {
                        Console.Write("*");
                    }
                    else if (i == ortanokta)
                        Console.Write("*");
                    else
                        Console.Write(" ");
            }
            Console.WriteLine();
            
        }
        Console.ReadKey();
    }
}