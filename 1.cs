            int a, n, sp = 0, bn = 0;
            Console.WriteLine("Enter n: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter numbers:");
            for (int i = 0; i < n; i++)
            {
                a = Convert.ToInt32(Console.ReadLine());
                if (a % 2 == 0)
                {
                    sp += a;
                }
                else
                {
                    bn++;
                }

            }
            Console.WriteLine("Sum of even numbers: {0}\nNumber of uneven numbers: {1}",sp,bn);
            Console.ReadKey();
