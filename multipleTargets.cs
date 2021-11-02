using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class multipleTargets : MonoBehaviour
{
    public List<Transform> targets;
    public Vector3 offset;
    //private Vector3 velocity;
    //public float smoothTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(targets.Count == 0)
        {
            return;
        }

        Vector3 centerPoint = GetCenterPoint();
        Vector3 newPos = centerPoint + offset;
        transform.position = newPos;
        //transform.position = Vector3.SmoothDamp(transform.position, newPos, ref velocity, smoothTime);
        
    }

    Vector3 GetCenterPoint()
    {
        if(targets.Count == 1)
        {
            return targets[0].position;
        }
        var bounds = new Bounds(targets[0].position, Vector3.zero);
        for(int i = 0; i < targets.Count; i++)
        {
            bounds.Encapsulate(targets[i].position);
        }
        return bounds.center;
    }
}
