using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Teleport : MonoBehaviour
{
    public NavMeshAgent player_nav;
    public GameObject targetDest;
    public Transform tp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) {
        Debug.Log("collided");
        Vector3 dest = new Vector3(tp.position.x + 1, tp.position.y, tp.position.z + 1);
        targetDest.transform.position = dest;
        player_nav.Warp(dest);
    }
}
