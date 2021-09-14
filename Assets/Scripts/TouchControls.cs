using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.EventSystems;

public class TouchControls : MonoBehaviour
{
    private Touch touch;
    private Vector3 touchPosition;
    public ARRaycastManager arRaycastManager;
    static List<ARRaycastHit> hits = new List<ARRaycastHit>();
    public GameObject newCreature;
    private GameObject creature;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && !EventSystem.current.IsPointerOverGameObject())
        {
            touch = Input.GetTouch(0);
            touchPosition = touch.position;
            if (arRaycastManager.Raycast(touchPosition, hits, TrackableType.PlaneWithinPolygon))
            {
                var hitPose = hits[0].pose;
                if (creature==null)
                {
                    creature = Instantiate(newCreature, hitPose.position, hitPose.rotation);
                    creature.transform.LookAt(Camera.main.transform);
                }
                else
                {
                    creature.transform.position = hitPose.position;
                    creature.transform.LookAt(Camera.main.transform);
                }
                
            }
        }
    }
}
