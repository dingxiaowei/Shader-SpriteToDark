using UnityEngine;
using System.Collections;

public class RemoveSpriteColorBySetColorRValue : MonoBehaviour {

	public UISprite Star;
	private bool isDark = false;
	
	void Update () {
		Debug.LogError("*************");
		this.Star.color = this.isDark ? new Color(255, 255, 255) : new Color(51, 255, 255);
		this.isDark = !this.isDark;
	}
}
