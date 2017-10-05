using Decorator.Component;
using Decorator.Decorator;

namespace Decorator.ConcreteDecorator
{
    class Spoiler :CarDecorator
    {
        public Spoiler(Car car) : base(car)
        {
            Description = "Spoiler";
        }

        public override string GetDescription() => $"{_car.GetDescription()}, {Description}";
        public override double GetCarPrice() => _car.GetCarPrice() + 2000;
    }
}
