using Decorator.Component;

namespace Decorator.ConcreteComponent
{
    class FullSizeCar : Car
    {
        public FullSizeCar()
        {
            Description = "Full Size Car";
        }

        public override string GetDescription() => Description;
        public override double GetCarPrice() => 30000.00;
    }
}
