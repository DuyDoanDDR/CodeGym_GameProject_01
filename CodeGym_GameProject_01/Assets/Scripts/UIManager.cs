using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    public TMP_Text HPText;
    public TMP_Text GameOverText;
    public void DisplayHP(int HP)
    {
        HPText.text = "HP : " +(HP.ToString());
    }
    public void DisplayGameOver()
    {
        GameOverText.text = "Game Over !";
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
