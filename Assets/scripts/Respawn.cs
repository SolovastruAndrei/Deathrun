using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
public class Respawn : MonoBehaviour
{
    public GameoverScript gameover;
    static int deaths = 0;
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;
    public TMP_Text deathText;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player.transform.position = respawnPoint.transform.position;
            deaths++;
            deathText.text = "Number of deaths: " + deaths;
            if(deaths>10)
            {
                gameover.Setup();
            }
        }
    }
}
