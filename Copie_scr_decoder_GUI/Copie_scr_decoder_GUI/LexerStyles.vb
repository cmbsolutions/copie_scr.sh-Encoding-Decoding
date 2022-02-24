Public Class LexerStyles
    Public Sub ResetLexer(ByRef lexer As ScintillaNET.Scintilla)
        lexer.StyleClearAll()

        lexer.HScrollBar = True
        lexer.VScrollBar = True

        lexer.Styles(ScintillaNET.Style.Default).BackColor = Color.FromArgb(43, 43, 46)
        lexer.Styles(ScintillaNET.Style.Default).Font = "Consolas"
        lexer.Styles(ScintillaNET.Style.Default).ForeColor = Color.FromArgb(220, 220, 220)
        lexer.Styles(ScintillaNET.Style.Default).Size = 10

        lexer.Styles(ScintillaNET.Style.LineNumber).BackColor = Color.FromArgb(43, 43, 46)
        lexer.Styles(ScintillaNET.Style.LineNumber).ForeColor = Color.FromArgb(43, 145, 175)
        lexer.Styles(ScintillaNET.Style.LineNumber).Font = lexer.Styles(ScintillaNET.Style.Default).Font
        lexer.Styles(ScintillaNET.Style.LineNumber).Size = lexer.Styles(ScintillaNET.Style.Default).Size

        lexer.Margins(0).Type = ScintillaNET.MarginType.Number
        lexer.Margins(0).Width = 30
    End Sub

    Public Sub setKShStyle(ByRef lexer As ScintillaNET.Scintilla)
        Try
            ResetLexer(lexer)

            lexer.Lexer = ScintillaNET.Lexer.PowerShell

            lexer.CreateDocument()

            lexer.Styles(ScintillaNET.Style.PowerShell.Default).BackColor = Color.FromArgb(-12632257)
            lexer.Styles(ScintillaNET.Style.PowerShell.Default).FillLine = True
            lexer.Styles(ScintillaNET.Style.PowerShell.Default).Font = "Consolas"
            lexer.Styles(ScintillaNET.Style.PowerShell.Default).ForeColor = Color.FromArgb(-2302772)
            lexer.Styles(ScintillaNET.Style.PowerShell.Default).Size = 9
            lexer.Styles(ScintillaNET.Style.PowerShell.Default).SizeF = 9.0F
            lexer.Styles(ScintillaNET.Style.PowerShell.Comment).BackColor = Color.FromArgb(-12632257)
            lexer.Styles(ScintillaNET.Style.PowerShell.Comment).Bold = True
            lexer.Styles(ScintillaNET.Style.PowerShell.Comment).ForeColor = Color.FromArgb(-8413313)
            lexer.Styles(ScintillaNET.Style.PowerShell.Comment).Italic = True
            lexer.Styles(ScintillaNET.Style.PowerShell.Comment).Weight = 700
            lexer.Styles(ScintillaNET.Style.PowerShell.String).BackColor = Color.FromArgb(-12632257)
            lexer.Styles(ScintillaNET.Style.PowerShell.String).ForeColor = Color.FromArgb(-3370093)
            lexer.Styles(ScintillaNET.Style.PowerShell.String).Weight = 400
            lexer.Styles(ScintillaNET.Style.PowerShell.Character).BackColor = Color.FromArgb(-12632257)
            lexer.Styles(ScintillaNET.Style.PowerShell.Character).ForeColor = Color.FromArgb(-2317405)
            lexer.Styles(ScintillaNET.Style.PowerShell.Number).BackColor = Color.FromArgb(-12632257)
            lexer.Styles(ScintillaNET.Style.PowerShell.Number).ForeColor = Color.FromArgb(-7548717)
            lexer.Styles(ScintillaNET.Style.PowerShell.Variable).BackColor = Color.FromArgb(-12632257)
            lexer.Styles(ScintillaNET.Style.PowerShell.Variable).Bold = True
            lexer.Styles(ScintillaNET.Style.PowerShell.Variable).ForeColor = Color.FromArgb(-5155)
            lexer.Styles(ScintillaNET.Style.PowerShell.Variable).Weight = 700
            lexer.Styles(ScintillaNET.Style.PowerShell.Operator).BackColor = Color.FromArgb(-12632257)
            lexer.Styles(ScintillaNET.Style.PowerShell.Operator).Bold = False
            lexer.Styles(ScintillaNET.Style.PowerShell.Operator).ForeColor = Color.FromArgb(-6316691)
            lexer.Styles(ScintillaNET.Style.PowerShell.Operator).Weight = 700
            lexer.Styles(ScintillaNET.Style.PowerShell.Identifier).BackColor = Color.FromArgb(-12632257)
            lexer.Styles(ScintillaNET.Style.PowerShell.Identifier).ForeColor = Color.FromArgb(-2302772)
            lexer.Styles(ScintillaNET.Style.PowerShell.Keyword).BackColor = Color.FromArgb(-12632257)
            lexer.Styles(ScintillaNET.Style.PowerShell.Keyword).Bold = True
            lexer.Styles(ScintillaNET.Style.PowerShell.Keyword).ForeColor = Color.FromArgb(-2112387)
            lexer.Styles(ScintillaNET.Style.PowerShell.Keyword).Weight = 700
            lexer.Styles(ScintillaNET.Style.PowerShell.Alias).BackColor = Color.FromArgb(-12632257)
            lexer.Styles(ScintillaNET.Style.PowerShell.Alias).Bold = True
            lexer.Styles(ScintillaNET.Style.PowerShell.Alias).ForeColor = Color.FromArgb(-6316691)
            lexer.Styles(ScintillaNET.Style.PowerShell.Alias).Weight = 700
            lexer.Styles(ScintillaNET.Style.PowerShell.Function).BackColor = Color.FromArgb(-12632257)
            lexer.Styles(ScintillaNET.Style.PowerShell.Function).ForeColor = Color.FromArgb(-2302772)
            lexer.Styles(ScintillaNET.Style.PowerShell.User1).BackColor = Color.FromArgb(-12632257)
            lexer.Styles(ScintillaNET.Style.PowerShell.User1).Bold = True
            lexer.Styles(ScintillaNET.Style.PowerShell.User1).ForeColor = Color.FromArgb(-1847637)
            lexer.Styles(ScintillaNET.Style.PowerShell.User1).Weight = 700
            lexer.Styles(ScintillaNET.Style.PowerShell.HereString).ForeColor = Color.Brown

            lexer.SetKeywords(0, "7z adduser alias apt-get ar as asa autoconf automake awk banner base64 basename bash bc bdiff blkid break bsdcpio bsdtar bunzip2 bzcmp bzdiff bzegrep bzfgrep bzgrep bzip2 bzip2recover bzless bzmore c++ cal calendar case cat cc cd cfdisk chattr chgrp chmod chown chroot chvt cksum clang clang++ clear cmp col column comm compgen compress continue convert cp cpio crontab crypt csplit ctags curl cut date dc dd deallocvt declare deluser depmod deroff df dialog diff diff3 dig dircmp dirname disown dmesg do done dpkg dpkg-deb du echo ed egrep elif else env esac eval ex exec exit expand export expr fakeroot false fc fdisk ffmpeg fgrep fi file find flex flock fmt fold for fsck function functions fuser fusermount g++ gas gawk gcc gdb genisoimage getconf getopt getopts git gpg gpgsplit gpgv grep gres groff groups gunzip gzexe hash hd head help hexdump hg history httpd iconv id if ifconfig ifdown ifquery ifup in insmod integer inxi ip ip6tables ip6tables-save ip6tables-restore iptables iptables-save iptables-restore ip jobs join kill killall killall5 lc ld ldd let lex line ln local logname look ls lsattr lsb_release lsblk lscpu lshw lslocks lsmod lsusb lzcmp lzegrep lzfgrep lzgrep lzless lzma lzmainfo lzmore m4 mail mailx make man mkdir mkfifo mkswap mktemp modinfo modprobe mogrify more mount msgfmt mt mv nameif nasm nc ndisasm netcat newgrp nl nm nohup ntps objdump od openssl p7zip pacman passwd paste patch pathchk pax pcat pcregrep pcretest perl pg ping ping6 pivot_root poweroff pr print printf ps pwd python python2 python3 ranlib read readlink readonly reboot reset return rev rm rmdir rmmod rpm rsync sed select service set sh sha1sum sha224sum sha256sum sha3sum sha512sum shift shred shuf shutdown size sleep sort spell split start stop strings strip stty su sudo sum suspend switch_root sync systemctl tac tail tar tee test then time times touch tr trap troff true tsort tty type typeset ulimit umask umount unalias uname uncompress unexpand uniq unlink unlzma unset until unzip unzipsfx useradd userdel uudecode uuencode vi vim wait wc wget whence which while who wpaste wstart xargs xdotool xxd xz xzcat xzcmp xzdiff xzfgrep xzgrep xzless xzmore yes yum zcat zcmp zdiff zegrep zfgrep zforce zgrep zless zmore znew zsh")

        Catch ex As Exception

        End Try
    End Sub
End Class
