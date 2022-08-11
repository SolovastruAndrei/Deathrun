using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEnemyTrigger : MonoBehaviour
{
    public int lives = 3;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            --lives;
            Instantiate(gameObject, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
