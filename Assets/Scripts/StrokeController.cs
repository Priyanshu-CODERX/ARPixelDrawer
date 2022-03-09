using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrokeController : MonoBehaviour
{
    private GameObject pinPoint;

    private void Start()
    {
        pinPoint = GameObject.Find("PinPoint");
    }

    private void Update()
    {
        if(DrawController.draw)
        {
            this.transform.position = pinPoint.transform.position;
            this.transform.rotation = pinPoint.transform.rotation;
        }
        else
        {
            this.enabled = false;
        }
    }
}
