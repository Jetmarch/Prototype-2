using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            return;
        }

        if (this.tag == "Projectile")
        {
            Destroy(gameObject);
            return;
        }

        /*if(other.tag == "Player")
        {
            return;
        }


        //Destroy(other.gameObject);
        //Destroy(gameObject);*/
    }
}
