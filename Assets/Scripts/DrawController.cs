using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawController : MonoBehaviour
{
    public GameObject pinPoint;
    public GameObject stroke;
    public bool editorTesting;

    public static bool draw = false;

    float pitch = 0;
    float yaw = 0;

    private void Update()
    {
        if(editorTesting)
        {
            yaw += 2 * Input.GetAxis("Mouse X");
            pitch -= 2 * Input.GetAxis("Mouse Y");

            transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
        }
    }

    public void StartStroke()
    {
        draw = true;
        GameObject currStroke = (GameObject)Instantiate(stroke, pinPoint.transform.position, pinPoint.transform.rotation);
    }

    public void EndStroke()
    {
        draw = false;
    }

}
