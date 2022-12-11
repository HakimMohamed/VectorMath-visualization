using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtTrigger : MonoBehaviour
{
    public Transform p1;
    public Transform p2;
    
    public Transform p3;
    public Transform p4;
    private void OnDrawGizmos()
    {
        Vector2 p1Pos = p1.position;
        Vector2 p2Pos = p2.position;
        Vector2 p3Pos = p3.position;
        Vector2 p4Pos = p4.position;


        Vector2 p1Top2Dir = p2.position - p1.position;
        Vector2 p3Top4Dir = p4.position - p3.position;


        Vector2 p1Top2Normalized = p1Top2Dir.normalized;
        Vector2 p3Top4Normalized = p3Top4Dir.normalized;


        Gizmos.DrawLine(p1.position, (Vector2)p1.position+ p1Top2Normalized);
        Gizmos.DrawLine(p3.position, (Vector2)p3.position+ p3Top4Normalized);

        float dotProduct= p1Top2Normalized.x * p3Top4Normalized.x + p1Top2Normalized.y * p3Top4Normalized.y;

        Debug.Log(dotProduct);

    }
}
