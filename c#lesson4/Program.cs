/*Console.WriteLine();



Fraction f1 = new Fraction(2,15);
Fraction f2 = new Fraction(4,7);
Fraction f3 = f2.Minus(f1);
f3.Print();



public class Fraction
{
    private int numerator;
    private int denominator;

    public Fraction(int num, int don)
    {
        numerator = num;
        denominator = don;
    }

    public Fraction Multiply(Fraction other)
    {
        int newNum = numerator * other.numerator;
        int newDen = denominator * other.denominator;
        int eb = Setebob(newNum, newDen);
        return new Fraction(newNum/eb, newDen/eb);
    }

    public Fraction Add(Fraction other)
    {
        int newDen = SetEkob(denominator, other.denominator); 
        int newNum = (numerator * other.denominator) + (other.numerator * denominator);


        return new Fraction(newNum, newDen);
    }

    public Fraction Minus(Fraction other)
    {
        int newNum = (numerator * other.denominator) - (other.numerator * denominator);
        int newDen = SetEkob(denominator, other.denominator);
        return new Fraction(newNum, newDen);
    }

    public Fraction Divide(Fraction other) 
    {
        int newNum = numerator * other.denominator;
        int newDen = denominator * other.numerator;
        return new Fraction(newNum, newDen);
    }

    public void Simplify()
    {
        int g = Setebob(numerator, denominator);
        numerator /= g;
        denominator /= g;
    }

    private int Setebob(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    public void Print()
    {
        Console.WriteLine($"{this.numerator}/{this.denominator}");
    }

    public int SetEkob(int a, int b)
    {
        return (a * b )/ Setebob(a, b);
    }

    

    
    public int Num { get { return numerator; } set { if (value > numerator) numerator = value; } } 
   
   
}*/

//Task2 
/*Counterr ab  = new Counterr(7,20,4) ;
ab.Decrement();
ab.Decrement();
ab.Decrement();
ab.Decrement();
ab.Decrement();

Console.WriteLine(ab.Current);
ab.ShowCurrent();
class Counterr
{

    public Counterr() { current = 0; max = 100;min = 0; }
    public Counterr(int d, int max , int min) { current = d;this.max = max;this.min = min; }
    private int max ;
    private int min;
    private int current;
    public int Current { get { return current; } set { if (value >= 0) current = value; } }
    public int Max { get { return max; } set { max = value; } }
    public int Min { get { return min; } set { min = value; } }
    public void Increment()
    {
        if (current < max)
            current += 1;

       else current = 0;

    }


        public void Decrement()
    {
        if (current > min)
            current -= 1;

       else current = min+1;

    }

    public void ShowCurrent()
    {
        Console.WriteLine($"Current data is {current}");
            







    
    }
}






*/








/*
Point a = new Point();
a.X = 4;
a.ShowData();

class Point
{
  public  Point()
    {
       x=0; y=0;    
    }
    
   public Point(int x , int y)
    {
        this.x = x;
        this.y= y;  

    }


    private int x; private int y;

    public int X { get
        
        { return x; }
        set {
            if (value > 0)
            {
                x = value;  
            }
        } 
    } 
    public int Y { get
        
        { return y; }
        set {
            if (value > 0)
            {
                y = value;  
            }
        } 
    }

  public  void ShowData()
    {
        Console.WriteLine("Cordinant of x " + x);
        Console.WriteLine("Cordinant of y " + y);
    }
}*/




/*
int[][] jj = new int[5][];//jagged arraylarde biz*/ 
/*
var arr = new int []{ 3,4,54,234,234,234432,234};
int a = 9;
Console.WriteLine(arr.Length);
Console.WriteLine(arr.Max());
int[,,] numbers = { { { 333, 3, 5 }, { 2, 4, 6 } },
                                 { { 2, 4, 9 }, { 5, 7, 11 } } };
Console.WriteLine(numbers[0,0,0]);


*/


// -------------------------------------------------------------

// Dil Uzerinde struct vasitsi ile yaradilmish Hazir Type-lar

// DateTime, Time, DateOnly, Date, TimeSpan
/*
Console.WriteLine(DateTime.UtcNow); // 2021-10-14 14:00:00 dunya ortak saat
Console.WriteLine(DateTime.Now);    // 2021-10-14 17:00:00 indiki vaxt
Console.WriteLine(DateTime.Today);  // 2021-10-14 00:00:00

*/


//Console.WriteLine(DateTime.Now.Day);
//Console.WriteLine(DateTime.Now.Month);
//Console.WriteLine(DateTime.Now.ToString("M yyy ddd"));

//Console.WriteLine(DateTime.Now.Hour);
//Console.WriteLine(DateTime.Now.Minute);
//Console.WriteLine(DateTime.Now.Second);
//Console.WriteLine(DateTime.Now.Millisecond);
/*Console.WriteLine(DateTime.MaxValue   
    );
*/



//Console.WriteLine(DateOnly.MaxValue);
//Console.WriteLine(DateOnly.MinValue);


// ToString ile deyse bilrik
/*
Console.WriteLine(DateTime.Now.ToString());
Console.WriteLine(DateTime.Now.ToString("MM yyyy dd"));
Console.WriteLine(DateTime.Now.ToString("MMMM yyyy dd"));
Console.WriteLine(DateTime.Now.ToString("MMM yyyy dd"));
Console.WriteLine(DateTime.Now.ToString("ddd dd.MM.yyyy"));
Console.WriteLine(DateTime.Now.ToString("F"));
Console.WriteLine(DateTime.Now.ToString("dd MMMM yyyy HH:mm:ss"));


DateTime date = new DateTime(2008, 3, 20);

Console.WriteLine(date.ToString("MMM, dd_MM_yyyy"));
*/