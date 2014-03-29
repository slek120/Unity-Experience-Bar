using UnityEngine;
using System.Collections;

public class ExperienceBar : MonoBehaviour
{
	[Range(0,1)]
	public float
		percent;
	float oldPercent = 0;
	Material material;

	void Start ()
	{
		material = renderer.material;
	}

	void Update ()
	{
		if (oldPercent != percent) {
			material.SetTextureOffset ("_MaskTex", Vector2.right * (1 - percent * 2));
			oldPercent = percent;
		}
	}
}
