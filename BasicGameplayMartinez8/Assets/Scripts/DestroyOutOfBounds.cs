using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameUserInterface>();
    }
    
    private float topBound =30;
    private float lowerBound = -10;
    private float sideBound = 30;
    private GameUserInterface gameManager;
    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
        else if (transform.position.x > sideBound) 
        {
            gameManager.AddLives(-1);
            Destroy(gameObject); 
        }
        else if (transform.position.x < -sideBound) 
        {
            gameManager.AddLives(-1); 
            Destroy(gameObject); 
        }
    }
}