class SpeedInfo
{
    public static void Main(String[] args)
    {
        double speed = double.Parse(Console.ReadLine());
        if (speed <= 30)
        {
            Console.WriteLine("Slow");
        }
        else
            {
                Console.WriteLine("Fast");
            }
        }
    }
