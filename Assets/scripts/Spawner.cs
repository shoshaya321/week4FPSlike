using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefabToSpawen;
    public bool gateIsOpen = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreatGate()
    {
      gateIsOpen = true;
    Instantiate(prefabToSpawen, transform.position, transform.rotation);
    }
}
