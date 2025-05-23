// <copyright file="AVError.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

namespace FFMpegSharp.Native;

/// <summary>
/// FFMpeg error codes
/// </summary>
public static class AVError
{
    /// <summary>
    /// Bitstream filter not found
    /// </summary>
    public static readonly int AVERROR_BSF_NOT_FOUND = FFERRTAG(0xF8, 'B', 'S', 'F');
    /// <summary>
    /// Internal bug, also see AVERROR_BUG2
    /// </summary>
    public static readonly int AVERROR_BUG = FFERRTAG('B', 'U', 'G', '!');
    /// <summary>
    /// Buffer too small
    /// </summary>
    public static readonly int AVERROR_BUFFER_TOO_SMALL = FFERRTAG('B', 'U', 'F', 'S');
    /// <summary>
    /// Decoder not found
    /// </summary>
    public static readonly int AVERROR_DECODER_NOT_FOUND = FFERRTAG(0xF8, 'D', 'E', 'C');
    /// <summary>
    /// Demuxer not found
    /// </summary>
    public static readonly int AVERROR_DEMUXER_NOT_FOUND = FFERRTAG(0xF8, 'D', 'E', 'M');
    /// <summary>
    /// Encoder not found
    /// </summary>
    public static readonly int AVERROR_ENCODER_NOT_FOUND = FFERRTAG(0xF8, 'E', 'N', 'C');
    /// <summary>
    /// End of file
    /// </summary>
    public static readonly int AVERROR_EOF = FFERRTAG('E', 'O', 'F', ' ');
    /// <summary>
    /// Immediate exit was requested; the called function should not beint padonly rttc reeati sted
    /// </summary>
    public static readonly int AVERROR_EXIT = FFERRTAG('E', 'X', 'I', 'T');
    /// <summary>
    /// Generic error in an external library
    /// </summary>
    public static readonly int AVERROR_EXTERNAL = FFERRTAG('E', 'X', 'T', ' ');
    /// <summary>
    /// Filter not found
    /// </summary>
    public static readonly int AVERROR_FILTER_NOT_FOUND = FFERRTAG(0xF8, 'F', 'I', 'L');
    /// <summary>
    /// Invalid data found when processing input
    /// </summary>
    public static readonly int AVERROR_INVALIDDATA = FFERRTAG('I', 'N', 'D', 'A');
    /// <summary>
    /// Muxer not found
    /// </summary>
    public static readonly int AVERROR_MUXER_NOT_FOUND = FFERRTAG(0xF8, 'M', 'U', 'X');
    /// <summary>
    /// Option not found
    /// </summary>
    public static readonly int AVERROR_OPTION_NOT_FOUND = FFERRTAG(0xF8, 'O', 'P', 'T');
    /// <summary>
    /// Not yet implemented in FFmpeg, patches welcome
    /// </summary>
    public static readonly int AVERROR_PATCHWELCOME = FFERRTAG('P', 'A', 'W', 'E');
    /// <summary>
    /// Protocol not found
    /// </summary>
    public static readonly int AVERROR_PROTOCOL_NOT_FOUND = FFERRTAG(0xF8, 'P', 'R', 'O');
    /// <summary>
    /// Stream not found
    /// </summary>
    public static readonly int AVERROR_STREAM_NOT_FOUND = FFERRTAG(0xF8, 'S', 'T', 'R');

    /// <summary>
    /// This is semantically identical to AVERROR_BUG
    /// it has been introduced in Libav after our AVERROR_BUG and with a modified value.
    /// </summary>
    public static readonly int AVERROR_BUG2 = FFERRTAG('B', 'U', 'G', ' ');
    /// <summary>
    /// Unknown error, typically from an external library
    /// </summary>
    public static readonly int AVERROR_UNKNOWN = FFERRTAG('U', 'N', 'K', 'N');
    /// <summary>
    /// Requested feature is flagged experimental. Set strict_std_compliance if you really want to use it.
    /// </summary>
    public static readonly int AVERROR_EXPERIMENTAL = -0x2bb2afa8;
    /// <summary>
    /// Input changed between calls. Reconfiguration is required. (can be OR-ed with AVERROR_OUTPUT_CHANGED)
    /// </summary>
    public static readonly int AVERROR_INPUT_CHANGED = -0x636e6701;
    /// <summary>
    /// Output changed between calls. Reconfiguration is required. (can be OR-ed with AVERROR_INPUT_CHANGED)
    /// </summary>
    public static readonly int AVERROR_OUTPUT_CHANGED = -0x636e6702;

    /// <summary>
    /// HTTP & RTSP errors
    /// </summary>
    public static readonly int AVERROR_HTTP_BAD_REQUEST = FFERRTAG(0xF8, '4', '0', '0');
    public static readonly int AVERROR_HTTP_UNAUTHORIZED = FFERRTAG(0xF8, '4', '0', '1');
    public static readonly int AVERROR_HTTP_FORBIDDEN = FFERRTAG(0xF8, '4', '0', '3');
    public static readonly int AVERROR_HTTP_NOT_FOUND = FFERRTAG(0xF8, '4', '0', '4');
    public static readonly int AVERROR_HTTP_OTHER_4XX = FFERRTAG(0xF8, '4', 'X', 'X');
    public static readonly int AVERROR_HTTP_SERVER_ERROR = FFERRTAG(0xF8, '5', 'X', 'X');

    public static readonly int AV_ERROR_MAX_STRING_SIZE = 64;

    private static int FFERRTAG(char a, char b, char c, char d)
    {
        return -MKTAG((byte)a, (byte)b, (byte)c, (byte)d);
    }

    private static int FFERRTAG(byte a, char b, char c, char d)
    {
        return -MKTAG(a, (byte)b, (byte)c, (byte)d);
    }

    private static int MKTAG(byte a, byte b, byte c, byte d)
    {
        return (int)(a | ((uint)b << 8) | ((uint)c << 16) | ((uint)d << 24));
    }

    public static int Error(int errno)
    {
        return -errno;
    }
}
