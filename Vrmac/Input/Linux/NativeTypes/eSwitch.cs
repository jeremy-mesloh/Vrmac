﻿// This source file is generated by a tool.
#pragma warning disable CS1591  // CS1591: Missing XML comment for publicly visible type or member

namespace Vrmac.Input.Linux
{
	/// <summary>Switch events</summary>
	public enum eSwitch: byte
	{
		/// <summary>set = lid shut</summary>
		Lid = 0x00,
		/// <summary>set = tablet mode</summary>
		TabletMode = 0x01,
		/// <summary>set = inserted</summary>
		HeadphoneInsert = 0x02,
		/// <summary>rfkill master switch, type "any" set = radio enabled</summary>
		RfkillAll = 0x03,
		/// <summary>set = inserted</summary>
		MicrophoneInsert = 0x04,
		/// <summary>set = plugged into dock</summary>
		Dock = 0x05,
		/// <summary>set = inserted</summary>
		LineoutInsert = 0x06,
		/// <summary>set = mechanical switch set</summary>
		JackPhysicalInsert = 0x07,
		/// <summary>set = inserted</summary>
		VideooutInsert = 0x08,
		/// <summary>set = lens covered</summary>
		CameraLensCover = 0x09,
		/// <summary>set = keypad slide out</summary>
		KeypadSlide = 0x0a,
		/// <summary>set = front proximity sensor active</summary>
		FrontProximity = 0x0b,
		/// <summary>set = rotate locked/disabled</summary>
		RotateLock = 0x0c,
		/// <summary>set = inserted</summary>
		LineinInsert = 0x0d,
		/// <summary>set = device disabled</summary>
		MuteDevice = 0x0e,
		/// <summary>set = pen inserted</summary>
		PenInserted = 0x0f,
	}
}