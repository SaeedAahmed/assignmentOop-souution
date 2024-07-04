namespace assignment01Oop
{


    enum WeekDays
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }

    internal struct person
    {
        public string name;
        public int age;


        public person(string _name, int _age)
        {
            name = _name;
            age = _age;
        }


    }
    enum Season
    {
        Spring, Summer, Autumn, Winter
    }

    enum Permissions
    {
        Read = 1, Write = 2, Delete = 4, Execute = 8
    }
    enum Colors
    {
        Red, Green, Blue
    }

    internal struct Point
    {

        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

    }

    internal struct Person
    {

        private string name;
        private int age;

        public Person(string _Name, int _Age)
        {
            name = _Name;
            age = _Age;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            #region task 01
            //for (int i = 0; i <= (int)WeekDays.Saturday; i++)
            //{
            //    WeekDays day = (WeekDays)i;
            //    Console.WriteLine(day);
            //}
            #endregion

            #region task 02
            //person[] person = new person[3];

            //person[0]=new person("saeeed" , 25);
            //person[1] = new person("ahmed", 30);
            //person[2] = new person("mohamed", 20);

            //foreach(person p in person)
            //{
            //    Console.WriteLine($"name :{p.name}\nage : {p.age}");
            //} 
            #endregion

            #region task 03

            //Console.WriteLine("Enter the season");
            //string input = Console.ReadLine();

            //if (Enum.TryParse(input, true, out Season season))
            //{
            //    if (season == Season.Spring)
            //    {
            //        Console.WriteLine("march to may");
            //    }
            //    else if (season == Season.Summer)
            //    {
            //        Console.WriteLine("june to august");
            //    }
            //    else if (season == Season.Autumn)
            //    {
            //        Console.WriteLine("september to november");
            //    }
            //    else if (season == Season.Winter)
            //    {
            //        Console.WriteLine("december to february");
            //    }
            //    else
            //    {
            //        Console.WriteLine("invalid season name");
            //    }
            //}
            #endregion

            #region task 04
            //Permissions permissions = Permissions.Read | Permissions.Write;
            //permissions = permissions | Permissions.Execute;
            //permissions = permissions & ~Permissions.Write;

            //bool read = (permissions & Permissions.Read) == Permissions.Read;
            //bool write = (permissions & Permissions.Write) == Permissions.Write;
            //bool delete = (permissions & Permissions.Delete) == Permissions.Delete;
            //bool execute = (permissions & Permissions.Execute) == Permissions.Execute;
            //Console.WriteLine(read);
            //Console.WriteLine(write);
            //Console.WriteLine(delete);
            //Console.WriteLine(execute);
            #endregion

            #region task 05
            //Console.WriteLine("enter a color");
            //string input = Console.ReadLine();

            //if (Enum.TryParse(input, true, out Colors color))
            //{
            //    if (color == Colors.Red || color == Colors.Green || color == Colors.Blue)
            //    {
            //        Console.WriteLine($"{color} is a primary color");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{color} is not a primary color");
            //    }
            //}
            #endregion

            #region task 06
            //Console.WriteLine("enter x1");
            //double x1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("enter y1");
            //double y1 = Convert.ToDouble(Console.ReadLine());
            //Point point1 = new Point(x1, y1);

            //Console.WriteLine("enter x2");
            //double x2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("enter y2");
            //double y2 = Convert.ToDouble(Console.ReadLine());
            //Point point2 = new Point(x2, y2);

            //double X = point2.X - point1.X;
            //double Y = point2.Y - point1.Y;

            //double space = Math.Sqrt(X * X + Y * Y);

            //Console.WriteLine(space);
            #endregion

            #region task 07

            //Person[] person = new Person[3];

            //for (int i = 0; i < person.Length; i++)
            //{
            //    Console.WriteLine($"enter name for person {i+1}");
            //    string name = Console.ReadLine();

            //    Console.WriteLine($"enter age for person {i + 1}");
            //    int age = int.Parse(Console.ReadLine());

            //    person[i] = new Person(name, age);
            //}

            //Person old = person[0];

            //for (int i = 1; i < person.Length; i++)
            //{
            //    if (person[i].Age > old.Age)
            //    {
            //        old = person[i]; ;
            //    }
            //}

            //Console.WriteLine($"the old person is {old.Name} and age is {old.Age}");


            #endregion
        }
    }
}
