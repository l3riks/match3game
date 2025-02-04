using TMPro;
using UnityEngine;

public sealed class ScoreContainer : MonoBehaviour
{
    public string ItemName;

    private int _scoreItem;

    public int ScoreItem
    {
        get => _scoreItem;

        set
        {
            if(_scoreItem == value && _scoreItem != 0) return;

            _scoreItem = value;

            scoreText.SetText($"{_scoreItem}");
        }
    }

    [SerializeField] private TextMeshProUGUI scoreText;
}
