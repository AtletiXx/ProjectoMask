using UnityEngine;
using UnityEngine.InputSystem;

public class HandMovement : MonoBehaviour
{
    public float minX = -5f;
    public float maxX = 5f;
    public float minY = -3f;
    public float maxY = 3f;

    private Animator _animator;

    public bool closed = false;

    public MaskBehaviour mascara;

    public bool lista = false;

    

    void Start()
    {
        _animator = GetComponent<Animator>();
        _animator.SetBool("IsClose", false);
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
            closed = true;
        }
        else
        {
            _animator.SetBool("IsClose", false);
            closed = false;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (lista && closed && collision.gameObject.tag == "Mascara")
        {
            mascara.agarrada = true;
            //Debug.Log("Tocando mascara"); 
        }
        else
        {
            mascara.agarrada = false;
        }
    }


}

