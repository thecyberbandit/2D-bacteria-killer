using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject bubble;

    void Start()
    {
        InvokeRepeating("SpawnParticles", 3f, 20f);
    }

    public void SpawnParticles()
    {
        GameObject a = Instantiate(bubble) as GameObject;
        a.transform.position = spawnPoints[0].transform.position;
        GameObject b = Instantiate(bubble) as GameObject;
        b.transform.position = spawnPoints[1].transform.position;
        GameObject c = Instantiate(bubble, spawnPoints[2].position, Quaternion.identity);
        GameObject d = Instantiate(bubble, spawnPoints[3].position, Quaternion.identity);
        GameObject e = Instantiate(bubble, spawnPoints[4].position, Quaternion.identity);
    }


}
