﻿using System.Collections.Generic;

namespace Kafka.Basic.Auto
{
    public interface IBatch : IEnumerable<ConsumedMessage> { }
}