using UnityEngine;
using System.Collections;

public class ParallaxBackground : MonoBehaviour {

    public Transform[] backgrounds;
    private float[] parallaxScales;
    public float smoothing;

    private Transform cam;
    private Vector3 previousCamPosition;

    //

    void Start ()
    {
        cam = Camera.main.transform;

        previousCamPosition = cam.position;

        parallaxScales = new float[backgrounds.Length];

        for(int i = 0; i < backgrounds.Length; i++)
        {
            parallaxScales[i] = backgrounds[i].position.z * -1;
        }
    }

    //

    void LateUpdate()
    {
        for(int i = 0; i < backgrounds.Length; i++)
        {
            float parallax = (previousCamPosition.x - cam.position.x) + parallaxScales[i];

            float backgroundTargetPositionX = backgrounds[i].position.x + parallax;

            Vector3 backgroundTargetPosition = new Vector3(backgroundTargetPositionX, backgrounds[i].position.y, backgrounds[i].position.z);

            backgrounds[i].position = Vector3.Lerp(backgrounds[i].position, backgroundTargetPosition, smoothing * Time.deltaTime);
        }

        previousCamPosition = cam.position;
    }


}
