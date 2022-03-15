using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipaScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    
    

    private void Start()
    {   
        

    }

    // Update is called once per frame
    private void Update()
    {
        transform.position += ((Vector3.left * speed) * Time.deltaTime);

        if(GameControl.instance.gameOver == true){
            speed = 0f;
        }

        // if(GameControl.instance.play == true){
        //     Log.SetActive(true);
        //     Log2.SetActive(true);
        // }
    }

    public void Pause(){
        speed = 0f;
    }
}
