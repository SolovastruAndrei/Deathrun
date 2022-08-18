using UnityEngine;

public class ChangeDelayTime : MonoBehaviour
{
    public Animator anim;
    [SerializeField, Range(0.001f, 2.4f)] 
    private float delayAnim = 1f; 
    public void ChangeStateSpeed()
    {
        anim.speed = delayAnim;
    }
}
