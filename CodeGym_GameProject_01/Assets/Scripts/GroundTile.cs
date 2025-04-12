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
        //if (other.gameObject.CompareTag("Player"))
        {
            groundSpawner.SpawnTile();
        }
           
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public Transform horizonobstacles_Spawnpoint;
    public GameObject horizonobstaclesPrefab;
    public Transform verticalobstacles_Spawnpoint;
    public GameObject verticalobstaclesPrefab;
    public void SpawnObstacles()
    {
        //Choose a random point to spawn the obstacles
        int obstaclesSpawnIndex = Random.Range(2,4);
        Transform spawnPoint = transform.GetChild(obstaclesSpawnIndex).transform;
        //Spawn the obstacles at the position
        Instantiate(horizonobstaclesPrefab, horizonobstacles_Spawnpoint.position, Quaternion.identity, transform);
        Instantiate(verticalobstaclesPrefab, verticalobstacles_Spawnpoint.position, Quaternion.identity,transform);
    }

}
