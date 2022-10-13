using ScoreSys;
using InputSus;

namespace Core
{
    public class Game
    {
        public const int shet = 5;
        public Score score;
        private Esc input;


        public Game(Score score, Esc input)
        {
            this.score = score;
            this.input = input;
            StartGame();
            
        }

        private void StartGame()
        {
            score.PlayerScore = shet;
            input.OnExitInput += QuiteGame;
        }

        private void QuiteGame()
        {
            score.PlayerScore = 0;
            input.OnExitInput -= QuiteGame;
        }

    }
}
