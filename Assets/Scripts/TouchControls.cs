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
    public Vector3 destination;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && !EventSystem.current.IsPointerOverGameObject(0))
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
                    //creature.transform.position = hitPose.position;
                    //creature.transform.LookAt(Camera.main.transform);
                    destination = hitPose.position;
                }
            }
        }
        else if (Mathf.Abs(destination.x - creature.transform.position.x) > 0.1 || Mathf.Abs(destination.y - creature.transform.position.y) > 0.1 || Mathf.Abs(destination.z - creature.transform.position.z) > 0.1)
        {
            Vector3 direction = new Vector3(destination.x - creature.transform.position.x, destination.y - creature.transform.position.y, destination.z - creature.transform.position.z);
            direction = Vector3.Normalize(direction);
            creature.transform.forward = direction;
            creature.transform.position += creature.transform.forward * Time.deltaTime;
        }
        else
        {
            creature.transform.LookAt(Camera.main.transform);
        }
    }
}
