using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Text scoreText;
    private int score;

    void Start()
    {
        Initialize();
    }

    void Update()
    {
        scoreText.text = score.ToString();
    }

    private void Initialize()
    {
        score = 0;
    }

    public void AddPoint(int point)
    {
        score = score + point;
    }

}