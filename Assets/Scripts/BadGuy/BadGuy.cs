using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadGuy : MonoBehaviour
{
    /// <summary>
/// move forward then move towards player
/// shoot at player
/// die from player
/// can damage player
/// 
/// </summary>
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.right += Vector3.left * Time.deltaTime;
    }
}
