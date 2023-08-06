using UnityEngine;
using System;

public class HealthSystem : MonoBehaviour
{
    public int startHealth;
    public int maxHealth;

    public Action<int> Damaged;
    public Action Dead;

    private int currentHealth;

    private void Start()
    {
        currentHealth = startHealth;
    }

    public void TakeHit(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
            Dead?.Invoke();
        else
            Damaged?.Invoke(currentHealth);
    }
}