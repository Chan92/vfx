using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotating : MonoBehaviour {
    [SerializeField]
    private Vector3Int rotateDirection = new Vector3Int(0, 1, 0);

    [SerializeField]
    private float speed = 0.5f;


	void Update() {
        transform.Rotate((Vector3) rotateDirection * speed * Time.deltaTime);
    }
}
