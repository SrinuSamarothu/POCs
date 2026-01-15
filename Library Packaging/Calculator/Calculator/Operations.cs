namespace Calculator
{
    public static class Operations
    {
        public static int Add(int a, int b) => a + b;

        public static int Subtract(int a, int b) => a - b;

        public static int Multiply(int a, int b) => a * b;

        public static int Divide(int a, int b)
        {
            if(b == 0)
                throw new System.DivideByZeroException("Denominator cannot be zero.");

            return a / b;
        }
    }
}
