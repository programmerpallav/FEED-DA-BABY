using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NavigationScript : MonoBehaviour
{
    public GameObject firstLevelStory;

    public void StoryPlayButton()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }

    public void PlayButton()
    {
        firstLevelStory.SetActive(true);
    }


    public void Level2Button()
    {
        SceneManager.LoadScene(2);
    }

    public void Level3Button()
    {
        SceneManager.LoadScene(3);
    }

}
