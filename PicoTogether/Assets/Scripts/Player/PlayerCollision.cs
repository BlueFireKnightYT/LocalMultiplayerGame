using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public Gamemanager gm;
    SpriteRenderer btnSprite;

    public Sprite btnNotPressed;
    public Sprite btnPressed;

    int buildindex = 0;

    private void Update()
    {
        if (gm.enteredDoor >= 2)
        {
            Debug.Log("nextLeeeeeee");
            buildindex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(buildindex + 1);
        }

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("button"))
        {
            gm.pressedButtons += 1;
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
