using UnityEngine;

public class PuntoScript : MonoBehaviour
{
    public bool utilitzat = false;

    private bool _timerIni = false;

    private bool _cosit = false;

    private float targetTime = 3.0f;

    private SpriteRenderer _color;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _color = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (utilitzat == true) {
            _color.color = Color.red;
        }   
        
        if (_timerIni == true) {
            targetTime -= Time.deltaTime;
        }

        if (targetTime <= 0.0f)
        {
           timerEnded();
        }

    }

    public void Coser()
    {
        if (_cosit == false)
        {
            utilitzat = true;
        }
        else {
           //...
        }
    }

    public void EmpezarTimer()
    {
        _timerIni = true;
    }

    void timerEnded()
    {
       _color.color = Color.black;
    }           

}
