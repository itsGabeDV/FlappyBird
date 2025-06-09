using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //needed to load scenes
public class MainMenu : MonoBehaviour
{
    public void PlayGame() //load level 1
    {
        Debug.Log("Game Started");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //get currently loaded level and load next level in queue.
    }

    public void OptionMenu()
    {
        Debug.Log("Options Menu");
        
    }

    public void QuitQame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
