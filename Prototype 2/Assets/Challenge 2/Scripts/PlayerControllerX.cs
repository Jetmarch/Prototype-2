using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float dogCooldown = 1.0f;
    private bool isDogReady;

    private void Start()
    {
        isDogReady = true;
    }

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && isDogReady)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            isDogReady = false;
            Invoke("DogReady", dogCooldown);
        }
    }

    void DogReady()
    {
        isDogReady = true;
        Debug.Log("Dog is ready!");
    }
}
