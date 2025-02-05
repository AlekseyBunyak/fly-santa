using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private Text[] _scoreText;

    private float _score = 0;

    private void Update()
    {        
        _scoreText[0].text = $"Cчет: {_score}";
        _scoreText[1].text = $"¬аш счет: {_score}";
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("SnowBall"))
        {
            _score++;
        }
    }
}
