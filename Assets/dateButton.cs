using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dateButton : MonoBehaviour {
	Button db;
	// Use this for initialization
	bool flag = false;

	void Start () {
		db = GetComponent<Button> ();
	}

	public void Press () {
		if (flag == true) {
			flag = false;
			ColorBlock cb = db.colors;
			cb.normalColor = new Color(0f, 1f, 1f, 1f);
			db.colors = cb;
		} else {
			flag = true;
			ColorBlock cb = db.colors;
			cb.normalColor = new Color(0f, 0f, 1f, 1f);
			db.colors = cb;
		}
	}
}