using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace HOG.Utils
{
    public class ActionOnKey : MonoBehaviour
    {
        public UnityEvent actionToDo;
        public KeyCode keyDown = KeyCode.None;
        public KeyCode keyHold = KeyCode.None;
        public KeyCode keyRelease = KeyCode.None;

        // Update is called once per frame
        void Update()
        {
            if(Input.GetKeyDown(keyDown))
            {
                actionToDo.Invoke();
            }

            if (Input.GetKey(keyHold))
            {
                actionToDo.Invoke();
            }

            if (Input.GetKeyUp(keyRelease))
            {
                actionToDo.Invoke();
            }
        }
    }
}
