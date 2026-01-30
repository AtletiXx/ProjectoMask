using UnityEngine;
using System.Collections.Generic;

public class PointLineGenerator : MonoBehaviour
{
    public List<Transform> pointsIniciales = new List<Transform>();
    public GameObject pointPrefab;
    public float distanceBetweenPoints = 0.2f;

    public List<Transform> points = new List<Transform>();

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
            points.Add(p.transform);
        }
    }
}
