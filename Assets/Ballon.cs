using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballon : MonoBehaviour
{  
    Animator animator;
    


    Vector2 difference = Vector2.zero;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void OnMouseDown()
    {
        difference = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition)- (Vector2)transform.position;

    }
    private void OnMouseDrag()
    {
        transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - difference;
    }
    private void OnMouseUp()
    {
        animator.SetTrigger("Burst");
       
    }

    public void BallonDestroy()
    {
        Destroy(this.gameObject);
    }
}
