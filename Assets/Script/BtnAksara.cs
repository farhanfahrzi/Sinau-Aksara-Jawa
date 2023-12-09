using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class BtnAksara : MonoBehaviour
{
    [HideInInspector]public Vector2 SavePosisi;
    [HideInInspector]public bool IsDiAtasObj;
    Transform SaveObj;

    public int ID;
    public Text Teks;
    [Space]
    public UnityEvent OnDragBenar;
    // Start is called before the first frame update
    void Start()
    {
        SavePosisi = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseUp()
    {
        if (IsDiAtasObj)
        {
            int ID_Btndrop = SaveObj.GetComponent<BtnDrop>().ID;
            if(ID == ID_Btndrop)
            {
                transform.SetParent(SaveObj);
                transform.localPosition = Vector3.zero;
                transform.localScale = new Vector2(0.97f, 0.97f);
                SaveObj.GetComponent<SpriteRenderer>().enabled = false;
                SaveObj.GetComponent<Rigidbody2D>().simulated = false;
                SaveObj.GetComponent<BoxCollider2D>().enabled = false;
                gameObject.GetComponent<BoxCollider2D>().enabled = false;
                OnDragBenar.Invoke();

                // if sukses
                GameSystem.instance.DataSaatIni++;
                Data.DataScore += 200;
                KumpulanSuara.instance.Panggil_Sfx(7);
            }
            else
            {
                transform.position = SavePosisi;

                //if salah
                Data.DataDarah--;
                KumpulanSuara.instance.Panggil_Sfx(2);
            }
            
            
        }
        else
        {
            transform.position = SavePosisi;

            //if laka tempat
        }
    }

    private void OnMouseDown()
    {

    }

    private void OnMouseDrag()
    {
        if(!GameSystem.instance.GameSelesai)
        {
            Vector2 Pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = Pos;
        }
        
    }

    private void OnTriggerStay2D(Collider2D trig)
    {
        if(trig.gameObject.CompareTag("Drop"))
        {
            IsDiAtasObj = true;
            SaveObj = trig.gameObject.transform;
        }
    }

    private void OnTriggerExit2D(Collider2D trig)
    {
        if(trig.gameObject.CompareTag("Drop"))
        {
            IsDiAtasObj = false;
        }
    }
}
