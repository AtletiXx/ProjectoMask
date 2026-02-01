using UnityEngine;

public class MusicManager: MonoBehaviour
{
    private static MusicManager instancia;

    void Awake()
    {
        if (instancia != null)
        {
            Destroy(gameObject);
            return;
        }

        instancia = this;
        DontDestroyOnLoad(gameObject);
    }

    public void CambiarMusica(AudioClip nuevaMusica)
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = nuevaMusica;
        audio.Play();
    }


}
