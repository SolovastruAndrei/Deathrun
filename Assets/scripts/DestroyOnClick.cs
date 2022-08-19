using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnClick : MonoBehaviour
{
    public RayCastGunScript raycast;
 
    private void OnMouseDown()
    {
        raycast.Tinte();
        Destroy(gameObject);
        
    }
}
