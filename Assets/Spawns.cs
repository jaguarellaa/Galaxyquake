using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawns : MonoBehaviour
{
    public GameObject obstacle;
    public float maxX;
    public float maxY;
    public float minX;
    public float minY;
    public float time;
    public GameObject panel;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > time)
        {
            Spawn();
            time= Time.time+time;    
        }
    }

    void Spawn()
    {
        float randomX=Random.Range(minX, maxX);
        float randomy = Random.Range(minY, maxY);
        Instantiate(obstacle,panel.transform.position + new Vector3(randomX,randomy,0),transform.rotation);


    }
}
