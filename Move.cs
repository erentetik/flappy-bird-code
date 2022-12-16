using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour

{
    public float speeds;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 7);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speeds * Time.deltaTime;
    }
}
