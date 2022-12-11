using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class RadialTrigger : MonoBehaviour
{
    public Transform Circle;
    public Transform p1;

    [Range(0f, 4f)]
    public float radius;

    private void OnDrawGizmos()
    {
        Vector2 disP = Circle.position - p1.position;
        float distSq = disP.x * disP.x + disP.y * disP.y;

        bool isInside = distSq < radius * radius;
        //ternary operator it's the same if we use
        //if(distSq<radius*radius)
        //isInside = true;
        //else
        //isInside = false;

        Handles.color = isInside ? Color.green : Color.red; // if the the point(p1) is inside change the color to green otherwise make it red

        Handles.DrawWireDisc(Circle.position, transform.forward, radius); // draws the circle

    }
}
