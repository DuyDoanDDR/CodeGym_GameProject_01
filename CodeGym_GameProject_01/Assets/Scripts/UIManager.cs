using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    
    public Image GameOver_UI;
    public Image HP_UI_1;
    public Image HP_UI_2;
    public Image HP_UI_3;
    public Image ReplayButton_UI;
    public Image ExitButton_UI;

    

    public void DisplayHP()
    {
        HP_UI_1.gameObject.SetActive(true);
        HP_UI_2.gameObject.SetActive(true);
        HP_UI_3.gameObject.SetActive(true);
        
    }
    public void DisplayGameOver()
    {
        ReplayButton_UI.gameObject.SetActive(true);
        ExitButton_UI.gameObject.SetActive(true);
        GameOver_UI.gameObject.SetActive(true);
       
    }

    public void OnReplayButton()
    {
        Debug.Log("Clicked!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void OnExitButton()
    {
        Debug.Log("Clicked");
        Application.Quit();
    }


    private void OnEnable()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
