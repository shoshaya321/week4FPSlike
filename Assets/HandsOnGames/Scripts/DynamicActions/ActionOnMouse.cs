using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace HOG.Utils
{
    public class ActionOnMouse : MonoBehaviour
    {
        public UnityEvent actionOnDown;
        public UnityEvent actionOnDrag;
        public UnityEvent actionOnUp;

        private void OnMouseDown()
        {
            actionOnDown.Invoke();
        }

        private void OnMouseDrag()
        {
            actionOnDrag.Invoke();
        }

        private void OnMouseUp()
        {
            actionOnUp.Invoke();
        }
    }
}
