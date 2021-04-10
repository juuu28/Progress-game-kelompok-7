using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walled : MonoBehaviour
{
    GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = gameObject.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionWallEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "wall")
        {
            Player.GetComponent<Mono2D>().isWalled = true;
        }
    }
    private void OnCollisionWallExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "wall")
        {
            Player.GetComponent<Mono2D>().isWalled = false;
        }
    }
}
