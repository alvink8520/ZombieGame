using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroManager : MonoBehaviour
{
    public GameObject LobbyPanel;
    public GameObject IntroPanel;
    //public GameObject menuSet;
    public int AniTime;



    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(DelayTime(AniTime));
    }
    IEnumerator DelayTime(float time)
    {
        yield return new WaitForSeconds(time);

        IntroPanel.SetActive(false);
        LobbyPanel.SetActive(true);

    }
}
