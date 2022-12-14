using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalToWorld : MonoBehaviour
{
    //public Vector2 localSpacePoint;
    [SerializeField]public Transform localObjTransform;
    public Vector2 worldSpacePoint;

    void OnDrawGizmos()
    {
        Vector2 objPos = transform.position;
        Vector2 right = transform.right;
        Vector2 up = transform.up;

        //Vector2 localToWorld(Vector2 localPt)
        //{
        //    //return transform.TransformPoint(localPt);
        //    Vector2 WorldOffset = right * localPt.x + up * localPt.y;
        //    return (Vector2)transform.position + WorldOffset;
        //}

        Vector2 worldToLocal(Vector2 worldPt)
        {
            //return transform.InverseTransformPoint(worldPt);

            Vector2 relPoint = worldPt - objPos;

            float x = Vector2.Dot(relPoint, right);
            float y = Vector2.Dot(relPoint, up);

            return new Vector2(x, y);
        }

        //Vector2 WorldSpacePoint = localToWorld(localSpacePoint);

        drawBasisVector(transform.position, transform.right, transform.up);
        drawBasisVector(Vector2.zero, Vector2.right, Vector2.up);

        Gizmos.color = Color.cyan;
        Gizmos.DrawSphere(worldSpacePoint, .1f);

        localObjTransform.localPosition = worldToLocal(worldSpacePoint);
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
