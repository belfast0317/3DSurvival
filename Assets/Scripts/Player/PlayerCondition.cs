using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageable
{
    void TakePhysicalDamage(int damage);
}
public class PlayerCondition : MonoBehaviour, IDamageable
{
    public UICondition uICondition; 

    Condition health { get { return uICondition.health; } }
    Condition stamina { get { return uICondition.stamina; } }
    
    public event Action onTakeDamage;

    // Update is called once per frame
    void Update()
    {
        stamina.Add(Time.deltaTime * stamina.passiveValue);

        if (health.curValue <= 0)
        {
            // 플레이어가 죽었을 때의 로직
            
            Die();
        }
    }

    public void Heal(float amount)
    {
        health.Add(amount);
    }
    
    public void Die()
    {
        Debug.Log("Player is dead");
    }

    public void TakePhysicalDamage(int damage)
    {
        health.Substract(damage);
        onTakeDamage?.Invoke();
    }
}
