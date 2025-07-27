namespace Ass3OOP
{
    #region Part1
    #region Q1
    //class Calculator 
    //{
    //    public int Add (int a , int b)
    //    {
    //        return a + b;
    //    }
    //    public int Add(int a, int b,int c)
    //    {
    //        return a + b +c;
    //    }
    //    public double Add(double a, double b)
    //    {
    //        return a + b;
    //    }

    //}
    #endregion

    #region Q2
    //class Regtangle
    //{
    //     int height, widht;
    //    public Regtangle() 
    //    {
    //      height = widht = 0;
    //    }
    //    public Regtangle(int height,int widht)
    //    {
    //        this.height = height;
    //        this.widht = widht;
    //    }
    //    public Regtangle(int value)
    //    {
    //        height = widht = value;
    //    }

    //    public override string ToString()
    //    {
    //        return $"height = {height} , widht = {widht}";
    //    }


    //}
    #endregion

    #region Q3
    //class ComplexNumber
    //{
    //    public double Real { get; set; }
    //    public double Imagine { get; set; }

    //    public ComplexNumber (double Real, double Imagine)
    //    {
    //        this.Real = Real;
    //        this.Imagine =Imagine;
    //    }

    //    override public string ToString()
    //    {
    //        return $"{Real} + {Imagine}i";
    //    }

    //    public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
    //    {
    //        return new ComplexNumber
    //            (
    //              c1.Real + c2.Real,
    //                c1.Imagine + c2.Imagine
    //            );
    //    }

    //    public static ComplexNumber operator -(ComplexNumber c1, ComplexNumber c2)
    //    {
    //        return new ComplexNumber
    //            (
    //              c1.Real - c2.Real,
    //                c1.Imagine - c2.Imagine
    //            );
    //    }
    //}

    #endregion

    #region Q4
    //class Employee
    //{
    //    public void Display()
    //    {
    //        Console.WriteLine("Employee is  working");
    //    }
    //}
    //class Manager : Employee
    //{
    //    public new void Display()
    //    {
    //        Console.WriteLine("Manager is  working");
    //    }
    //}
    #endregion

    #region Q5
    //class BaseClass
    //{
    //    public virtual void Display()
    //    {
    //        Console.WriteLine("Message from BaseClass");
    //    }
    //}
    //class DerivedClass1: BaseClass
    //{
    //    public override void Display()
    //    {
    //        Console.WriteLine("Message from DerivedClass1");
    //    }
    //}
    //class DerivedClass2 : DerivedClass1
    //{
    //    public new void Display()
    //    {
    //        Console.WriteLine("Message from DerivedClass2"); // give the last once we make overirde so will return "Message from DerivedClass1"
    //    }
    //}

    #endregion

    #endregion

    #region Partt2
    #region Qestion
    // --1--
    //class Duration
    //{
    //    public int Hours { set; get; }
    //    public int Minutes { set; get; }
    //    public int Seconds { set; get; }

    //    public int ToTotalSeconds()
    //    {
    //        return Hours * 3600 + Minutes * 60 + Seconds;
    //    }

    //    //--2--

    //    public override bool Equals(object? obj)
    //    {
    //        if (obj is Duration other)
    //        {
    //            return this.Hours == other.Hours &&
    //                   this.Minutes == other.Minutes &&
    //                   this.Seconds == other.Seconds;
    //        }
    //        return false;
    //    }


    //    public override int GetHashCode()
    //    {
    //        return HashCode.Combine(Hours, Minutes, Seconds);
    //    }

    //    public override string ToString()
    //    {
    //        string Result = "";
    //        if (Hours > 0)
    //            Result += $"Hours: {Hours}";
    //        if (Hours > 0 || Minutes > 0)
    //            Result += $" Minutes : {Minutes}";
    //        Result += $" Seconds: {Seconds}";

    //        return Result;

    //    }

    //    //--3--
    //    public Duration(int Hours, int Minutes, int Seconds)
    //    {
    //        this.Hours = Hours;
    //        this.Minutes = Minutes;
    //        this.Seconds = Seconds;
    //    }
    //    public Duration(int TotalSeconds)
    //    {
    //        Hours = TotalSeconds / 3600;
    //        int Rem = TotalSeconds % 3600;

    //        Minutes = Rem / 60;
    //        Seconds = Rem % 60;
    //    }
    //    //operator Overloading 
    //    //--1-- D3 = D1+D2
    //    public static Duration operator +(Duration D1, Duration D2)
    //    {
    //        return new Duration(D1.ToTotalSeconds() + D2.ToTotalSeconds());
    //    }
    //    //--2-- D3=D1 + 7800
    //    public static Duration operator +(Duration D1, int Sec)
    //    {
    //        return new Duration(D1.ToTotalSeconds() + Sec);
    //    }
    //    //--3-- D3=666+D3
    //    public static Duration operator +(int Sec, Duration D3)
    //    {
    //        return new Duration(D3.ToTotalSeconds() + Sec);
    //    }
    //    //--4-- D3= ++D1 (Increase One Minute)
    //    public static Duration operator ++(Duration D1)
    //    {
    //        return new Duration(D1.ToTotalSeconds() + 60);
    //    }

    //    //--5-- D3 = --D2 (Decrease One Minute)
    //    public static Duration operator --(Duration D1)
    //    {
    //        int total = D1.ToTotalSeconds() - 60;
    //        if (total < 0) total = 0;
    //        return new Duration(total);
    //    }

    //    //--6-- D1= D1 -D2
    //    public static Duration operator -(Duration D1, Duration D2)
    //    {
    //        int result = D1.ToTotalSeconds() - D2.ToTotalSeconds();
    //        if (result < 0) result = 0;
    //        return new Duration(result);
    //    }

    //    //--7-- If (D1>D2)
    //    public static bool operator >(Duration D1, Duration D2)
    //    {
    //        return D1.ToTotalSeconds() > D2.ToTotalSeconds();
    //    }
    //    public static bool operator <(Duration D1, Duration D2)
    //    {
    //        return D1.ToTotalSeconds() < D2.ToTotalSeconds();
    //    }
    //    //--8-- If (D1<=D2)
    //    public static bool operator >=(Duration D1, Duration D2)
    //    {
    //        return D1.ToTotalSeconds() >= D2.ToTotalSeconds();
    //    }
    //    public static bool operator <=(Duration D1, Duration D2)
    //    {
    //        return D1.ToTotalSeconds() <= D2.ToTotalSeconds();
    //    }

    //    //--9-- If (D1)
    //    public static bool operator true(Duration d)
    //    {
    //        return d.ToTotalSeconds() > 0;
    //    }

    //    public static bool operator false(Duration d)
    //    {
    //        return d.ToTotalSeconds() <= 0;
    //    }

    //    //--10-- DateTime Obj = (DateTime) D1
    //    public static explicit operator DateTime(Duration d)
    //    {
    //        return new DateTime(1, 1, 1, d.Hours, d.Minutes, d.Seconds);
    //    }


    //}




    #endregion




    #endregion
    class Program
    {
        static void Main(string[] args)
        {

            #region CallPart1
            #region CallQ1
            //Calculator calculator = new Calculator();
            //Console.WriteLine(calculator.Add(1, 2));
            //Console.WriteLine(calculator.Add(1, 2, 3));
            //Console.WriteLine(calculator.Add(1.4, 2.5));

            #endregion

            #region CallQ2
            //Regtangle regtangle  = new Regtangle();
            //Regtangle regtangle1 = new Regtangle(10, 20);
            //Regtangle regtangle2 = new Regtangle(10);
            //Console.WriteLine(regtangle);
            //Console.WriteLine(regtangle1);
            //Console.WriteLine(regtangle2);


            #endregion

            #region CallQ3
            //ComplexNumber c1 = new ComplexNumber(2, 3);
            //ComplexNumber c2 = new ComplexNumber(4, 5);
            //ComplexNumber Sum = c1 + c2;
            //ComplexNumber Sub = c1 - c2;
            //Console.WriteLine($"the sum = {Sum} , the sub = {Sub}");
            #endregion

            #region CallQ4
            //Employee employee = new Employee();
            //Manager manager = new Manager();
            //employee.Display(); 
            //manager.Display();  
            #endregion

            #region CallQ5
            //BaseClass baseClass = new BaseClass();
            //BaseClass baseClass1 = new DerivedClass1();
            //BaseClass baseClass2 = new DerivedClass2();
            //DerivedClass2 baseClass3 = new DerivedClass2();

            //baseClass.Display();
            //baseClass1.Display();
            //baseClass2.Display();
            //baseClass3.Display(); 


            #endregion

            #endregion

            #region CallPart2
            ////--1--
            //Duration D1 = new Duration(1,10,15);
            //Console.WriteLine(D1);
            //Duration D2 = new Duration(3600);
            //Console.WriteLine(D2);
            //Duration D3 = new Duration(7800);
            //Console.WriteLine(D3);
            //Duration D4 = new Duration(666);
            //Console.WriteLine(D4);

            //Duration D5 = new Duration(1,10,15);
            //Console.WriteLine(D1.Equals(D5));
            //Console.WriteLine(D1.GetHashCode());
            //Console.WriteLine(D5.GetHashCode());

            //------------------------------------------------------------------------------------//

            //Duration D1 = new Duration(1, 10, 15);
            //Duration D2 = new Duration(7800);

            //Duration D3 = D1 + D2;
            //Console.WriteLine("D3 = D1 + D2 → " + D3);

            //D3 = D1 + 7800;
            //Console.WriteLine("D3 = D1 + 7800 → " + D3);

            //D3 = 666 + D3;
            //Console.WriteLine("D3 = 666 + D3 → " + D3);

            //D3 = ++D1;
            //Console.WriteLine("D3 = ++D1 → " + D3);

            //D3 = --D2;
            //Console.WriteLine("D3 = --D2 → " + D3);

            //D1 = D1 - D2;
            //Console.WriteLine("D1 = D1 - D2 → " + D1);

            //if (D1 > D2)
            //    Console.WriteLine("D1 > D2");

            //if (D1 <= D2)
            //    Console.WriteLine("D1 <= D2");

            //if (D1)
            //    Console.WriteLine("D1 has non-zero duration");

            //DateTime dt = (DateTime)D1;
            //Console.WriteLine("DateTime = " + dt.ToLongTimeString());


            #endregion

        }
    }
}
