using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.SceneManagement;

public class codes : MonoBehaviour
{
    public Rigidbody bluecar;
    public Rigidbody redcar;

    public GameObject bluewintext;
    public GameObject redwintext;

    public bool paused = false;

    void Start()
    {
        Time.timeScale = 1f;
    }

    void Update()
    {
        if(bluecar.transform.position.z >= 35 && bluecar.transform.position.z > redcar.transform.position.z)
        {
            Invoke("bluewin",0);
        }
        if (redcar.transform.position.z >= 35 && redcar.transform.position.z > bluecar.transform.position.z)
        {
            Invoke("redwin", 0);
        }
    }

    public void bluecarbutton()
    {
        if (bluecar.transform.position.z <= 35)
        {
            bluecar.AddForce(0, 0, 10);
        }
    }

    public void redcarbutton()
    {
        if (redcar.transform.position.z <= 35)
        {
            redcar.AddForce(0, 0, 10);
        }
    }

    public void playbutton()
    {
        SceneManager.LoadScene(1);
    }

    public void pausebutton()
    {
        if (paused == false)
        {
            Time.timeScale = 0f;
            paused = true;
        }
        else
        {
            Time.timeScale = 1f;
            paused = false;
        }
    }

    public void backbutton()
    {
        SceneManager.LoadScene(0);
    }

    public void quitbutton()
    {
        Application.Quit();
    }

    public void bluewin()
    {
        bluewintext.SetActive(true);
        Destroy(redwintext);
    }

    public void redwin()
    {
        redwintext.SetActive(true);
        Destroy(bluewintext);
    }
}
