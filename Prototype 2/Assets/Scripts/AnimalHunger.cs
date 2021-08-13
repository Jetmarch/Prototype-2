using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimalHunger : MonoBehaviour
{
    public float maxFill;
    public float currentFill;

    public Slider hungerSlider;
    // Start is called before the first frame update
    void Start()
    {
        currentFill = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag != "Projectile")
        {
            return;
        }

        currentFill++;

        hungerSlider.value = Mathf.Clamp(currentFill / maxFill, 0, 1);

        if(currentFill >= maxFill)
        {
            Destroy(gameObject);
        }
    }
}
