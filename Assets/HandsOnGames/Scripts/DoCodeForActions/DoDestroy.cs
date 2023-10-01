using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace HOG.Utils
{
    public class DoDestroy : MonoBehaviour
    {
        public void DestroyThisGameObject()
        {
            Destroy(this.gameObject);
        }
    }
}
