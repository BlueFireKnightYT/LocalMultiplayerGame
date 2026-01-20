using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    public string levelName;
    public void SelectLevel()
    {
        SceneManager.LoadScene(levelName);
    }
}
