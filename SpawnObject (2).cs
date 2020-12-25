using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public int RandoMs;
    public GameObject Clip;
    public GameObject[] SpawnPoints;

    void Start()
    {
        RandoMs = Random.Range(0, 2);
        if(RandoMs == 1)
        {
            Clip.transform.position = SpawnPoints[0].transform.position;
        }
        if (RandoMs == 2)
        {
            Clip.transform.position = SpawnPoints[1].transform.position;
        }
        if (RandoMs == 3)
        {
            Clip.transform.position = SpawnPoints[2].transform.position;
        }
    }

    
    void Update()
    {
        
    }
}
