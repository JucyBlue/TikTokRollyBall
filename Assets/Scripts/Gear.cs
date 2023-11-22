using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Gear : MonoBehaviour
{
    public float rotationSpeed;
    private void Update() {
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }
}
