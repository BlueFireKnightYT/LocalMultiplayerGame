using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    public int pressedButtons = 0;
    public int neededButtons = 0;
    public bool key = false;

    public SpriteRenderer doorSr;
    public GameObject pref_Key;
    public Sprite doorOpen;


    private void Start()
    {
        
    }

    void Update()
    {
        if (pressedButtons == neededButtons)
        {
            Instantiate(pref_Key, new Vector2(-0.25f, -1.75f), Quaternion.identity);
            pressedButtons = 3;
        }
    }
}
