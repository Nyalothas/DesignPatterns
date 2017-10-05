using Decorator.Component;

namespace Decorator.ConcreteComponent
{
    class CompactCar : Car
    {
        public CompactCar()
        {
            Description = "Copact Car";
        }

        public override string GetDescription() => Description;
        public override double GetCarPrice() => 10000.00;
    }
}
