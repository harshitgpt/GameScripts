using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    int cubesCount=26;
    finish count;
    public GameObject winningCanvas;
    public string nextLevel;
    public string sameLevel;
    public GameObject debugModeCanvas;

    

    void Start()
    {

        count = FindObjectOfType<finish>();
        debugModeCanvas.SetActive(false);

    }

   
    void Update()
    {
        Result();
    }

    public void Result()
    {
        if (cubesCount == count.TotalCount())
        {
           
            winningCanvas.GetComponent<UI>().enabled = true;
            
            
        }

    }

    public void NextLevel()
    {

        SceneManager.LoadScene(nextLevel);

    }

    public void SameLevel()
    {
        SceneManager.LoadScene(sameLevel);

    }

   public void TapToClick()
    {
        SceneManager.LoadScene(0);

    }

    public void DebugModeOn()
    {
        debugModeCanvas.SetActive(true);

    }

    public void DebugModeOff()
    {
        debugModeCanvas.SetActive(false);

    }


}
