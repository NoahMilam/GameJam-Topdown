using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public Vector2 RawInput { get; private set; }
    public Vector2 MovementInput { get; private set; }
    public float AnimSpeed { get; private set; }

    [SerializeField] private float Speed = 20;

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        RawInput = new Vector3(horizontal, vertical, 0);
        MovementInput = RawInput * Speed;

        AnimSpeed = Mathf.Abs(horizontal + vertical) * Speed;
    }
}
