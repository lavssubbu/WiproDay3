namespace LoggingDemo
{
    public class Calculator
    {

        public int Add(int a, int b)
        {
            // Simulate a possible error scenario (optional)
            if (a == 999)
            {
                throw new InvalidOperationException("Cannot process input 999 for 'a'.");
            }

            return a + b;
        }
    }
}
