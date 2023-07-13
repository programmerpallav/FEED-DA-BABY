using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    public GameObject levelComplete;
    public GameObject GameOver;
    public GameObject ScoreUI;
    private void OnTriggerEnter(Collider other)

    {

        if (other.tag == "Spoon" && gameObject.tag == "Items")
        {
            Destroy(gameObject);
        }

        if (other.tag == "Spoon" && gameObject.tag == "Child")
        {
            levelComplete.SetActive(true);
            ScoreUI.SetActive(false);
            Time.timeScale = 0;
        }

        //if (other.tag == "Spoon" && gameObject.tag == "Obstacle")
        {
            //GameOver.SetActive(true);
            //Time.timeScale = 0;
        }
    }
}
