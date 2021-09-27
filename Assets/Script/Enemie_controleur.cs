using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemie_controleur : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public Rigidbody2D rig;
    private Vector2 velocity;
    // Start is called before the first frame update
    void Start()
    {
        velocity = new Vector2(1.75f, 1.1f);
        spriteRenderer = GetComponent<SpriteRenderer>();
        transform.position = new Vector3(-10.0f, 0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        rig.MovePosition(rig.position + velocity * Time.fixedDeltaTime);


    }
}
