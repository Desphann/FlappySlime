using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerPipe : MonoBehaviour
{
    public float quequeTime = 2.5f;
    public float time = 0;
    public GameObject obstacle;
    public float height;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if(time > quequeTime){
            GameObject go = Instantiate(obstacle);
            go.transform.position = transform.position + new Vector3(0, Random.Range(-height, height),0);
            time = 0;
            //Destroy(go, 25);           
    }
        time += Time.deltaTime;
    }
}
