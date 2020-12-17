using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{


    const float MoveUnitsPerSecond = 5;

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        float horizontalAxis = Input.GetAxis("Horizontal");
        float verticalAxis = Input.GetAxis("Vertical");

        if(horizontalAxis != 0)
        {
            position.x += horizontalAxis * MoveUnitsPerSecond * Time.deltaTime;
        }
        if (verticalAxis != 0)
        {
            position.y += verticalAxis * MoveUnitsPerSecond * Time.deltaTime;
        }
        transform.position = position;
    }


}
