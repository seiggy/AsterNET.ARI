/*
   AsterNET ARI Framework
   Automatically generated file @ 6/23/2020 3:09:38 PM
*/
using System;
using System.Collections.Generic;
using AsterNET.ARI.Actions;

namespace AsterNET.ARI.Models
{
    /// <summary>
    /// Event showing the start of a recording operation.
    /// </summary>
    public class RecordingStartedEvent : Event
    {


        /// <summary>
        /// Recording control object
        /// </summary>
        public LiveRecording Recording { get; set; }

    }
}
