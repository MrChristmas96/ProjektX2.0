using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    private PlayerActionControls menu;

    private void Awake()
    {
        menu = new PlayerActionControls();
        menu.Enable();
        menu.Esc.Menu.performed += _ => Esc();

        pauseMenuUI.SetActive(false);
    }

    private void Esc()
    {              
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
            Pause();
            }
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void Pause()
    {
        // pauser spillet med Time.timeScale = 0f
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void LoadMenu()
    {
        // loader Menu og sætter tid tilbage til normal tid
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
    public void QuitGame()
    {
        Debug.Log("Quitting game");
        Application.Quit();
    }
}
