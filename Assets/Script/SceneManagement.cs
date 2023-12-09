using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SceneManagement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject pauseMenu;
    [SerializeField] GameObject exitMenu;
    public void KembaliMainMenu(){
        Application.LoadLevel("Main Menu");
    }
    public void MenuSinau(){
        Application.LoadLevel("MenuSinau");
    }
    public void Informasi(){
        Application.LoadLevel("Informasi");
    }
    public void Sejarah_Slide(){
        Application.LoadLevel("Sejarah_Slide");
    }
    public void Sinau(){
        Application.LoadLevel("Sinau");
    }
    public void Quiz(){
        Application.LoadLevel("Quiz");
    }
    public void Bermain(){
        Application.LoadLevel("Bermain");
    }
    public void Tutorial(){
        Application.LoadLevel("Tutorial");
    }
    public void PilihAksara(){
        Application.LoadLevel("PilihAksara");
    }
    public void Game0(){
        Application.LoadLevel("Game0");
    }
    public void Pause(){
        pauseMenu.SetActive(true);
    }
    public void Resume(){
        pauseMenu.SetActive(false);
    }
    public void MenuClose(){
        exitMenu.SetActive(true);
    }
    public void NoClose(){
        exitMenu.SetActive(false);
    }
    public void Close(){
        Application.Quit();
    }
    public void Sinau2(){
        Application.LoadLevel("Sinau2");
    }
    public void Sinau3(){
        Application.LoadLevel("Sinau3");
    }
    public void Sinau4(){
        Application.LoadLevel("Sinau4");
    }
    public void Sinau5(){
        Application.LoadLevel("Sinau5");
    }
    public void Sinau6(){
        Application.LoadLevel("Sinau6");
    }
    public void Sinau7(){
        Application.LoadLevel("Sinau7");
    }
    public void Mudah(){
        Application.LoadLevel("Mudah");
    }
    public void Sedang1(){
        Application.LoadLevel("Sedang1");
    }
    public void Sulit1(){
        Application.LoadLevel("Sulit1");
    }
}
