using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_LockMovement : MonoBehaviour
{
    public float playerDistance;
    Vector3 playerStartPosition;

    // Start is called before the first frame update
    void Start()
    {
        playerStartPosition = transform.position;
    }
    public CharacterController controller;
    public float speed = 0f;
    private Vector3 moveDirection;

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");  // Nhận input di chuyển ngang
        moveDirection = new Vector3(moveX, 0, 0);   // Chỉ cho phép di chuyển trên trục X
        moveDirection *= speed;

        controller.Move(moveDirection * Time.deltaTime);

        playerDistance = Vector3.Distance(playerStartPosition, transform.position);
        
    }
}
