namespace Ass3OOP
{

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

  

  
    class Program
    {
        static void Main(string[] args)
        {
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

         

        }
    }
}
