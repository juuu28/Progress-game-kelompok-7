using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToNextStage : MonoBehaviour
{
    /*[SerializeField] protected int Index;
    [SerializeField] protected string levelName;*/
    private int nextScene;
    // Start is called before the first frame update
    void Start()
    {
        nextScene = SceneManager.GetActiveScene().buildIndex + 1;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene(nextScene);
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
