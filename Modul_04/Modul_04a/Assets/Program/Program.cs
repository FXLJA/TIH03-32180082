using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Program : MonoBehaviour 
{ 
    private Animator animasi; 
    // Start is called before the first frame update 
    void Start() 
    { 
        animasi = GetComponent<Animator>(); 
    } 
    public void animWalkAttack() 
    { 
        animasi.Play("WalkAttack", -1, 0f); 
    } 
    public void animWalkBack() 
    { 
        animasi.Play("WalkBack", -1, 0f); 
    } 
    public void animWalkHit() 
    { 
        animasi.Play("WalkHit", -1, 0f); 
    }
    public void animAttack() 
    { 
        animasi.Play("Attack", -1, 0f); 
    }
    public void animHit() 
    { 
        animasi.Play("Hit", -1, 0f); 
    }
    public void animEatDown() 
    { 
        animasi.Play("EatDown", -1, 0f); 
    }
    public void animDeath() 
    { 
        animasi.Play("Death", -1, 0f); 
    }
    public void animRebirth()
    {
        animasi.Play("Rebirth", -1, 0f);
    }
    public void animBlendTree()
    {
        animasi.Play("Blend Tree", -1, 0f);
    }
    public void QuitAR()
    {
        Application.Quit();
    }
}