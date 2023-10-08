using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameLogicScript : MonoBehaviour
{
    // Start is called before the first frame update

    public int playerScore = 0 ;
    public Text textScore;
    public GameObject gameOverScreen;
    public AudioSource audioSource1;
    


    [ContextMenu("Increase Score")]
    public void increaseScore(int scoreAmount)
    {
        playerScore = playerScore + scoreAmount;
        textScore.text = playerScore.ToString();
        audioSource1.Play();
    }

    
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
    
    
    // void Start()
    // {
    //     
    // }
    //
    // // Update is called once per frame
    // void Update()
    // {
    //     
    // }
}
