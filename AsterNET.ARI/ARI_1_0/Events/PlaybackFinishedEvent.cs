﻿/*
	AsterNET ARI Framework
	Automatically generated file @ 25/05/2014 20:39:48
*/
using System;
using System.Collections.Generic;

namespace AsterNET.ARI.Models
{
	/// <summary>
	/// Event showing the completion of a media playback operation.
	/// </summary>
	public class PlaybackFinishedEvent  : Event
	{
		/// <summary>
		/// Playback control object
		/// </summary>
		public Playback Playback { get; set; }

	}
}