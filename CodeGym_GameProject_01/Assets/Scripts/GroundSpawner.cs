using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour

{
    public GameObject groundTile;
    Vector3 nextSpawnPoint;
    GroundTile tileScript;
   
    public void SpawnTile()
    {
        GameObject temp = Instantiate(groundTile, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
        GroundTile tileScript = temp.GetComponent<GroundTile>();
        tileScript.SpawnObstacles();
    }

    // Start is called before the first frame update
    void Start()
    {
        SpawnTile();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     
}
