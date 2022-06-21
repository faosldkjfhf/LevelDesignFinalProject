using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Makes walls that block the player from the Camera transparent
public class CameraScript : MonoBehaviour
{
    public GameObject player;

    private Transform _selection;

    [SerializeField] private Material defaultMaterial;
    [SerializeField] private Material transparentMaterial;

    // Update is called once per frame
    void Update()
    {
        if (_selection != null) {
            if (_selection.CompareTag("Wall")) {
                var selectionRenderer = _selection.GetComponent<Renderer>();
                selectionRenderer.material = defaultMaterial;
                _selection = null;
            }

        }
   

        Ray ray = new Ray(Camera.main.transform.position, player.transform.position - Camera.main.transform.position);
        Debug.Log(ray);
        RaycastHit hit;


        if (Physics.Raycast(ray, out hit)) {
            var selection = hit.transform;
            Debug.Log(selection);
            if(selection.CompareTag("Wall")) { 
                var selectionRenderer = selection.GetComponent<Renderer>();
                if(selectionRenderer != null) {
                    selectionRenderer.material = transparentMaterial;
                    Debug.Log("material change");
                }   
            }
            else if (selection.CompareTag("Ground")) {
                Debug.Log("not wall");
            }
            _selection = selection;
        }
    }
}
