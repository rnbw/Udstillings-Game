using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAnim : MonoBehaviour {

    Vector3 tempPos;
    Animator anim;
    AnimatorClipInfo[] animInfo; 

	// Use this for initialization
	void Start () {
        anim = this.GetComponent(Animation).animation.Play("New Sprite 1");
        anim.SetTrigger("New Sprite 1");

        
 
	}
	
	// Update is called once per frame
	void Update () {
        tempPos = transform.position;
        

    

        tempPos.x -= 0.001f;

        transform.position = tempPos;
	}
}
