namespace FFMpegSharp.Native
{
    public enum AVDevToAppMessageType
    {
        AV_DEV_TO_APP_NONE = unchecked((int)(((sbyte)('E')) | (((sbyte)('N')) << 8) | (((sbyte)('O')) << 16) | ((uint)('N') << 24))),
        AV_DEV_TO_APP_CREATE_WINDOW_BUFFER = unchecked((int)(((sbyte)('E')) | (((sbyte)('R')) << 8) | (((sbyte)('C')) << 16) | ((uint)('B') << 24))),
        AV_DEV_TO_APP_PREPARE_WINDOW_BUFFER = unchecked((int)(((sbyte)('E')) | (((sbyte)('R')) << 8) | (((sbyte)('P')) << 16) | ((uint)('B') << 24))),
        AV_DEV_TO_APP_DISPLAY_WINDOW_BUFFER = unchecked((int)(((sbyte)('S')) | (((sbyte)('I')) << 8) | (((sbyte)('D')) << 16) | ((uint)('B') << 24))),
        AV_DEV_TO_APP_DESTROY_WINDOW_BUFFER = unchecked((int)(((sbyte)('S')) | (((sbyte)('E')) << 8) | (((sbyte)('D')) << 16) | ((uint)('B') << 24))),
        AV_DEV_TO_APP_BUFFER_OVERFLOW = unchecked((int)(((sbyte)('L')) | (((sbyte)('F')) << 8) | (((sbyte)('O')) << 16) | ((uint)('B') << 24))),
        AV_DEV_TO_APP_BUFFER_UNDERFLOW = unchecked((int)(((sbyte)('L')) | (((sbyte)('F')) << 8) | (((sbyte)('U')) << 16) | ((uint)('B') << 24))),
        AV_DEV_TO_APP_BUFFER_READABLE = unchecked((int)(((sbyte)(' ')) | (((sbyte)('D')) << 8) | (((sbyte)('R')) << 16) | ((uint)('B') << 24))),
        AV_DEV_TO_APP_BUFFER_WRITABLE = unchecked((int)(((sbyte)(' ')) | (((sbyte)('R')) << 8) | (((sbyte)('W')) << 16) | ((uint)('B') << 24))),
        AV_DEV_TO_APP_MUTE_STATE_CHANGED = unchecked((int)(((sbyte)('T')) | (((sbyte)('U')) << 8) | (((sbyte)('M')) << 16) | ((uint)('C') << 24))),
        AV_DEV_TO_APP_VOLUME_LEVEL_CHANGED = unchecked((int)(((sbyte)('L')) | (((sbyte)('O')) << 8) | (((sbyte)('V')) << 16) | ((uint)('C') << 24))),
    }
}
