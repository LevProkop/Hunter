using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    private float horizontal;
    private float vertical;
    private float sensitivity = 2f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Mouse X") * sensitivity;
        vertical = Input.GetAxis("Mouse Y") * sensitivity;

        transform.Rotate(0, horizontal, 0);
        transform.Rotate(0, 0, vertical);
        
    }
}
