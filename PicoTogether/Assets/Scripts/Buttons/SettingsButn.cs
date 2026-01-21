using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class SettingsButton : MonoBehaviour
{
    public GameObject settingsPanel;
    
    public void OpenSettings()
    {
        if (settingsPanel.activeSelf == true)
        { 
            Time.timeScale = 1f;
            settingsPanel.SetActive(false);
        }
        else
        { 
            Time.timeScale = 0f;
            settingsPanel.SetActive(true);
        }
    }
    public void ReturnToMenu()
    {
        Time.timeScale = 1f;
        UnityEngine.SceneManagement.SceneManager.LoadScene("StartScene");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void LevelSelector()
    {
        Time.timeScale = 1f;
        UnityEngine.SceneManagement.SceneManager.LoadScene("LevelSelector");
    }
}
 