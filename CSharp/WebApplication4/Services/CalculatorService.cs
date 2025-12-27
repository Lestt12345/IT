namespace WebApplication4.Services
{
    public class CalculatorService
    {
        public int Add(int a, int b) => a + b;

        public string Divide(int a, int b)
        {
            if (b == 0)
                return "Division by zero error";

            return (a / b).ToString();
        }
    }
}