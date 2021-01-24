using UnityEngine;

public class enemy : MonoBehaviour
{
    public float health = 51f;

    public static float hitEnemy = 0f;




    public void Start()
    {

    }
    
    public void TakeDamage (float amount)
    {
        
        health -= amount;
        if(health <= 0f)
        {
            Die();
            hitEnemy += 1;

        }
    }

    void Die()
    {
        Destroy(gameObject);
    }

}
