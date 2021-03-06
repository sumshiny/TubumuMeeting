﻿namespace TubumuMeeting.Mediasoup
{
    public class ProducerScore
    {
        /// <summary>
        /// SSRC of the RTP stream.
        /// </summary>
        public long Ssrc { get; set; }

        /// <summary>
        /// RID of the RTP stream.
        /// </summary>
        public string? Rid { get; set; }

        /// <summary>
        /// The score of the RTP stream.
        /// </summary>
        public int Score { get; set; }
    }
}
