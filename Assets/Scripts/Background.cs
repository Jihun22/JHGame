using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    private float moveSpeed =3f;
    // Update is called once per frame
    void Update()
    {
     transform.position += vector3.down * moveSpeed

    }
}
