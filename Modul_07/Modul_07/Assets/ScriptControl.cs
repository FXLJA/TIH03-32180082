using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptControl : MonoBehaviour
{
    private Animator animator; 
    // Start is called before the first frame update 

    void Start() 
    { 
        animator = GetComponent<Animator>(); 
    } 
    public void idle() 
    { 
        animator.Play("Idle_3", -1, 0f); 
    } 
    public void walk() 
    { 
        animator.Play("Walk_IP", -1, 0f); 
    } 
    public void run() 
    { 
        animator.Play("Run_IP", -1, 0f); 
    } 
    public void attack() 
    {
        animator.Play("Attack_Arm_1", -1, 0f);
    }
}
