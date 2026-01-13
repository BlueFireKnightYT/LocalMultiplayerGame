using UnityEngine;

public class SpawnKey : MonoBehaviour
{
    public int pressedButtons = 0;
    public int neededButtons = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pressedButtons == neededButtons)
        {
            Instantiate(gameObject);
        }

    }
}
