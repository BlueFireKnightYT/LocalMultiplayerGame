using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    public int pressedButtons = 0;
    public int neededButtons = 0;
    public int enteredDoor = 0;
    public bool key = false;

    public SpriteRenderer doorSr;
    public GameObject pref_Key;
    public Sprite doorOpen;

    public Transform keyTrans;

    void Update()
    {
        if (pressedButtons == neededButtons)
        {
            Instantiate(pref_Key, keyTrans);
            pressedButtons = 9999;
        }

        if (enteredDoor >= 2)
        {
            Debug.Log("nextLeeeeeee");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
