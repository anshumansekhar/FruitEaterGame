using UnityEngine;
using System.Collections;

public class fuitspawner : MonoBehaviour {
    [SerializeField]
    private GameObject[] Fruits;
    private BoxCollider2D col;
    float x1, x2;

	// Use this for initialization
	void Awake () {
        col = GetComponent<BoxCollider2D>();
         x1 = transform.position.x - col.bounds.size.x / 2f;
         x2 = transform.position.x + col.bounds.size.x / 2f;



    }
    void Start()
    {
        StartCoroutine(Spawnfruits(1));
    


}
    IEnumerator Spawnfruits(float time)
    {
        yield return new WaitForSecondsRealtime(time);
        

        Vector3 temp = transform.position;
        temp.x = Random.Range(x1, x2);
        Instantiate(Fruits[Random.Range(0, Fruits.Length)], temp, Quaternion.identity);
        StartCoroutine(Spawnfruits(Random.Range(1f, 2f))); 
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
