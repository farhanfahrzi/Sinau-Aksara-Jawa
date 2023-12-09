using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuaraKoin : MonoBehaviour
{
    public void Bunyikan (AudioClip suara)
    {
        GetComponent<AudioSource>().PlayOneShot (suara, 1F);
    }
}
