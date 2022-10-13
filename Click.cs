using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScoreSys;

namespace Core
{
    public class Click : MonoBehaviour
    {
        private Score score;

        private void OnMouseDown()
        {
            
                score.PlayerScore -= 1;
            
        }

        public void Construct(Score score)
        {
            this.score = score;
        }
    }
}

