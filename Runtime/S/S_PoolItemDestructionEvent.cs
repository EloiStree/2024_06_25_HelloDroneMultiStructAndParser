﻿//Refresh every seconds
[System.Serializable]
public struct S_PoolItemDestructionEvent
{
    public byte m_poolId;
    public uint m_poolItemIndex;
    public ulong m_serverUtcNowTicks;
}