namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            var x = 20;
            var y = 40;

            var a = 20.00m;
            var b = 40.00m;


            var intAdd = Add(x, y);           
            var decimalAdd = Add(a, b);
            var addWithBool = Add(5, 1, false);
            Console.WriteLine($"Int Add : {x} + {y} = {intAdd}\nDecimal Add: {a} + {b} = {decimalAdd}\nBool Add: {addWithBool}");
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Add(decimal num1, decimal num2) 
        {
            return num1 + num2;
        }

        public static string Add(int num1, int num2, bool isChecked)
        {
            var addedNums = num1 + num2;
            if(isChecked && addedNums > 1)
            {
                return $"{addedNums} dollars";
            }
            else if(isChecked && addedNums == 1)
            {
                return $"{addedNums} dollar";
            }
            else
            {
                return addedNums.ToString();                
            }
        }
    }
}
