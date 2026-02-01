using UnityEngine;
using UnityEngine.InputSystem;

public class CursorBehaviour : MonoBehaviour
{
    AudioSource audioSource;

    private Animator _animator;
    public bool cosiendo = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        _animator = GetComponent<Animator>();  
        _animator.SetBool("cosiendo", false);
        cosiendo = false;
    }

    // Update is called once per frame
    void Update()
    {
        //movimiento de coser
        if (Mouse.current.leftButton.isPressed)
        {
            _animator.SetBool("cosiendo", true);
            cosiendo = true;
            if (!audioSource.isPlaying)
                audioSource.Play();
        }
        else
        {
            _animator.SetBool("cosiendo", false);
            cosiendo = false;
            if (audioSource.isPlaying)
                audioSource.Stop();
        } 
    }
}
