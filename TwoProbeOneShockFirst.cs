using UnityEngine;
using System.Collections;
using System;
using System.ComponentModel;
using System.Text;
using System.Collections.Generic;

using System.Runtime.InteropServices;

public class TwoProbeOneShockFirst : MonoBehaviour {
	
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
	
	public static float timeLeft = 31.0f;
	public static float e1 = 0.0f;
	public static float e2 = 0.0f;
	public static float e3 = 0.0f;
	public AudioClip whitenoise;
	
	// Use this for initialization
	void Start () {
		//		e1 = UnityEngine.Random.Range (6,8);
		//		e2 = UnityEngine.Random.Range (13,16);
		//		e3 = UnityEngine.Random.Range (21,24);
		// Debug.Log (LoadLevel.counter);
	}
	
	IEnumerator MyWait() {
		Out32_x64(57336, 1);
		yield return new WaitForSeconds(1);
		Out32_x64(57336, 0);
	}
	
	IEnumerator ShockWait() {
		yield return new WaitForSeconds(1);
		Out32_x64(57336, 100);
		yield return new WaitForSeconds(1);
		Out32_x64(57336, 0);
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey("escape"))
			Application.Quit();
		timeLeft -= Time.deltaTime;
		if (timeLeft < e1) {
			Debug.Log ("Startle probe 2");
			e1 = 0.0f;
			GetComponent<AudioSource>().PlayOneShot(whitenoise, 1F);
			StartCoroutine(MyWait());
			GameObject start_event = GameObject.Find("Start_event_2");
			start_event.GetComponent<TwoProbeOneShockFirst>().enabled = false;
		}
		if (timeLeft < e3) {
			Debug.Log ("Shock 1");
			e3 = 0.0f;
			StartCoroutine(MyWait());
			StartCoroutine(ShockWait());			
		}
		if (timeLeft < e2) {
			Debug.Log ("Startle probe 1");
			e2 = 0.0f;
			GetComponent<AudioSource>().PlayOneShot(whitenoise, 1F);
			StartCoroutine(MyWait());
		}
	}
}
