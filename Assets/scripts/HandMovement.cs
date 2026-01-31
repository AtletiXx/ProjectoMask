using UnityEngine;
using UnityEngine.InputSystem;

public class HandMovement : MonoBehaviour
{
    public float minX = -5f;
    public float maxX = 5f;
    public float minY = -3f;
    public float maxY = 3f;

    private Animator _animator;

    void Start()
    {
        _animator.SetBool("IsClose", false);
        _animator = GetComponent<Animator>();
    }


    void Update()
    {
        // Leer posición del ratón con el NEW Input System
        Vector2 mouseScreenPos = Mouse.current.position.ReadValue();

        Vector3 mousePos = new Vector3(mouseScreenPos.x, mouseScreenPos.y, 0f);

        Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);

        float clampX = Mathf.Clamp(worldPos.x, minX, maxX);
        float clampY = Mathf.Clamp(worldPos.y, minY, maxY);

        transform.position = new Vector3(clampX, clampY, transform.position.z);

        //movimiento de coser
        if (Mouse.current.leftButton.isPressed)
        {
            _animator.SetBool("IsClose", true);
        }
        else
        {
            _animator.SetBool("IsClose", false);
        }
    }
}

