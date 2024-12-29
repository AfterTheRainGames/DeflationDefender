using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public Canvas MM; //Main Menu
    public Canvas LS; //Level Select
    public Button LSButton;
    public Button L1;
    public Button L2;

    void Start()
    {
        MM.gameObject.SetActive(true);
        LS.gameObject.SetActive(false);
        LSButton.onClick.AddListener(LSButtonClicked);
        L1.onClick.AddListener(L1ButtonClicked);
        L2.onClick.AddListener(L2ButtonClicked);
    }

    void LSButtonClicked()
    {
        MM.gameObject.SetActive(false);
        LS.gameObject.SetActive(true);
    }

    void L1ButtonClicked()
    {
        LoadScene("GrassLevel");
        LS.gameObject.SetActive(false);
    }

    void L2ButtonClicked()
    {
        LoadScene("WinterLevel");
        LS.gameObject.SetActive(false);
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

}
