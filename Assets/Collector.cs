using UnityEngine;
using System.Collections;

public class Collector : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
    void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag=="Bomb"||target.tag=="Fruit")
        {
            target.gameObject.SetActive(false);
        }

    }
	
	// Update is called once per frame
	void Update () {
	
	}
    
}
