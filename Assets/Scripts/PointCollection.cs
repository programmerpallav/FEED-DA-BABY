using UnityEngine;
using TMPro;

public class PointCollection : MonoBehaviour
{
    private int score;
    public GameObject starOne;
    public GameObject starTwo;
    public GameObject starThree;
    public TextMeshProUGUI scoreText;
    public AudioSource collectiblesSfx;
    public AudioSource obstaclesSfx;
    public AudioSource babyGiggle;
    public AudioSource backgroundMusicfx;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Items"))
        {
            collectiblesSfx.Play();
            Destroy(collision.gameObject);
            score++;
            scoreText.text = score.ToString() + " " + "points";

            if (score >= 1 && score <= 3)
            {
                starOne.SetActive(false);
                starTwo.SetActive(true);
                starThree.SetActive(false);
            }

            if (score > 3 && score <= 7)
            {
                starOne.SetActive(true);
                starTwo.SetActive(true);
                starThree.SetActive(false);
            }

            if (score > 7 && score <= 10)
            {
                starOne.SetActive(true);
                starTwo.SetActive(true);
                starThree.SetActive(true);
            }
        }

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            obstaclesSfx.Play();
            Destroy(collision.gameObject);
            score--;
            scoreText.text = score.ToString() + " " + "points";
        }

        if (collision.gameObject.CompareTag("Child"))
        {
            babyGiggle.Play();
            Destroy(collision.gameObject);
            backgroundMusicfx.Stop();
        }
    }
}
