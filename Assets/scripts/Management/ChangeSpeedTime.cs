using UnityEngine;

public class ChangeSpeedTime : MonoBehaviour
{
    Animator anim;
    [SerializeField, Range(0.01f, 2.4f)] 
    private float speedAnim = 1f;

    void Start()
    {
        anim = GetComponent<Animator>();    
    }

    void Update()
    {
        anim.SetFloat("speed", speedAnim);
    }
}
