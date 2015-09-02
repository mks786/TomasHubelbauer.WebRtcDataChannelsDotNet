﻿namespace Rhaeo.WebRtc.Ice
{
  public sealed class RelayIceCandidate
    : IceCandidate
  {
    #region Constructors

    public RelayIceCandidate(int foundation, int priority, string address, int port)
      : base(foundation, priority, address, port)
    {
    }

    #endregion

    #region Properties

    public override IceCandidateType Type => IceCandidateType.Relay;

    #endregion
  }
}
