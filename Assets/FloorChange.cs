using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorChange : MonoBehaviour
{
    MeshRenderer my_renderer;
    float startTime;
    public Material next;
    bool canDoThis;
    

    public void Start()
    {
        my_renderer = GetComponent<MeshRenderer>();
        startTime = Time.time;
        canDoThis = false;
    }

    public void Update()
    {
        if (!canDoThis && Time.time - startTime > 8)
        {
            canDoThis = true;
            my_renderer.material = next;
        }
    }

}
