﻿namespace VrmacVideo.IO.HEVC
{
	enum eDecoderRegister: ushort
	{
		SPS0 = 0,
		SPS1 = 1,
		PPS = 2,
		Slice = 3,
		TileStart = 4,
		TileEnd = 5,
		SliceStart = 6,
		Mode = 7,
		Left0 = 8,
		Left1 = 9,
		Left2 = 10,
		Left3 = 11,
		QP = 12,
		Control = 13,
		Status = 14,
		Version = 15,
		BfBase = 16,
		BfNum = 17,
		BfControl = 18,
		BfStatus = 19,
		PuwBase = 20,
		PuwStride = 21,
		CoeffwBase = 22,
		CoeffwStride = 23,
		SliceCommands = 24,
		BeginTileEnd = 25,
		Transfer = 26,
		CfBase = 27,
		CfNum = 28,
		CfStatus = 29,

		/// <summary>Offset of the first scaling list. The list has 1019 values, 32 bit / each</summary>
		ScalingList0 = 0x800,

		PurBase = 0x2000,
		PurStride = 0x2001,
		CoeffrBase = 0x2002,
		CoeffrStride = 0x2003,
		NumRows = 0x2004,
		Config2 = 0x2005,
		OutyBase = 0x2006,
		OutyStride = 0x2007,
		OutcBase = 0x2008,
		OutcStride = 0x2009,
		Status2 = 0x200A,
		FrameSize = 0x200B,
		MvBase = 0x200C,
		MvStride = 0x200D,
		ColBase = 0x200E,
		ColStride = 0x200F,
		CurrentPoc = 0x2010,
	}
}