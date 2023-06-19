using Labb3DesignPattern;

var machine = new WarmDrinkMachine();
IWarmDrink drink = machine.MakeDrink();
drink.Consume();
