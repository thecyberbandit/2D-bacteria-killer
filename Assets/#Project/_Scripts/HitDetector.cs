using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HitDetector : MonoBehaviour
{
    //private ParticleSystem destroyParticle;
    private ParticleSystem destroyParticle;
    [HideInInspector]
    public Transform spawnPos;


    private void Start()
    {
        destroyParticle = this.GetComponentInChildren<ParticleSystem>();
        //destroyParticle = GameObject.Find("BeamOfLight (1)").GetComponent<ParticleSystem>();

        //destroyParticle.Stop();
    }

    public void AssignSpawnPosition(Transform trans)
    {
        spawnPos = trans;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("bullet"))
        {
            //Debug.Log("bullet");

            this.gameObject.GetComponent<Image>().enabled = false;
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
            destroyParticle.transform.position = this.transform.position;
            destroyParticle.Play();
      

            if (this.gameObject.CompareTag("gb"))
            {
                GameManager.instance.score -= 1;
                AudioManager.instance.PlaySound("negativepoint");
            }

            else if (this.gameObject.CompareTag("bb"))
            {
                GameManager.instance.score += 1;
                AudioManager.instance.PlaySound("positivepoint");
            }
        }
    }
}
