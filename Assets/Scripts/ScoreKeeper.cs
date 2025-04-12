using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    public static ScoreKeeper Instance;
    int correctAnswers = 0;
    int questionsSeen = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int GetCorrectAnswers()
    {
        return correctAnswers;
    }
    public void IncrementCorrectAnswers()
    {
        correctAnswers++;
    }

    public int GetQuestionsSeen()
    {
        return questionsSeen;
    }
    public void IncrementQuestionsSeen()
    {
        questionsSeen++;
    }

    public int CalculateScore()
    {
        return Mathf.RoundToInt(correctAnswers/ (float)questionsSeen * 100);
    }

    void Awake()
    {
        Instance = this;
    }

}
