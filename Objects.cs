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

public class Item
{
    protected String Name;
    protected Int32 ID;
    protected Int64 Number;
    protected Int64 Max_Number;
}

public class Unit:Item
{

    protected Int64 Value;
    protected Int64 SpawnTime;
    
    public Unit(string name,Int64 value, Int64 maxValue, Int64 price, Int64 time)
    {
        if (name!="")
        {
            this.Name = name;
        }
        else
        {
            throw new ArgumentException("Text cannot be empty!");      
        }                                                              
        if (value<=maxValue)                                         
        {                                                              
            this.Number = value;                                        
            this.Max_Number = maxValue;                                 
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
    }

    public ~Unit()
    {
        //some tekst

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

    public ~Resource()
    {
        //not now
    }
}

public class Structure:Item
{
    private Int64 UnitGenerate; //gain of units (+x/s)
    private Int64 UnitType;
}

//need list of ID - unit,resources,structures
