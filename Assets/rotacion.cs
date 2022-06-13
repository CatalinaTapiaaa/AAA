using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotacion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update" + transform.position);
        //transform.position += new Vector3(1, 0, 0) * Time.deltaTime;
        transform.rotation = Quaternion.Euler(0, 0, (1 * Time.deltaTime) + transform.rotation.eulerAngles.z);
        // transform.position = transform.position + new Vector3(1, 0, 0) * Time.deltaTime;
    }
}
