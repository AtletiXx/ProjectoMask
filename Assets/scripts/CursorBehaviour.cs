using UnityEngine;
using UnityEngine.InputSystem;

public class CursorBehaviour : MonoBehaviour
{
    private Animator _animator;
    public bool cosiendo = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
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
        }
        else
        {
            _animator.SetBool("cosiendo", false);
            cosiendo = false;
        } 
    }
}
