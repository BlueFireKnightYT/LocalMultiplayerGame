using UnityEngine;
using UnityEngine.UI;
using SceneManager = UnityEngine.SceneManagement.SceneManager;

public class ControlsBtn : MonoBehaviour
{
    public GameObject Panel;
    public GameObject Settings;
    public GameObject SOS;
    public void Controls()
    {
        Panel.SetActive(!Panel.activeSelf);
        Settings.SetActive(false);
        SOS.SetActive(false);
    }
}