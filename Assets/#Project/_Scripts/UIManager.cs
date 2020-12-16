using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public Image playMenu;
    public Image welcomeMenu;
    public Image instructionMenu;


    private void Start()
    {
        AudioManager.instance.PlaySound("background");

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void OnPlayButtonClicked()
    {
        playMenu.gameObject.SetActive(false);
        Cursor.visible = false;
        welcomeMenu.gameObject.SetActive(true);

        StartCoroutine(InstructionMenu());
    }

    public void OnQuitButtonClicked()
    {
        Application.Quit();
    }

    IEnumerator InstructionMenu()
    {
        yield return new WaitForSeconds(5f);

        welcomeMenu.gameObject.SetActive(false);
        instructionMenu.gameObject.SetActive(true);

        StartCoroutine(StartGame());
    }

    IEnumerator StartGame()
    {
        yield return new WaitForSeconds(5f);

        SceneManager.LoadScene(1);
    }
}
