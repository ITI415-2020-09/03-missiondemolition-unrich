using System.Collections;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    static public FollowCam S;

    public float easing = 0.05f;

    public Vector2 minXY;

    public bool _____________________________;

    public GameObject poi;
    public float camZ;

    void Awake()
    {
        S = this;
        camZ = this.transform.position.z;
    }

    void Update()
    {
        if (poi == null) return;
        Vector3 destination = poi.transform.position;
        destination.x = Mathf.Max(miniXY.x, destination.x);
        destination.y = Mathf.Max(miniXY.y, destination.y);
        destination = Vector3.Lerp(transform.position, destination, easing);
        destination.z = camZ;
        transform.position = destination;
        this.GetComponent<Camera>().orthographicSize = destination.y + 10;
    }
}
