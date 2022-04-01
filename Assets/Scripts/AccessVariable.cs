using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Bolt;

public class AccessVariable : MonoBehaviour
{
    public SceneVariables sceneVariables;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dist = (Mathf.Sin(Time.time) + 1.0f) * 5;
        sceneVariables.variables.declarations.Set("dist", dist);
    }
}
