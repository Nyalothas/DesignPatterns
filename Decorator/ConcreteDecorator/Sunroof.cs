using Decorator.Component;
using Decorator.Decorator;

namespace Decorator.ConcreteDecorator
{
    class Sunroof : CarDecorator
    {
        public Sunroof(Car car) : base(car)
        {
            Description = "Sunroof";
        }

        public override string GetDescription() => $"{_car.Description} , {Description}";
        public override double GetCarPrice() => _car.GetCarPrice() + 2500;
    }
}
