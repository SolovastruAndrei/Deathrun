using UnityEngine;

public class PlayerLives : MonoBehaviour
{
    public int lives = 3;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Enemy")
        {
            --lives;
        }
    }
}
