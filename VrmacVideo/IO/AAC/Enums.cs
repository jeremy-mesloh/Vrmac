﻿// This C# source file has been generated by a T4 template.
using System;

namespace VrmacVideo.IO.AAC
{
	/// <summary>Transport type identifiers</summary>
	enum eTransportType: int
	{
		/// <summary>Unknown format</summary>
		Unknown = -1,
		/// <summary>"as is" access units (packet based since there is obviously no sync layer)</summary>
		Raw = 0,
		/// <summary>ADIF bitstream format</summary>
		ADIF = 1,
		/// <summary>ADTS bitstream format</summary>
		ADTS = 2,
		/// <summary>Low Overhead Audio Transport Multiplex; Audio Mux Elements with muxConfigPresent = 1</summary>
		LATM_MCP1 = 6,
		/// <summary>Low Overhead Audio Transport Multiplex; Audio Mux Elements with muxConfigPresent = 0, out of band StreamMuxConfig</summary>
		LATM_MCP0 = 7,
		/// <summary>Self-synchronizing format called Low Overhead Audio Stream</summary>
		LOAS = 10,
		/// <summary>Digital Radio Mondiale (DRM30/DRM+) bitstream format</summary>
		DRM = 12,
	}

	/// <summary>Speaker description tags.</summary>
	[Flags]
	enum eAudioChannel: int
	{
		/// <summary>None</summary>
		None = 0,
		/// <summary>Front speaker position at normal height</summary>
		Front = 1,
		/// <summary>Side speaker position at normal height</summary>
		Size = 2,
		/// <summary>Back speaker position at normal height</summary>
		Back = 3,
		/// <summary>Low frequency effect speaker position (front)</summary>
		Sub = 4,
		/// <summary>Top speaker area flag, for combination with speaker positions</summary>
		Top = 0x10,
		/// <summary>Bottom speaker area flag, for combination with speaker positions</summary>
		Bottom = 0x20,
	}
}