using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class manager : MonoBehaviour
{
    public TextMeshProUGUI txtp1;
    public TextMeshProUGUI txtp2;
    public bool isplay = true;
    public Button button;
    public GameObject p1;
    public GameObject p2;
    public GameObject ball;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameoverp1()
    {
        txtp2.gameObject.SetActive(true);
        button.gameObject.SetActive(true);
        isplay = false;
    }
    public void gameoverp2()
    {
        txtp1.gameObject.SetActive(true);
        button.gameObject.SetActive(true);
        isplay = false;
    }
}
