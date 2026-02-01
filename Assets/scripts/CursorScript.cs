using UnityEngine;
using UnityEngine.InputSystem;

public class CursorScript : MonoBehaviour
{

    public float minX = -9f;

    public float maxX = 9f;

    public float minY = -5f;

    public float maxY = 5f;

    public bool tijeras = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void OnTriggerEnter2D (Collider2D other) 
    {
        if ((tijeras == false && other.CompareTag("Punto")) || (tijeras == true && other.CompareTag("Tijera")))
        {
            other.GetComponent<PuntoScript>()?.Coser();
        }
    }

    void OnTriggerExit2D (Collider2D other)
    {
        if ((tijeras == false && other.CompareTag("Punto")) || (tijeras == true && other.CompareTag("Tijera")))
        {
            other.GetComponent<PuntoScript>()?.EmpezarTimer();
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mouseScreenPos = Mouse.current.position.ReadValue();

        Vector2 mousePos = new Vector3(mouseScreenPos.x, mouseScreenPos.y, 0f);

        Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);

        float clampX = Mathf.Clamp(worldPos.x, minX, maxX);
        float clampY = Mathf.Clamp(worldPos.y, minY, maxY);

        transform.position = new Vector3(clampX, clampY, transform.position.z);
    }
}
