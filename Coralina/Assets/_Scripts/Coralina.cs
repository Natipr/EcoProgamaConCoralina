using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coralina : MonoBehaviour {
    

    private Rigidbody2D rb;    
    private Animator anim;  

    GameObject current;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

       Move();
        if (isPick())
        {
            PickUp();
        }
        if (isDrop())
            Drop();

    }
    void MoveUp()
    {

        transform.Translate(0, 1f, 0);
    }
    void MoveDown()
    {

        transform.Translate(0, -1f, 0);
    }
    void MoveLeft()
    {

        transform.Translate(-1f, 0, 0);
   
    }
    void MoveRight()
    {

        transform.Translate(1f, 0, 0);
    }
    void PickUp()
    {
        anim.Play("pickup");
        if (current != null) { Destroy(current); current = null; }
    }

    void Drop()
    {
        anim.Play("drop");
    }

    //TESTING FUNCTIONS

    //Determines if the user pressed the up key.
    bool isUp()
    {

        // this.transform.Translate(0, 1, 0);
        return Input.GetKeyDown(KeyCode.UpArrow);
    }

    //Determines if the user pressed the down key.
    bool isDown()
    {
        return Input.GetKeyDown(KeyCode.DownArrow);
    }

    //Determines if the user pressed the left key.
    bool isLeft()
    {
        return Input.GetKeyDown(KeyCode.LeftArrow);

    }

    //Determines if the user pressed the right key.
    bool isRight()
    {
        return Input.GetKeyDown(KeyCode.RightArrow);
    }
    //Determines if the user pressed the z.
    bool isDrop()
    {
        return Input.GetKeyDown(KeyCode.Z);
    }
    //Determines if the user pressed the X.
    bool isPick()
    {
        return Input.GetKeyDown(KeyCode.X);
    }
    void Move()
    {
        if (isUp())
        {
            MoveUp();
          
        }
        else if (isDown())
        {
            MoveDown();
           
        }
        else if (isLeft())
        {
            MoveLeft();
           
        }
        else if (isRight())
        {
            MoveRight();        
        }
       

    }

    void OnTriggerStay2D(Collider2D col)
    {
        if ((col.gameObject.tag == "aluminum") || (col.gameObject.tag == "plastic" )|| (col.gameObject.tag == "glass"))
        {
            current = col.gameObject;
        }
      
    }
    void OnTriggerExit2D(Collider2D col)
    {
        current = null;
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "enemy")
        {
            Debug.Log("va");
            anim.Play("hit");
        }
        else if (col.gameObject.tag == "collider")
        {
            anim.Play("hit");
        }
            current = null;

    }





}


