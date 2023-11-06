using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackGround : MonoBehaviour
{
    public GameObject camera;
    public float parallaxEffect;
    private float width, possitionX;

    // Start is called before the first frame update
    void Start()
    {
        width = GetComponent<SpriteRenderer>().bounds.size.x;
        possitionX = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        float parallaxDistance = camera.transform.position.x * parallaxEffect;
        float remainingDistance = camera.transform.position.x * (1 - parallaxEffect);
        
        transform.position = new Vector3(possitionX + parallaxDistance, transform.position.y, transform.position.z);

        if(remainingDistance > possitionX + width )
        {
            possitionX += width;
        }
    }
}
