namespace HelloWorld_A.model
{
    public class MathParameters
    {
        public double firstnumber { get; set; }
        public double secondnumber { get; set; }

        public double Add()
        {
            return firstnumber + secondnumber;
        }

        public double Subtract()
        {
            return firstnumber - secondnumber;
        }

        public double Multiply()
        {
            return firstnumber * secondnumber;
        }

        public double Divide()
        {
            if (secondnumber == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }
            return firstnumber / secondnumber;
        }
    }
}