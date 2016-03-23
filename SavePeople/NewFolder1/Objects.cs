using System;

public class ItList
{
    private Int32 ID;
    private String Name;
    
    public ItList(Int32 id, String name)
    {
        this.ID = id;
        this.Name = name;
    } 
}

public class FlagList
{
    private int ID;
    private Boolean DoneFlag;
    private Boolean DoFlag;
    private String Mes;

    public FlagList(int id, String mes)
    {
        if (id>0)
        {
            ID = id;
        }
        DoFlag = false;
        DoneFlag = false;
        Mes = mes;
    }


}

public class Item
{
    protected String Name;
    protected Int32 ID;
    protected Int64 Number; //obecna ilość
    protected Int64 Max_Number; //ile może być max
    protected Int16 HP=1;
    protected Int16 Def=1;
    protected Int64 Value; //cena w biomasie
    protected Int64 SpawnTime; //czas na zrobienie
}

public class Unit:Item
{
    protected Int16 Speed;
    protected Int16 Damage;

    
    public Unit(string name, Int32 id, Int64 number, Int64 maxNumber, Int64 price, Int64 time)
    {
        if (name!="")
        {
            this.Name = name;
        }
        else
        {
            throw new ArgumentException("Text cannot be empty!");      
        }                                                              
        if (number<=maxNumber)                                         
        {                                                              
            this.Number = number;                                        
            this.Max_Number = maxNumber;                                 
        }                                                              
        else                                                           
        {
            throw new ArgumentException("The initial value need to be smaller or equal the maximum range!");
        }
        if (time==0)
        {
            this.SpawnTime = 1;
        }
        else
        {
            this.SpawnTime = time;
        }
        this.Value = price;
        this.ID = id;
    }

    public void IncNumber()
    {
        if (Max_Number != Number)
        {
            Number = Number + 1;
        }
    }

    public Int64 GetNumber()
    {
        return Number;
    }

    public void DecNumber()
    {
        if (Number > 0)
        {
            this.Number = this.Number - 1;
        }
    }

}

public class Resource : Item
{
    private Int64 Gain;

    public Resource(string name, Int64 value, Int64 maxValue, Int64 gain)
    {
        if (name != "")
        {
            this.Name = name;
        }
        else
        {
            throw new ArgumentException("Text cannot be empty!");
        }
        if (value <= maxValue)
        {
            this.Number = value;
            this.Max_Number = maxValue;
        }
        else
        {
            throw new ArgumentException("The initial value need to be smaller or equal the maximum range!");
        }
        this.Gain = gain;
    }

    public void IncNumber()
    {
        if (Max_Number != (Number+Gain))
        {
            Number = Number + Gain;
        }
    }

    public void SetGain(Int64 newGain)
    {
        if ( newGain>0)
        {
            Gain=newGain;
        }
    }

    public Int64 GetValue()
    {
        return this.Number;
    }

   
}

public class Structure:Item
{
    private Int64 UnitGenerate=1; //gain of units (+x/s)
    private Int64 UnitType=1;

    public Structure(string name, Int32 id, Int64 value, Int64 maxValue)
    {
        Name = name;
        ID = id;
        Number = value;
        Max_Number = maxValue;
    }

    public Int64 GetValue()
    {
        return this.Number;
    }
}

public class Overmind
{
    private String Name = "Overmind";
    private Int32 ID = 1;
    private Int64 Energy;
    private Int64 MaxEnergy;

    public Overmind(Int64 energy,Int64 maxEnergy)
    {
        if (energy > maxEnergy)
        {
            throw new ArgumentException("The initial value need to be smaller or equal the maximum range!");
        } else
        {
            this.Energy = energy;
            this.MaxEnergy = maxEnergy;
        }
    }
    public void OvermindSpawnLarve(Unit larve)
    {
        if (this.Energy < 50)
        {
            System.Windows.MessageBox.Show("You do not have enough energy, my Overmind", "But Overmind!");
        }
        else
        {
            larve.IncNumber();
            this.Energy = this.Energy - 50;

        }
    }
    public void OvermindMutateDrone(Unit larve,Unit drone)
    {
        if (this.Energy < 50)
        {
            System.Windows.MessageBox.Show("You do not have enough energy, my Overmind", "But Overmind!");
        }
        else
        {
            if (larve.GetNumber() > 0)
            {
                larve.IncNumber();
                this.Energy = this.Energy - 50;
                larve.DecNumber();
                drone.IncNumber();
            }
            else
            {
                System.Windows.MessageBox.Show("There is not enough larves, my Overmind", "But Overmind!");
            }
        }
    }

    public void WaitAClice()
    {
        if (Energy+3<=MaxEnergy)
        {
            this.Energy = Energy + 3;
        } else
        {
            Energy = MaxEnergy;
        }

    }

    public Int64 GetEnegry()
    {
        return Energy;
    }


}

//need list of ID - unit,resources,structures
