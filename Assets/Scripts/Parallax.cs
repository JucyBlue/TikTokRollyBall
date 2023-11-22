using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour {
    public Transform[] backgrounds; // Array of background layers
    public float[] parallaxScales; // The proportion of the camera's movement to move the backgrounds by



    void Update() {
        
        
        for (int i = 0; i < backgrounds.Length; i++) {
            backgrounds[i].transform.position = new Vector3(transform.position.x / parallaxScales[i], transform.position.y / parallaxScales[i], 7.94f);
        }


    }
}