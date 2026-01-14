using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float speed = 5f;
    [SerializeField] float jumpHeight;
    [SerializeField] LayerMask jumpLayers;
    [SerializeField] Transform groundCheck;

    public bool performed;

    float InputX;


    void Update()
    {
        rb.linearVelocityX = InputX * speed;
    }

    public void Move(InputAction.CallbackContext context)
    {
        InputX = context.ReadValue<Vector2>().x;
    }
    public bool isGrounded()
    {
        var hits = Physics2D.OverlapCapsuleAll
        (
            groundCheck.position,
            new Vector2(1f, 0.5f),
            CapsuleDirection2D.Horizontal,
            0f,
            jumpLayers
        );

        return hits.Length > 0;
    }

    public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed && isGrounded() == true)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpHeight);
        }
    }

    public void Interact(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            performed = true;
            Debug.Log("on");
        }
        if (context.canceled)
        {
            performed = false;
            Debug.Log("off");
        }
    }
}
