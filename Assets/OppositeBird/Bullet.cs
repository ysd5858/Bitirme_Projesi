using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public GameObject expoEffect;
    public AudioSource soundEffect;
    private void Start()
    {
        rb.velocity = transform.right * speed;
        soundEffect.gameObject.SetActive(true);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            StartCoroutine(dead(collision));
        }
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
    IEnumerator dead(Collider2D collision)
    {
        collision.gameObject.GetComponent<kusscripts>().velocity = 0;
        collision.gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
        GameObject effect = Instantiate(expoEffect, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(1);
        collision.gameObject.GetComponent<kusscripts>().Dead();
    }
}
