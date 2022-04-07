using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public string ScenetoGo;
    public GameObject PanneltoOpen;
        
    public void pauseGame()
    {
        Time.timeScale = 0;
    }

    public void resumeGame()
    {
        Time.timeScale = 1;
    }

    public void openPannel()
    {
        PanneltoOpen.SetActive(true);
    }

    public void ClosePannel()
    {
        PanneltoOpen.SetActive(false);
    }

    public void GoScene()
    {
        SceneManager.LoadScene(ScenetoGo);
        print(ScenetoGo);
    }
}
