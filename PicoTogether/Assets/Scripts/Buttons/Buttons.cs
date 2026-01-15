using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    //public GameObject panel;
    public GameObject settings;
    public GameObject controls;

    public void StartGame()
    {
        SceneManager.LoadScene("Level1");
    }

    public void Settings()
    {
        settings.SetActive(true);
        controls.SetActive(false);
    }

    public void Controls()
    {
        //panel.SetActive(!panel.activeSelf);
        controls.SetActive(true);
        settings.SetActive(false);
    }
}