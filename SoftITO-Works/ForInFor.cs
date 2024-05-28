namespace SoftITO_Works
{
    internal class ForInFor
    {
        private static void StepsStepsSteps()
        {
            uint steps = 0;
            uint start = 0;
            uint loop = 0;
            string text = "";
            bool isValidInput = false;
            while (!isValidInput)
            {
                try
                {
                    Console.Write("\nTekrar işlemi kaç adım sürmeli? : ");
                    steps = Convert.ToUInt32(Console.ReadLine());

                    if (steps == 0)
                    {
                        Console.WriteLine("Hatalı girdi. Toplam adım 0 olamaz!");
                        continue;
                    }

                    Console.Write("\nTekrar işlemi kaçıncı adımdan başlamalı? : ");
                    start = Convert.ToUInt32(Console.ReadLine());

                    if (start == 0)
                    {
                        Console.WriteLine("Hatalı girdi. Başlanacak adım 0 olamaz!");
                        continue;
                    }

                    if (start > steps)
                    {
                        Console.WriteLine("Hatalı girdi. Başlangıç adımı, toplam adım sayısından fazla olamaz!");
                        continue;
                    }

                    Console.Write("\nTekrar işlemi kaç defa tekrar etmeli? : ");
                    loop = Convert.ToUInt32(Console.ReadLine());

                    if (loop == 0)
                    {
                        Console.WriteLine("Hatalı girdi. Döngü en az 1 kere çalışmalı!");
                        continue;
                    }

                    Console.Write("\nTekrar işleminde ekrana ne yazdırılmalı? : ");
                    text = Console.ReadLine();

                    isValidInput = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Hatalı girdi. Girilen veriler sadece pozitif tamsayılar olmalıdır!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Hatalı girdi. Girilen veriler 1 ve 4,294,967,295 aralığında olmalıdır!");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Beklenmeyen bir hata oluştu! Hata: " + e.Message);
                }
            }

            Console.WriteLine("\n-----------------------------\n");
            for (uint i = 1; i <= loop; i++)
            {
                Console.WriteLine("{0}. Döngü: \n", i);
                for (uint j = start; j <= steps; j++)
                {
                    Console.WriteLine("{0}. Adım, {1}", j, text);
                }
                Console.WriteLine("\n-----------------------------\n");
            }
        }
    }
}
