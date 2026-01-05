
using System.Collections.ObjectModel;
using System.Collections;
// using System.Collections.Generic;
using UnityEngine; 
public class Player : MonoBehaviour 
{ //private cause we dont want anyone to acccess outside the class 
//if public it show in the inspector and can be modified 
private Rigidbody2D rb; 
private SpriteRenderer sr;
private Vector2 startPosition;
private Vector2 currentPosition;
private Vector2 direction;  
public float launchSpeed;
public float maxDragAmount;
public float delaytime;


// Start is called once before the first execution of Update after the MonoBehaviour is created
void Start()
{   //we can access the rigidbody component and can change from dynamic to kinematic when played the game
    rb = GetComponent<Rigidbody2D>();
    rb.isKinematic = true;

    sr=GetComponent<SpriteRenderer>();
    startPosition = rb.position;



     Debug.Log("START is running");
}

// Update is called once per frame
void Update()
{
}

//to change color on mouse click of the bird
private void OnMouseDown()
{
    Debug.Log("My script in OnMouseDown is running");
    sr.color = Color.red;
}


private void OnMouseUp()
{
    Debug.Log("My script in OnMouseUp is running");
    currentPosition=rb.position;//from a position to another position here done this to make it stay there
    direction = startPosition - currentPosition;
    Debug.Log("Direction: " + direction);
    Debug.Log("startPosition: " + startPosition);
    Debug.Log("currentPosition: " + currentPosition);


    direction.Normalize();

    rb.isKinematic = false;
    rb.AddForce(direction * launchSpeed);//to add force in the direction we want to launch  


    sr.color = Color.white;

}


private void OnMouseDrag()
{
    //to get the mouse position in world space
    Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); 
    Vector2 desiredPosition = mousePosition; 
    //we are intializing desired position to mouse position //vector2 have x and y only
    
    //vector2.distance distance between two points
    float distance = Vector2.Distance(desiredPosition, startPosition);
    if (distance>maxDragAmount)
        {
            direction = desiredPosition - startPosition;
            direction.Normalize();
            desiredPosition = startPosition + (direction * maxDragAmount);
        }





     //so that we cannot move outside the 2d space
    if (desiredPosition.x>startPosition.x)
    {
        desiredPosition.x=startPosition.x;
    }
    //as we know that there is z axis in camera but not in 2d objects therefore it is required to take transform by hand of the user and not use the mouse z axis
    // dont need this
    // transform.position=new Vector3(mousePosition.x,mousePosition.y,transform.position.z);

    rb.position=desiredPosition;


}
//to reset the position of the bird to its starting position after hitting the blocks 
private void OnCollisionEnter2D(Collision2D collision)
{
    // Debug.Log("we have collided");
    // rb.position=startPosition;
    // rb.isKinematic=true;
    // rb.velocity=Vector2.zero;
    StartCoroutine(DelayRestart());
}
//this ieumerator is called corotine to add delay in the restart of the bird
IEnumerator DelayRestart()
    {//inside the brackett can put any number but here used to input the number from the inspector 
        yield return new WaitForSeconds(delaytime);
        rb.position = startPosition;
        rb.isKinematic = true;
        rb.linearVelocity = Vector2.zero;
    }

}