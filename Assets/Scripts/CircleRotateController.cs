using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleRotateController : MonoBehaviour
{

    [SerializeField] private float RotateSpeed;

    // Update is called once per frame
    void Update()
    {
        setCircleRotater();
    }

    private void setCircleRotater()
    {
        transform.Rotate(0,0 , RotateSpeed * Time.deltaTime);
    }


}
    
