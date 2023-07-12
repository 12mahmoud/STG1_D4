namespace STG1_D4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array");
            int size=int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Read(arr);
            Console.WriteLine("Before swap");
            Print(arr);
            try {
                Console.WriteLine("Enter first index to swap ");
                int i1=int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second index to swap ");
                int i2=int.Parse(Console.ReadLine());
                swap(arr, i1, i2);
                Console.WriteLine("After swap");
                Print(arr);
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            


        }
        static void Read(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($" Enter value{i + 1} ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static void Print(int[] a) {
            
            for(int i=0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
        static void swap(int[] a,int i1,int i2) {
            int temp = a[i1];
            a[i1] = a[i2];
            a[i2] = temp;

        }
            
        
    }
}