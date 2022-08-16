using System.Collections;
using UnityEngine;

public class Trap : MonoBehaviour
{ 
    void Start()
    {
        StartCoroutine(Go());
    }
    IEnumerator Go()
    {
        while(true)
        {
            FindObjectOfType<Animation>().Play();
            yield return new WaitForSeconds(1f);
        }
    }
}
