using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    //How quickly the player follows the mouse
    public float Speed;

    //Called every frame
    void Update()
    {
        //Converting mouse position into Vector3
        Vector3 Target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //Fixing Z-Axis
        Target.z = transform.position.z;

        //Actually move the player towards the mouse.
        transform.position = Vector3.MoveTowards(transform.position, Target, Speed * Time.deltaTime / transform.localScale.x);
    }
}
