using DesignPatterns.Structural.Facade.Systems;

namespace DesignPatterns.Structural.Facade
{
    public class Calculator
    {
        private readonly MathSubsystem _math;
        private readonly LogicSubsystem _logic;

        public Calculator(MathSubsystem math, LogicSubsystem logic)
        {
            _math = math;
            _logic = logic;
        }

        public string Calculate(int a, int b)
        {
            int leftResult = _math.Sum(a, b);
            int rightResult = _math.Product(a, b);

            string sign;
            
            if (_logic.IsGreater(leftResult, rightResult))
                sign = ">";
            else if (_logic.IsLess(leftResult, rightResult))
                sign = "<";
            else
                sign = "==";

            return $"({a} + {b} = {leftResult}) {sign} ({a} * {b} = {rightResult})";
        }
    }
}
