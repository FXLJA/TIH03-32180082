using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlScript : MonoBehaviour
{
    private Animator animate; 
    // Start is called before the first frame update 
    void Start() 
    { 
        animate = GetComponent<Animator>(); 
    } 

    public void walkForward() 
    { 
        animate.Play("WALK00_F", -1, 0f); 
    } 

    public void walkBackward() 
    { 
        animate.Play("WALK00_B", -1, 0f); 
    }

    public void walkRight() 
    { 
        animate.Play("WALK00_R", -1, 0f); 
    } 

    public void walkLeft() 
    { 
        animate.Play("WALK00_L", -1, 0f); 
    }

    public void jumpA() 
    { 
        animate.Play("JUMP00", -1, 0f); 
    }

    public void jumpB() 
    { 
        animate.Play("JUMP01", -1, 0f); 
    } 

    public void runForward() 
    { 
        animate.Play("RUN00_F", -1, 0f); 
    } 

    public void runSlide() 
    { 
        animate.Play("SLIDE00", -1, 0f); 
    } 

    public void runRight() 
    { 
        animate.Play("RUN00_R", -1, 0f); 
    } 

    public void runLeft() 
    { 
        animate.Play("RUN00_L", -1, 0f); 
    } 

    public void stopMovement()
    { 
        animate.Play("WAIT02", -1, 0f); 
    }
}