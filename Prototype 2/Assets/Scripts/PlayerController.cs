using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed = 10.0f;
    public float distanceToInvisibleWall = 10;
    public GameObject projectilePrefab;

    private float horizontalInput;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -distanceToInvisibleWall)
        {
            transform.position = new Vector3(-distanceToInvisibleWall, transform.position.y, transform.position.z);
        }
        if (transform.position.x > distanceToInvisibleWall)
        {
            transform.position = new Vector3(distanceToInvisibleWall, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * playerSpeed * horizontalInput);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
