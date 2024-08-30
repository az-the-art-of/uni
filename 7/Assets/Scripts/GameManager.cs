using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
   
    private int score;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI gameWonText;
    public TextMeshProUGUI welcomeText;
    public Button restartButton;
    public Button menuButton;
    public Button level1Button;
    public Button level2Button;
    public Button winButton;
    public Button loseButton;




    // Start is called before the first frame update
    void Start()
    {

       // public void StartGame()
        {
          //  isGameActive = true;
            score = 0;
            // StartCoroutine(SpawnTarget);
           // UpdateScore(0);
        }

        // StartCoroutine(SpawnTarget);
        score = 0;
        scoreText.text = "Score: " + score;

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GameOver() {
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);

    }

    //restarts game on button press/click
    public void RestartGame() { SceneManager.LoadScene(SceneManager.GetActiveScene().name); }


}
