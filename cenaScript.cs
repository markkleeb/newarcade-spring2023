using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cenaScript : MonoBehaviour
{
    public GameObject player;
    public float speed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 position = this.transform.position;

        position.x = Mathf.Lerp(this.transform.position.x, player.transform.position.x, speed * Time.deltaTime);
        position.y = Mathf.Lerp(this.transform.position.y, player.transform.position.y, speed * Time.deltaTime);

        this.transform.position = position;
    }
}
