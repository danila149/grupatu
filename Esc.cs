using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace InputSus
{
    public class Esc : MonoBehaviour
    {
        [SerializeField] private KeyCode _exitCode;
        public Action OnExitInput;
        

        private void Update()
        {
            if (UnityEngine.Input.GetKeyDown(_exitCode))
            {
                OnExitInput?.Invoke();
            }
        }
    }
}

