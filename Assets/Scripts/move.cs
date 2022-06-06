using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed;

    private void Start()
    {
        Destroy(gameObject, 8);
    }
  
    void FixedUpdate()
    {
        if(kusscripts.startGame)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
     
    }
}
