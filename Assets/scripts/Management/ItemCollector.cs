using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;


public class ItemCollector : MonoBehaviour
{
    public GameoverScript gameOverScript;
    static int coins = 0;
    public TMP_Text coinsText;
    public TMP_Text deathText;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            coins++;
            coinsText.text = "Coins: " + coins;
            gameOverScript.coins(coins);
        }
        if (other.gameObject.CompareTag("Inima"))
        {
            Destroy(other.gameObject);
            Respawn.lives++;
            deathText.text = "Lives: " + Respawn.lives;

        }
    }


}
