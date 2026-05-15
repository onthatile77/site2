class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven()
    {
        
        try
        {
            return 40;
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex);
            return -1;
        }
    }

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int remain)
    {
        
        try
        {
            return ExpectedMinutesInOven() - remain;
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex);
            return -1;
        }
    }

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int layers)
    {
        
        try
        {
            return layers * 2;
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex);
            return -1;
        }
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layers, int lapse)
    {
        try
        {
            return PreparationTimeInMinutes(layers) + lapse;
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex);
            return -1;
        }
    }
}
