using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerHEllo : MonoBehaviour
{
    public float Speed;
    float HorizontelInput;
    float Boundary = 20f;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        HorizontelInput = Input.GetAxis("Horizontal");

        if (transform.position.x >= Boundary)
        {
            transform.position = new Vector3(Boundary, transform.position.y, transform.position.z);
        }

        else if (transform.position.x <= -Boundary)
        {
            transform.position = new Vector3(-Boundary, transform.position.y, transform.position.z);
        }
        

        transform.Translate(Vector3.right * Speed * Time.deltaTime * HorizontelInput);
    }
}
