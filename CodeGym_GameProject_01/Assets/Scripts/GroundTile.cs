using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTile : MonoBehaviour
{
    GroundSpawner groundSpawner;
   
    


    // Start is called before the first frame update
    void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            groundSpawner.SpawnTile();       
        }
    }
    // Update is called once per frame
    void Update()
    { }

    public Transform horizon_Spawnpoint;
    public GameObject horizonobs_Prefab;
    public Transform vertical_Spawnpoint;
    public GameObject verticalobs_Prefab;
    public void SpawnObstacles()
    {
        GameObject horiclone = Instantiate(horizonobs_Prefab, horizon_Spawnpoint.position, Quaternion.Euler(-90f,0f,0f), transform);
        horiclone.transform.SetParent(horizon_Spawnpoint);
        
        GameObject verticlone = Instantiate(verticalobs_Prefab, vertical_Spawnpoint.position, Quaternion.identity, transform);
        verticlone.transform.SetParent(vertical_Spawnpoint);
    }




}




