using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrigger : MonoBehaviour
{
    public GameObject player;
    //public Animator anim;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Enemy"))
        {
            player.SetActive(false);
            //anim.StopPlayback();
            FindObjectOfType<ChangeSpeedTime>().GetComponent<Animator>().StopPlayback();
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
