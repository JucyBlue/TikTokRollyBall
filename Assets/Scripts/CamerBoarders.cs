using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerBoarders : MonoBehaviour {
    public float yOffset;
    private EdgeCollider2D edgeCollider;
    Camera mainCamera;
    private void Start() {
        edgeCollider= GetComponent<EdgeCollider2D>();
        mainCamera = Camera.main;
        UpdateCameraCollider();
    }

  
    public void UpdateCameraCollider() {
        float cameraSize = mainCamera.orthographicSize;
        float cameraAspect = mainCamera.aspect;
        float width = cameraSize * cameraAspect;
        float height = cameraSize;
        edgeCollider.points = new Vector2[]
       {
            new Vector2(-width , -height + yOffset),
            new Vector2(-width , height + yOffset),
            new Vector2(width , height + yOffset),
            new Vector2(width , -height + yOffset),
            new Vector2(-width , -height+ yOffset),
       };
    }
}


