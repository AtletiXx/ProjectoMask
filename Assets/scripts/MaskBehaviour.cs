using UnityEngine;
using UnityEngine.InputSystem;

public class MaskBehaviour : MonoBehaviour
{

    public bool agarrada = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public float minX = -7f;
    public float maxX = 7f;
    public float minY = -3f;
    public float maxY = 3f;
    
    public int numComponentes;

    public int compActuales;
    
    public HandMovement Manos;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (agarrada)
        {
        //para que se mueva con el ratón
        Vector2 mouseScreenPos = Mouse.current.position.ReadValue();

        Vector3 mousePos = new Vector3(mouseScreenPos.x, mouseScreenPos.y, 0f);

        Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);

        float clampX = Mathf.Clamp(worldPos.x, minX, maxX);
        float clampY = Mathf.Clamp(worldPos.y, minY, maxY);

        transform.position = new Vector3(clampX, clampY, transform.position.z);
        }

        if (compActuales == numComponentes)
        {
            Manos.lista = true;
        }


    }
}
