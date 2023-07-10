using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PointCollection : MonoBehaviour
{
    private int score;
    public TextMeshProUGUI scoreText;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Items"))
        {
            Destroy(collision.gameObject);
            score++;
            scoreText.text = score.ToString() + "points";
        }
    }
}
