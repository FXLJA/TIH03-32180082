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

	public void walkButton()
	{
		animate.Play("walk", -1, 0f);
	}

	public void runButton()
	{
		animate.Play("running", -1, 0f);
	}

	public void jumpButton()
	{
		animate.Play("hit03", -1, 0f);
	}

	public void rollFButton()
	{
		animate.Play("jump", -1, 0f);
	}

	public void rollBButton()
	{
		animate.Play("hit02", -1, 0f);
	}

	public void kickButton()
	{
		animate.Play("hit01", -1, 0f);
	}

	public void QuitAR()
	{
		Application.Quit(); Debug.Log("Exit");
	}
}