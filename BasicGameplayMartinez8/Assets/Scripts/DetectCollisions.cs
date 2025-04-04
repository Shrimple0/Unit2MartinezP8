using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private GameUserInterface gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameUserInterface>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other) 
    { 
        if (other.CompareTag("Player")) 
        {
            gameManager.AddLives(-1);
            Destroy(gameObject); 
        }
        else if (other.CompareTag("Animal")) 
        { 
            gameManager.AddScore(5);
            Destroy(gameObject);
            Destroy(other.gameObject); 
        }
    }
}
