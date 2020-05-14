using System.Collections;
using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private IntConstant maxScore;
    [SerializeField] private IntVariable player1Score;
    [SerializeField] private IntVariable player2Score;
    [SerializeField] private IntVariable playerWon;
    [SerializeField] private BoolVariable gameOver;

    [SerializeField] private float resetDelay;
    
    void Update()
    {
        if (player1Score.Value == maxScore.Value)
        {
            playerWon.Value = 1;
            gameOver.Value = true;
        }

        if (player2Score.Value == maxScore.Value)
        {
            playerWon.Value = 2;
            gameOver.Value = true;
        }

        if (gameOver.Value)
        {
            StartCoroutine(ResetGame());
        }
    }

    private IEnumerator ResetGame()
    {
        yield return new WaitForSeconds(resetDelay);

        player1Score.Reset();
        player2Score.Reset();
        playerWon.Reset();
        gameOver.Reset();
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
