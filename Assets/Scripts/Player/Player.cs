using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public InputHandler input;
    public PlayerStateMachine MovementStateMachine { get; private set; }
    public Transform Gun;
    public Animator Anim { get; private set; }
   
    public IPlayerState[] moveStates;

    private Rigidbody2D rigidbody;

    private int _facingDirection = 1;
    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        MovementStateMachine = new PlayerStateMachine();
        input = GetComponent<InputHandler>();
        Anim = GetComponent<Animator>();

        moveStates = new IPlayerState[3];
        IPlayerState north = new PlayerMoveUpState(this, MovementStateMachine, "North");
        moveStates[0] = north;
        IPlayerState south = new PlayerMoveDownState(this, MovementStateMachine, "South");
        moveStates[1] = south;
        IPlayerState side = new PlayerMoveStateSide(this, MovementStateMachine, "Side");
        moveStates[2] = side;

        MovementStateMachine.init(south);
    }


    // Update is called once per frame
    void Update()
    {
       
        MovementStateMachine.CurrentState.LogicUpdate();
        MovePlayer();
    }

    private void MovePlayer() {
        rigidbody.velocity = input.MovementInput;
    }

    private void FixedUpdate()
    {
        MovementStateMachine.CurrentState.physicsUpdate();
    }

    public void CheckIfShouldFlip(int xinput) {
        if (xinput != 0 && xinput != _facingDirection) {
            flipDirection();
        }
    }
    private void flipDirection() {
        _facingDirection *= -1;
        transform.Rotate(0f, 180f, 0f);
    }
}
