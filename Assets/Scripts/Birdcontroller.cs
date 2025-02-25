using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Birdcontroller : MonoBehaviour
{
    public float force;
    private Rigidbody2D rb;
    private Animator anim;
    private int Points = 0;
    public Text ScoreText;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ClickOnSpace();
        }
        else
        {
            anim.SetBool("Click", false);
        }

    }
    void ClickOnSpace()
    {
        rb.velocity = Vector2.up * force;
        anim.SetBool("Click", true);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene("MainMenu");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PipeScore")
        {
            Points++;
            ScoreText.text = Points.ToString();
        }
    }

}
