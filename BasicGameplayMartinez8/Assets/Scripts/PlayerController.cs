using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public float horizontalInput;
    void Update()
    {
        horizontalInput = Input.GetAxis(“Horizontal”), 
    }
}
