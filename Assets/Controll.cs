using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controll : MonoBehaviour
{

    public Sprite sp2;
    public SpriteRenderer spriteRenderer;
    public Rigidbody2D r2D;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public Vector2 vector;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        vector = new Vector2(x,y) * 5;
        r2D.velocity = vector;
        List<int> list = new List<int>();

        list.FindIndex(item=> item == 2);

        if (Input.GetKeyUp(KeyCode.Space)) {
            spriteRenderer.sprite = sp2;
        }
        

    }

    private void OnMouseUp() {
        
    }

    private void OnMouseUpAsButton() {
        
    }
}
