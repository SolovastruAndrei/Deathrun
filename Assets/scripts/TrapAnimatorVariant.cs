using System.Collections;
using UnityEngine;

public class TrapAnimatorVariant : MonoBehaviour
{
    Animator anim;
    public float delayAnimation = 50f;
    void Start()
    {
        anim = GetComponent<Animator>();
        StartCoroutine(Go());
    }
    IEnumerator Go()
    {
        anim.Play("Moving Wall");
        yield return new WaitForSeconds(delayAnimation);
    }
}
