// Section 44 "Bridge pattern"
// The Bridge design pattern allows us to split an inheritance hierarchy into a set of hierarchies .
// It is the implementation of the "composition over inheritance" principle

var electricPickupWithManualGear = new Pickup(new ElectricMotor(), new ManualGear());

var petrolSedanWithAutomaticGear = new Sedan( new PetrolMotor(), new AutomaticGear());




class Car
{
    public Motor Motor { get; }
    public Gear Gear { get; }

    public Car(Motor motor, Gear gear)
    {
        Motor = motor;
        Gear = gear;
    }
}


class Pickup : Car
{
    public Pickup(Motor motor, Gear gear) : base(motor, gear)
    {

    }
}

class Sedan : Car
{
    public Sedan(Motor motor, Gear gear) : base(motor, gear)
    {

    }
}


class Motor { }
class ElectricMotor : Motor { }
class PetrolMotor : Motor { }

class Gear { }
class ManualGear : Gear { }
class AutomaticGear : Gear { }