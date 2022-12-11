using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif 

public class RadialTrigger : MonoBehaviour
{
    public Transform Circle;
    public Transform p1;
    [Range(0f, 4f)]
    public float radius;
    private void OnDrawGizmos()
    {
        Vector2 disp = Circle.position - p1.position;
        float distSq = disp.x * disp.x + disp.y * disp.y;


        bool isInside = distSq < radius * radius;

        Handles.color = isInside? Color.green : Color.red;

        Handles.DrawWireDisc(Circle.position,transform.forward, radius);

    }
}
