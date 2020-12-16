using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public List<Transform> spawnPoints;
    //public Sprite[] badBacterias;

    public GameObject[] spawnedObjects;
    public GameObject parent;

    //private bool isSpawned;


    private void Start()
    {
        //isSpawned = false;

        InvokeRepeating("SpawnTarget", 1f, 4f);
    }

    private void SpawnTarget()
    {
        //if (isSpawned)
        //{
        //    StartCoroutine(SpawnDelay());
        //}
        int r1 = Random.Range(0, spawnPoints.Count);
        int r2 = Random.Range(0, spawnedObjects.Length);

        GameObject s = Instantiate(spawnedObjects[r2], parent.transform) as GameObject;
        s.transform.position = spawnPoints[r1].transform.position;
        s.transform.rotation = Quaternion.identity;
        //s.GetComponent<HitDetector>().AssignSpawnPosition(spawnPoints[r1]);
        //s.GetComponent<SpriteRenderer>().sprite = badBacterias[r2];
        Debug.Log(r1);

        spawnPoints.Remove(spawnPoints[r1]);

        //spawnPoints.RemoveAt(r1);
    }
}
