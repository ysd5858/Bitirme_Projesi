using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OppositeBird : MonoBehaviour
{
    public Transform player,firePoint;    
    public Rigidbody2D rb;    
    public GameObject bullet;
    private void Start()
    {
        player = FindObjectOfType<kusscripts>().gameObject.transform;
        transform.rotation = Quaternion.Euler(0, 0, 180);
    }
    public void setPosition()
    {
        Vector3 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
        direction.Normalize();
    }

    public IEnumerator Shoot()
    {
        Instantiate(bullet, firePoint.position, transform.rotation);        
        yield return new WaitForSeconds(2);
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, 180), 2);
    }
    public void Destroy()
    {
        Destroy(gameObject);
    }
}
