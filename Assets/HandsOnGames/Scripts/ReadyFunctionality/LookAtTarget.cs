using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HOG.Utils
{
    public class LookAtTarget : MonoBehaviour
    {
        public Transform target;

        // Update is called once per frame
        void Update()
        {
            transform.LookAt(target);
        }
    }
}
