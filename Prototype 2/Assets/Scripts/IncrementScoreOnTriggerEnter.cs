using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncrementScoreOnTriggerEnter : MonoBehaviour
{
    public GameObject scoreManager;
    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            return;
        }
        if (scoreManager)
        {
            scoreManager.GetComponent<Score>().IncrementScore();
        }
    }
}
