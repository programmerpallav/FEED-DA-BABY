using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PopupManager : MonoBehaviour
{
    public GameObject secondLevelStory;

    public void NextLevel()
    {
        secondLevelStory.SetActive(true);
    }

    public void StoryPlayButton()

    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1f;
    }

    public void Restart()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName);
        Time.timeScale = 1f;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MenuScreen");
        Time.timeScale = 1f;
    }
}
