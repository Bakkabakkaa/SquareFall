using TMPro;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _currentScoreLabel;
    [SerializeField] private int _scorePerSquare;

    private int _currentScore;

    public void AddScore()
    {
        _currentScore += _scorePerSquare;

        _currentScoreLabel.text = _currentScore.ToString();
    }

    public int GetCurrentScore()
    {
        return _currentScore;
    }
}
