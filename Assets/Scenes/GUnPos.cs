using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUnPos : MonoBehaviour
{
    public Transform posTransform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = posTransform.transform.position;
    }
}
