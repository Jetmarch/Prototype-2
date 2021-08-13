using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Projectile")
        {
            return;
        }

        currentHealth--;
        Debug.Log($"Health: {currentHealth}");

        if(currentHealth < 1)
        {
            Debug.Log("Game Over!");
        }
    }
}
