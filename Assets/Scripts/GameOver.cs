using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {
    public GameObject gameOverMenuUI;

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.CompareTag("GameOverTrigger")) {
            Death();
        }
    }

    public void TryAgain() {
        gameOverMenuUI.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void Death() {
        FindObjectOfType<AudioManager>().Play("hit");
        gameOverMenuUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void LoadMenu() {
        gameOverMenuUI.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene("MenuScene");
    }
}
