using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public Gamemanager gm;
    public Movement m;

    SpriteRenderer btnSprite;

    public Sprite btnNotPressed;
    public Sprite btnPressed;

    public GameObject lineMaker;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("button"))
        {
            gm.pressedButtons++;
            btnSprite = other.GetComponent<SpriteRenderer>();
            btnSprite.sprite = btnPressed;
        }
        else if (other.CompareTag("key"))
        {
            Destroy(other.gameObject);
            gm.key = true;
            gm.doorSr.sprite = gm.doorOpen;
        }
        else if (other.CompareTag("door"))
        {
            if (gm.key == true)
            {
                gm.enteredDoor++;
                Debug.Log(gm.enteredDoor);
                Destroy(this.gameObject);
                Destroy(lineMaker);
            }
        }
        else if (other.CompareTag("lever"))
        {
            if (m.performed == true)
            {

            }
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("button"))
        {
            gm.pressedButtons -= 1;
            btnSprite = other.GetComponent<SpriteRenderer>();
            btnSprite.sprite = btnNotPressed;
        }
    }
}
