using UnityEngine;
using System.Collections;

public class RemoveSpriteColorBySetColorRValue : MonoBehaviour
{

	public UISprite Star;
	private bool isDark = false;

	void Start()
	{
		//闪烁吧，Star！
		InvokeRepeating("Repeat", 0f, 0.5f);
	}

	void Repeat()
	{
		this.Star.color = this.isDark ? new Color(1f, 1f, 1f, 1f) : new Color(0.2f, 1f, 1f, 1f);
		this.isDark = !this.isDark;
	}
}
