
using System.Diagnostics;
using UnityEngine;

public class HealthSystem 
{
    private int health;
    private int maxHealth;
    public HealthSystem(int maxHealth) {
        this.maxHealth = maxHealth;
        health = maxHealth;
    }

    public int getHealth() {
        return health;
    }

    public float getHealthPercent() {
        float percentage = (float) health/maxHealth;
        return percentage * 0.5f;
    }

    public void Damage(int damageAmount)
    {
        health -= damageAmount;
        if (health < 0) {
            health = 0;
        }
    }
    public void Heal(int healAmount)
    {
        health += healAmount;
        if (health > maxHealth) {
            health = maxHealth;
        }
    }
}
