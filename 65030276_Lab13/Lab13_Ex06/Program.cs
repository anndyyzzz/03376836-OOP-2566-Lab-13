Television myTV = new SonyTV();
myTV.Wattage = 100;
myTV.TurnOn();
myTV.ChannelUp();
myTV.ChannelDown();
myTV.TurnOff();

Lamp myLamp = new DesktopLamp();
myLamp.Wattage = 50;
myLamp.TurnOn();
myLamp.TurnOff();

interface IRemoteControl
{
    void TurnOn();
    void TurnOff();
    void ChannelUp();
    void ChannelDown();
}

abstract class PowerAppliance
{
    public bool PowerStatus;
    public int Wattage;
}

abstract class Television : PowerAppliance, IRemoteControl
{
    public int Channel { get; set; }

    public void TurnOn() { Console.WriteLine("TV Turn on"); PowerStatus = true; }
    public void TurnOff() { Console.WriteLine("TV Turn off"); PowerStatus = false; }
    public void ChannelUp() { Console.WriteLine("TV Channel up"); }
    public void ChannelDown() { Console.WriteLine("TV Channel down"); }
}

abstract class Lamp : PowerAppliance, IRemoteControl
{
    public void TurnOn() { Console.WriteLine("Lamp Turn on"); PowerStatus = true; }
    public void TurnOff() { Console.WriteLine("Lamp Turn off"); PowerStatus = false; }
    public void ChannelUp() { Console.WriteLine("Lamp cannot change channel"); }
    public void ChannelDown() { Console.WriteLine("Lamp cannot change channel"); }
}

class SonyTV : Television
{
}

class DesktopLamp : Lamp
{
}