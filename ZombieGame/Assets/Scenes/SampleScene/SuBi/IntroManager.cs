using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroManager : MonoBehaviour
{
    public GameObject StartPanel;
    public GameObject IntroPanel;
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
        StartPanel.SetActive(true);

    }

    public void GoGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void GoSettingScene()
    {
        SceneManager.LoadScene("SettingScene");
    }

    public void GoCreditsScene()
    {
        SceneManager.LoadScene("CreditsScene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
