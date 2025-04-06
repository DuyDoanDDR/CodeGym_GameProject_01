using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Player_Collision : MonoBehaviour
{
    public int HP = 3;
    public int NewHP = 3;
    public int HitsCount = 0;
    //bool isGameOver = false;

    void DisplayHP()
    {
        UIManager.Instance.DisplayHP(NewHP);
    }
    void DisplayGameOver()
    {
        UIManager.Instance.DisplayGameOver();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacles"))
        {
            HitsCount++;
            NewHP = HP - HitsCount;
            DisplayHP();

            if (HitsCount >= HP)
            {
                //isGameOver = true;
                DisplayGameOver();
                Time.timeScale = 0;
                return;
            }

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        UIManager.Instance.DisplayHP(NewHP);
    }


    // Update is called once per frame
    private void Update()
    {

    }

}
