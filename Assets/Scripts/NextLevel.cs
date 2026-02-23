using UnityEngine;
using UnityEngine.SceneManagement;

//This script will be used to load scenes and quitting the game.
public class NextLevel : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("HUB"); //'Start' Butonuna basýldýðýnda HUB sahnesine geçiþ yapar.
    }

    public void QuitGame()
    {
        Application.Quit(); //'Quit' butonuna basildiginda oyundan çýkýþ yapar.
    }
}
