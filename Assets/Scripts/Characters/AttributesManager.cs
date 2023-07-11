using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttributesManager : MonoBehaviour
{
    public int health;
    public int attack;
    public int soul;
    public int armor;
    public float critDamage = 1.5f;
    public float critChance = 0.5f;
    //TODO:enemy veya karakterin canı 0 ın altına inince ölüm animasyonu devreye girecek
    public void TakeDamage(int amount)
    {
        health -= amount - (amount * armor/100);

    }
    public void DealDamage(GameObject target) 
    { 
        var atm = target.GetComponent<AttributesManager>();
        if (atm != null)
        {
            float totalDamage = attack;
            if (Random.Range(0f, 1f) < critChance)
            {
                totalDamage *= critDamage;
            }
            atm.TakeDamage((int)totalDamage);
        }
    }
}
