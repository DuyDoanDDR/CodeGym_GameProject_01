using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using Unity.VisualScripting;

public class Player_Collision : MonoBehaviour
{
    public int HP = 3;
    public int NewHP = 3;
    public int HitsCount = 0;
    float Y_Position;
   

    
    void DisplayHP()
    {
        UIManager.Instance.DisplayHP();
        
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
            switch (NewHP)
            {
                case 0:
                    DisplayGameOver();
                    UIManager.Instance.HP_UI_3.gameObject.SetActive(false);
                    UIManager.Instance.HP_UI_2.gameObject.SetActive(false);
                    UIManager.Instance.HP_UI_1.gameObject.SetActive(false);
                    Time.timeScale = 0;
                    break;
                case 1:
                    DisplayHP();
                    UIManager.Instance.HP_UI_3.gameObject.SetActive(false);
                    UIManager.Instance.HP_UI_2.gameObject.SetActive(false);
                    break;
                case 2:
                    DisplayHP();
                    UIManager.Instance.HP_UI_3.gameObject.SetActive(false);
                    break;
            }

        }
    }
   
   
    // Start is called before the first frame update
    void Start()
    {
        UIManager.Instance.DisplayHP();
        
    }


    // Update is called once per frame
    private void Update()
    {
        Debug.Log("Running");
        Y_Position = transform.position.y;
        if (Y_Position < -5)
        {
            Time.timeScale = 0;
            DisplayGameOver();
            
        }

    }

}
