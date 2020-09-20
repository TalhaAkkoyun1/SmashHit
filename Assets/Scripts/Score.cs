using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    CameraCharacter cameraCharacter;


    // Start is called before the first frame update
    private void Start()
    {
        cameraCharacter = Camera.main.GetComponent<CameraCharacter>();

     }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "BallScore")
           {
            Debug.Log("where is my fucking point");
            Destroy(collision.gameObject);
            Debug.Log("ballCount");
            cameraCharacter.ballCount += 3;
        }
    }


}
