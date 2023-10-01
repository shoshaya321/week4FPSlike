using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace HOG.Utils
{
    public class DoMove : MonoBehaviour
    {
        public float MoveSpeed = 10f;

        public void MoveDirection(Vector3 direction)
        {
            transform.position += direction * Time.deltaTime * MoveSpeed;
        }

        public void MoveX(float xAmount)
        {
            transform.position += transform.right * xAmount * Time.deltaTime * MoveSpeed;
        }

        public void MoveY(float yAmount)
        {
            transform.position += transform.forward * yAmount * Time.deltaTime * MoveSpeed;
        }
    }
}
