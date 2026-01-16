using System;
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
        if (other.CompareTag("button1"))
        {
            gm.button1 = true;
            btnSprite = other.GetComponent<SpriteRenderer>();
            btnSprite.sprite = btnPressed;
        }
        else if (other.CompareTag("button2"))
        {
            gm.button2 = true;
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
            if (m.interact == true)
            {

            }
        }
        else if (other.CompareTag("Respawn"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Debug.Log("Patatje");
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("button1"))
        {
            gm.button1 = false;
            btnSprite = other.GetComponent<SpriteRenderer>();
            btnSprite.sprite = btnNotPressed;
        }
        else if (other.CompareTag("button2"))
        {
            gm.button2 = false;
            btnSprite = other.GetComponent<SpriteRenderer>();
            btnSprite.sprite = btnNotPressed;
        }
    }
}
