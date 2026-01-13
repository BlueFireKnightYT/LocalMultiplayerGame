using UnityEngine;
using static UnityEngine.Rendering.DebugUI;
using SceneManager = UnityEngine.SceneManagement.SceneManager;

public class sosBtn : MonoBehaviour
{
    public GameObject Panel;
    public GameObject Settings;
    public GameObject Controls;
    public void sos()
    {
        Panel.SetActive(!Panel.activeSelf);
        Settings.SetActive(false);
        Controls.SetActive(false);
    }
}