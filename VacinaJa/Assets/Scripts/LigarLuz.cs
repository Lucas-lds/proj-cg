using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LigarLuz : MonoBehaviour
{
    private Light lights;

    void Awake()
    {
        lights = GetComponent<Light>();
    }

    void OnMouseDown()
    {
        lights.enabled = !lights.enabled;
    }
}
