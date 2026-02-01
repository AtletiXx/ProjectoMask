using UnityEngine;

public class ControlEscena : MonoBehaviour
{
    public AudioClip musicaEscena;

    void Start()
    {
        FindFirstObjectByType<MusicManager>().CambiarMusica(musicaEscena);
    }
}

