using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    // Start is called before the first frame update

    public float xAngle, yAngle, zAngle;
    Camera _camera;

    void Start()
    {
        //this.transform.Rotate(0.0f, 180.0f, 0.0f, Space.Self);
        _camera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {

            _camera.orthographic = !_camera.orthographic;

            //if (_camera.orthographic)
            //{
            //    _camera.orthographic = false;
            //}
            //else
            //{
            //    _camera.orthographic = true;
            //}
            //_camera.orthographic = true;
        }


        transform.Rotate(xAngle * Time.deltaTime, yAngle * Time.deltaTime, zAngle * Time.deltaTime, Space.Self);
    }
}
