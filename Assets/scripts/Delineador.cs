using UnityEngine;
using System.Collections.Generic;

public class Delineador : MonoBehaviour
{
    public GameObject SpriteAcabado;

    public List<Transform> pointsIniciales = new List<Transform>();
    public GameObject pointPrefab;
    public float distanceBetweenPoints = 0.2f;

    public List<GameObject> points = new List<GameObject>();
    public int numPuntos;

    public MaskBehaviour Mascara;
    public bool BTijeras;

    void Start()
    {
        for (int i = 0; i + 1 < pointsIniciales.Count; i++)
        {
            GeneratePoints(pointsIniciales[i], pointsIniciales[i+1]);
        }
    }

    void GeneratePoints(Transform startPoint, Transform endPoint)
    {
        float distance = Vector2.Distance(startPoint.position, endPoint.position);
        int amount = Mathf.CeilToInt(distance / distanceBetweenPoints);

        for (int i = 0; i <= amount; i++)
        {
            float t = i / (float)amount;
            Vector2 pos = Vector2.Lerp(startPoint.position, endPoint.position, t);
            GameObject p = Instantiate(pointPrefab, pos, Quaternion.identity, transform);
            if (BTijeras == true) {
                p.tag = "Tijera";
                p.GetComponent<SpriteRenderer>().color = Color.purple;
            }
            points.Add(p);
        }
    }

    public void AddPuntos() {
        numPuntos += 1;
        if (numPuntos == points.Count) {
            win();
        }
    }

    void win()
    {
        Mascara.compActuales += 1;
        SpriteAcabado.SetActive(true);
        destroypoints();
    }

    public void Lose()
    {
        Debug.Log("Perdiste");
    }

    void destroypoints()
    {
        Debug.Log(points.Count);
        for (int i = 0; i < points.Count; i++)
        {
            Destroy(points[i]);
        }
        points.Clear();

    }

}
