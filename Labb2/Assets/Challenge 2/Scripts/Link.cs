﻿using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class Link : MonoBehaviour 
{

	public void OpenRepository()
	{
#if !UNITY_EDITOR
		openWindow("https://github.com/Kekbabus/TestRepo");
#endif
	}

	[DllImport("__Internal")]
	private static extern void openWindow(string url);

}