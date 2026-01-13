using UnityEngine;
using static UnityEngine.Rendering.DebugUI;
using SceneManager = UnityEngine.SceneManagement.SceneManager;

public class SettingsBtn : MonoBehaviour
{
    public GameObject Panel;
    public GameObject SOS;
    public GameObject Controls;
    public void Settings()
    {
        Panel.SetActive(!Panel.activeSelf);
        SOS.SetActive(false);
        Controls.SetActive(false);
    }
}