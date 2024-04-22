using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ItemRotation : MonoBehaviour
{
    public int RotationSpeed = 100;
    private Transform itemTransform;
    // Start is called before the first frame update
    void Start()
    {
        itemTransform = this.GetComponent<Transform>();
        debug.log("hello");
    }

    // Update is called once per frame
    void Update()
    {
        itemTransform.Rotate(RotationSpeed * Time.deltaTime, 0 , 0);
    }
}
