using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Checkpoint : MonoBehaviour
{   
    public AudioClip suara;
    public SuaraKoin sk;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            PlayerController.lastCheckPointPos = transform.position; 
            sk.Bunyikan(suara);  
            GetComponent<SpriteRenderer>().color = Color.white;         
        }
    }
}
