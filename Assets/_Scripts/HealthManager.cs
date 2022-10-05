using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{

    public static HealthManager instance;

    public int health;

    private void Awake()
    {
        if (!instance)
        {
            instance = this;
        }
    }
    
    public int getHealth()
    {
        return health;
    }

    public void ChangeHealth(int poisonValue)
    {
        health -= poisonValue;
        Debug.Log(health);
    }

    public void addHealth(int healthValue)
    {
        health++;
        
    }
    public void death()
    {
        if(health <= 0)
        {
            ScoreManager.instance.ChangeScore(-1000);
            addHealth(1);
            Debug.Log(ScoreManager.instance.score);
            Debug.Log(health);
        }
    }
}

