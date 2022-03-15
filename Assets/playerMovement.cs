using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class playerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D Rb;
    public float jumpforce ;
    // public float velocity = 2.4f;
    float score;
    public Animator anim;
    public Text scoreTxt;
    public ScoreManager ScoreManager;

    private void Awake()
    {
        Rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void Update()
    {
        // scoreTxt.text = "" + score;

        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)){
            Jump();
        }
    }

    public void Jump(){
        Rb.velocity = Vector2.up * jumpforce;
        anim.SetTrigger("slime");
    }

    // public void RestartGame(){
    //     EditorSceneManager.LoadScene(0);
    // }

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.tag == "point"){
            ScoreManager.AddScore();
        }
        if(collision.gameObject.tag == "pipa"){
            GameControl.instance.SlimeDied();
            Rb.velocity = Vector2.zero;
            Rb.gravityScale = 12f;
            jumpforce = 0f;
            anim.enabled = false;
            //FindObjectOfType<GameControl>().GameOver();
            //GameControl.instance.Pause();
            //Destroy(gameObject);
            //RestartGame();
        }
        if(collision.gameObject.tag == "platform"){
            //FindObjectOfType<GameControl>().GameOver();
            GameControl.instance.SlimeDied();
            Rb.constraints = RigidbodyConstraints2D.FreezeAll;
            anim.enabled = false;
            //Rb.angularVelocity = Vector3.zero;
            // GameControl.instance.Pause();
            //Destroy(gameObject);
            // RestartGame();
    }
    }
}
