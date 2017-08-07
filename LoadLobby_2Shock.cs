using UnityEngine;
using System.Collections;
using System;
using System.ComponentModel;
using System.Text;
using System.Collections.Generic;

using System.Runtime.InteropServices;

public class LoadLobby_2Shock : MonoBehaviour {

//	[DllImport("inpout32")]
//	private static extern UInt32 IsInpOutDriverOpen();
//	[DllImport("inpout32")]
//	private static extern void Out32(short PortAddress, short Data);
//	[DllImport("inpout32")]
//	private static extern char Inp32(short PortAddress);
//	
//	[DllImport("inpout32")]
//	private static extern void DlPortWritePortUshort(short PortAddress, ushort Data);
//	[DllImport("inpout32")]
//	private static extern ushort DlPortReadPortUshort(short PortAddress);
//	
//	[DllImport("inpout32")]
//	private static extern void DlPortWritePortUlong(int PortAddress, uint Data);
//	[DllImport("inpout32")]
//	private static extern uint DlPortReadPortUlong(int PortAddress);
	
	[DllImport("inpoutx64")]
	private static extern bool GetPhysLong(ref int PortAddress, ref uint Data);
	[DllImport("inpoutx64")]
	private static extern bool SetPhysLong(ref int PortAddress, ref uint Data);
	
	
	[DllImport("inpoutx64", EntryPoint="IsInpOutDriverOpen")]
	private static extern UInt32 IsInpOutDriverOpen_x64();
	[DllImport("inpoutx64", EntryPoint = "Out32")]
	private static extern void Out32_x64(int PortAddress, short Data);
	[DllImport("inpoutx64", EntryPoint = "Inp32")]
	private static extern char Inp32_x64(short PortAddress);
	
	[DllImport("inpoutx64", EntryPoint = "DlPortWritePortUshort")]
	private static extern void DlPortWritePortUshort_x64(short PortAddress, ushort Data);
	[DllImport("inpoutx64", EntryPoint = "DlPortReadPortUshort")]
	private static extern ushort DlPortReadPortUshort_x64(short PortAddress);
	
	[DllImport("inpoutx64", EntryPoint = "DlPortWritePortUlong")]
	private static extern void DlPortWritePortUlong_x64(int PortAddress, uint Data);
	[DllImport("inpoutx64", EntryPoint = "DlPortReadPortUlong")]
	private static extern uint DlPortReadPortUlong_x64(int PortAddress);
	
	[DllImport("inpoutx64", EntryPoint = "GetPhysLong")]
	private static extern bool GetPhysLong_x64(ref int PortAddress, ref uint Data);
	[DllImport("inpoutx64", EntryPoint = "SetPhysLong")]
	private static extern bool SetPhysLong_x64(ref int PortAddress, ref uint Data);

	float timeLeft = 31.0f;
	float b1 = 0;
	float badd = 0;
	float b2 = 0;
	float s1 = 0;
	float s2 = 0;
	public AudioClip whitenoise;

	// Use this for initialization
	void Start () {
		Invoke ("nextScene", 30);
		b1 = UnityEngine.Random.Range (6,10);
		badd = UnityEngine.Random.Range (10,13);
		b2 = b1 + badd;
		s1 = UnityEngine.Random.Range (1,5);
		s2 = s1 + (UnityEngine.Random.Range (3,5));
		Debug.Log (s1);
		// Debug.Log (LoadLevel.counter);
	}

	IEnumerator MyWait() {
		Out32_x64(57336, 1);
		yield return new WaitForSeconds(1);
		Out32_x64(57336, 0);
	}

	IEnumerator ShockWait() {
		yield return new WaitForSeconds(s1);
		Out32_x64(57336, 100);
		Debug.Log ("Shock 1");
	}

	IEnumerator ShockWait2() {
		yield return new WaitForSeconds(1);
		Out32_x64(57336, 0);
		Out32_x64(57336, 100);
		Debug.Log ("Shock 2");
	}

	void nextScene() {
	//	Application.LoadLevel (0);
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey("escape"))
			Application.Quit();
		timeLeft -= Time.deltaTime;
		if (timeLeft < b1) {
			Debug.Log ("Startle probe 2");
			b1 = 0.0f;
			GetComponent<AudioSource>().PlayOneShot(whitenoise, 1F);
			StartCoroutine(MyWait());
			StartCoroutine(ShockWait2());
		}
		if (timeLeft < b2) {
			Debug.Log ("Startle probe 1");
			b2 = 0.0f;
			GetComponent<AudioSource>().PlayOneShot(whitenoise, 1F);
			StartCoroutine(MyWait());
			StartCoroutine(ShockWait());

		}
	}
}
