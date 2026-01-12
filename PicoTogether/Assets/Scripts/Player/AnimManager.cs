using UnityEngine;

public class AnimManager : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField]  Animator anim;
    [SerializeField]  SpriteRenderer sr;
    void Update()
    {
        if (rb.linearVelocityX > 0)
        {
            anim.SetBool("walking", true);
            sr.flipX = true;
        }
        else if (rb.linearVelocityX < 0)
        {
            anim.SetBool("walking", true);
            sr.flipX = false;
        }
        else
        {
            anim.SetBool("walking", false);
        }
    }
}
