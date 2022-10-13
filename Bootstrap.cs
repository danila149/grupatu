using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScoreSys;
using InputSus;

namespace Core
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private Click _click;
        [SerializeField] private Esc _esc;
        [SerializeField] private ScoreViee _text;
        private Game game;
        private Score score;

        private void Awake()
        {
            score = new Score();
            game = new Game(score, _esc);
            _click.Construct(score);
            _text.GetScore(score);
        }

    }
}

