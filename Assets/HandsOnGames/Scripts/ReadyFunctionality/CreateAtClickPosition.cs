using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace HOG.Utils
{
    public class CreateAtClickPosition : MonoBehaviour
    {
        public GameObject objectToCreate;

        // Update is called once per frame
        void Update()
        {
            if(Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                if(Physics.Raycast(ray, out RaycastHit hit, 1000f))
                {
                    Instantiate(objectToCreate, hit.point, objectToCreate.transform.rotation);
                }
            }
        }
    }
}
