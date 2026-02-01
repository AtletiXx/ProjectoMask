using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene("Minijuego");
    }

    public void Ayuda()
    {
        SceneManager.LoadScene("Help");
    }

    public void Salir()
    {
        Application.Quit();
    }
}
