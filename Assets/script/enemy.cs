using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public int health;
    private Transform Money;

    void Update()
    {
        if(health <= 0)
        {
            gamemanager money = Money.GetComponent<gamemanager>();
            money.gold += 5;
        }   
    }
}
