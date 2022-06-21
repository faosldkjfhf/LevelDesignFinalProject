using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    public Camera cam;
    public NavMeshAgent player;
    // public Animator playerAnimator;
    public GameObject targetDest;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitPoint;

            if (Physics.Raycast(ray, out hitPoint)) {
                targetDest.transform.position = hitPoint.point;
                player.SetDestination(hitPoint.point);
            }
        }
    }
}
