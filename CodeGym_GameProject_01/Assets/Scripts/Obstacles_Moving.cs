using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Obstacles_Moving : MonoBehaviour
{
    public Vector3 Obstacles_Velocity;
    private Vector3 startPosition;
    private float movedDistance = 0f;
    private bool IsReTurning = false;
    private void ReverseDirection()
    {
        Obstacles_Velocity = -Obstacles_Velocity; // Đảo chiều
        movedDistance = 0f; // Reset quãng đường
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Obstacles_Velocity = -Obstacles_Velocity;
            IsReTurning = true;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float moveStep = Obstacles_Velocity.magnitude * Time.deltaTime;
        movedDistance += moveStep;

        if (IsReTurning)
        {
            if (Vector3.Distance(transform.position, startPosition) < 1.0f || Vector3.Distance(transform.position, startPosition) >= 20f)
            {
                ReverseDirection();
                IsReTurning = false;
            }
            
        }
        else
        {
            if (movedDistance >= 20f) // Nếu di chuyển được 20 đơn vị
            {
                ReverseDirection();
            }
            
        }
        transform.Translate(Obstacles_Velocity * Time.deltaTime);
    }
}
//do
//{
//    Obstacles_Velocity = -transform.position;
//}
//while (