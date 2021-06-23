using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{

    public GameObject mainMenuPanel;
    public GameObject creditPanel;
    public GameObject aboutPanel;
    public GameObject exitPanel;

    // Use this for initialization
    void Start()
    {
        mainMenuPanel.SetActive(true);
        creditPanel.SetActive(false);
        aboutPanel.SetActive(false);
        exitPanel.SetActive(false);

    }

    public void StartGameClick()
    {
        Application.LoadLevel(1);

    }

    //public void LoadScene(string scenename){
    //SceneManager.LoadScene(scenename);
    //}

    public void CreditClicked()
    {
        creditPanel.SetActive(true);
        mainMenuPanel.SetActive(false);
        aboutPanel.SetActive(false);
        exitPanel.SetActive(false);
    }

    public void AboutClicked()
    {
        aboutPanel.SetActive(true);
        creditPanel.SetActive(false);
        mainMenuPanel.SetActive(false);
        exitPanel.SetActive(false);
    }

    public void ExitClicked()
    {
        exitPanel.SetActive(true);
        aboutPanel.SetActive(false);
        creditPanel.SetActive(false);
        mainMenuPanel.SetActive(false);
    }

    public void NoClicked()
    {
        mainMenuPanel.SetActive(true);
        creditPanel.SetActive(false);
        aboutPanel.SetActive(false);
        exitPanel.SetActive(false);
    }

    public void YesGameClick()
    {
        Application.Quit();
    }


    public void BackClicked()
    {
        mainMenuPanel.SetActive(true);
        creditPanel.SetActive(false);
        aboutPanel.SetActive(false);
        exitPanel.SetActive(false);

    }
}