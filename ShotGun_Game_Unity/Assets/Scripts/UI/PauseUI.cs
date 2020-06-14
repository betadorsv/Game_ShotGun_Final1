using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseUI : MonoBehaviour
{
    public static bool GameIsPause = false;
    public GameObject pauseUI;

    // Start is called before the first frame update
    void Start()
    {
        pauseUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPause)
            {
                Resume();
            }
            else
            {
                Pause();
            }

        }
     


    }

    public void Pause()
    {
        pauseUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPause = true;
    }

    public void Resume()
    {
        pauseUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPause = false;
    }
    public void Restart()
    {
        GameIsPause = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }
    public void quit()
    {
        Application.Quit();
    }
}


