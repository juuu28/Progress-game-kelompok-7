using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour /*HealthBar*/
{
    public List<string> inventory;
    void Start()
    {
        inventory = new List<string>();
    }
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("kindness"))
        {
            string itemType = collision.gameObject.GetComponent<Collectable>().itemType;
            print("we have collected a:" + itemType);

            inventory.Add(itemType);
            print("Inventory.length:" + inventory.Count);
            Destroy(collision.gameObject);
        }
        if (collision.CompareTag("meanness"))
        {
            HealthBar.health -= 1;
            Destroy(collision.gameObject);
            
            /*string itemType = collision.gameObject.GetComponent<Collectable>().itemType;
            print("we have collected a:" + itemType);

            inventory.Add(itemType);
            print("Inventory.length:" + inventory.Count);*/

        }
    }
}
