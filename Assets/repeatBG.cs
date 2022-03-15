using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class repeatBG : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    public float animationSpeed = 0.1f;

    private void Awake(){
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update(){
        meshRenderer.material.mainTextureOffset += new Vector2(animationSpeed * Time.deltaTime, 0);

        if(GameControl.instance.gameOver == true){
            //Time.timeScale = 0f;
            animationSpeed = 0f;
        }
        // if(GameControl.instance.startButton == true){
        //     //Time.timeScale = 0f;
        //     animationSpeed = 0.1f;
        // }
        
    }

}
