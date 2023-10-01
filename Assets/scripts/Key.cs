using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject enemyToSpawen;
    public GameObject Hand;
    bool EnemyCreated = false;
    public float countDown = 5f;

    private void Update()
    {
        if (FindObjectOfType<Spawner>().gateIsOpen)
        {
            countDown -= Time.deltaTime;
        }

        if (countDown <= 0)
        {
            CreatEnemy();
            countDown = 5f;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            transform.position = Hand.transform.position;
            transform.SetParent(Hand.transform);

          CreatEnemy();
            
        }
    }

    void CreatEnemy()
    {
      
        for (int i = 0; i< 10; i++)
        {
            int tempx = Random.Range(-11, -36);//ציר האיקס בפוזישן
            int tempz = Random.Range(-14, 12);
            int tempy = Random.Range(10, 25);
            Vector3 newPos = new Vector3(tempx, tempy, tempz);
            Instantiate(enemyToSpawen, newPos, enemyToSpawen.transform.rotation);
        }
    }
}
