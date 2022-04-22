using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerScore : MonoBehaviour {

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI playerRecordText;

    private int score;

    void Start() {
        playerRecordText.text = PlayerPrefs.GetString("playerRecord", "0");
    }

    private void OnTriggerExit2D(Collider2D collision) {
        if (collision.gameObject.CompareTag("ScoreTrigger")) {
            FindObjectOfType<AudioManager>().Play("point");
            score++;
            scoreText.text = score.ToString();

            if (score > int.Parse(playerRecordText.text)) {                
                PlayerPrefs.SetString("playerRecord", score.ToString());
            }
        }
    }

    public void ResetPlayerRecord() {
        PlayerPrefs.DeleteKey("playerRecord");
        SceneManager.LoadScene("MenuScene");
    }
}