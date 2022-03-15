using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    private const float CAMERA_ORTHD_SIZE = 50f;
    private const float PIPE_WIDTH =7.8f;
    
    private void Start() {
        CreatePipe(50f, 0f);
        CreatePipe(50f, 20f);
    }

    private void CreatePipe(float height, float xPosition){
        Transform Logs = Instantiate(GameAssets.GetInstance().Logs);
    }
}
