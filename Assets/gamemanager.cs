using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public enum Gamestate
{
    Running,
    Pause
}

public class gamemanager : MonoBehaviour
{
    public TextMeshProUGUI txtp1;
    public TextMeshProUGUI txtp2;
    public TextMeshProUGUI ispause;
    public bool isplay = true;
    public Button button;
    public Button button2;
    public GameObject p1;
    public GameObject p2;
    public GameObject ball;
    public Gamestate gamestate = Gamestate.Running;
    music mc;
    private AudioSource bgMusicAudioSource;

    // Start is called before the first frame update
    void Start()
    {
        mc = GameObject.Find("musicmanager").GetComponent<music>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape) && isplay==true)
        {
            transformGameState();
        }
    }
    public void transformGameState()
    {
        if (gamestate == Gamestate.Running)
        {
            pause();
        }else if(gamestate == Gamestate.Pause)
        {
            Continue();
        }
    }
    public void pause()
    {
        Time.timeScale = 0;
        gamestate = Gamestate.Pause;
        bgMusicAudioSource = GameObject.FindGameObjectWithTag("music").GetComponent<AudioSource>();
        bgMusicAudioSource.Pause();
        ispause.gameObject.SetActive(true);

    }
    public void Continue()
    {
        Time.timeScale = 1;
        gamestate = Gamestate.Running;
        bgMusicAudioSource.UnPause();
        ispause.gameObject.SetActive(false);
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().buildIndex);
        Resources.UnloadUnusedAssets();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
        isplay = true;
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void gameoverp1()
    {
        txtp2.gameObject.SetActive(true);
        button.gameObject.SetActive(true);
        button2.gameObject.SetActive(true);
        isplay = false;
    }
    public void gameoverp2()
    {
        txtp1.gameObject.SetActive(true);
        button.gameObject.SetActive(true);
        button2.gameObject.SetActive(true);
        isplay = false;
    }
}
