using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finishpoint : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"));
        {
            FinishScene.instance.NextLevel();
        }
    }
}
