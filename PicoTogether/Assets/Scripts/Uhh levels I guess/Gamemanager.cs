using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    public GameObject pref_Key;
    public int pressedButtons = 0;
    public int neededButtons = 0;
    public bool door = false;
    public bool key = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pressedButtons == neededButtons)
        {
            Instantiate(pref_Key, new Vector2(-0.25f, -1.75f), Quaternion.identity);
        }

        if(door == true && key == true && Input.GetKeyDown("e"))
        {
            SceneManager.LoadScene("Level2");
        }
    }
}
