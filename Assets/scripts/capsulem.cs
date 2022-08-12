using UnityEngine;
public class capsulem: MonoBehaviour
{
    CharacterController characterController;

    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
    public float currentspeed ;
    public float currentjumpSpeed ;
    public float currentgravity ;
    

    private Vector3 moveDirection = Vector3.zero;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        currentspeed = speed;
        currentjumpSpeed = jumpSpeed;
        currentgravity = gravity;
    }

    void Update()
    {
        if (characterController.isGrounded)
        {
       

            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            moveDirection *= speed;

            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }
        }

        
        moveDirection.y -= gravity * Time.deltaTime;

        // Move the controller
        characterController.Move(moveDirection * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }

    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        switch(hit.gameObject.tag)
        {
            case "SpeedPad":
                speed = 25f;
                break;
            case "JumpPad":
                jumpSpeed = 25f;
                break;
            case "SlowPad":
                speed = 0.5f;
                break;
            case "Ground":
                speed = currentspeed;
                jumpSpeed = currentjumpSpeed;
                break;
        }
    }
}