﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TubumuMeeting.Mediasoup
{
    public class NewConsumerReadyRequest
    {
        public int PeerId { get; set; }

        public string ConsumerId { get; set; }
    }
}
