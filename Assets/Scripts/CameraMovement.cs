using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    Vector3 _cameraPosition;
    public GameObject _ObjectToFollow;
    // Start is called before the first frame update
    void Start()
    {
        _cameraPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = _ObjectToFollow.transform.position + _cameraPosition;
                
    }
}
