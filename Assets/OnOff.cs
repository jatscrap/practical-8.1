using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOff : MonoBehaviour
{
    public Light L;
    // Start is called before the first frame update
    void Start()
    {
        L = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)) {
            L.enabled = !L.enabled; //sets enabled to the opposite of what it's currently set on
        } 
    }
}
