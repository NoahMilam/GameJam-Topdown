using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
   
    void Update()
    {
        Vector3 mousePostion = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(mousePostion.x, mousePostion.y, 1);
    }
}
