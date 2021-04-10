using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mean : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        HealthBar.health -= 1;
    }
}
