using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using ScoreSys;

public class ScoreViee : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _text;
    Score score;

    public void GetScore(Score score)
    {
        this.score = score;
    }
    void Update()
    {
        _text.text = $"{score.PlayerScore}" ;
    }
}
