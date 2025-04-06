using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_LockMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public CharacterController controller;
    public float speed = 5f;
    private Vector3 moveDirection;

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");  // Nhận input di chuyển ngang
        moveDirection = new Vector3(moveX, 0, 0);   // Chỉ cho phép di chuyển trên trục X
        moveDirection *= speed;

        controller.Move(moveDirection * Time.deltaTime);
    }
}
