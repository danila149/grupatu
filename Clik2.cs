using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScoreSys;

namespace Core2
{
    public class Clik2 : MonoBehaviour
    {
        private Score score;
        private HingeJoint mbox;

        private void Start()
        {
            mbox = gameObject.GetComponent<HingeJoint>();
        }
        private void Update()
        {
            var motor = mbox.motor;
            Debug.Log("1");
            if (transform.position.x >= 2.017258) 
            {
                Debug.Log("2");
                motor.targetVelocity += 200;
            }else if(transform.position.x <= -1.97)
            {
                Debug.Log("3");
                motor.targetVelocity += -200;
            }
            gameObject.GetComponent<HingeJoint>().motor = motor;
        }

        private void OnMouseDown()
        {

            score.PlayerScore += 5;

        }

        public void Construct(Score score)
        {
            this.score = score;
        }
    }
}

