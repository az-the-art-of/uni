using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    // Start is called before the first frame update

    private int score;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;

    void Start()
    {

       

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
       
    }

    //restarts game on button press/click
    public void RestartGame() { SceneManager.LoadScene(SceneManager.GetActiveScene().name); }


}
