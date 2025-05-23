namespace FFMpegSharp.Native
{
    public enum AVAppToDevMessageType
    {
        AV_APP_TO_DEV_NONE = unchecked((int)(((sbyte)('E')) | (((sbyte)('N')) << 8) | (((sbyte)('O')) << 16) | ((uint)('N') << 24))),
        AV_APP_TO_DEV_WINDOW_SIZE = unchecked((int)(((sbyte)('M')) | (((sbyte)('O')) << 8) | (((sbyte)('E')) << 16) | ((uint)('G') << 24))),
        AV_APP_TO_DEV_WINDOW_REPAINT = unchecked((int)(((sbyte)('A')) | (((sbyte)('P')) << 8) | (((sbyte)('E')) << 16) | ((uint)('R') << 24))),
        AV_APP_TO_DEV_PAUSE = unchecked((int)(((sbyte)(' ')) | (((sbyte)('U')) << 8) | (((sbyte)('A')) << 16) | ((uint)('P') << 24))),
        AV_APP_TO_DEV_PLAY = unchecked((int)(((sbyte)('Y')) | (((sbyte)('A')) << 8) | (((sbyte)('L')) << 16) | ((uint)('P') << 24))),
        AV_APP_TO_DEV_TOGGLE_PAUSE = unchecked((int)(((sbyte)('T')) | (((sbyte)('U')) << 8) | (((sbyte)('A')) << 16) | ((uint)('P') << 24))),
        AV_APP_TO_DEV_SET_VOLUME = unchecked((int)(((sbyte)('L')) | (((sbyte)('O')) << 8) | (((sbyte)('V')) << 16) | ((uint)('S') << 24))),
        AV_APP_TO_DEV_MUTE = unchecked((int)(((sbyte)('T')) | (((sbyte)('U')) << 8) | (((sbyte)('M')) << 16) | ((uint)(' ') << 24))),
        AV_APP_TO_DEV_UNMUTE = unchecked((int)(((sbyte)('T')) | (((sbyte)('U')) << 8) | (((sbyte)('M')) << 16) | ((uint)('U') << 24))),
        AV_APP_TO_DEV_TOGGLE_MUTE = unchecked((int)(((sbyte)('T')) | (((sbyte)('U')) << 8) | (((sbyte)('M')) << 16) | ((uint)('T') << 24))),
        AV_APP_TO_DEV_GET_VOLUME = unchecked((int)(((sbyte)('L')) | (((sbyte)('O')) << 8) | (((sbyte)('V')) << 16) | ((uint)('G') << 24))),
        AV_APP_TO_DEV_GET_MUTE = unchecked((int)(((sbyte)('T')) | (((sbyte)('U')) << 8) | (((sbyte)('M')) << 16) | ((uint)('G') << 24))),
    }
}
