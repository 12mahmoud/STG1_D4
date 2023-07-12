namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Console.WriteLine("Enter student information");
            read(student);
            Console.WriteLine(student.PrintAsString());
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Enter number of students");
            int size = int.Parse(Console.ReadLine());
            Student[] students = new Student[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter student{i+1} information");
                students[i] = new Student();
                read(students[i]);
                
            }
            for(int i = 0; i < size; i++)
            {
                Console.WriteLine($"Student{i+1}");
                Console.WriteLine(students[i].PrintAsString()); 
            }

        }
        static void read(Student s1)
        {
            Console.WriteLine("Enter Employee national id");
            s1.setSsn(Console.ReadLine());
            Console.WriteLine("Enter Employee name");
            s1.setName(Console.ReadLine());           
            Console.WriteLine("Enter Employee age");
            s1.setAge(int.Parse(Console.ReadLine()));
            Console.WriteLine("Enter Employee address");
            s1.setAddress(Console.ReadLine());
        }
    }
    class Student
    {
        private string ssn;
        private string name;
        private int age;
        private string address;
        #region setters
        public void setSsn(string _ssn) {
        ssn = _ssn;}
        public void setName(string _name)
        {
            name = _name;
        }
        public void setAge(int _age)
        {
            age = _age;
        }
        public void setAddress(string _address)
        {
            address = _address;
        }
        #endregion
        #region getters
        public string getSsn()
        {
            return ssn;
        }
        public string getName()
        {
            return name;
        }
        public int getAge() { 
        return age;}
        public string getAddress()
        {
            return address;
        }

        #endregion
        public string PrintAsString()
        {
            return $"Employee ssn is {this.ssn},\n" +
                $"Employee  name is {this.name}\n" +
                $"Employee age is {this.age}\n" +
                $"Employee address is {this.address}\n";
        }
    }
}