using System.Collections;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public float delayAnim = 1f;
    void Start()
    {
        StartCoroutine(Go());
    }
    IEnumerator Go()
    {
        while(true)
        {
            FindObjectOfType<Animation>().Play();
            yield return new WaitForSeconds(delayAnim);
        }
    }
}
