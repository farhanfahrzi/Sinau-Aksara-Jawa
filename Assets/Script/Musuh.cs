using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musuh : MonoBehaviour
{
    PlayerController KomponenPlayerController;

    // Start is called before the first frame update
    void Start()
    {
        KomponenPlayerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D (Collider2D other) 
    {
        if (other.transform.tag == "Player") {
            KomponenPlayerController.nyawa-- ;
             KomponenPlayerController.ulang = true;
        }
    }
}
