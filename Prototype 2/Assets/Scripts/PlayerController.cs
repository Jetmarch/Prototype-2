using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed = 10.0f;
    public float leftAndRightInvisibleWall = 10;
    public float topInvisibleWall = 16;
    public float bottomInvisibleWall = -1;
    public GameObject projectilePrefab;

    private float horizontalInput;
    private float verticalInput;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckWalls();

        ProcessInput();
    }

    void CheckWalls()
    {
        if (transform.position.x < -leftAndRightInvisibleWall)
        {
            transform.position = new Vector3(-leftAndRightInvisibleWall, transform.position.y, transform.position.z);
        }
        if (transform.position.x > leftAndRightInvisibleWall)
        {
            transform.position = new Vector3(leftAndRightInvisibleWall, transform.position.y, transform.position.z);
        }
        if (transform.position.z > topInvisibleWall)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, topInvisibleWall);
        }
        if (transform.position.z < bottomInvisibleWall)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, bottomInvisibleWall);
        }
    }

    void ProcessInput()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * Time.deltaTime * playerSpeed * horizontalInput);
        transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed * verticalInput);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
