using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerData : MonoBehaviour {

    // Character
    public GameObject redBird;
    public GameObject yellowBird;
    public GameObject blueBird;

    // Background
    public GameObject dayBackground;
    public GameObject nightBackground;

    // Images
    public Image birdImage;
    public Image backgroundImage;

    // Sprites
    public Sprite redBirdSprite;
    public Sprite yellowBirdSprite;
    public Sprite blueBirdSprite;
    public Sprite dayBackgroundSprite;
    public Sprite nightBackgroundSprite;

    int bird;
    int background;

    void Start() {
        LoadData();
    }

    void LoadData() {
        int bird = PlayerPrefs.GetInt("playerBird", 1);
        int background = PlayerPrefs.GetInt("playerBackground", 1);

        // Bird Settings
        if (bird == 1) {
            redBird.SetActive(true);
            yellowBird.SetActive(false);
            blueBird.SetActive(false);
            birdImage.sprite = redBirdSprite;
        }
        else if (bird == 2) {
            redBird.SetActive(false);
            yellowBird.SetActive(true);
            blueBird.SetActive(false);
            birdImage.sprite = yellowBirdSprite;
        }
        else if (bird == 3) {
            redBird.SetActive(false);
            yellowBird.SetActive(false);
            blueBird.SetActive(true);
            birdImage.sprite = blueBirdSprite;
        }

        // Background Settings
        if (background == 1) {
            dayBackground.SetActive(true);
            nightBackground.SetActive(false);
            backgroundImage.sprite = dayBackgroundSprite;
        }
        else if (background == 2) {
            dayBackground.SetActive(false);
            nightBackground.SetActive(true);
            backgroundImage.sprite = nightBackgroundSprite;
        }
    }

    public void setBirdIntFirst() {
        bird = 1;
        PlayerPrefs.SetInt("playerBird", bird);
    }

    public void setBirdIntSecond() {
        bird = 2;
        PlayerPrefs.SetInt("playerBird", bird);
    }

    public void setBirdIntThird() {
        bird = 3;
        PlayerPrefs.SetInt("playerBird", bird);
    }

    public void setBackgroundIntFirst() {
        background = 1;
        PlayerPrefs.SetInt("playerBackground", background);
    }
    public void setBackgroundIntSecond() {
        background = 2;
        PlayerPrefs.SetInt("playerBackground", background);
    }

}
