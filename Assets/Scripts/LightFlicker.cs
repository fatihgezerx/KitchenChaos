using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlicker : MonoBehaviour
{
    [SerializeField] private float flickerIntensity = 0.2f;
    [SerializeField] private float flickerPerSecond = 3.0f;
    [SerializeField] private float speedRandomness = 1.0f;

    private float time;
    private float startingIntensity;
    private Light spotLight;

    private void Start()
    {
        spotLight = GetComponent<Light>();
        startingIntensity = spotLight.intensity;
    }

    private void Update()
    {
        time += Time.deltaTime * (1 - Random.Range(-speedRandomness, speedRandomness)) * Mathf.PI;
        spotLight.intensity = startingIntensity + Mathf.Sin(time * flickerPerSecond) * flickerIntensity;
    }
}
