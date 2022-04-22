using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeMenuBack : MonoBehaviour {

    public GameObject mainMenu;
    public GameObject optionsMenu;
    public GameObject customizationMenu;
    public GameObject backgroundMenu;

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (optionsMenu.activeSelf || customizationMenu.activeSelf || backgroundMenu.activeSelf) {
                BackToMenu();
            }
        }
    }

    void BackToMenu() {
        mainMenu.SetActive(true);
        optionsMenu.SetActive(false);
        customizationMenu.SetActive(false);
        backgroundMenu.SetActive(false);
    }
}
