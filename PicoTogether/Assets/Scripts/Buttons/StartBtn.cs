using UnityEngine;
using SceneManager = UnityEngine.SceneManagement.SceneManager;

public class StartBtn : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}