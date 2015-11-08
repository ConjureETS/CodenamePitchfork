using UnityEngine;
using System.Collections;

public class DummyRotationTest : MonoBehaviour {
    private int x = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.rotation = Quaternion.Euler(0, 10 + x, 0);
        x++;
	}
}
