using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Water2D;

public class Ballon : MonoBehaviour
{  
    Animator animator;
    public GameObject water;
    Water2D_Spawner spawner;

    Vector2 difference = Vector2.zero;

    private void Start()
    {   
       spawner = water.GetComponent<Water2D_Spawner>();
       water.gameObject.SetActive(false);
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
       // spawner.FillColor = Color.blue;
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
        spawner.transform.parent = null;
        Destroy(this.gameObject);
        water.gameObject.SetActive(true);
    }
}
