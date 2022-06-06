using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kusscripts : MonoBehaviour
{
    public bool isDead;

    public float velocity = 1f;
    public Rigidbody2D rb2D;

    public GameManager managerGame;

    public GameObject OlumEkrani;

    public Rigidbody2D rb;
    public GameObject startbutton;
    public GameObject textGameObject;
    bool startActive;
    public AudioSource coin, yanma, ziplama;
    public static bool startGame;
    public UnityEngine.UI.Text maxScoreText;
    private void Start()
    {
        Time.timeScale = 1;
        kusscripts.startGame = false;
        if(PlayerPrefs.GetInt("maxscor")==0)
        {
            maxScoreText.gameObject.SetActive(false);
        }
        else
        {
            maxScoreText.text = "Max Score " + PlayerPrefs.GetInt("maxscor");
        }

    }



    void Update()
    {


        //t?klamay? al
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("deneme");
            //havada ku?u s??ratma

            if (startActive)
            {
                if (kusscripts.startGame == false)
                {
                    rb.simulated = true;
                    textGameObject.SetActive(false);
                    kusscripts.startGame = true;
                }
            }
           
                rb2D.velocity = Vector2.up * velocity;
            if(rb.simulated==true)
            {
                ziplama.Play();
            }
            
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "skoralani")
        {

            managerGame.UpdateScore();
            coin.Play();
            Destroy(collision.gameObject);

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "OlumAlani")
        {
            isDead = true;
            Time.timeScale = 0;
            yanma.Play();

            OlumEkrani.SetActive(true);
        }
    }
    public void startButton()
    {
        startActive = true;
        textGameObject.SetActive(true);
        startbutton.SetActive(false);
        maxScoreText.gameObject.SetActive(false);

    }
    public void Dead()
    {
        isDead = true;
        Time.timeScale = 0;
        yanma.Play();

        OlumEkrani.SetActive(true);
    }
}
