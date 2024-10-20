using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int jumpspeed;
    Rigidbody2D rb;
    public AudioSource jumpSource;
    public AudioSource dieSource;
    public GameObject gameover;
    public GameManager gameManager;
    bool dead;

    // Start is called before the first frame update
    void Start() {

        jumpspeed = 0;
        Pipe.speed = 0;
        rb= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //jump
        if(Input.GetKeyDown(KeyCode.Space) && !dead)
        {
            jumpspeed = 3;
            Pipe.speed = 3;
            rb.simulated = true;
            rb.velocity = new Vector2(0, jumpspeed);
            gameManager.GameStart();
            jumpSource.Play();
        }


        //rotate
        transform.eulerAngles = new Vector3(0, 0, rb.velocity.y *3f);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        jumpspeed = 0;
        Pipe.speed = 0;
        //rb.simulated = false;
        gameover.SetActive(true);
        dieSource.Play();
        gameManager.GameOver();
        dead = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        gameManager.score++;
    }
}
