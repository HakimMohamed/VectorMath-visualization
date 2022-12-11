using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtTrigger : MonoBehaviour
{
    public Transform p1;
    public Transform p2;
    ss
    public Transform p3;
    public Transform p4;
    private void OnDrawGizmos()
    {
        Vector2 p1ToP2Dir = (p2.position - p1.position).normalized;
        Gizmos.DrawLine(p1.position, (Vector2)p1.position+ p1ToP2Dir);

        Vector2 p3ToP4Dir = (p4.position - p3.position).normalized;
        Gizmos.DrawLine(p3.position, (Vector2)p3.position+ p3ToP4Dir);

        float dotProduct= p1ToP2Dir.x * p3ToP4Dir.x + p1ToP2Dir.y * p3ToP4Dir.y;

        Debug.Log(dotProduct);

        


       


    }
}
