using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NavigationScript : MonoBehaviour
{
    public GameObject firstLevelStory;

    public void PlayButton()

    {
        firstLevelStory.SetActive(true);
    }

    public void StoryPlayButton()

    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Level2Button()
    {
        SceneManager.LoadScene(2);
    }
}
