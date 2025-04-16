using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Obstacles_Moving : MonoBehaviour
{
    public Vector3 Obstacles_Velocity;
    private Vector3 startPosition;
    private float movedDistance = 0f;
    private bool isReTurning = false;
    Player_LockMovement playerScript;
    //private bool isIncreased = false;
    public float increaseDistance = 50f;



    private void ReverseDirection()
    {
        Obstacles_Velocity = -Obstacles_Velocity; // Đảo chiều
        movedDistance = 0f; // Reset quãng đường
    }
    public void IncreaseSpeed()
    {
        Obstacles_Velocity += Obstacles_Velocity.normalized * 1.5f;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Obstacles_Velocity = -Obstacles_Velocity;
            isReTurning = true;

        }
    }

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        playerScript = GameObject.FindObjectOfType<Player_LockMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveStep = Obstacles_Velocity.magnitude * Time.deltaTime;
        movedDistance += moveStep;

        if (isReTurning)
        {
            if (Vector3.Distance(transform.position, startPosition) < 1.0f || Vector3.Distance(transform.position, startPosition) >= 20f)
            {
                ReverseDirection();
                isReTurning = false;
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

       


        if (playerScript.playerDistance >= increaseDistance)
        {
            
                IncreaseSpeed();
                //isIncreased = true;
                increaseDistance += 50f;
         
        }
       
    }


}

//do
//{
//    Obstacles_Velocity = -transform.position;
//}
//while (