using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMainMenu : MonoBehaviour
{
    private int MainMenuScene;
    // Start is called before the first frame update
    void Start()
    {
        MainMenuScene = SceneManager.GetActiveScene().buildIndex - 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            SceneManager.LoadScene(MainMenuScene);
        }
    }
}
