static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        try
        {
            if(knightIsAwake)
            {
                return false;
            }
            return true;
        }
        catch(Exception ex)
        {
            throw new NotImplementedException("Please implement the (static) QuestLogic.CanFastAttack() method");    
        }       
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        try
        {
            if(!knightIsAwake && !archerIsAwake && !prisonerIsAwake)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        catch(Exception ex)
        {
            throw new NotImplementedException("Please implement the (static) QuestLogic.CanSpy() method");
        }
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        try
        {
            if(!archerIsAwake && prisonerIsAwake)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        catch(Exception ex)
        {
            throw new NotImplementedException("Please implement the (static) QuestLogic.CanSignalPrisoner() method");
        }
        
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        try
        {
            if(petDogIsPresent && !archerIsAwake)
            {
                return true;
            }
            else if(!petDogIsPresent && !knightIsAwake && !archerIsAwake && prisonerIsAwake)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        catch(Exception ex)
        {
            throw new NotImplementedException("Please implement the (static) QuestLogic.CanFreePrisoner() method");
        }  
    }
}
