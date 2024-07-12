using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorTest : MonoBehaviour
{

    public Transform aTransform;
    public Transform bTransform;
    public double distAtoB;

    private void OnDrawGizmos()
    {
        Vector2 a = aTransform.position;
        Vector2 b = bTransform.position;

        /*      Gizmos.color = Color.red;
              Vector2 pt = transform.position;
              Vector2 dirTopt = pt.normalized;
              Gizmos.DrawLine(Vector3.zero, dirTopt);*/

        Gizmos.DrawLine(a, b);
        /*        distAtoB = Vector2.Distance(a, b);*/
        Vector2 difference = new Vector2(a.x - b.x, a.y - b.y);

        distAtoB = Math.Sqrt(Math.Pow(difference.x, 2f) + Math.Pow(difference.y, 2f));

    }
}
