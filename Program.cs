namespace Assignment2._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleMath.Add(1, 2);
            SimpleMath.Add(2.4m, 3.456m, 9.343356m);
            SimpleMath.Multiply(3, 4);
            SimpleMath.Multiply(4, 6, 9);
        }
    }

    static public class SimpleMath 
    {
        static public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        static public decimal Add(decimal num1, decimal num2, decimal num3) 
        { 
            return num1 + num2 + num3;
        }

        static public float Multiply(float num1, float num2) 
        { 
            return (float)num1 * num2;
        }

        static public float Multiply(float num1, float num2 , float num3) 
        {
            return (float)num1 * num2 * num3;
        }
    }

}
