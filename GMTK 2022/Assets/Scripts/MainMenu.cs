using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public GameObject SettingsMenu;
    public GameObject MainMenuUI;
    private bool isSettings;

   void Update()
    {


        if (Input.GetKeyDown(KeyCode.E))
        {
            LoadGame();
        }
    }
 


   

    public void LoadGame()
    {
        Debug.Log("a");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        

    }

    public void SettingsMenuScreen()
    {
        if (isSettings == false)
        {
            isSettings = true;
            MainMenuUI.SetActive(false);
            SettingsMenu.SetActive(true);
        } else if (isSettings == true)
        {
            MainMenuUI.SetActive(true);
            SettingsMenu.SetActive(false);
            isSettings = false;
        }



    }

    public void SetVolume (float volume)
    {

        Debug.Log(volume);

    }





    public void QuitGame()
    {
        Debug.Log("quit");
        Application.Quit();
    }
}
