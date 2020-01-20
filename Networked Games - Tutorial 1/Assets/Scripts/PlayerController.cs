using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    const int MOVEMENT_RATE = 30;
    const int ROTATION_RATE = 150;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        var horizontalInput = Input.GetAxis("Horizontal") * Time.deltaTime * ROTATION_RATE;
        var verticalInput = Input.GetAxis("Vertical") * Time.deltaTime * MOVEMENT_RATE;

        transform.Rotate(0, horizontalInput, 0);
        transform.Translate(0, 0, verticalInput);
    }
}
