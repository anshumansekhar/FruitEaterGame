using UnityEngine;
using System.Collections;

public class PlayerBounce : MonoBehaviour {

    private float minX, maxX;

	// Use this for initialization
	void Start () {
        Vector3 cor = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        minX = -cor.x + 0.3f;
        maxX = cor.x - 0.3f;
        
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 temp = transform.position;
        if (temp.x > maxX)
            temp.x = maxX;
        if (temp.x < minX)
            temp.x = minX;
        transform.position = temp;
	
	}
}
