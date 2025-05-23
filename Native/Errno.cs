namespace FFMpegSharp.Native;

public static class Errno
{
    /// Not super-user 
    public const int EPERM = 1;
    /// No such file or directory 
    public const int ENOENT = 2;
    /// No such process 
    public const int ESRCH = 3;
    /// Interrupted system call 
    public const int EINTR = 4;
    /// I/O error 
    public const int EIO = 5;
    /// No such device or address 
    public const int ENXIO = 6;
    /// Arg list too long 
    public const int E2BIG = 7;
    /// Exec format error 
    public const int ENOEXEC = 8;
    /// Bad file number 
    public const int EBADF = 9;
    /// No children 
    public const int ECHILD = 10;
    /// No more processes 
    public const int EAGAIN = 11;
    /// Not enough core 
    public const int ENOMEM = 12;
    /// Permission denied 
    public const int EACCES = 13;
    /// Bad address 
    public const int EFAULT = 14;
    /// Block device required 
    public const int ENOTBLK = 15;
    /// Mount device busy 
    public const int EBUSY = 16;
    /// File exists 
    public const int EEXIST = 17;
    /// Cross-device link 
    public const int EXDEV = 18;
    /// No such device 
    public const int ENODEV = 19;
    /// Not a directory 
    public const int ENOTDIR = 20;
    /// Is a directory 
    public const int EISDIR = 21;
    /// Invalid argument 
    public const int EINVAL = 22;
    /// Too many open files in system 
    public const int ENFILE = 23;
    /// Too many open files 
    public const int EMFILE = 24;
    /// Not a typewriter 
    public const int ENOTTY = 25;
    /// Text file busy 
    public const int ETXTBSY = 26;
    /// File too large 
    public const int EFBIG = 27;
    /// No space left on device 
    public const int ENOSPC = 28;
    /// Illegal seek 
    public const int ESPIPE = 29;
    /// Read only file system 
    public const int EROFS = 30;
    /// Too many links 
    public const int EMLINK = 31;
    /// Broken pipe 
    public const int EPIPE = 32;
    /// Math arg out of domain of func 
    public const int EDOM = 33;
    /// Math result not representable 
    public const int ERANGE = 34;
    /// No message of desired type 
    public const int ENOMSG = 35;
    /// Identifier removed 
    public const int EIDRM = 36;
    /// Channel number out of range 
    public const int ECHRNG = 37;
    /// Level 2 not synchronized 
    public const int EL2NSYNC = 38;
    /// Level 3 halted 
    public const int EL3HLT = 39;
    /// Level 3 reset 
    public const int EL3RST = 40;
    /// Link number out of range 
    public const int ELNRNG = 41;
    /// Protocol driver not attached 
    public const int EUNATCH = 42;
    /// No CSI structure available 
    public const int ENOCSI = 43;
    /// Level 2 halted 
    public const int EL2HLT = 44;
    /// Deadlock condition 
    public const int EDEADLK = 45;
    /// No record locks available 
    public const int ENOLCK = 46;
    /// Invalid exchange 
    public const int EBADE = 50;
    /// Invalid request descriptor 
    public const int EBADR = 51;
    /// Exchange full 
    public const int EXFULL = 52;
    /// No anode 
    public const int ENOANO = 53;
    /// Invalid request code 
    public const int EBADRQC = 54;
    /// Invalid slot 
    public const int EBADSLT = 55;
    /// File locking deadlock error 
    public const int EDEADLOCK = 56;
    /// Bad font file fmt 
    public const int EBFONT = 57;
    /// Device not a stream 
    public const int ENOSTR = 60;
    /// No data (for no delay io) 
    public const int ENODATA = 61;
    /// Timer expired 
    public const int ETIME = 62;
    /// Out of streams resources 
    public const int ENOSR = 63;
    /// Machine is not on the network 
    public const int ENONET = 64;
    /// Package not installed 
    public const int ENOPKG = 65;
    /// The object is remote 
    public const int EREMOTE = 66;
    /// The link has been severed 
    public const int ENOLINK = 67;
    /// Advertise error 
    public const int EADV = 68;
    /// Srmount error 
    public const int ESRMNT = 69;
    /// Communication error on send 
    public const int ECOMM = 70;
    /// Protocol error 
    public const int EPROTO = 71;
    /// Multihop attempted 
    public const int EMULTIHOP = 74;
    /// Inode is remote (not really error) 
    public const int ELBIN = 75;
    /// Cross mount point (not really error) 
    public const int EDOTDOT = 76;
    /// Trying to read unreadable message 
    public const int EBADMSG = 77;
    /// Inappropriate file type or format 
    public const int EFTYPE = 79;
    /// Given log. name not unique 
    public const int ENOTUNIQ = 80;
    /// f.d. invalid for this operation 
    public const int EBADFD = 81;
    /// Remote address changed 
    public const int EREMCHG = 82;
    /// Can't access a needed shared lib 
    public const int ELIBACC = 83;
    /// Accessing a corrupted shared lib 
    public const int ELIBBAD = 84;
    /// .lib section in a.out corrupted 
    public const int ELIBSCN = 85;
    /// Attempting to link in too many libs 
    public const int ELIBMAX = 86;
    /// Attempting to exec a shared library 
    public const int ELIBEXEC = 87;
    /// Function not implemented 
    public const int ENOSYS = 88;
    /// No more files 
    public const int ENMFILE = 89;
    /// Directory not empty 
    public const int ENOTEMPTY = 90;
    /// File or path name too long 
    public const int ENAMETOOLONG = 91;
    /// Too many symbolic links 
    public const int ELOOP = 92;
    /// Operation not supported on transport endpoint 
    public const int EOPNOTSUPP = 95;
    /// Protocol family not supported 
    public const int EPFNOSUPPORT = 96;
    /// Connection reset by peer 
    public const int ECONNRESET = 104;
    /// No buffer space available 
    public const int ENOBUFS = 105;
    /// Address family not supported by protocol family 
    public const int EAFNOSUPPORT = 106;
    /// Protocol wrong type for socket 
    public const int EPROTOTYPE = 107;
    /// Socket operation on non-socket 
    public const int ENOTSOCK = 108;
    /// Protocol not available 
    public const int ENOPROTOOPT = 109;
    /// Can't send after socket shutdown 
    public const int ESHUTDOWN = 110;
    /// Connection refused 
    public const int ECONNREFUSED = 111;
    /// Address already in use 
    public const int EADDRINUSE = 112;
    /// Connection aborted 
    public const int ECONNABORTED = 113;
    /// Network is unreachable 
    public const int ENETUNREACH = 114;
    /// Network interface is not configured 
    public const int ENETDOWN = 115;
    /// Connection timed out 
    public const int ETIMEDOUT = 116;
    /// Host is down 
    public const int EHOSTDOWN = 117;
    /// Host is unreachable 
    public const int EHOSTUNREACH = 118;
    /// Connection already in progress 
    public const int EINPROGRESS = 119;
    /// Socket already connected 
    public const int EALREADY = 120;
    /// Destination address required 
    public const int EDESTADDRREQ = 121;
    /// Message too long 
    public const int EMSGSIZE = 122;
    /// Unknown protocol 
    public const int EPROTONOSUPPORT = 123;
    /// Socket type not supported 
    public const int ESOCKTNOSUPPORT = 124;
    /// Address not available 
    public const int EADDRNOTAVAIL = 125;
    public const int ENETRESET = 126;
    /// Socket is already connected 
    public const int EISCONN = 127;
    /// Socket is not connected 
    public const int ENOTCONN = 128;
    public const int ETOOMANYREFS = 129;
    public const int EPROCLIM = 130;
    public const int EUSERS = 131;
    public const int EDQUOT = 132;
    public const int ESTALE = 133;
    /// Not supported 
    public const int ENOTSUP = 134;
    /// No medium (in tape drive) 
    public const int ENOMEDIUM = 135;
    /// No such host or network path 
    public const int ENOSHARE = 136;
    /// Filename exists with different case 
    public const int ECASECLASH = 137;
    public const int EILSEQ = 138;
    /// Value too large for defined data type 
    public const int EOVERFLOW = 139;
    /// Operation would block 
    public const int EWOULDBLOCK = EAGAIN;
}
