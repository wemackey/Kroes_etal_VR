using UnityEngine;
using System.Collections;
using System;
using System.ComponentModel;
using System.Text;
using System.Collections.Generic;

using System.Runtime.InteropServices;

public class Event_3 : MonoBehaviour {
	
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
	
	IEnumerator MyWait() {
		Out32_x64(57336, 1);
		yield return new WaitForSeconds(1);
		Out32_x64(57336, 0);
	}
	
	void OnTriggerEnter(Collider Player){
		float w1 = 0;
		float w2 = 0;
		float w3 = 0;
		
		SeqCounter.counter++;
		Debug.Log (SeqCounter.counter);
		GameObject start_event = GameObject.Find("Start_event_2");
		
		switch (SeqCounter.counter)
		{
		case 1:
			start_event.GetComponent<HallwayOneProbe>().enabled = true;
			HallwayOneProbe.timeLeft = 15.0f;
			w3 = UnityEngine.Random.Range (5,10);
			HallwayOneProbe.e3 = w3;
			StartCoroutine(MyWait());
			break;
		case 2:
			start_event.GetComponent<TwoProbeNoShock>().enabled = true;
			TwoProbeNoShock.timeLeft = 31.0f;
			w1 = UnityEngine.Random.Range (6,8);
			w2 = UnityEngine.Random.Range (13,16);
			w3 = UnityEngine.Random.Range (21,24);
			TwoProbeNoShock.e1 = w1;
			TwoProbeNoShock.e2 = w2;
			TwoProbeNoShock.e3 = w3;
			StartCoroutine(MyWait());
			break;
		case 3:
			start_event.GetComponent<HallwayOneProbe>().enabled = true;
			HallwayOneProbe.timeLeft = 15.0f;
			w3 = UnityEngine.Random.Range (5,10);
			HallwayOneProbe.e3 = w3;
			StartCoroutine(MyWait());
			break;
		case 4:
			start_event.GetComponent<TwoProbeOneShock>().enabled = true;
			TwoProbeOneShock.timeLeft = 31.0f;
			w1 = UnityEngine.Random.Range (6,8);
			w2 = UnityEngine.Random.Range (13,16);
			w3 = UnityEngine.Random.Range (21,24);
			TwoProbeOneShock.e1 = w1;
			TwoProbeOneShock.e2 = w2;
			TwoProbeOneShock.e3 = w3;
			StartCoroutine(MyWait());
			break;
		case 5:
			start_event.GetComponent<HallwayOneProbe>().enabled = true;
			HallwayOneProbe.timeLeft = 15.0f;
			w3 = UnityEngine.Random.Range (5,10);
			HallwayOneProbe.e3 = w3;
			StartCoroutine(MyWait());
			break;
		case 6:
			start_event.GetComponent<TwoProbeNoShock>().enabled = true;
			TwoProbeNoShock.timeLeft = 31.0f;
			w1 = UnityEngine.Random.Range (6,8);
			w2 = UnityEngine.Random.Range (13,16);
			w3 = UnityEngine.Random.Range (21,24);
			TwoProbeNoShock.e1 = w1;
			TwoProbeNoShock.e2 = w2;
			TwoProbeNoShock.e3 = w3;
			StartCoroutine(MyWait());
			break;
		case 7:
			start_event.GetComponent<HallwayOneProbe>().enabled = true;
			HallwayOneProbe.timeLeft = 15.0f;
			w3 = UnityEngine.Random.Range (5,10);
			HallwayOneProbe.e3 = w3;
			StartCoroutine(MyWait());
			break;
		case 8:
			start_event.GetComponent<TwoProbeNoShock>().enabled = true;
			TwoProbeNoShock.timeLeft = 31.0f;
			w1 = UnityEngine.Random.Range (6,8);
			w2 = UnityEngine.Random.Range (13,16);
			w3 = UnityEngine.Random.Range (21,24);
			TwoProbeNoShock.e1 = w1;
			TwoProbeNoShock.e2 = w2;
			TwoProbeNoShock.e3 = w3;
			StartCoroutine(MyWait());
			break;
		case 9:
			start_event.GetComponent<HallwayOneProbe>().enabled = true;
			HallwayOneProbe.timeLeft = 15.0f;
			w3 = UnityEngine.Random.Range (5,10);
			HallwayOneProbe.e3 = w3;
			StartCoroutine(MyWait());
			break;
		case 10:
			start_event.GetComponent<TwoProbeOneShockFirst>().enabled = true;
			TwoProbeOneShockFirst.timeLeft = 31.0f;
			w1 = UnityEngine.Random.Range (6,8);
			w2 = UnityEngine.Random.Range (13,16);
			w3 = UnityEngine.Random.Range (21,24);
			TwoProbeOneShockFirst.e1 = w1;
			TwoProbeOneShockFirst.e2 = w2;
			TwoProbeOneShockFirst.e3 = w3;
			StartCoroutine(MyWait());
			break;
		case 11:
			start_event.GetComponent<HallwayOneProbe>().enabled = true;
			HallwayOneProbe.timeLeft = 15.0f;
			w3 = UnityEngine.Random.Range (5,10);
			HallwayOneProbe.e3 = w3;
			StartCoroutine(MyWait());
			break;
		case 12:
			start_event.GetComponent<OneProbeNoShock>().enabled = true;
			OneProbeNoShock.timeLeft = 31.0f;
			w1 = UnityEngine.Random.Range (6,8);
			w2 = UnityEngine.Random.Range (13,16);
			w3 = UnityEngine.Random.Range (21,24);
			OneProbeNoShock.e1 = w1;
			OneProbeNoShock.e2 = w2;
			OneProbeNoShock.e3 = w3;
			StartCoroutine(MyWait());
			break;
		case 13:
			start_event.GetComponent<HallwayOneProbe>().enabled = true;
			HallwayOneProbe.timeLeft = 15.0f;
			w3 = UnityEngine.Random.Range (5,10);
			HallwayOneProbe.e3 = w3;
			StartCoroutine(MyWait());
			break;
		case 14:
			start_event.GetComponent<TwoProbeNoShock>().enabled = true;
			TwoProbeNoShock.timeLeft = 31.0f;
			w1 = UnityEngine.Random.Range (6,8);
			w2 = UnityEngine.Random.Range (13,16);
			w3 = UnityEngine.Random.Range (21,24);
			TwoProbeNoShock.e1 = w1;
			TwoProbeNoShock.e2 = w2;
			TwoProbeNoShock.e3 = w3;
			StartCoroutine(MyWait());
			break;
		case 15:
			start_event.GetComponent<HallwayOneProbe>().enabled = true;
			HallwayOneProbe.timeLeft = 15.0f;
			w3 = UnityEngine.Random.Range (5,10);
			HallwayOneProbe.e3 = w3;
			StartCoroutine(MyWait());
			break;
		case 16:
			start_event.GetComponent<TwoProbeNoShock>().enabled = true;
			TwoProbeNoShock.timeLeft = 31.0f;
			w1 = UnityEngine.Random.Range (6,8);
			w2 = UnityEngine.Random.Range (13,16);
			w3 = UnityEngine.Random.Range (21,24);
			TwoProbeNoShock.e1 = w1;
			TwoProbeNoShock.e2 = w2;
			TwoProbeNoShock.e3 = w3;
			StartCoroutine(MyWait());
			break;
		case 17:
			start_event.GetComponent<HallwayOneProbe>().enabled = true;
			HallwayOneProbe.timeLeft = 15.0f;
			w3 = UnityEngine.Random.Range (5,10);
			HallwayOneProbe.e3 = w3;
			StartCoroutine(MyWait());
			break;
		case 18:
			start_event.GetComponent<TwoProbeNoShock>().enabled = true;
			TwoProbeNoShock.timeLeft = 31.0f;
			w1 = UnityEngine.Random.Range (6,8);
			w2 = UnityEngine.Random.Range (13,16);
			w3 = UnityEngine.Random.Range (21,24);
			TwoProbeNoShock.e1 = w1;
			TwoProbeNoShock.e2 = w2;
			TwoProbeNoShock.e3 = w3;
			StartCoroutine(MyWait());
			break;
		case 19:
			start_event.GetComponent<HallwayOneProbe>().enabled = true;
			HallwayOneProbe.timeLeft = 15.0f;
			w3 = UnityEngine.Random.Range (5,10);
			HallwayOneProbe.e3 = w3;
			StartCoroutine(MyWait());
			break;
		case 20:
			start_event.GetComponent<OneProbeTwoShock>().enabled = true;
			OneProbeTwoShock.timeLeft = 31.0f;
			w1 = UnityEngine.Random.Range (6,8);
			w2 = UnityEngine.Random.Range (13,16);
			w3 = UnityEngine.Random.Range (21,24);
			OneProbeTwoShock.e1 = w1;
			OneProbeTwoShock.e2 = w2;
			OneProbeTwoShock.e3 = w3;
			StartCoroutine(MyWait());
			break;
		case 21:
			start_event.GetComponent<HallwayOneProbe>().enabled = true;
			HallwayOneProbe.timeLeft = 15.0f;
			w3 = UnityEngine.Random.Range (5,10);
			HallwayOneProbe.e3 = w3;
			StartCoroutine(MyWait());
			break;
		case 22:
			start_event.GetComponent<TwoProbeOneShock>().enabled = true;
			TwoProbeOneShock.timeLeft = 31.0f;
			w1 = UnityEngine.Random.Range (6,8);
			w2 = UnityEngine.Random.Range (13,16);
			w3 = UnityEngine.Random.Range (21,24);
			TwoProbeOneShock.e1 = w1;
			TwoProbeOneShock.e2 = w2;
			TwoProbeOneShock.e3 = w3;
			StartCoroutine(MyWait());
			break;
		case 23:
			start_event.GetComponent<HallwayOneProbe>().enabled = true;
			HallwayOneProbe.timeLeft = 15.0f;
			w3 = UnityEngine.Random.Range (5,10);
			HallwayOneProbe.e3 = w3;
			StartCoroutine(MyWait());
			break;
		case 24:
			start_event.GetComponent<TwoProbeNoShock>().enabled = true;
			TwoProbeNoShock.timeLeft = 31.0f;
			w1 = UnityEngine.Random.Range (6,8);
			w2 = UnityEngine.Random.Range (13,16);
			w3 = UnityEngine.Random.Range (21,24);
			TwoProbeNoShock.e1 = w1;
			TwoProbeNoShock.e2 = w2;
			TwoProbeNoShock.e3 = w3;
			StartCoroutine(MyWait());
			break;
		case 25:
			start_event.GetComponent<HallwayOneProbe>().enabled = true;
			HallwayOneProbe.timeLeft = 15.0f;
			w3 = UnityEngine.Random.Range (5,10);
			HallwayOneProbe.e3 = w3;
			StartCoroutine(MyWait());
			break;
		case 26:
			start_event.GetComponent<TwoProbeOneShock>().enabled = true;
			TwoProbeOneShock.timeLeft = 31.0f;
			w1 = UnityEngine.Random.Range (6,8);
			w2 = UnityEngine.Random.Range (13,16);
			w3 = UnityEngine.Random.Range (21,24);
			TwoProbeOneShock.e1 = w1;
			TwoProbeOneShock.e2 = w2;
			TwoProbeOneShock.e3 = w3;
			StartCoroutine(MyWait());
			break;
		case 27:
			start_event.GetComponent<HallwayOneProbe>().enabled = true;
			HallwayOneProbe.timeLeft = 15.0f;
			w3 = UnityEngine.Random.Range (5,10);
			HallwayOneProbe.e3 = w3;
			StartCoroutine(MyWait());
			break;
		case 28:
			start_event.GetComponent<OneProbeNoShock>().enabled = true;
			OneProbeNoShock.timeLeft = 31.0f;
			w1 = UnityEngine.Random.Range (6,8);
			w2 = UnityEngine.Random.Range (13,16);
			w3 = UnityEngine.Random.Range (21,24);
			OneProbeNoShock.e1 = w1;
			OneProbeNoShock.e2 = w2;
			OneProbeNoShock.e3 = w3;
			StartCoroutine(MyWait());
			break;
		case 29:
			start_event.GetComponent<HallwayOneProbe>().enabled = true;
			HallwayOneProbe.timeLeft = 15.0f;
			w3 = UnityEngine.Random.Range (5,10);
			HallwayOneProbe.e3 = w3;
			StartCoroutine(MyWait());
			break;
		case 30:
			start_event.GetComponent<TwoProbeNoShock>().enabled = true;
			TwoProbeNoShock.timeLeft = 31.0f;
			w1 = UnityEngine.Random.Range (6,8);
			w2 = UnityEngine.Random.Range (13,16);
			w3 = UnityEngine.Random.Range (21,24);
			TwoProbeNoShock.e1 = w1;
			TwoProbeNoShock.e2 = w2;
			TwoProbeNoShock.e3 = w3;
			StartCoroutine(MyWait());
			break;
		case 31:
			start_event.GetComponent<HallwayOneProbe>().enabled = true;
			HallwayOneProbe.timeLeft = 15.0f;
			w3 = UnityEngine.Random.Range (5,10);
			HallwayOneProbe.e3 = w3;
			StartCoroutine(MyWait());
			break;
		case 32:
			start_event.GetComponent<TwoProbeNoShock>().enabled = true;
			TwoProbeNoShock.timeLeft = 31.0f;
			w1 = UnityEngine.Random.Range (6,8);
			w2 = UnityEngine.Random.Range (13,16);
			w3 = UnityEngine.Random.Range (21,24);
			TwoProbeNoShock.e1 = w1;
			TwoProbeNoShock.e2 = w2;
			TwoProbeNoShock.e3 = w3;
			StartCoroutine(MyWait());
			break;
		case 33:
			start_event.GetComponent<HallwayOneProbe>().enabled = true;
			HallwayOneProbe.timeLeft = 15.0f;
			w3 = UnityEngine.Random.Range (5,10);
			HallwayOneProbe.e3 = w3;
			StartCoroutine(MyWait());
			break;
		case 34:
			start_event.GetComponent<TwoProbeNoShock>().enabled = true;
			TwoProbeNoShock.timeLeft = 31.0f;
			w1 = UnityEngine.Random.Range (6,8);
			w2 = UnityEngine.Random.Range (13,16);
			w3 = UnityEngine.Random.Range (21,24);
			TwoProbeNoShock.e1 = w1;
			TwoProbeNoShock.e2 = w2;
			TwoProbeNoShock.e3 = w3;
			StartCoroutine(MyWait());
			break;
		case 35:
			start_event.GetComponent<HallwayOneProbe>().enabled = true;
			HallwayOneProbe.timeLeft = 15.0f;
			w3 = UnityEngine.Random.Range (5,10);
			HallwayOneProbe.e3 = w3;
			StartCoroutine(MyWait());
			break;
		case 36:
			start_event.GetComponent<OneProbeTwoShock>().enabled = true;
			OneProbeTwoShock.timeLeft = 31.0f;
			w1 = UnityEngine.Random.Range (6,8);
			w2 = UnityEngine.Random.Range (13,16);
			w3 = UnityEngine.Random.Range (21,24);
			OneProbeTwoShock.e1 = w1;
			OneProbeTwoShock.e2 = w2;
			OneProbeTwoShock.e3 = w3;
			StartCoroutine(MyWait());
			break;
		case 37:
			start_event.GetComponent<HallwayOneProbe>().enabled = true;
			HallwayOneProbe.timeLeft = 15.0f;
			w3 = UnityEngine.Random.Range (5,10);
			HallwayOneProbe.e3 = w3;
			StartCoroutine(MyWait());
			break;
		case 38:
			start_event.GetComponent<TwoProbeNoShock>().enabled = true;
			TwoProbeNoShock.timeLeft = 31.0f;
			w1 = UnityEngine.Random.Range (6,8);
			w2 = UnityEngine.Random.Range (13,16);
			w3 = UnityEngine.Random.Range (21,24);
			TwoProbeNoShock.e1 = w1;
			TwoProbeNoShock.e2 = w2;
			TwoProbeNoShock.e3 = w3;
			StartCoroutine(MyWait());
			break;
		case 39:
			start_event.GetComponent<HallwayOneProbe>().enabled = true;
			HallwayOneProbe.timeLeft = 15.0f;
			w3 = UnityEngine.Random.Range (5,10);
			HallwayOneProbe.e3 = w3;
			StartCoroutine(MyWait());
			break;
		case 40:
			start_event.GetComponent<TwoProbeNoShock>().enabled = true;
			TwoProbeNoShock.timeLeft = 31.0f;
			w1 = UnityEngine.Random.Range (6,8);
			w2 = UnityEngine.Random.Range (13,16);
			w3 = UnityEngine.Random.Range (21,24);
			TwoProbeNoShock.e1 = w1;
			TwoProbeNoShock.e2 = w2;
			TwoProbeNoShock.e3 = w3;
			StartCoroutine(MyWait());
			break;
		case 41:
			StartCoroutine(MyWait());
			break;
		}
	}
}