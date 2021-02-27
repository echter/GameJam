using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{

    public GameObject mainMenu;
    public GameObject optionsMenu;
    public GameObject explainationMenu;
    public GameObject controlsMenu;

    // Start is called before the first frame update
    void Start()
    {
        LoadMainMenu();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadControlsMenu()
    {
        mainMenu.SetActive(false);
        explainationMenu.SetActive(false);
        controlsMenu.SetActive(true);
        optionsMenu.SetActive(false);
    }

    public void LoadExplainationMenu()
    {
        mainMenu.SetActive(false);
        explainationMenu.SetActive(true);
        controlsMenu.SetActive(false);
        optionsMenu.SetActive(false);
    }

    public void LoadOptionsMenu()
    {
        mainMenu.SetActive(false);
        explainationMenu.SetActive(false);
        controlsMenu.SetActive(false);
        optionsMenu.SetActive(true);
    }

    public void LoadMainMenu()
    {
        mainMenu.SetActive(true);
        explainationMenu.SetActive(false);
        controlsMenu.SetActive(false);
        optionsMenu.SetActive(false);
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
