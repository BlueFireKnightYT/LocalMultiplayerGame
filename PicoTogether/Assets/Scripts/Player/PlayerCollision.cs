using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public Gamemanager gm;
    SpriteRenderer btnSprite;

    public Sprite btnNotPressed;
    public Sprite btnPressed;

    int buildindex = 0;
    
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
            gm.key = true;
            gm.doorSr.sprite = gm.doorOpen;
        }
        else if (other.CompareTag("door"))
        {
            if (gm.key == true)
            {
                buildindex = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(buildindex);
            }
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("button"))
        {
            gm.pressedButtons =- 1;
            btnSprite = other.GetComponent<SpriteRenderer>();
            btnSprite.sprite = btnNotPressed;
        }
    }
}
