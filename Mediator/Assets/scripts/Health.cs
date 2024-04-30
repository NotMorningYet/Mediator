using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health 
{
    private const int ORIGINHEALTH = 5;
    private const int MINHEALTH = 1;
    private const int MAXHEALTH = 10;


    public Health()
    {

    }

    public int HealthUp(int currentHealth)
    {
        if (currentHealth < MAXHEALTH) return currentHealth+1;
        return currentHealth;
    }

    public int HealthDown(int currentHealth)
    {
        if (currentHealth != MINHEALTH) return currentHealth-1;
        return 0;
    }

    public int HealthSet()
    {
        return ORIGINHEALTH;
    }
}
