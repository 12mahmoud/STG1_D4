namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyMath m1= new MyMath();
            
            while(true)
            {
                Console.WriteLine("Select the operation you want");
                string s = Console.ReadLine();
                if (s == "exit")
                {
                    break;
                }

                else
                {
                    Console.WriteLine("Enter num 1");
                    int n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter num 2");
                    int n2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter num 3");
                    int n3 = int.Parse(Console.ReadLine());
                    
                    switch (s)
                        {
                            case "add":
                                Console.WriteLine($"{n1} " + m1.add(n1));
                                Console.WriteLine($"{n1}+{n2}=  " + m1.add(n1, n2));
                                Console.WriteLine($"{n1}+{n2}+{n3}=  " + m1.add(n1, n2, n3));
                                break;
                            case "substract":
                                Console.WriteLine($"{n1}= " + m1.substract(n1));
                                Console.WriteLine($"{n1}-{n2}=  " + m1.substract(n1, n2));
                                Console.WriteLine($"{n1}-{n2}-{n3}=  " + m1.substract(n1, n2, n3));
                                break;
                            case "multiply":
                                Console.WriteLine($"{n1}" + m1.mul(n1));
                                Console.WriteLine($"{n1}*{n2}= " + m1.mul(n1, n2));
                                Console.WriteLine($"{n1}*{n2}*{n3}= " + m1.mul(n1, n2, n3));
                                break;
                            case "divide":
                                Console.WriteLine($"{n1}= " + m1.div(n1));
                                Console.WriteLine($"{n1}/{n2}= " + m1.div(n1, n2));
                                Console.WriteLine($"{n1}/{n2}/{n3}= " + m1.div(n1, n2, n3));
                                break;
                            case "reminder":
                                Console.WriteLine($"{n1}= " + m1.reminder(n1));
                                Console.WriteLine($"{n1}%{n2}= " + m1.reminder(n1, n2));

                                break;
                            default:
                                Console.WriteLine("NOT avaliable action");
                                break;
                        }
                    
                    
                }
            } 
        }
        
           
        

    }
    class MyMath
    {
        public int add(int x, int y = 0, int z = 0) { return x + y + z; }
        public int substract(int x, int y = 0, int z = 0) { return x - y - z; }
        public int mul(int x, int y = 1, int z = 1) { return x * y * z; }
        public double div(int x, int y = 1,int z=1) { return (double)x / y /z; }
        public int reminder(int x, int y = 1) { return x % y; }
    }
}