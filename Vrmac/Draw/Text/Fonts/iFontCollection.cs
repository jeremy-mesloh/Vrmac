﻿using System;

namespace Vrmac.Draw
{
	public interface iFontCollection
	{
		iFontFace defaultSerif( eFontStyleFlags styleFlags );
		iFontFace defaultSanSerif( eFontStyleFlags styleFlags );
		iFontFace defaultMono( eFontStyleFlags styleFlags );
		iFontFace comicSans( eFontStyleFlags styleFlags );
	}

	public interface iFontFace: IDisposable
	{
		string familyName { get; }
		eFontStyleFlags styleFlags { get; }
		iFont createFont( float fontSizePt, float dpiScaling );
	}

	public interface iFont
	{
		iFontFace fontFace { get; }
		uint sizePixels { get; }
		int lineHeightPixels { get; }
	}
}