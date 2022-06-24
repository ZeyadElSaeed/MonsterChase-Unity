using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;


public class sceneController : MonoBehaviour
{
    public void Playgame()
    {
        int selectedCharacter = int.Parse(EventSystem.current.currentSelectedGameObject.name);
        GameManager.instance.SelectedIndex = selectedCharacter - 1;
        SceneManager.LoadScene("GamePlay");
    }

    public void ReloadGame()
    {
        SceneManager.LoadScene("GamePlay");
    }

    public void HomeGame()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
