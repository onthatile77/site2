class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        try
        {
            int[] lastWeek = new [] {0, 2, 5, 3, 7, 8, 4};
            return lastWeek;
        }
        catch(Exception ex)
        {
            throw new NotImplementedException("Please implement the (static) BirdCount.LastWeek() method");
        }

        
    }

    public int Today()
    {
        try{
            return birdsPerDay[birdsPerDay.Length-1];
        }
        catch(Exception ex)
        {
            throw new NotImplementedException("Please implement the BirdCount.Today() method");
        }
    }

    public void IncrementTodaysCount()
    {
        try{
            birdsPerDay[birdsPerDay.Length-1] += 1;
        }
        catch{
            throw new NotImplementedException("Please implement the BirdCount.IncrementTodaysCount() method");    
        }
        
    }

    public bool HasDayWithoutBirds()
    {
        try
        {
            foreach(int birds in birdsPerDay)
            {
                if (birds==0)
                {
                    return true;
                }
            }
            return false;
        }
        catch{
            throw new NotImplementedException("Please implement the BirdCount.HasDayWithoutBirds() method");
        }
    }

    public int CountForFirstDays(int numberOfDays)
    {
        try
        {
            int total = 0;
            for(int i = 0; i < numberOfDays; i++)
            {
                total+=birdsPerDay[i];
            }
            return total;
        }
        catch(Exception ex)
        {
            throw new NotImplementedException("Please implement the BirdCount.CountForFirstDays() method");
        }
        
    }

    public int BusyDays()
    {
        int busy = 0;
        try{
            foreach(int birds in birdsPerDay)
            {
                if(birds >= 5)
                {
                    busy++;
                }
            }
            return busy;
        }
        catch(Exception ex)
        {
            throw new NotImplementedException("Please implement the BirdCount.BusyDays() method");
        }
        
    }

    
}
