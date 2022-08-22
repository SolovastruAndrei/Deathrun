using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public TMP_Text deathText;
    public HealthBar healthBar;
     public  GameoverScript gameover;
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        

}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Tinta"))
        {
            TakeDamage(5);
         
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        if(currentHealth<0)
        {
            Respawn.lives--;
            Start();
            deathText.text = "Lives: " + Respawn.lives;
            if(Respawn.lives<1)
            {
                Respawn.lives = 11;
                gameover.Setup();
            }

        }
    }
  
   
    
}
