using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boruspawner : MonoBehaviour
{

    public kusscripts kusscritp;

    public GameObject Borular,oppoBird, oppoBird2;
    public Transform oppoBirdSpawnPoint, oppoBirdSpawnPoint2;

    public float height;

    public float time;
    float globalTime;
    public float randomValue;
    public float Waittime;

    private void Start()
    {
        globalTime =0;
    }

    private void Update()
    {
        if (!kusscripts.startGame)
            return;
        globalTime -= Time.deltaTime;

        if (kusscripts.startGame)
        {
            Waittime += Time.deltaTime;
        }
        if(globalTime<=0)
        {
            randomValue = Random.Range(-height, height);

            Instantiate(Borular, new Vector3(1, randomValue, 0), Quaternion.identity);
           
            globalTime = time;
        }
        if(Waittime >= 10)
        {
            int i = Random.Range(0, 10);
            if(i % 2 == 0)
            {
                Instantiate(oppoBird, oppoBirdSpawnPoint.position, Quaternion.identity);
                Waittime = 0;
            }
            else
            {
                Instantiate(oppoBird2, oppoBirdSpawnPoint2.position, Quaternion.identity);
                Waittime = 0;
            }
        }


    }
   
   

}
