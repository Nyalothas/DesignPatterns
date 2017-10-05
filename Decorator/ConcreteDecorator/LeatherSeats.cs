using Decorator.Component;
using Decorator.Decorator;

namespace Decorator.ConcreteDecorator
{
    class LeatherSeats : CarDecorator
    {
        public LeatherSeats(Car car) : base(car)
        {
            Description = "LeatherSeats";
        }

        public override string GetDescription() => $"{_car.GetDescription()}, {Description}";
        public override double GetCarPrice() => _car.GetCarPrice() + 2500;
    }
}
