using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinAnimation : MonoBehaviour
{
	public Animation anim;
	public AnimationClip[] clips;

	[Space(10)]
	public float walkSpeed = 1f;

	private void Start() {
		anim[clips[1].name].speed = walkSpeed;
	}

	public void ChangeAnimationClip(int clipId) {
		if(clips[clipId] == null || clipId >= clips.Length) {
			anim.Stop();
		} else {
			anim.Play(clips[clipId].name);
		}
	}
}
