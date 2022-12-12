using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldToLocal : MonoBehaviour
{
    public Vector2 localSpacePoint = new Vector2(2, 1);
    void OnDrawGizmos()
    {
        Vector2 objPos = transform.position;
        Vector2 right = transform.right;
        Vector2 up = transform.up;

        Vector2 localToWorld(Vector2 localPt)
        {
            Vector2 WorldOffset = right * localPt.x + up * localPt.y;
            return (Vector2)transform.position + WorldOffset;
        }

        Vector2 WorldSpacePoint = localToWorld(localSpacePoint);

        drawBasisVector(transform.position, transform.right, transform.up);
        drawBasisVector(Vector2.zero, Vector2.right, Vector2.up);

        Gizmos.color = Color.cyan;
        Gizmos.DrawSphere(WorldSpacePoint, .1f);

    }


    void drawBasisVector(Vector2 pos, Vector2 right, Vector2 up)
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(pos, right);
        Gizmos.color = Color.green;
        Gizmos.DrawRay(pos, up);
        Gizmos.color = Color.white;
    }
}
