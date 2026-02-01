using UnityEngine;
using UnityEngine.InputSystem;

public class TijerasBehaviour : MonoBehaviour
{

    private Animator _animator;

    public bool cortando = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _animator = GetComponent<Animator>();  
        _animator.SetBool("cortando", false);
        cortando = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.isPressed)
        {
            _animator.SetBool("cortando", true);
            cortando = true;
        }
        else
        {
            _animator.SetBool("cortando", false);
            cortando = false;
        } 
    }
}
