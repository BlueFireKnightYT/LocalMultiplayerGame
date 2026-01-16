using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    public bool button1 = false;
    public bool button2 = false;
    private bool keyspawned = false;
    public bool key = false;
    public int enteredDoor = 0;

    public SpriteRenderer doorSr;
    public GameObject pref_Key;
    public Sprite doorOpen;

    public Transform keyTrans;

    void Update()
    {
        if (button1 == true && button2 == true && keyspawned == false)
        {
            Instantiate(pref_Key, keyTrans);
            keyspawned = true;
        }

        if (enteredDoor >= 2)
        {
            Debug.Log("nextLeeeeeee");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
