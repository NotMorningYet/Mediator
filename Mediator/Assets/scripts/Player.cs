using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public event Action Dead; 
    public event Action HealthUped;
    public event Action HealthDowned;
    public event Action LevelUped;

    public int PlayerHealth;
    public int PlayerLevel;
    private Level _level;
    private Health _health;

    public void Initialize()
    {
        _level = new Level();
        _health =new Health();
        PlayerLevel = _level.LevelSet();
        PlayerHealth = _health.HealthSet();
    }

    public void LevelUp()
    {
        PlayerLevel = _level.LevelUp(PlayerLevel);
    }


    public void HealthUp()
    {
        PlayerHealth = _health.HealthUp(PlayerHealth);

    }
    public void HealthDown()
    {
        PlayerHealth = _health.HealthDown(PlayerHealth);
        if (PlayerHealth <= 0) OnDead();
    }


    public void Reborn()
    {
        PlayerLevel = _level.LevelSet();
        PlayerHealth = _health.HealthSet();
    }

    public void OnDead()
    {
        Dead?.Invoke();
    }

    public void OnHealthUp()
    {
        HealthUped?.Invoke();
    }

    public void OnHealthDown()
    {
        HealthDowned?.Invoke();
    }

    public void OnLevelUp()
    {
        LevelUped?.Invoke();
    }
    
}
