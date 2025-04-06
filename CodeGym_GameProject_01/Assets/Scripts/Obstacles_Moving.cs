using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles_Moving : MonoBehaviour
{
    public Vector3 Obstacles_Velocity;
    private Vector3 startPosition;
    private float movedDistance = 0f;

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

        if (movedDistance >= 20f) // Nếu di chuyển được 20 đơn vị
        {
            Obstacles_Velocity = -Obstacles_Velocity; // Đảo chiều
            movedDistance = 0f; // Reset quãng đường
        }
        transform.Translate(Obstacles_Velocity * Time.deltaTime);

    }
}
//do
//{
//    Obstacles_Velocity = -transform.position;
//}
//while (