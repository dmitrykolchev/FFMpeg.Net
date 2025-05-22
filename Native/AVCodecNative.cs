using System;

namespace FFMpegSharp.Native
{
    public enum AVCodecID
    {
        AV_CODEC_ID_NONE,
        AV_CODEC_ID_MPEG1VIDEO,
        AV_CODEC_ID_MPEG2VIDEO,
        AV_CODEC_ID_H261,
        AV_CODEC_ID_H263,
        AV_CODEC_ID_RV10,
        AV_CODEC_ID_RV20,
        AV_CODEC_ID_MJPEG,
        AV_CODEC_ID_MJPEGB,
        AV_CODEC_ID_LJPEG,
        AV_CODEC_ID_SP5X,
        AV_CODEC_ID_JPEGLS,
        AV_CODEC_ID_MPEG4,
        AV_CODEC_ID_RAWVIDEO,
        AV_CODEC_ID_MSMPEG4V1,
        AV_CODEC_ID_MSMPEG4V2,
        AV_CODEC_ID_MSMPEG4V3,
        AV_CODEC_ID_WMV1,
        AV_CODEC_ID_WMV2,
        AV_CODEC_ID_H263P,
        AV_CODEC_ID_H263I,
        AV_CODEC_ID_FLV1,
        AV_CODEC_ID_SVQ1,
        AV_CODEC_ID_SVQ3,
        AV_CODEC_ID_DVVIDEO,
        AV_CODEC_ID_HUFFYUV,
        AV_CODEC_ID_CYUV,
        AV_CODEC_ID_H264,
        AV_CODEC_ID_INDEO3,
        AV_CODEC_ID_VP3,
        AV_CODEC_ID_THEORA,
        AV_CODEC_ID_ASV1,
        AV_CODEC_ID_ASV2,
        AV_CODEC_ID_FFV1,
        AV_CODEC_ID_4XM,
        AV_CODEC_ID_VCR1,
        AV_CODEC_ID_CLJR,
        AV_CODEC_ID_MDEC,
        AV_CODEC_ID_ROQ,
        AV_CODEC_ID_INTERPLAY_VIDEO,
        AV_CODEC_ID_XAN_WC3,
        AV_CODEC_ID_XAN_WC4,
        AV_CODEC_ID_RPZA,
        AV_CODEC_ID_CINEPAK,
        AV_CODEC_ID_WS_VQA,
        AV_CODEC_ID_MSRLE,
        AV_CODEC_ID_MSVIDEO1,
        AV_CODEC_ID_IDCIN,
        AV_CODEC_ID_8BPS,
        AV_CODEC_ID_SMC,
        AV_CODEC_ID_FLIC,
        AV_CODEC_ID_TRUEMOTION1,
        AV_CODEC_ID_VMDVIDEO,
        AV_CODEC_ID_MSZH,
        AV_CODEC_ID_ZLIB,
        AV_CODEC_ID_QTRLE,
        AV_CODEC_ID_TSCC,
        AV_CODEC_ID_ULTI,
        AV_CODEC_ID_QDRAW,
        AV_CODEC_ID_VIXL,
        AV_CODEC_ID_QPEG,
        AV_CODEC_ID_PNG,
        AV_CODEC_ID_PPM,
        AV_CODEC_ID_PBM,
        AV_CODEC_ID_PGM,
        AV_CODEC_ID_PGMYUV,
        AV_CODEC_ID_PAM,
        AV_CODEC_ID_FFVHUFF,
        AV_CODEC_ID_RV30,
        AV_CODEC_ID_RV40,
        AV_CODEC_ID_VC1,
        AV_CODEC_ID_WMV3,
        AV_CODEC_ID_LOCO,
        AV_CODEC_ID_WNV1,
        AV_CODEC_ID_AASC,
        AV_CODEC_ID_INDEO2,
        AV_CODEC_ID_FRAPS,
        AV_CODEC_ID_TRUEMOTION2,
        AV_CODEC_ID_BMP,
        AV_CODEC_ID_CSCD,
        AV_CODEC_ID_MMVIDEO,
        AV_CODEC_ID_ZMBV,
        AV_CODEC_ID_AVS,
        AV_CODEC_ID_SMACKVIDEO,
        AV_CODEC_ID_NUV,
        AV_CODEC_ID_KMVC,
        AV_CODEC_ID_FLASHSV,
        AV_CODEC_ID_CAVS,
        AV_CODEC_ID_JPEG2000,
        AV_CODEC_ID_VMNC,
        AV_CODEC_ID_VP5,
        AV_CODEC_ID_VP6,
        AV_CODEC_ID_VP6F,
        AV_CODEC_ID_TARGA,
        AV_CODEC_ID_DSICINVIDEO,
        AV_CODEC_ID_TIERTEXSEQVIDEO,
        AV_CODEC_ID_TIFF,
        AV_CODEC_ID_GIF,
        AV_CODEC_ID_DXA,
        AV_CODEC_ID_DNXHD,
        AV_CODEC_ID_THP,
        AV_CODEC_ID_SGI,
        AV_CODEC_ID_C93,
        AV_CODEC_ID_BETHSOFTVID,
        AV_CODEC_ID_PTX,
        AV_CODEC_ID_TXD,
        AV_CODEC_ID_VP6A,
        AV_CODEC_ID_AMV,
        AV_CODEC_ID_VB,
        AV_CODEC_ID_PCX,
        AV_CODEC_ID_SUNRAST,
        AV_CODEC_ID_INDEO4,
        AV_CODEC_ID_INDEO5,
        AV_CODEC_ID_MIMIC,
        AV_CODEC_ID_RL2,
        AV_CODEC_ID_ESCAPE124,
        AV_CODEC_ID_DIRAC,
        AV_CODEC_ID_BFI,
        AV_CODEC_ID_CMV,
        AV_CODEC_ID_MOTIONPIXELS,
        AV_CODEC_ID_TGV,
        AV_CODEC_ID_TGQ,
        AV_CODEC_ID_TQI,
        AV_CODEC_ID_AURA,
        AV_CODEC_ID_AURA2,
        AV_CODEC_ID_V210X,
        AV_CODEC_ID_TMV,
        AV_CODEC_ID_V210,
        AV_CODEC_ID_DPX,
        AV_CODEC_ID_MAD,
        AV_CODEC_ID_FRWU,
        AV_CODEC_ID_FLASHSV2,
        AV_CODEC_ID_CDGRAPHICS,
        AV_CODEC_ID_R210,
        AV_CODEC_ID_ANM,
        AV_CODEC_ID_BINKVIDEO,
        AV_CODEC_ID_IFF_ILBM,
        AV_CODEC_ID_KGV1,
        AV_CODEC_ID_YOP,
        AV_CODEC_ID_VP8,
        AV_CODEC_ID_PICTOR,
        AV_CODEC_ID_ANSI,
        AV_CODEC_ID_A64_MULTI,
        AV_CODEC_ID_A64_MULTI5,
        AV_CODEC_ID_R10K,
        AV_CODEC_ID_MXPEG,
        AV_CODEC_ID_LAGARITH,
        AV_CODEC_ID_PRORES,
        AV_CODEC_ID_JV,
        AV_CODEC_ID_DFA,
        AV_CODEC_ID_WMV3IMAGE,
        AV_CODEC_ID_VC1IMAGE,
        AV_CODEC_ID_UTVIDEO,
        AV_CODEC_ID_BMV_VIDEO,
        AV_CODEC_ID_VBLE,
        AV_CODEC_ID_DXTORY,
        AV_CODEC_ID_V410,
        AV_CODEC_ID_XWD,
        AV_CODEC_ID_CDXL,
        AV_CODEC_ID_XBM,
        AV_CODEC_ID_ZEROCODEC,
        AV_CODEC_ID_MSS1,
        AV_CODEC_ID_MSA1,
        AV_CODEC_ID_TSCC2,
        AV_CODEC_ID_MTS2,
        AV_CODEC_ID_CLLC,
        AV_CODEC_ID_MSS2,
        AV_CODEC_ID_VP9,
        AV_CODEC_ID_AIC,
        AV_CODEC_ID_ESCAPE130,
        AV_CODEC_ID_G2M,
        AV_CODEC_ID_WEBP,
        AV_CODEC_ID_HNM4_VIDEO,
        AV_CODEC_ID_HEVC,
        AV_CODEC_ID_FIC,
        AV_CODEC_ID_ALIAS_PIX,
        AV_CODEC_ID_BRENDER_PIX,
        AV_CODEC_ID_PAF_VIDEO,
        AV_CODEC_ID_EXR,
        AV_CODEC_ID_VP7,
        AV_CODEC_ID_SANM,
        AV_CODEC_ID_SGIRLE,
        AV_CODEC_ID_MVC1,
        AV_CODEC_ID_MVC2,
        AV_CODEC_ID_HQX,
        AV_CODEC_ID_TDSC,
        AV_CODEC_ID_HQ_HQA,
        AV_CODEC_ID_HAP,
        AV_CODEC_ID_DDS,
        AV_CODEC_ID_DXV,
        AV_CODEC_ID_SCREENPRESSO,
        AV_CODEC_ID_RSCC,
        AV_CODEC_ID_AVS2,
        AV_CODEC_ID_PGX,
        AV_CODEC_ID_AVS3,
        AV_CODEC_ID_MSP2,
        AV_CODEC_ID_VVC,
        AV_CODEC_ID_Y41P,
        AV_CODEC_ID_AVRP,
        AV_CODEC_ID_012V,
        AV_CODEC_ID_AVUI,
        AV_CODEC_ID_AYUV,
        AV_CODEC_ID_TARGA_Y216,
        AV_CODEC_ID_V308,
        AV_CODEC_ID_V408,
        AV_CODEC_ID_YUV4,
        AV_CODEC_ID_AVRN,
        AV_CODEC_ID_CPIA,
        AV_CODEC_ID_XFACE,
        AV_CODEC_ID_SNOW,
        AV_CODEC_ID_SMVJPEG,
        AV_CODEC_ID_APNG,
        AV_CODEC_ID_DAALA,
        AV_CODEC_ID_CFHD,
        AV_CODEC_ID_TRUEMOTION2RT,
        AV_CODEC_ID_M101,
        AV_CODEC_ID_MAGICYUV,
        AV_CODEC_ID_SHEERVIDEO,
        AV_CODEC_ID_YLC,
        AV_CODEC_ID_PSD,
        AV_CODEC_ID_PIXLET,
        AV_CODEC_ID_SPEEDHQ,
        AV_CODEC_ID_FMVC,
        AV_CODEC_ID_SCPR,
        AV_CODEC_ID_CLEARVIDEO,
        AV_CODEC_ID_XPM,
        AV_CODEC_ID_AV1,
        AV_CODEC_ID_BITPACKED,
        AV_CODEC_ID_MSCC,
        AV_CODEC_ID_SRGC,
        AV_CODEC_ID_SVG,
        AV_CODEC_ID_GDV,
        AV_CODEC_ID_FITS,
        AV_CODEC_ID_IMM4,
        AV_CODEC_ID_PROSUMER,
        AV_CODEC_ID_MWSC,
        AV_CODEC_ID_WCMV,
        AV_CODEC_ID_RASC,
        AV_CODEC_ID_HYMT,
        AV_CODEC_ID_ARBC,
        AV_CODEC_ID_AGM,
        AV_CODEC_ID_LSCR,
        AV_CODEC_ID_VP4,
        AV_CODEC_ID_IMM5,
        AV_CODEC_ID_MVDV,
        AV_CODEC_ID_MVHA,
        AV_CODEC_ID_CDTOONS,
        AV_CODEC_ID_MV30,
        AV_CODEC_ID_NOTCHLC,
        AV_CODEC_ID_PFM,
        AV_CODEC_ID_MOBICLIP,
        AV_CODEC_ID_PHOTOCD,
        AV_CODEC_ID_IPU,
        AV_CODEC_ID_ARGO,
        AV_CODEC_ID_CRI,
        AV_CODEC_ID_SIMBIOSIS_IMX,
        AV_CODEC_ID_SGA_VIDEO,
        AV_CODEC_ID_GEM,
        AV_CODEC_ID_VBN,
        AV_CODEC_ID_JPEGXL,
        AV_CODEC_ID_QOI,
        AV_CODEC_ID_PHM,
        AV_CODEC_ID_RADIANCE_HDR,
        AV_CODEC_ID_WBMP,
        AV_CODEC_ID_MEDIA100,
        AV_CODEC_ID_VQC,
        AV_CODEC_ID_PDV,
        AV_CODEC_ID_EVC,
        AV_CODEC_ID_RTV1,
        AV_CODEC_ID_VMIX,
        AV_CODEC_ID_FIRST_AUDIO = 0x10000,
        AV_CODEC_ID_PCM_S16LE = 0x10000,
        AV_CODEC_ID_PCM_S16BE,
        AV_CODEC_ID_PCM_U16LE,
        AV_CODEC_ID_PCM_U16BE,
        AV_CODEC_ID_PCM_S8,
        AV_CODEC_ID_PCM_U8,
        AV_CODEC_ID_PCM_MULAW,
        AV_CODEC_ID_PCM_ALAW,
        AV_CODEC_ID_PCM_S32LE,
        AV_CODEC_ID_PCM_S32BE,
        AV_CODEC_ID_PCM_U32LE,
        AV_CODEC_ID_PCM_U32BE,
        AV_CODEC_ID_PCM_S24LE,
        AV_CODEC_ID_PCM_S24BE,
        AV_CODEC_ID_PCM_U24LE,
        AV_CODEC_ID_PCM_U24BE,
        AV_CODEC_ID_PCM_S24DAUD,
        AV_CODEC_ID_PCM_ZORK,
        AV_CODEC_ID_PCM_S16LE_PLANAR,
        AV_CODEC_ID_PCM_DVD,
        AV_CODEC_ID_PCM_F32BE,
        AV_CODEC_ID_PCM_F32LE,
        AV_CODEC_ID_PCM_F64BE,
        AV_CODEC_ID_PCM_F64LE,
        AV_CODEC_ID_PCM_BLURAY,
        AV_CODEC_ID_PCM_LXF,
        AV_CODEC_ID_S302M,
        AV_CODEC_ID_PCM_S8_PLANAR,
        AV_CODEC_ID_PCM_S24LE_PLANAR,
        AV_CODEC_ID_PCM_S32LE_PLANAR,
        AV_CODEC_ID_PCM_S16BE_PLANAR,
        AV_CODEC_ID_PCM_S64LE,
        AV_CODEC_ID_PCM_S64BE,
        AV_CODEC_ID_PCM_F16LE,
        AV_CODEC_ID_PCM_F24LE,
        AV_CODEC_ID_PCM_VIDC,
        AV_CODEC_ID_PCM_SGA,
        AV_CODEC_ID_ADPCM_IMA_QT = 0x11000,
        AV_CODEC_ID_ADPCM_IMA_WAV,
        AV_CODEC_ID_ADPCM_IMA_DK3,
        AV_CODEC_ID_ADPCM_IMA_DK4,
        AV_CODEC_ID_ADPCM_IMA_WS,
        AV_CODEC_ID_ADPCM_IMA_SMJPEG,
        AV_CODEC_ID_ADPCM_MS,
        AV_CODEC_ID_ADPCM_4XM,
        AV_CODEC_ID_ADPCM_XA,
        AV_CODEC_ID_ADPCM_ADX,
        AV_CODEC_ID_ADPCM_EA,
        AV_CODEC_ID_ADPCM_G726,
        AV_CODEC_ID_ADPCM_CT,
        AV_CODEC_ID_ADPCM_SWF,
        AV_CODEC_ID_ADPCM_YAMAHA,
        AV_CODEC_ID_ADPCM_SBPRO_4,
        AV_CODEC_ID_ADPCM_SBPRO_3,
        AV_CODEC_ID_ADPCM_SBPRO_2,
        AV_CODEC_ID_ADPCM_THP,
        AV_CODEC_ID_ADPCM_IMA_AMV,
        AV_CODEC_ID_ADPCM_EA_R1,
        AV_CODEC_ID_ADPCM_EA_R3,
        AV_CODEC_ID_ADPCM_EA_R2,
        AV_CODEC_ID_ADPCM_IMA_EA_SEAD,
        AV_CODEC_ID_ADPCM_IMA_EA_EACS,
        AV_CODEC_ID_ADPCM_EA_XAS,
        AV_CODEC_ID_ADPCM_EA_MAXIS_XA,
        AV_CODEC_ID_ADPCM_IMA_ISS,
        AV_CODEC_ID_ADPCM_G722,
        AV_CODEC_ID_ADPCM_IMA_APC,
        AV_CODEC_ID_ADPCM_VIMA,
        AV_CODEC_ID_ADPCM_AFC,
        AV_CODEC_ID_ADPCM_IMA_OKI,
        AV_CODEC_ID_ADPCM_DTK,
        AV_CODEC_ID_ADPCM_IMA_RAD,
        AV_CODEC_ID_ADPCM_G726LE,
        AV_CODEC_ID_ADPCM_THP_LE,
        AV_CODEC_ID_ADPCM_PSX,
        AV_CODEC_ID_ADPCM_AICA,
        AV_CODEC_ID_ADPCM_IMA_DAT4,
        AV_CODEC_ID_ADPCM_MTAF,
        AV_CODEC_ID_ADPCM_AGM,
        AV_CODEC_ID_ADPCM_ARGO,
        AV_CODEC_ID_ADPCM_IMA_SSI,
        AV_CODEC_ID_ADPCM_ZORK,
        AV_CODEC_ID_ADPCM_IMA_APM,
        AV_CODEC_ID_ADPCM_IMA_ALP,
        AV_CODEC_ID_ADPCM_IMA_MTF,
        AV_CODEC_ID_ADPCM_IMA_CUNNING,
        AV_CODEC_ID_ADPCM_IMA_MOFLEX,
        AV_CODEC_ID_ADPCM_IMA_ACORN,
        AV_CODEC_ID_ADPCM_XMD,
        AV_CODEC_ID_AMR_NB = 0x12000,
        AV_CODEC_ID_AMR_WB,
        AV_CODEC_ID_RA_144 = 0x13000,
        AV_CODEC_ID_RA_288,
        AV_CODEC_ID_ROQ_DPCM = 0x14000,
        AV_CODEC_ID_INTERPLAY_DPCM,
        AV_CODEC_ID_XAN_DPCM,
        AV_CODEC_ID_SOL_DPCM,
        AV_CODEC_ID_SDX2_DPCM,
        AV_CODEC_ID_GREMLIN_DPCM,
        AV_CODEC_ID_DERF_DPCM,
        AV_CODEC_ID_WADY_DPCM,
        AV_CODEC_ID_CBD2_DPCM,
        AV_CODEC_ID_MP2 = 0x15000,
        AV_CODEC_ID_MP3,
        AV_CODEC_ID_AAC,
        AV_CODEC_ID_AC3,
        AV_CODEC_ID_DTS,
        AV_CODEC_ID_VORBIS,
        AV_CODEC_ID_DVAUDIO,
        AV_CODEC_ID_WMAV1,
        AV_CODEC_ID_WMAV2,
        AV_CODEC_ID_MACE3,
        AV_CODEC_ID_MACE6,
        AV_CODEC_ID_VMDAUDIO,
        AV_CODEC_ID_FLAC,
        AV_CODEC_ID_MP3ADU,
        AV_CODEC_ID_MP3ON4,
        AV_CODEC_ID_SHORTEN,
        AV_CODEC_ID_ALAC,
        AV_CODEC_ID_WESTWOOD_SND1,
        AV_CODEC_ID_GSM,
        AV_CODEC_ID_QDM2,
        AV_CODEC_ID_COOK,
        AV_CODEC_ID_TRUESPEECH,
        AV_CODEC_ID_TTA,
        AV_CODEC_ID_SMACKAUDIO,
        AV_CODEC_ID_QCELP,
        AV_CODEC_ID_WAVPACK,
        AV_CODEC_ID_DSICINAUDIO,
        AV_CODEC_ID_IMC,
        AV_CODEC_ID_MUSEPACK7,
        AV_CODEC_ID_MLP,
        AV_CODEC_ID_GSM_MS,
        AV_CODEC_ID_ATRAC3,
        AV_CODEC_ID_APE,
        AV_CODEC_ID_NELLYMOSER,
        AV_CODEC_ID_MUSEPACK8,
        AV_CODEC_ID_SPEEX,
        AV_CODEC_ID_WMAVOICE,
        AV_CODEC_ID_WMAPRO,
        AV_CODEC_ID_WMALOSSLESS,
        AV_CODEC_ID_ATRAC3P,
        AV_CODEC_ID_EAC3,
        AV_CODEC_ID_SIPR,
        AV_CODEC_ID_MP1,
        AV_CODEC_ID_TWINVQ,
        AV_CODEC_ID_TRUEHD,
        AV_CODEC_ID_MP4ALS,
        AV_CODEC_ID_ATRAC1,
        AV_CODEC_ID_BINKAUDIO_RDFT,
        AV_CODEC_ID_BINKAUDIO_DCT,
        AV_CODEC_ID_AAC_LATM,
        AV_CODEC_ID_QDMC,
        AV_CODEC_ID_CELT,
        AV_CODEC_ID_G723_1,
        AV_CODEC_ID_G729,
        AV_CODEC_ID_8SVX_EXP,
        AV_CODEC_ID_8SVX_FIB,
        AV_CODEC_ID_BMV_AUDIO,
        AV_CODEC_ID_RALF,
        AV_CODEC_ID_IAC,
        AV_CODEC_ID_ILBC,
        AV_CODEC_ID_OPUS,
        AV_CODEC_ID_COMFORT_NOISE,
        AV_CODEC_ID_TAK,
        AV_CODEC_ID_METASOUND,
        AV_CODEC_ID_PAF_AUDIO,
        AV_CODEC_ID_ON2AVC,
        AV_CODEC_ID_DSS_SP,
        AV_CODEC_ID_CODEC2,
        AV_CODEC_ID_FFWAVESYNTH,
        AV_CODEC_ID_SONIC,
        AV_CODEC_ID_SONIC_LS,
        AV_CODEC_ID_EVRC,
        AV_CODEC_ID_SMV,
        AV_CODEC_ID_DSD_LSBF,
        AV_CODEC_ID_DSD_MSBF,
        AV_CODEC_ID_DSD_LSBF_PLANAR,
        AV_CODEC_ID_DSD_MSBF_PLANAR,
        AV_CODEC_ID_4GV,
        AV_CODEC_ID_INTERPLAY_ACM,
        AV_CODEC_ID_XMA1,
        AV_CODEC_ID_XMA2,
        AV_CODEC_ID_DST,
        AV_CODEC_ID_ATRAC3AL,
        AV_CODEC_ID_ATRAC3PAL,
        AV_CODEC_ID_DOLBY_E,
        AV_CODEC_ID_APTX,
        AV_CODEC_ID_APTX_HD,
        AV_CODEC_ID_SBC,
        AV_CODEC_ID_ATRAC9,
        AV_CODEC_ID_HCOM,
        AV_CODEC_ID_ACELP_KELVIN,
        AV_CODEC_ID_MPEGH_3D_AUDIO,
        AV_CODEC_ID_SIREN,
        AV_CODEC_ID_HCA,
        AV_CODEC_ID_FASTAUDIO,
        AV_CODEC_ID_MSNSIREN,
        AV_CODEC_ID_DFPWM,
        AV_CODEC_ID_BONK,
        AV_CODEC_ID_MISC4,
        AV_CODEC_ID_APAC,
        AV_CODEC_ID_FTR,
        AV_CODEC_ID_WAVARC,
        AV_CODEC_ID_RKA,
        AV_CODEC_ID_AC4,
        AV_CODEC_ID_OSQ,
        AV_CODEC_ID_FIRST_SUBTITLE = 0x17000,
        AV_CODEC_ID_DVD_SUBTITLE = 0x17000,
        AV_CODEC_ID_DVB_SUBTITLE,
        AV_CODEC_ID_TEXT,
        AV_CODEC_ID_XSUB,
        AV_CODEC_ID_SSA,
        AV_CODEC_ID_MOV_TEXT,
        AV_CODEC_ID_HDMV_PGS_SUBTITLE,
        AV_CODEC_ID_DVB_TELETEXT,
        AV_CODEC_ID_SRT,
        AV_CODEC_ID_MICRODVD,
        AV_CODEC_ID_EIA_608,
        AV_CODEC_ID_JACOSUB,
        AV_CODEC_ID_SAMI,
        AV_CODEC_ID_REALTEXT,
        AV_CODEC_ID_STL,
        AV_CODEC_ID_SUBVIEWER1,
        AV_CODEC_ID_SUBVIEWER,
        AV_CODEC_ID_SUBRIP,
        AV_CODEC_ID_WEBVTT,
        AV_CODEC_ID_MPL2,
        AV_CODEC_ID_VPLAYER,
        AV_CODEC_ID_PJS,
        AV_CODEC_ID_ASS,
        AV_CODEC_ID_HDMV_TEXT_SUBTITLE,
        AV_CODEC_ID_TTML,
        AV_CODEC_ID_ARIB_CAPTION,
        AV_CODEC_ID_FIRST_UNKNOWN = 0x18000,
        AV_CODEC_ID_TTF = 0x18000,
        AV_CODEC_ID_SCTE_35,
        AV_CODEC_ID_EPG,
        AV_CODEC_ID_BINTEXT,
        AV_CODEC_ID_XBIN,
        AV_CODEC_ID_IDF,
        AV_CODEC_ID_OTF,
        AV_CODEC_ID_SMPTE_KLV,
        AV_CODEC_ID_DVD_NAV,
        AV_CODEC_ID_TIMED_ID3,
        AV_CODEC_ID_BIN_DATA,
        AV_CODEC_ID_SMPTE_2038,
        AV_CODEC_ID_PROBE = 0x19000,
        AV_CODEC_ID_MPEG2TS = 0x20000,
        AV_CODEC_ID_MPEG4SYSTEMS = 0x20001,
        AV_CODEC_ID_FFMETADATA = 0x21000,
        AV_CODEC_ID_WRAPPED_AVFRAME = 0x21001,
        AV_CODEC_ID_VNULL,
        AV_CODEC_ID_ANULL,
    }

    public unsafe partial struct AVProfile
    {
        public int profile;

        [NativeTypeName("const char *")]
        public sbyte* name;
    }

    public unsafe partial struct AVCodec
    {
        [NativeTypeName("const char *")]
        public sbyte* name;

        [NativeTypeName("const char *")]
        public sbyte* long_name;

        [NativeTypeName("enum AVMediaType")]
        public AVMediaType type;

        [NativeTypeName("enum AVCodecID")]
        public AVCodecID id;

        public int capabilities;

        [NativeTypeName("uint8_t")]
        public byte max_lowres;

        [NativeTypeName("const AVRational *")]
        public AVRational* supported_framerates;

        [NativeTypeName("const enum AVPixelFormat *")]
        public AVPixelFormat* pix_fmts;

        [NativeTypeName("const int *")]
        public int* supported_samplerates;

        [NativeTypeName("const enum AVSampleFormat *")]
        public AVSampleFormat* sample_fmts;

        [NativeTypeName("const uint64_t *")]
        [Obsolete]
        public ulong* channel_layouts;

        [NativeTypeName("const AVClass *")]
        public AVClass* priv_class;

        [NativeTypeName("const AVProfile *")]
        public AVProfile* profiles;

        [NativeTypeName("const char *")]
        public sbyte* wrapper_name;

        [NativeTypeName("const AVChannelLayout *")]
        public AVChannelLayout* ch_layouts;
    }

    public partial struct AVCodecHWConfig
    {
        [NativeTypeName("enum AVPixelFormat")]
        public AVPixelFormat pix_fmt;

        public int methods;

        [NativeTypeName("enum AVHWDeviceType")]
        public AVHWDeviceType device_type;
    }

    public enum AVFieldOrder
    {
        AV_FIELD_UNKNOWN,
        AV_FIELD_PROGRESSIVE,
        AV_FIELD_TT,
        AV_FIELD_BB,
        AV_FIELD_TB,
        AV_FIELD_BT,
    }

    public enum AVDiscard
    {
        AVDISCARD_NONE = -16,
        AVDISCARD_DEFAULT = 0,
        AVDISCARD_NONREF = 8,
        AVDISCARD_BIDIR = 16,
        AVDISCARD_NONINTRA = 24,
        AVDISCARD_NONKEY = 32,
        AVDISCARD_ALL = 48,
    }

    public enum AVAudioServiceType
    {
        AV_AUDIO_SERVICE_TYPE_MAIN = 0,
        AV_AUDIO_SERVICE_TYPE_EFFECTS = 1,
        AV_AUDIO_SERVICE_TYPE_VISUALLY_IMPAIRED = 2,
        AV_AUDIO_SERVICE_TYPE_HEARING_IMPAIRED = 3,
        AV_AUDIO_SERVICE_TYPE_DIALOGUE = 4,
        AV_AUDIO_SERVICE_TYPE_COMMENTARY = 5,
        AV_AUDIO_SERVICE_TYPE_EMERGENCY = 6,
        AV_AUDIO_SERVICE_TYPE_VOICE_OVER = 7,
        AV_AUDIO_SERVICE_TYPE_KARAOKE = 8,
        AV_AUDIO_SERVICE_TYPE_NB,
    }

    public unsafe partial struct AVPanScan
    {
        public int id;

        public int width;

        public int height;

        [NativeTypeName("int16_t[3][2]")]
        public fixed short position[3 * 2];
    }

    public partial struct AVCPBProperties
    {
        [NativeTypeName("int64_t")]
        public long max_bitrate;

        [NativeTypeName("int64_t")]
        public long min_bitrate;

        [NativeTypeName("int64_t")]
        public long avg_bitrate;

        [NativeTypeName("int64_t")]
        public long buffer_size;

        [NativeTypeName("uint64_t")]
        public ulong vbv_delay;
    }

    public partial struct AVProducerReferenceTime
    {
        [NativeTypeName("int64_t")]
        public long wallclock;

        public int flags;
    }

    public enum AVPacketSideDataType
    {
        AV_PKT_DATA_PALETTE,
        AV_PKT_DATA_NEW_EXTRADATA,
        AV_PKT_DATA_PARAM_CHANGE,
        AV_PKT_DATA_H263_MB_INFO,
        AV_PKT_DATA_REPLAYGAIN,
        AV_PKT_DATA_DISPLAYMATRIX,
        AV_PKT_DATA_STEREO3D,
        AV_PKT_DATA_AUDIO_SERVICE_TYPE,
        AV_PKT_DATA_QUALITY_STATS,
        AV_PKT_DATA_FALLBACK_TRACK,
        AV_PKT_DATA_CPB_PROPERTIES,
        AV_PKT_DATA_SKIP_SAMPLES,
        AV_PKT_DATA_JP_DUALMONO,
        AV_PKT_DATA_STRINGS_METADATA,
        AV_PKT_DATA_SUBTITLE_POSITION,
        AV_PKT_DATA_MATROSKA_BLOCKADDITIONAL,
        AV_PKT_DATA_WEBVTT_IDENTIFIER,
        AV_PKT_DATA_WEBVTT_SETTINGS,
        AV_PKT_DATA_METADATA_UPDATE,
        AV_PKT_DATA_MPEGTS_STREAM_ID,
        AV_PKT_DATA_MASTERING_DISPLAY_METADATA,
        AV_PKT_DATA_SPHERICAL,
        AV_PKT_DATA_CONTENT_LIGHT_LEVEL,
        AV_PKT_DATA_A53_CC,
        AV_PKT_DATA_ENCRYPTION_INIT_INFO,
        AV_PKT_DATA_ENCRYPTION_INFO,
        AV_PKT_DATA_AFD,
        AV_PKT_DATA_PRFT,
        AV_PKT_DATA_ICC_PROFILE,
        AV_PKT_DATA_DOVI_CONF,
        AV_PKT_DATA_S12M_TIMECODE,
        AV_PKT_DATA_DYNAMIC_HDR10_PLUS,
        AV_PKT_DATA_NB,
    }

    public unsafe partial struct AVPacketSideData
    {
        [NativeTypeName("uint8_t *")]
        public byte* data;

        [NativeTypeName("size_t")]
        public nuint size;

        [NativeTypeName("enum AVPacketSideDataType")]
        public AVPacketSideDataType type;
    }

    public unsafe partial struct AVPacket
    {
        public AVBufferRef* buf;

        [NativeTypeName("int64_t")]
        public long pts;

        [NativeTypeName("int64_t")]
        public long dts;

        [NativeTypeName("uint8_t *")]
        public byte* data;

        public int size;

        public int stream_index;

        public int flags;

        public AVPacketSideData* side_data;

        public int side_data_elems;

        [NativeTypeName("int64_t")]
        public long duration;

        [NativeTypeName("int64_t")]
        public long pos;

        public void* opaque;

        public AVBufferRef* opaque_ref;

        public AVRational time_base;
    }

    public unsafe partial struct AVPacketList
    {
        public AVPacket pkt;

        [NativeTypeName("struct AVPacketList *")]
        public AVPacketList* next;
    }

    public enum AVSideDataParamChangeFlags
    {
        AV_SIDE_DATA_PARAM_CHANGE_CHANNEL_COUNT = 0x0001,
        AV_SIDE_DATA_PARAM_CHANGE_CHANNEL_LAYOUT = 0x0002,
        AV_SIDE_DATA_PARAM_CHANGE_SAMPLE_RATE = 0x0004,
        AV_SIDE_DATA_PARAM_CHANGE_DIMENSIONS = 0x0008,
    }

    public unsafe partial struct AVCodecDescriptor
    {
        [NativeTypeName("enum AVCodecID")]
        public AVCodecID id;

        [NativeTypeName("enum AVMediaType")]
        public AVMediaType type;

        [NativeTypeName("const char *")]
        public sbyte* name;

        [NativeTypeName("const char *")]
        public sbyte* long_name;

        public int props;

        [NativeTypeName("const char *const *")]
        public sbyte** mime_types;

        [NativeTypeName("const struct AVProfile *")]
        public AVProfile* profiles;
    }

    public unsafe partial struct AVCodecParameters
    {
        [NativeTypeName("enum AVMediaType")]
        public AVMediaType codec_type;

        [NativeTypeName("enum AVCodecID")]
        public AVCodecID codec_id;

        [NativeTypeName("uint32_t")]
        public uint codec_tag;

        [NativeTypeName("uint8_t *")]
        public byte* extradata;

        public int extradata_size;

        public int format;

        [NativeTypeName("int64_t")]
        public long bit_rate;

        public int bits_per_coded_sample;

        public int bits_per_raw_sample;

        public int profile;

        public int level;

        public int width;

        public int height;

        public AVRational sample_aspect_ratio;

        [NativeTypeName("enum AVFieldOrder")]
        public AVFieldOrder field_order;

        [NativeTypeName("enum AVColorRange")]
        public AVColorRange color_range;

        [NativeTypeName("enum AVColorPrimaries")]
        public AVColorPrimaries color_primaries;

        [NativeTypeName("enum AVColorTransferCharacteristic")]
        public AVColorTransferCharacteristic color_trc;

        [NativeTypeName("enum AVColorSpace")]
        public AVColorSpace color_space;

        [NativeTypeName("enum AVChromaLocation")]
        public AVChromaLocation chroma_location;

        public int video_delay;

        [NativeTypeName("uint64_t")]
        [Obsolete]
        public ulong channel_layout;

        [Obsolete]
        public int channels;

        public int sample_rate;

        public int block_align;

        public int frame_size;

        public int initial_padding;

        public int trailing_padding;

        public int seek_preroll;

        public AVChannelLayout ch_layout;

        public AVRational framerate;

        public AVPacketSideData* coded_side_data;

        public int nb_coded_side_data;
    }

    public partial struct RcOverride
    {
        public int start_frame;

        public int end_frame;

        public int qscale;

        public float quality_factor;
    }

    public unsafe partial struct AVCodecContext
    {
        [NativeTypeName("const AVClass *")]
        public AVClass* av_class;

        public int log_level_offset;

        [NativeTypeName("enum AVMediaType")]
        public AVMediaType codec_type;

        [NativeTypeName("const struct AVCodec *")]
        public AVCodec* codec;

        [NativeTypeName("enum AVCodecID")]
        public AVCodecID codec_id;

        [NativeTypeName("unsigned int")]
        public uint codec_tag;

        public void* priv_data;

        [NativeTypeName("struct AVCodecInternal *")]
        public AVCodecInternal* @internal;

        public void* opaque;

        [NativeTypeName("int64_t")]
        public long bit_rate;

        public int bit_rate_tolerance;

        public int global_quality;

        public int compression_level;

        public int flags;

        public int flags2;

        [NativeTypeName("uint8_t *")]
        public byte* extradata;

        public int extradata_size;

        public AVRational time_base;

        [Obsolete]
        public int ticks_per_frame;

        public int delay;

        public int width;

        public int height;

        public int coded_width;

        public int coded_height;

        public int gop_size;

        [NativeTypeName("enum AVPixelFormat")]
        public AVPixelFormat pix_fmt;

        [NativeTypeName("void (*)(struct AVCodecContext *, const AVFrame *, int *, int, int, int)")]
        public delegate* unmanaged[Cdecl]<AVCodecContext*, AVFrame*, int, int, int, int, void> draw_horiz_band;

        [NativeTypeName("enum AVPixelFormat (*)(struct AVCodecContext *, const enum AVPixelFormat *)")]
        public delegate* unmanaged[Cdecl]<AVCodecContext*, AVPixelFormat*, AVPixelFormat> get_format;

        public int max_b_frames;

        public float b_quant_factor;

        public float b_quant_offset;

        public int has_b_frames;

        public float i_quant_factor;

        public float i_quant_offset;

        public float lumi_masking;

        public float temporal_cplx_masking;

        public float spatial_cplx_masking;

        public float p_masking;

        public float dark_masking;

        [Obsolete]
        public int slice_count;

        [Obsolete]
        public int* slice_offset;

        public AVRational sample_aspect_ratio;

        public int me_cmp;

        public int me_sub_cmp;

        public int mb_cmp;

        public int ildct_cmp;

        public int dia_size;

        public int last_predictor_count;

        public int me_pre_cmp;

        public int pre_dia_size;

        public int me_subpel_quality;

        public int me_range;

        public int slice_flags;

        public int mb_decision;

        [NativeTypeName("uint16_t *")]
        public ushort* intra_matrix;

        [NativeTypeName("uint16_t *")]
        public ushort* inter_matrix;

        public int intra_dc_precision;

        public int skip_top;

        public int skip_bottom;

        public int mb_lmin;

        public int mb_lmax;

        public int bidir_refine;

        public int keyint_min;

        public int refs;

        public int mv0_threshold;

        [NativeTypeName("enum AVColorPrimaries")]
        public AVColorPrimaries color_primaries;

        [NativeTypeName("enum AVColorTransferCharacteristic")]
        public AVColorTransferCharacteristic color_trc;

        [NativeTypeName("enum AVColorSpace")]
        public AVColorSpace colorspace;

        [NativeTypeName("enum AVColorRange")]
        public AVColorRange color_range;

        [NativeTypeName("enum AVChromaLocation")]
        public AVChromaLocation chroma_sample_location;

        public int slices;

        [NativeTypeName("enum AVFieldOrder")]
        public AVFieldOrder field_order;

        public int sample_rate;

        [Obsolete]
        public int channels;

        [NativeTypeName("enum AVSampleFormat")]
        public AVSampleFormat sample_fmt;

        public int frame_size;

        [Obsolete]
        public int frame_number;

        public int block_align;

        public int cutoff;

        [NativeTypeName("uint64_t")]
        [Obsolete]
        public ulong channel_layout;

        [NativeTypeName("uint64_t")]
        [Obsolete]
        public ulong request_channel_layout;

        [NativeTypeName("enum AVAudioServiceType")]
        public AVAudioServiceType audio_service_type;

        [NativeTypeName("enum AVSampleFormat")]
        public AVSampleFormat request_sample_fmt;

        [NativeTypeName("int (*)(struct AVCodecContext *, AVFrame *, int)")]
        public delegate* unmanaged[Cdecl]<AVCodecContext*, AVFrame*, int, int> get_buffer2;

        public float qcompress;

        public float qblur;

        public int qmin;

        public int qmax;

        public int max_qdiff;

        public int rc_buffer_size;

        public int rc_override_count;

        public RcOverride* rc_override;

        [NativeTypeName("int64_t")]
        public long rc_max_rate;

        [NativeTypeName("int64_t")]
        public long rc_min_rate;

        public float rc_max_available_vbv_use;

        public float rc_min_vbv_overflow_use;

        public int rc_initial_buffer_occupancy;

        public int trellis;

        [NativeTypeName("char *")]
        public sbyte* stats_out;

        [NativeTypeName("char *")]
        public sbyte* stats_in;

        public int workaround_bugs;

        public int strict_std_compliance;

        public int error_concealment;

        public int debug;

        public int err_recognition;

        [NativeTypeName("int64_t")]
        [Obsolete]
        public long reordered_opaque;

        [NativeTypeName("const struct AVHWAccel *")]
        public AVHWAccel* hwaccel;

        public void* hwaccel_context;

        [NativeTypeName("uint64_t[8]")]
        public fixed ulong error[8];

        public int dct_algo;

        public int idct_algo;

        public int bits_per_coded_sample;

        public int bits_per_raw_sample;

        public int lowres;

        public int thread_count;

        public int thread_type;

        public int active_thread_type;

        [NativeTypeName("int (*)(struct AVCodecContext *, int (*)(struct AVCodecContext *, void *), void *, int *, int, int)")]
        public delegate* unmanaged[Cdecl]<AVCodecContext*, delegate* unmanaged[Cdecl]<AVCodecContext*, void*, int>, void*, int*, int, int, int> execute;

        [NativeTypeName("int (*)(struct AVCodecContext *, int (*)(struct AVCodecContext *, void *, int, int), void *, int *, int)")]
        public delegate* unmanaged[Cdecl]<AVCodecContext*, delegate* unmanaged[Cdecl]<AVCodecContext*, void*, int, int, int>, void*, int*, int, int> execute2;

        public int nsse_weight;

        public int profile;

        public int level;

        [NativeTypeName("enum AVDiscard")]
        public AVDiscard skip_loop_filter;

        [NativeTypeName("enum AVDiscard")]
        public AVDiscard skip_idct;

        [NativeTypeName("enum AVDiscard")]
        public AVDiscard skip_frame;

        [NativeTypeName("uint8_t *")]
        public byte* subtitle_header;

        public int subtitle_header_size;

        public int initial_padding;

        public AVRational framerate;

        [NativeTypeName("enum AVPixelFormat")]
        public AVPixelFormat sw_pix_fmt;

        public AVRational pkt_timebase;

        [NativeTypeName("const struct AVCodecDescriptor *")]
        public AVCodecDescriptor* codec_descriptor;

        [NativeTypeName("int64_t")]
        public long pts_correction_num_faulty_pts;

        [NativeTypeName("int64_t")]
        public long pts_correction_num_faulty_dts;

        [NativeTypeName("int64_t")]
        public long pts_correction_last_pts;

        [NativeTypeName("int64_t")]
        public long pts_correction_last_dts;

        [NativeTypeName("char *")]
        public sbyte* sub_charenc;

        public int sub_charenc_mode;

        public int skip_alpha;

        public int seek_preroll;

        [NativeTypeName("uint16_t *")]
        public ushort* chroma_intra_matrix;

        [NativeTypeName("uint8_t *")]
        public byte* dump_separator;

        [NativeTypeName("char *")]
        public sbyte* codec_whitelist;

        [NativeTypeName("unsigned int")]
        public uint properties;

        public AVPacketSideData* coded_side_data;

        public int nb_coded_side_data;

        public AVBufferRef* hw_frames_ctx;

        public int trailing_padding;

        [NativeTypeName("int64_t")]
        public long max_pixels;

        public AVBufferRef* hw_device_ctx;

        public int hwaccel_flags;

        public int apply_cropping;

        public int extra_hw_frames;

        public int discard_damaged_percentage;

        [NativeTypeName("int64_t")]
        public long max_samples;

        public int export_side_data;

        [NativeTypeName("int (*)(struct AVCodecContext *, AVPacket *, int)")]
        public delegate* unmanaged[Cdecl]<AVCodecContext*, AVPacket*, int, int> get_encode_buffer;

        public AVChannelLayout ch_layout;

        [NativeTypeName("int64_t")]
        public long frame_num;

        public partial struct AVCodecInternal
        {
        }
    }

    public unsafe partial struct AVHWAccel
    {
        [NativeTypeName("const char *")]
        public sbyte* name;

        [NativeTypeName("enum AVMediaType")]
        public AVMediaType type;

        [NativeTypeName("enum AVCodecID")]
        public AVCodecID id;

        [NativeTypeName("enum AVPixelFormat")]
        public AVPixelFormat pix_fmt;

        public int capabilities;
    }

    public enum AVSubtitleType
    {
        SUBTITLE_NONE,
        SUBTITLE_BITMAP,
        SUBTITLE_TEXT,
        SUBTITLE_ASS,
    }

    public unsafe partial struct AVSubtitleRect
    {
        public int x;

        public int y;

        public int w;

        public int h;

        public int nb_colors;

        [NativeTypeName("uint8_t *[4]")]
        public _data_e__FixedBuffer data;

        [NativeTypeName("int[4]")]
        public fixed int linesize[4];

        [NativeTypeName("enum AVSubtitleType")]
        public AVSubtitleType type;

        [NativeTypeName("char *")]
        public sbyte* text;

        [NativeTypeName("char *")]
        public sbyte* ass;

        public int flags;

        public unsafe partial struct _data_e__FixedBuffer
        {
            public byte* e0;
            public byte* e1;
            public byte* e2;
            public byte* e3;

            public ref byte* this[int index]
            {
                get
                {
                    fixed (byte** pThis = &e0)
                    {
                        return ref pThis[index];
                    }
                }
            }
        }
    }

    public unsafe partial struct AVSubtitle
    {
        [NativeTypeName("uint16_t")]
        public ushort format;

        [NativeTypeName("uint32_t")]
        public uint start_display_time;

        [NativeTypeName("uint32_t")]
        public uint end_display_time;

        [NativeTypeName("unsigned int")]
        public uint num_rects;

        public AVSubtitleRect** rects;

        [NativeTypeName("int64_t")]
        public long pts;
    }

    public enum AVPictureStructure
    {
        AV_PICTURE_STRUCTURE_UNKNOWN,
        AV_PICTURE_STRUCTURE_TOP_FIELD,
        AV_PICTURE_STRUCTURE_BOTTOM_FIELD,
        AV_PICTURE_STRUCTURE_FRAME,
    }

    public unsafe partial struct AVCodecParserContext
    {
        public void* priv_data;

        [NativeTypeName("const struct AVCodecParser *")]
        public AVCodecParser* parser;

        [NativeTypeName("int64_t")]
        public long frame_offset;

        [NativeTypeName("int64_t")]
        public long cur_offset;

        [NativeTypeName("int64_t")]
        public long next_frame_offset;

        public int pict_type;

        public int repeat_pict;

        [NativeTypeName("int64_t")]
        public long pts;

        [NativeTypeName("int64_t")]
        public long dts;

        [NativeTypeName("int64_t")]
        public long last_pts;

        [NativeTypeName("int64_t")]
        public long last_dts;

        public int fetch_timestamp;

        public int cur_frame_start_index;

        [NativeTypeName("int64_t[4]")]
        public fixed long cur_frame_offset[4];

        [NativeTypeName("int64_t[4]")]
        public fixed long cur_frame_pts[4];

        [NativeTypeName("int64_t[4]")]
        public fixed long cur_frame_dts[4];

        public int flags;

        [NativeTypeName("int64_t")]
        public long offset;

        [NativeTypeName("int64_t[4]")]
        public fixed long cur_frame_end[4];

        public int key_frame;

        public int dts_sync_point;

        public int dts_ref_dts_delta;

        public int pts_dts_delta;

        [NativeTypeName("int64_t[4]")]
        public fixed long cur_frame_pos[4];

        [NativeTypeName("int64_t")]
        public long pos;

        [NativeTypeName("int64_t")]
        public long last_pos;

        public int duration;

        [NativeTypeName("enum AVFieldOrder")]
        public AVFieldOrder field_order;

        [NativeTypeName("enum AVPictureStructure")]
        public AVPictureStructure picture_structure;

        public int output_picture_number;

        public int width;

        public int height;

        public int coded_width;

        public int coded_height;

        public int format;
    }

    public unsafe partial struct AVCodecParser
    {
        [NativeTypeName("int[7]")]
        public fixed int codec_ids[7];

        public int priv_data_size;

        [NativeTypeName("int (*)(AVCodecParserContext *)")]
        public delegate* unmanaged[Cdecl]<AVCodecParserContext*, int> parser_init;

        [NativeTypeName("int (*)(AVCodecParserContext *, AVCodecContext *, const uint8_t **, int *, const uint8_t *, int)")]
        public delegate* unmanaged[Cdecl]<AVCodecParserContext*, AVCodecContext*, byte**, int*, byte*, int, int> parser_parse;

        [NativeTypeName("void (*)(AVCodecParserContext *)")]
        public delegate* unmanaged[Cdecl]<AVCodecParserContext*, void> parser_close;

        [NativeTypeName("int (*)(AVCodecContext *, const uint8_t *, int)")]
        public delegate* unmanaged[Cdecl]<AVCodecContext*, byte*, int, int> split;
    }

    public unsafe partial class AVCodecNative
    {
        public delegate* unmanaged[Cdecl]<AVCodecID, AVMediaType> avcodec_get_type;

        public delegate* unmanaged[Cdecl]<AVCodecID, sbyte*> avcodec_get_name;

        public delegate* unmanaged[Cdecl]<AVCodecID, int> av_get_bits_per_sample;

        public delegate* unmanaged[Cdecl]<AVCodecID, int> av_get_exact_bits_per_sample;

        public delegate* unmanaged[Cdecl]<AVCodecID, int, sbyte*> avcodec_profile_name;

        public delegate* unmanaged[Cdecl]<AVSampleFormat, int, AVCodecID> av_get_pcm_codec;

        public delegate* unmanaged[Cdecl]<void**, AVCodec*> av_codec_iterate;

        public delegate* unmanaged[Cdecl]<AVCodecID, AVCodec*> avcodec_find_decoder;

        public delegate* unmanaged[Cdecl]<sbyte*, AVCodec*> avcodec_find_decoder_by_name;

        public delegate* unmanaged[Cdecl]<AVCodecID, AVCodec*> avcodec_find_encoder;

        public delegate* unmanaged[Cdecl]<sbyte*, AVCodec*> avcodec_find_encoder_by_name;

        public delegate* unmanaged[Cdecl]<AVCodec*, int> av_codec_is_encoder;

        public delegate* unmanaged[Cdecl]<AVCodec*, int> av_codec_is_decoder;

        public delegate* unmanaged[Cdecl]<AVCodec*, int, sbyte*> av_get_profile_name;

        public const int AV_CODEC_HW_CONFIG_METHOD_HW_DEVICE_CTX = 0x01;
        public const int AV_CODEC_HW_CONFIG_METHOD_HW_FRAMES_CTX = 0x02;
        public const int AV_CODEC_HW_CONFIG_METHOD_INTERNAL = 0x04;
        public const int AV_CODEC_HW_CONFIG_METHOD_AD_HOC = 0x08;

        public delegate* unmanaged[Cdecl]<AVCodec*, int, AVCodecHWConfig*> avcodec_get_hw_config;

        public delegate* unmanaged[Cdecl]<nuint*, AVCPBProperties*> av_cpb_properties_alloc;

        public delegate* unmanaged[Cdecl]<byte*, uint, uint> av_xiphlacing;

        public delegate* unmanaged[Cdecl]<AVPacketSideData**, int*, AVPacketSideDataType, nuint, int, AVPacketSideData*> av_packet_side_data_new;

        public delegate* unmanaged[Cdecl]<AVPacketSideData**, int*, AVPacketSideDataType, void*, nuint, int, AVPacketSideData*> av_packet_side_data_add;

        public delegate* unmanaged[Cdecl]<AVPacketSideData*, int, AVPacketSideDataType, AVPacketSideData*> av_packet_side_data_get;

        public delegate* unmanaged[Cdecl]<AVPacketSideData*, int*, AVPacketSideDataType, void> av_packet_side_data_remove;

        public delegate* unmanaged[Cdecl]<AVPacketSideData**, int*, void> av_packet_side_data_free;

        public delegate* unmanaged[Cdecl]<AVPacketSideDataType, sbyte*> av_packet_side_data_name;

        public delegate* unmanaged[Cdecl]<AVPacket*> av_packet_alloc;

        public delegate* unmanaged[Cdecl]<AVPacket*, AVPacket*> av_packet_clone;

        public delegate* unmanaged[Cdecl]<AVPacket**, void> av_packet_free;

        [Obsolete]
        public delegate* unmanaged[Cdecl]<AVPacket*, void> av_init_packet;

        public delegate* unmanaged[Cdecl]<AVPacket*, int, int> av_new_packet;

        public delegate* unmanaged[Cdecl]<AVPacket*, int, void> av_shrink_packet;

        public delegate* unmanaged[Cdecl]<AVPacket*, int, int> av_grow_packet;

        public delegate* unmanaged[Cdecl]<AVPacket*, byte*, int, int> av_packet_from_data;

        public delegate* unmanaged[Cdecl]<AVPacket*, AVPacketSideDataType, nuint, byte*> av_packet_new_side_data;

        public delegate* unmanaged[Cdecl]<AVPacket*, AVPacketSideDataType, byte*, nuint, int> av_packet_add_side_data;

        public delegate* unmanaged[Cdecl]<AVPacket*, AVPacketSideDataType, nuint, int> av_packet_shrink_side_data;

        public delegate* unmanaged[Cdecl]<AVPacket*, AVPacketSideDataType, nuint*, byte*> av_packet_get_side_data;

        public delegate* unmanaged[Cdecl]<AVDictionary*, nuint*, byte*> av_packet_pack_dictionary;

        public delegate* unmanaged[Cdecl]<byte*, nuint, AVDictionary**, int> av_packet_unpack_dictionary;

        public delegate* unmanaged[Cdecl]<AVPacket*, void> av_packet_free_side_data;

        public delegate* unmanaged[Cdecl]<AVPacket*, AVPacket*, int> av_packet_ref;

        public delegate* unmanaged[Cdecl]<AVPacket*, void> av_packet_unref;

        public delegate* unmanaged[Cdecl]<AVPacket*, AVPacket*, void> av_packet_move_ref;

        public delegate* unmanaged[Cdecl]<AVPacket*, AVPacket*, int> av_packet_copy_props;

        public delegate* unmanaged[Cdecl]<AVPacket*, int> av_packet_make_refcounted;

        public delegate* unmanaged[Cdecl]<AVPacket*, int> av_packet_make_writable;

        public delegate* unmanaged[Cdecl]<AVPacket*, AVRational, AVRational, void> av_packet_rescale_ts;

        public delegate* unmanaged[Cdecl]<AVCodecID, AVCodecDescriptor*> avcodec_descriptor_get;

        public delegate* unmanaged[Cdecl]<AVCodecDescriptor*, AVCodecDescriptor*> avcodec_descriptor_next;

        public delegate* unmanaged[Cdecl]<sbyte*, AVCodecDescriptor*> avcodec_descriptor_get_by_name;

        public delegate* unmanaged[Cdecl]<AVCodecParameters*> avcodec_parameters_alloc;

        public delegate* unmanaged[Cdecl]<AVCodecParameters**, void> avcodec_parameters_free;

        public delegate* unmanaged[Cdecl]<AVCodecParameters*, AVCodecParameters*, int> avcodec_parameters_copy;

        public delegate* unmanaged[Cdecl]<AVCodecParameters*, int, int> av_get_audio_frame_duration2;

        public delegate* unmanaged[Cdecl]<uint> avcodec_version;

        public delegate* unmanaged[Cdecl]<sbyte*> avcodec_configuration;

        public delegate* unmanaged[Cdecl]<sbyte*> avcodec_license;

        public delegate* unmanaged[Cdecl]<AVCodec*, AVCodecContext*> avcodec_alloc_context3;

        public delegate* unmanaged[Cdecl]<AVCodecContext**, void> avcodec_free_context;

        public delegate* unmanaged[Cdecl]<AVClass*> avcodec_get_class;

        public delegate* unmanaged[Cdecl]<AVClass*> avcodec_get_subtitle_rect_class;

        public delegate* unmanaged[Cdecl]<AVCodecParameters*, AVCodecContext*, int> avcodec_parameters_from_context;

        public delegate* unmanaged[Cdecl]<AVCodecContext*, AVCodecParameters*, int> avcodec_parameters_to_context;

        public delegate* unmanaged[Cdecl]<AVCodecContext*, AVCodec*, AVDictionary**, int> avcodec_open2;

        public delegate* unmanaged[Cdecl]<AVCodecContext*, int> avcodec_close;

        public delegate* unmanaged[Cdecl]<AVSubtitle*, void> avsubtitle_free;

        public delegate* unmanaged[Cdecl]<AVCodecContext*, AVFrame*, int, int> avcodec_default_get_buffer2;

        public delegate* unmanaged[Cdecl]<AVCodecContext*, AVPacket*, int, int> avcodec_default_get_encode_buffer;

        public delegate* unmanaged[Cdecl]<AVCodecContext*, int*, int*, void> avcodec_align_dimensions;

        public delegate* unmanaged[Cdecl]<AVCodecContext*, int*, int*, int*, void> avcodec_align_dimensions2;

        [Obsolete]
        public delegate* unmanaged[Cdecl]<int*, int*, AVChromaLocation, int> avcodec_enum_to_chroma_pos;

        [Obsolete]
        public delegate* unmanaged[Cdecl]<int, int, AVChromaLocation> avcodec_chroma_pos_to_enum;

        public delegate* unmanaged[Cdecl]<AVCodecContext*, AVSubtitle*, int*, AVPacket*, int> avcodec_decode_subtitle2;

        public delegate* unmanaged[Cdecl]<AVCodecContext*, AVPacket*, int> avcodec_send_packet;

        public delegate* unmanaged[Cdecl]<AVCodecContext*, AVFrame*, int> avcodec_receive_frame;

        public delegate* unmanaged[Cdecl]<AVCodecContext*, AVFrame*, int> avcodec_send_frame;

        public delegate* unmanaged[Cdecl]<AVCodecContext*, AVPacket*, int> avcodec_receive_packet;

        public delegate* unmanaged[Cdecl]<AVCodecContext*, AVBufferRef*, AVPixelFormat, AVBufferRef**, int> avcodec_get_hw_frames_parameters;

        public delegate* unmanaged[Cdecl]<void**, AVCodecParser*> av_parser_iterate;

        public delegate* unmanaged[Cdecl]<int, AVCodecParserContext*> av_parser_init;

        public delegate* unmanaged[Cdecl]<AVCodecParserContext*, AVCodecContext*, byte**, int*, byte*, int, long, long, long, int> av_parser_parse2;

        public delegate* unmanaged[Cdecl]<AVCodecParserContext*, void> av_parser_close;

        public delegate* unmanaged[Cdecl]<AVCodecContext*, byte*, int, AVSubtitle*, int> avcodec_encode_subtitle;

        public delegate* unmanaged[Cdecl]<AVPixelFormat, uint> avcodec_pix_fmt_to_codec_tag;

        public delegate* unmanaged[Cdecl]<AVPixelFormat*, AVPixelFormat, int, int*, AVPixelFormat> avcodec_find_best_pix_fmt_of_list;

        public delegate* unmanaged[Cdecl]<AVCodecContext*, AVPixelFormat*, AVPixelFormat> avcodec_default_get_format;

        public delegate* unmanaged[Cdecl]<sbyte*, int, AVCodecContext*, int, void> avcodec_string;

        public delegate* unmanaged[Cdecl]<AVCodecContext*, delegate* unmanaged[Cdecl]<AVCodecContext*, void*, int>, void*, int*, int, int, int> avcodec_default_execute;

        public delegate* unmanaged[Cdecl]<AVCodecContext*, delegate* unmanaged[Cdecl]<AVCodecContext*, void*, int, int, int>, void*, int*, int, int> avcodec_default_execute2;

        public delegate* unmanaged[Cdecl]<AVFrame*, int, AVSampleFormat, byte*, int, int, int> avcodec_fill_audio_frame;

        public delegate* unmanaged[Cdecl]<AVCodecContext*, void> avcodec_flush_buffers;

        public delegate* unmanaged[Cdecl]<AVCodecContext*, int, int> av_get_audio_frame_duration;

        public delegate* unmanaged[Cdecl]<void*, uint*, nuint, void> av_fast_padded_malloc;

        public delegate* unmanaged[Cdecl]<void*, uint*, nuint, void> av_fast_padded_mallocz;

        public delegate* unmanaged[Cdecl]<AVCodecContext*, int> avcodec_is_open;
    }
}
