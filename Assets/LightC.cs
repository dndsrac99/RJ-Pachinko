using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class LightC : MonoBehaviour
{
    public Light2D light;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetIntensity(float intensity)
    {
        light.intensity = intensity;
    }

    public float GetIntensity()
    {
        return light.intensity;
    }

    public void SetColor(Color color)
    {
        light.color = color;
    }

    public Color GetColor()
    {
        return light.color;
    }


}
