using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Computer
{
    private string name;
    private decimal price;

    

    static void Main(string[] args)
    {


    }
}

class Component
{
    private string model;
    private string manufacturer;
    private string processor;
    private int ram;
    private string graphicsCard;
    private string hdd;
    private string screen;
    private string battery;
    private double batteryLife;
    private decimal price;

    //constructor
    public Component(string model, decimal price, string manufacturer = "", string processor = "", int ram = 0,
        string graphicsCard = "", string hdd = "",  string screen = "", string battery = "",double batteryLife = 0)
    {
        this.Model = model;
        this.Price = price;
        this.Manufacturer = manufacturer;
        this.Processor = processor;
        this.RAM = ram;
        this.GraphicsCard = graphicsCard;
        this.HDD = hdd;
        this.Screen = screen;
        this.Battery = battery;
        this.BatteryLife = batteryLife;
    }
    //prints Laptop specifications
    public void PrintLaptop()
    {
        Console.WriteLine("model: {0} ", this.model);

        if(!String.IsNullOrEmpty(manufacturer))
            Console.WriteLine("manufacturer: {0} ", this.manufacturer);

        if (!String.IsNullOrEmpty(manufacturer))
            Console.WriteLine("processor: {0} ", this.processor);

        if (ram > 0)
            Console.WriteLine("RAM: {0} GB ", this.ram);

        if (!String.IsNullOrEmpty(graphicsCard))
            Console.WriteLine("graphics card: {0} ", this.graphicsCard);

        if (!String.IsNullOrEmpty(hdd))
            Console.WriteLine("HDD: {0}", this.hdd);

        if (!String.IsNullOrEmpty(screen))
            Console.WriteLine("screen: {0} ", this.screen);

        if (!String.IsNullOrEmpty(battery))
            Console.WriteLine("battery: {0} ", this.battery);

        if (batteryLife > 0)
            Console.WriteLine("battery life: {0} hours ", this.batteryLife);

            Console.WriteLine("price: {0} lv.", this.price);

        //string.Format("{0}, {1}", this.model, this.price);
    }

    //properties
    public string Model 
    {
        get
        {
            return this.model;
        }
        set
        {
            this.model = value;

            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentOutOfRangeException("Provided data should not be empty!");
            }         
        }
    }

    public string Manufacturer
    {
        get
        {
            return this.manufacturer;
        }
        set
        {
            this.manufacturer = value;

            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentOutOfRangeException("Provided data should not be empty!");
            } 
        }
    }

    public string Processor
    {
        get
        {
            return this.processor;
        }
        set
        {
            this.processor = value;

            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentOutOfRangeException("Provided data should not be empty!");
            }
        }
    }

    public int RAM
    {
        get
        {
            return this.ram;
        }
        set
        {
            this.ram = value;

            if (ram <= 0)
            {
                throw new ArgumentOutOfRangeException("Provided data should not be negative or equals to zero");
            }      
        }
    }

    public string GraphicsCard
    {
        get
        {
            return this.graphicsCard;
        }
        set
        {
            this.graphicsCard = value;

            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentOutOfRangeException("Provided data should not be empty!");
            }    
        }
    }

    public string HDD
    {
        get
        {
            return this.hdd;
        }
        set
        {
            this.hdd = value;

            if (String.IsNullOrEmpty(hdd))
            {
                throw new ArgumentOutOfRangeException("Provided data should not be empty!");
            }  
        }
    }

    public string Screen
    {
        get
        {
            return this.screen;
        }
        set
        {
            this.screen = value;

            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentOutOfRangeException("Provided data should not be empty!");
            }
        }
    }

    public string Battery
    {
        get
        {
            return this.battery;
        }
        set
        {
            this.battery = value;

            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentOutOfRangeException("Provided data should not be empty!");
            }     
        }
    }

    public double BatteryLife
    {
        get
        {
            return this.batteryLife;
        }
        set
        {
            this.batteryLife = value;

            if (batteryLife <= 0)
            {
                throw new ArgumentOutOfRangeException("Provided data should not be negative or equals to zero");
            }       
        }
    }

    public decimal Price
    {
        get
        {
            return this.price;
        }
        set
        {
            this.price = value;

            if (price <= 0)
            {
                throw new ArgumentOutOfRangeException("Provided data should not be negative or equals to zero");
            }    
        }
    }


}

   