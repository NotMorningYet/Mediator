using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level
{
    private const int ORIGINLEVEL = 1;
   
    private const int MAXLEVEl = 10;
   

    public Level()
    {
        
    }

    public int LevelUp(int currentLevel)
    {
        if (currentLevel < MAXLEVEl) return currentLevel+1; 
        return currentLevel;
    }


    public int LevelSet()
    {
        return ORIGINLEVEL;
    }
}

