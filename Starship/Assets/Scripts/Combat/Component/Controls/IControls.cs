﻿using System.Collections;

namespace Combat.Component.Controls
{
    public interface IControls
    {
        bool DataChanged { get; set; }

        float Throttle { get; set; }
        float? Course { get; set; }

        void SetSystemState(int id, bool active);
        bool GetSystemState(int id);
        BitArray SystemsState { get; set; }
    }
}
