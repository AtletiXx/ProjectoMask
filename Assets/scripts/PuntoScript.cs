using UnityEngine;

public class PuntoScript : MonoBehaviour
{
    public bool utilitzat = false;

    private bool _timerIni = false;

    private bool _cosit = false;

    private Delineador _delineador;

    private float targetTime = 3.0f;

    private SpriteRenderer _color;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _color = GetComponent<SpriteRenderer>();
        _delineador = GetComponentInParent<Delineador>();

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
            _delineador.AddPuntos();
            utilitzat = true;
        }
        else if (utilitzat == false) {
           _delineador.Lose();
        }
    }

    public void EmpezarTimer()
    {
        if (_cosit == false)
        {
            _timerIni = true;
            _cosit = true;
        }
    }

    void timerEnded()
    {
       _timerIni = false;
       _color.color = Color.black;
       targetTime = 3.0f;
       utilitzat = false;
    }           

}
