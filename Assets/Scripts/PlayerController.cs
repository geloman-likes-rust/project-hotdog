using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D _rb;
    bool isMoving = false, isMovingLeft = false, isMovingRight = false;
    float inputHorizontal = 0f;
    [SerializeField] ObjectBehavior _object;

    // Start is called before the first frame update
    void Start()
    {
        _rb = gameObject.GetComponent<Rigidbody2D>();
        _object.Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        inputHorizontal = Input.GetAxisRaw("Horizontal");
        isMoving = inputHorizontal != 0;
        isMovingLeft = inputHorizontal == -1;
        isMovingRight = inputHorizontal == 1;

        Move();
    }

    void Move() {
        if(isMoving) {
            if(isMovingLeft) MoveLeft();
            else if(isMovingRight) MoveRight();
        }
        else ResetVelocity();
    }

    void MoveLeft() => _rb.velocity = Vector2.left * 8;
    void MoveRight() => _rb.velocity = Vector2.right * 8;
    void ResetVelocity() => _rb.velocity = Vector2.zero;

}
