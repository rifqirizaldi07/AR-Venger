using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class evaluasi : MonoBehaviour {

	public GameObject soal1;
	public GameObject soal2;
	public GameObject soal3;
	public GameObject soal4;
	public GameObject soal5;
	public GameObject soal6;
	public GameObject soal7;
	public GameObject soal8;
	public GameObject soal9;
	public GameObject soal10;

	public void soal1Clicked() {
		soal1.SetActive (true);
		soal2.SetActive (false);
		soal3.SetActive (false);
		soal4.SetActive (false);
		soal5.SetActive (false);
		soal6.SetActive (false);
		soal7.SetActive (false);
		soal8.SetActive (false);
		soal9.SetActive (false);
		soal10.SetActive (false);
	}

	public void soal2Clicked() {
		soal1.SetActive (false);
		soal2.SetActive (true);
		soal3.SetActive (false);
		soal4.SetActive (false);
		soal5.SetActive (false);
		soal6.SetActive (false);
		soal7.SetActive (false);
		soal8.SetActive (false);
		soal9.SetActive (false);
		soal10.SetActive (false);
	}

	public void soal3Clicked() {
		soal1.SetActive (false);
		soal2.SetActive (false);
		soal3.SetActive (true);
		soal4.SetActive (false);
		soal5.SetActive (false);
		soal6.SetActive (false);
		soal7.SetActive (false);
		soal8.SetActive (false);
		soal9.SetActive (false);
		soal10.SetActive (false);
	}
	
	public void soal4Clicked() {
		soal1.SetActive (false);
		soal2.SetActive (false);
		soal3.SetActive (false);
		soal4.SetActive (true);
		soal5.SetActive (false);
		soal6.SetActive (false);
		soal7.SetActive (false);
		soal8.SetActive (false);
		soal9.SetActive (false);
		soal10.SetActive (false);
	}

		public void soal5Clicked() {
		soal1.SetActive (false);
		soal2.SetActive (false);
		soal3.SetActive (false);
		soal4.SetActive (false);
		soal5.SetActive (true);
		soal6.SetActive (false);
		soal7.SetActive (false);
		soal8.SetActive (false);
		soal9.SetActive (false);
		soal10.SetActive (false);
	}

		public void soal6Clicked() {
		soal1.SetActive (false);
		soal2.SetActive (false);
		soal3.SetActive (false);
		soal4.SetActive (false);
		soal5.SetActive (false);
		soal6.SetActive (true);
		soal7.SetActive (false);
		soal8.SetActive (false);
		soal9.SetActive (false);
		soal10.SetActive (false);
	}

		public void soal7Clicked() {
		soal1.SetActive (false);
		soal2.SetActive (false);
		soal3.SetActive (false);
		soal4.SetActive (false);
		soal5.SetActive (false);
		soal6.SetActive (false);
		soal7.SetActive (true);
		soal8.SetActive (false);
		soal9.SetActive (false);
		soal10.SetActive (false);
	}

		public void soal8Clicked() {
		soal1.SetActive (false);
		soal2.SetActive (false);
		soal3.SetActive (false);
		soal4.SetActive (false);
		soal5.SetActive (false);
		soal6.SetActive (false);
		soal7.SetActive (false);
		soal8.SetActive (true);
		soal9.SetActive (false);
		soal10.SetActive (false);
	}

		public void soal9Clicked() {
		soal1.SetActive (false);
		soal2.SetActive (false);
		soal3.SetActive (false);
		soal4.SetActive (false);
		soal5.SetActive (false);
		soal6.SetActive (false);
		soal7.SetActive (false);
		soal8.SetActive (false);
		soal9.SetActive (true);
		soal10.SetActive (false);
	}

		public void soal10Clicked() {
		soal1.SetActive (false);
		soal2.SetActive (false);
		soal3.SetActive (false);
		soal4.SetActive (false);
		soal5.SetActive (false);
		soal6.SetActive (false);
		soal7.SetActive (false);
		soal8.SetActive (false);
		soal9.SetActive (false);
		soal10.SetActive (true);
	}
}
