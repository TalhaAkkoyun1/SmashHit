using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraCharacter : MonoBehaviour
{

    public float spawnHelper = 4.5f;
    public GameObject ball;
    public float ballForce = 700;
    public float ballCount;
    private Camera _cam;
    public float camMove;
    public Text ballText;


    
    // Use this for initialization
    void Start()
    {

        _cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log(Time.time);
        Ray ray = _cam.ScreenPointToRay(Input.mousePosition);
        Quaternion targetRotation = Quaternion.LookRotation(ray.direction);

    GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 3f);

        float mousePosx = Input.mousePosition.x;
        float mousePosy = Input.mousePosition.y;

        
        Vector3 BallInstantiatePoint = _cam.ScreenToWorldPoint(new Vector3(mousePosx, mousePosy, _cam.nearClipPlane + spawnHelper));
        ballText.text = " ball =" + ballCount;
        
        

        if (Input.GetMouseButtonDown(0) && ballCount > 0)
        {
            Vector3 targetloc = ray.direction;
            ballCount -=1;

            GameObject ballRigid;
            ballRigid = Instantiate(ball, BallInstantiatePoint, transform.rotation) as GameObject;
            ballRigid.GetComponent<Rigidbody>().AddForce(targetloc * ballForce);
        }
    }
}