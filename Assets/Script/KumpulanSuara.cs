using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KumpulanSuara : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip[] Clip;
    public static KumpulanSuara instance;
    public AudioSource source_sfx;
    public AudioSource source_bgm;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }

        else
        {
            Destroy(gameObject);
        }
    }
    
    public void Panggil_Sfx(int id)
    {
        source_sfx.PlayOneShot(Clip[id]);
    }
}
