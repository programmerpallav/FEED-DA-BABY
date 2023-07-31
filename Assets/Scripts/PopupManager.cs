using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PopupManager : MonoBehaviour
{
    public GameObject secondLevelStory;
    public GameObject thirdLevelStory;
    public GameObject fourthLevelStory;

    public void StoryPlayButton()
    {
        int currentSceneBuildIndex = SceneManager.GetActiveScene().buildIndex;

        if (currentSceneBuildIndex + 1 < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(currentSceneBuildIndex + 1);
            Time.timeScale = 1f;
        }
        else
        {
            SceneManager.LoadScene(0);
            Time.timeScale = 1f;
        }
    }

    public void NextLevel()
    {
        secondLevelStory.SetActive(true);
        thirdLevelStory.SetActive(true);
        fourthLevelStory.SetActive(true);
    }


    public void Restart()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName);
        Time.timeScale = 1f;

    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
}
