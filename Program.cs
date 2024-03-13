namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee()
            {
                PIP = "PIP",
                Phone = "1234",
                Salary = 123
            };
            Employee employee2 = new Employee()
            {
                PIP = "PIP",
                Phone = "1234",
                Salary = 123
            };
            Employee employee3 = employee + 200;
            Employee employee4 = employee2 - 100;
            City city1 = new City()
            {
                Popular = 12657
            };
            City city2 = new City()
            {
                Popular = 12657
            };
            City city3 = city1 + 200;
            City city4 = city2 - 100;
            CreditСard card1 = new CreditСard()
            {
                CardSum = 500,
                CVC = 123
            };
            CreditСard card2 = new CreditСard()
            {
                CardSum = 500,
                CVC = 123
            };
            CreditСard card3 = card1 + 200;
            CreditСard card4 = card2 - 100;
            Matrix matrix1 = new Matrix(5,6);
            Matrix matrix2 = new Matrix(5,6);
            int whil = 0;
            while (whil <= 0)
            {
                Console.WriteLine("\nChoose Task 1-4 or 5 to exit: ");
                int swh = int.Parse(Console.ReadLine());
                switch (swh)
                {
                    case 1:
                        Console.WriteLine($"{employee3.PIP} - {employee3.Phone} - {employee3.Salary}");
                        Console.WriteLine($"{employee4.PIP} - {employee4.Phone} - {employee4.Salary}");
                        if (employee == employee2)
                        {
                            Console.WriteLine("==");
                        }
                        if (employee != employee2)
                        {
                            Console.WriteLine("!=");
                        }
                        if (employee < employee2)
                        {
                            Console.WriteLine("<");
                        }
                        if (employee > employee2)
                        {
                            Console.WriteLine(">");
                        }
                        break;
                    case 2:
                        Console.WriteLine(" ");
                        break;
                    case 3:
                        Console.WriteLine($"{city3.Popular}");
                        Console.WriteLine($"{city4.Popular}");
                        if (city1 == city2)
                        {
                            Console.WriteLine("==");
                        }
                        if (city1 != city2)
                        {
                            Console.WriteLine("!=");
                        }
                        if (city1 < city2)
                        {
                            Console.WriteLine("<");
                        }
                        if (city1 > city2)
                        {
                            Console.WriteLine(">");
                        }

                        break;
                    case 4:
                        Console.WriteLine($"{card3.CardSum} - {card3.CVC}");
                        Console.WriteLine($"{card4.CardSum} - {card4.CVC}");
                        if (card1 == card2)
                        {
                            Console.WriteLine("==");
                        }
                        if (card1 != card2)
                        {
                            Console.WriteLine("!=");
                        }
                        if (card1 < card2)
                        {
                            Console.WriteLine("<");
                        }
                        if (card1 > card2)
                        {
                            Console.WriteLine(">");
                        }
                        break;
                    case 5:
                        whil = 1;
                        break;
                }
            }
        }
        //Console.WriteLine($"{employee2.PIP} - {employee2.Phone} - {employee2.Salary}");
    }
}
