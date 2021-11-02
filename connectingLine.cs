using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class connectingLine : MonoBehaviour
{
    public GameObject wheel1;
    public GameObject wheel2;
    private LineRenderer lr;

    // Start is called before the first frame update
    void Start()
    {
        lr = GetComponent<LineRenderer>();   
    }

    // Update is called once per frame
    void Update()
    {
        lr.SetPosition(0, wheel1.transform.position);
        lr.SetPosition(1, wheel2.transform.position);
    }
}
