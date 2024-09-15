using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogMovement : MonoBehaviour
{
    public float speed = 10f; 
    public float horizontalSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called at each frame
    void Update()
    {
        
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        
        float horizontalInput = Input.GetAxis("Horizontal"); 
        transform.Translate(Vector3.right * horizontalInput * horizontalSpeed * Time.deltaTime);

        
        Vector3 currentPosition = transform.position;
        currentPosition.y = 0; 
        transform.position = currentPosition;
    }
}
