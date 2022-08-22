using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
public class Respawn : MonoBehaviour
{
    public GameoverScript gameover;
    public static int lives = 10;
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;
    public TMP_Text deathText;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player.transform.position = respawnPoint.transform.position;
            lives--;
            deathText.text = "Lives: " + lives;
            if(lives<1)
            {
                lives = 11;
                gameover.Setup();
            }
        }
    }
}
