using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player_Collision : MonoBehaviour
{
    public int MaxHits = 3;
    public int HitsCount = 3;
    public Text gameOverText;
    // Start is called before the first frame update
    void Start()
    {
        if (gameOverText != null)
            gameOverText.gameObject.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacles"))
        {
            HitsCount++;
            Debug.Log("HP : " + (HitsCount - 1));

            if (HitsCount <= MaxHits)
            {
                GameOver();
            }
        }
    }

    void GameOver()
    {
        Debug.Log("Game Over");
        if (gameOverText != null)
            gameOverText.gameObject.SetActive(true);
    }
    // Update is called once per frame
    
}
