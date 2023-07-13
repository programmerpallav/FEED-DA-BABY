using UnityEngine;
using TMPro;

public class PointCollection : MonoBehaviour
{
    private int score;
    public TextMeshProUGUI scoreText;
    public AudioSource collectiblesSfx;
    public AudioSource obstaclesSfx;
    public AudioSource babyGiggle;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Items"))
        {
            collectiblesSfx.Play();
            Destroy(collision.gameObject);
            score++;
            scoreText.text = score.ToString() + " " + "points";
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
        }
    }
}
