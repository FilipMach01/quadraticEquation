class QE
{
    public int a;
    public int b;
    public int c;
    
    public QE(int a, int b, int c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    private static double D(int a, int b, int c)
    {

        double d = Math.Pow(b, 2) - 4 * a * c;
        return d;
        
        
    }

    private double[] Equation(int a, int b, int c)
    {
        if (Math.Abs(D(a, b, c)) < 1e-9)
        {
            return [-b / (2 * a)];
        }

        if (D(a, b, c) < 0)
        {
            return [];
        }
        
        
        double xplus = (-b + Math.Sqrt(D(a,b,c))) / (2 * a);
        double xminus = (-b - Math.Sqrt(D(a,b,c))) / (2 * a);
        return [xplus, xminus];
   
        
        

    }

    public void Print()
    {
        double[] x = Equation(a, b, c);
        if (x.Length==0)
        {
            Console.WriteLine("This equation has no solution.");
        }

        else if (x.Length == 1)
        {
            Console.WriteLine($"x1 = {x[0]}");
        }
        else
        {
            Console.WriteLine($"x1 = {x[0]},x2 = {x[1]} ");

        }
        
    }
}
class Program
{
    static void Main()
    {
        QE qe = new QE(1,3,2);
        qe.Print();
    }
    
}