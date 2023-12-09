using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public static Vector2 lastCheckPointPos = new Vector2(-11,0);
    Text infonyawa,infokoin;
    public int kecepatan; // Kecepatan gerakan horizontal
    public int kekuatanlompat; // Kekuatan lompatan
    public bool balik; // Menyimpan informasi arah hadap karakter
    public int pindah; // Menyimpan arah gerakan karakter
    Rigidbody2D lompat; // Komponen Rigidbody2D untuk lompatan
    public bool tanah; // Menyimpan informasi apakah karakter berada di tanah
    public LayerMask targetlayer; // Layer yang dikategorikan sebagai tanah
    public Transform deteksitanah; // Posisi deteksi tanah
    public float jangkauan; // Jarak deteksi tanah
    public int nyawa;
    public int koin;
    //AudioSource jumpSoundEffect;

    Animator anim; // Komponen Animator untuk mengatur animasi karakter
    Vector2 mulai;
    public bool ulang;
    public bool tombolkiri,tombolkanan;
    public GameObject GameOver;

    void Start()
    {
        infonyawa = GameObject.Find("UInyawa").GetComponent<Text>();
        infokoin = GameObject.Find("UIkoin").GetComponent<Text>();
        lompat = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        mulai = transform.position;
        //jumpSoundEffect = GetComponent<AudioSource>();
    }

    void Update()
    {
        infonyawa.text = ":" + nyawa.ToString();
        infokoin.text = ":" + koin.ToString();
        if(ulang == true)
        {
            transform.position = mulai;
            ulang = false;
            GameObject.FindGameObjectWithTag("Player").transform.position = lastCheckPointPos;   
        }
        if (nyawa <= 0) 
        {
            Destroy(gameObject);   
            GameOver.SetActive(true);
            KumpulanSuara.instance.Panggil_Sfx(8);
        }
        if (tanah == true)
        {
            anim.SetBool("lompat", false);
        }
        else
        {
            //jumpSoundEffect.Play();
            anim.SetBool("lompat", true);
        }

        tanah = Physics2D.OverlapCircle(deteksitanah.position, jangkauan, targetlayer);        
        
            if (Input.GetKey(KeyCode.D) || (tombolkanan==true))
            {
                transform.Translate(Vector2.right * kecepatan * Time.deltaTime);
                pindah=1;
                anim.SetBool("Run", true);
            }
            else if (Input.GetKey(KeyCode.A) || (tombolkiri==true))
            {
                transform.Translate(Vector2.right * -kecepatan * Time.deltaTime);
                pindah=-1;
                anim.SetBool("Run", true);
            }
            else 
            {
                anim.SetBool("Run", false);
            }

//            if(tanah == true && Input.GetKey(KeyCode.Mouse0))
//            {
//                lompat.AddForce(new Vector2(0,kekuatanlompat));
//            }

            if ((pindah > 0 && !balik) || (pindah < 0 && balik))
            {
                Flip();
            }
    }

    void Flip()
    {
        balik = !balik;
        Vector3 Player = transform.localScale;
        Player.x *= -1;
        transform.localScale = Player;
    }  

    public void tekankiri()
    {
       tombolkiri = true;        
    }
    public void lepaskiri()
    {
        tombolkiri = false;
    }
    public void tekankanan()
    {
       tombolkanan = true;        
    }
    public void lepaskanan()
    {
        tombolkanan = false;
    }
    public void loncat(){
       if (tanah == true){
            lompat.AddForce (new Vector2 (0, kekuatanlompat));
       }  
          
    }
    
    
}
