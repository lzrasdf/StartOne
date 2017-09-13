using UnityEngine;  
using System.Collections;  

public static class GlobalDirection
{
	public static string Str_Forward= "Z";
	public static string Str_Back 	="-Z";
	public static string Str_Up 	= "Y";
	public static string Str_Down 	="-Y";
	public static string Str_Left 	="-X";
	public static string Str_Right 	= "X";
			
	public static Vector3 Vec_Forward 	= new Vector3(0,0, 1);
	public static Vector3 Vec_Back 		= new Vector3(0,0,-1);
	public static Vector3 Vec_Up 		= new Vector3(0, 1,0);
	public static Vector3 Vec_Down 		= new Vector3(0,-1,0);
	public static Vector3 Vec_Left 		= new Vector3(-1,0,0);
	public static Vector3 Vec_Right 	= new Vector3( 1,0,0);
}