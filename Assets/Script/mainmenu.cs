using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainmenu : MonoBehaviour {

	public void goTomenu () {
		Application.LoadLevel ("mainmenu");
	}

	public void evaluasi () {
		Application.LoadLevel ("evaluasi");
	}

	public void tentang () {
		Application.LoadLevel ("tentang");
	}

	public void panduan () {
		Application.LoadLevel ("panduan");
	}

	public void arkamera () {
		Application.LoadLevel ("arkamera");
	}

	public void KeluarClicked() {
		Application.Quit ();
	}
}
