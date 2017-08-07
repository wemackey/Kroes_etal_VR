using UnityEngine;
using System.Collections;

public class SeqCounter : MonoBehaviour {
	public static int counter = 0;

	// Use this for initialization
	void Start () {

	}

//	void nextScene() {
//		counter++;
//		switch (counter)
//		{
//		case 1:
//			Application.LoadLevel (2);
//			break;
//		case 2:
//			Application.LoadLevel (4);
//			break;
//		case 3:
//			Application.LoadLevel (2);
//			break;
//		case 4:
//			Application.LoadLevel (4);
//			break;
//		case 5:
//			Application.LoadLevel (3);
//			break;
//		case 6:
//			Application.LoadLevel (2);
//			break;
//		case 7:
//			Application.LoadLevel (4);
//			break;
//		case 8:
//			Application.LoadLevel (4);
//			break;
//		case 9:
//			Application.LoadLevel (2);
//			break;
//		case 10:
//			Application.LoadLevel (4);
//			break;
//		case 11:
//			Application.LoadLevel (4);
//			break;
//		case 12:
//			Application.LoadLevel (3);
//			break;
//		case 13:
//			Application.LoadLevel (2);
//			break;
//		case 14:
//			Application.LoadLevel (4);
//			break;
//		case 15:
//			Application.LoadLevel (2);
//			break;
//		case 16:
//			Application.LoadLevel (4);
//			break;
//		case 17:
//			Application.LoadLevel (2);
//			break;
//		case 18:
//			Application.LoadLevel (4);
//			break;
//		case 19:
//			Application.LoadLevel (2);
//			break;
//		case 20:
//			Application.LoadLevel (4);
//			break;
//		case 21:
//			Application.Quit();
//			break;
//		}
//	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("escape"))
			Application.Quit();
	}
}
