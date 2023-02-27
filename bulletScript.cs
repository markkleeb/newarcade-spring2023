using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    public float speed = 0.1f;

    private GCScript gcscript;

    void Awake()
    {
        gcscript = GameObject.Find("GameController").GetComponent<GCScript>();
    }
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.up * speed, Space.World);

    }

    private void OnTriggerEnter2D(Collider2D collider)
    {

        if(collider.gameObject.tag == "Invader")
        {
            gcscript.AddScore();
            Destroy(collider.gameObject);
            Destroy(gameObject);
            //Nothing will happen after this
        }

    }
}
