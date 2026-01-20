using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class SettingsButton : MonoBehaviour
{
    public GameObject settingsPanel;
    private object activeSelf;

    public void OpenSettings()
    {
        settingsPanel.SetActive(!settingsPanel.activeSelf);

        if (settingsPanel.activeSelf == true)
            Time.timeScale = 0f;
        else
            Time.timeScale = 1f;
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
 