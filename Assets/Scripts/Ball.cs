using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Material myMat;
    [ColorUsage(true, true)]
    public Color orgColor;
    public float pulseDuration1;
    public float pulseDuration2;
    public float brightnessMultiplier = 1.5f;
    

    private void Start() {
        myMat = GetComponent<SpriteRenderer>().material;
        myMat.SetColor("_EmissionColor", orgColor);
        myMat.color = orgColor/10;

    }
    private void OnCollisionEnter2D(Collision2D collision) {
        StartCoroutine(PulseEffect());

    }

    private IEnumerator PulseEffect() {

        //Color orgColor = myMat.GetColor("_EmissionColor");
        float startTime = Time.time;

        // Increase brightness
        while (Time.time < startTime + pulseDuration1 / 2) {
            float t = (Time.time - startTime) / (pulseDuration1 / 2);
            Color pulseColor = Color.Lerp(orgColor, orgColor * brightnessMultiplier, t);
            myMat.SetColor("_EmissionColor", pulseColor);
            yield return null;
        }

        // Decrease brightness
        startTime = Time.time;
        while (Time.time < startTime + pulseDuration2 / 2) {
            float t = (Time.time - startTime) / (pulseDuration2 / 2);
            Color pulseColor = Color.Lerp(orgColor * brightnessMultiplier, orgColor, t);
            myMat.SetColor("_EmissionColor", pulseColor);
            yield return null;
        }

        // Reset to the original color after the pulse
        myMat.SetColor("_EmissionColor", orgColor);
    }
}
