using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    private float speed = 20.0f;
    int ball = 105;
    public static int score = 0;

    public AudioClip sound1;
    AudioSource audioSource;

    void Start()
    {

        score = 0;

        audioSource = GetComponent<AudioSource>();

        this.GetComponent<Rigidbody>()
        .AddForce(
          (transform.forward + transform.right) * speed, ForceMode.VelocityChange
        );
    }

    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Block"){
            audioSource.PlayOneShot(sound1);
            score++;
        } else if (collision.gameObject.tag == "BottomWall"){
            this.GetComponent<Rigidbody>()
            .velocity = Vector3.zero;
            SceneManager.LoadScene("Fin");
        }

        if(score == ball)
        {
            SceneManager.LoadScene("Fin");
        }

    }

    public static int getScore()
    {
        return score;
    }

}
