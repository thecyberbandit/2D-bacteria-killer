using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodBacteriaHitDetector : MonoBehaviour
{
    private Animator anim;


    private void Start()
    {
        anim = this.gameObject.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("bullet"))
        {
            AudioManager.instance.PlaySound("laugh");
            anim.SetTrigger("laugh");
        }
    }
}
