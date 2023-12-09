using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnPause : MonoBehaviour
{
    public bool IsTransisi, IsTidakPerlu;

    string SaveNamaScene;
    private void Awake()
    {
        if(IsTransisi && IsTidakPerlu)
        {
            gameObject.SetActive(false);
        }
    }
    public void Btn_Suara(int id)
    {
        KumpulanSuara.instance.Panggil_Sfx(0);
    }
    public void Btn_Buku(int id)
    {
        KumpulanSuara.instance.Panggil_Sfx(3);
    }

    public void Btn_Pindah(string nama)
    {
        this.gameObject.SetActive(true);
        SaveNamaScene = nama;
        GetComponent<Animator>().Play("end");
    }
    //public void Btn_Restart()
    //{
        //SaveNamaScene = SceneManager.GetActiveScene().name;
        //GetComponent<Animator>().Play("end");
    //}

    public void pindah()
    {
        SceneManager.LoadScene(SaveNamaScene);
    }

}
