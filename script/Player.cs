
using UnityEngine; 
public class Player : MonoBehaviour 
{ //private cause we dont want anyone to acccess outside the class 
//if public it show in the inspector and can be modified 
private Rigidbody2D rb; 
private SpriteRenderer sr;

// Start is called once before the first execution of Update after the MonoBehaviour is created
void Start()
{   //we can access the rigidbody component and can change from dynamic to kinematic when played the game
    rb = GetComponent<Rigidbody2D>();
    rb.isKinematic = true;

    sr=GetComponent<SpriteRenderer>();
}

// Update is called once per frame
void Update()
{
    
}


//to change color on mouse click of the bird
private void OnMouseDown()
{
    sr.color = Color.red;
}


    private void UpMouseDown()
{
    sr.color = Color.white;
}


private void OnMouseDrag()
{
    //to get the mouse position in world space
    Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);    
    //as we know that there is z axis in camera but not in 2d objects therefore it is required to take transform by hand of the user and not use the mouse z axis
    transform.position=new Vector3(mousePosition.x,mousePosition.y,transform.position.z);
}
}