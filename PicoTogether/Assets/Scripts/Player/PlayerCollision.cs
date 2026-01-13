using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public Gamemanager gm;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("button"))
        {
            gm.pressedButtons++;
        }
        else if (other.CompareTag("key"))
        {
            gm.key = true;
            gm.doorSprite.color = Color.black;
        }
        else if (other.CompareTag("door"))
        {
            if (gm.key == true)
            {
                SceneManager.LoadScene("Level2");
            }
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("button"))
        {
            gm.pressedButtons =- 1;
        }
    }
}
