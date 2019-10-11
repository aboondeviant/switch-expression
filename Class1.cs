using System;

namespace repro
{
    public class Test
    {
        private string _someValue = "SomeValue";
        private string _someOtherValue = "SomeOtherValue";

        // CA1822 triggers on this function
        public string ExpressionBody1(int a) =>
            a switch
            {
                _ => _someValue
            };

        // CA1822 doesn't trigger on this function
        public string ExpressionBody2(int a) =>
            a switch
            {
                _ => _someOtherValue
            };
    }
}