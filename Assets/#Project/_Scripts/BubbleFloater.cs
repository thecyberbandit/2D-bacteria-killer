using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleFloater : MonoBehaviour
{

    void Update()
    {
        float speed = Random.Range(1f, 3f);

        transform.position += Vector3.up * speed * Time.deltaTime;
    }
}
