S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 19028
Date: 2017-06-04 04:59:58+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0x00000008, esi = 0xbfbb78a0
ebp = 0xbfbb78f8, esp = 0xbfbb789c
eax = 0xb3788b82, ebx = 0xb378b000
ecx = 0x00000050, edx = 0x00000000
eip = 0xb6d4fc0b

Memory Information
MemTotal:      123 KB
MemFree:        24 KB
Buffers:        10 KB
Cached:     161668 KB
VmPeak:     123808 KB
VmSize:     118748 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       36760 KB
VmRSS:       31604 KB
VmData:      48836 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34636 KB
VmPTE:         104 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 19028 TID = 19028
19028 19030 19231 19232 19237 

Maps Information
b180b000 b1812000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b1815000 b182d000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b182e000 b1835000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b186c000 b1870000 r-xp /usr/lib/elementary/modules/datetime_input_spinner/v-1.13.0/module.so
b2b45000 b2b4f000 r-xp /usr/lib/libfeedback.so.0.1.4
b2b55000 b2b61000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2b62000 b2b83000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2b88000 b2b89000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2b8a000 b2b8f000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2b90000 b2b91000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2b92000 b2b94000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2b95000 b2b97000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2b98000 b2ba4000 r-xp /usr/lib/libdrm.so.2.4.0
b2ba5000 b2ba8000 r-xp /usr/lib/libdri2.so.0.0.0
b2ba9000 b2bb3000 r-xp /usr/lib/libtbm.so.1.0.0
b2bb4000 b2bc9000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2bca000 b2bdc000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b33de000 b340f000 r-xp /usr/lib/libidn.so.11.5.44
b3410000 b3432000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3433000 b3443000 r-xp /usr/lib/libcares.so.2.1.0
b3444000 b344d000 r-xp /usr/lib/libeventsystem.so.0.0.1
b344e000 b3457000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3458000 b34cf000 r-xp /usr/lib/libcurl.so.4.3.0
b34d1000 b34e3000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b34e4000 b3505000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b350c000 b350d000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b350e000 b350f000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b3510000 b3513000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b3514000 b3517000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b361f000 b3625000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3626000 b376a000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b377b000 b377c000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b377d000 b378a000 r-xp /opt/usr/apps/org.example.example/bin/example
b378c000 b37c5000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b41c8000 b41d3000 r-xp /lib/libnss_files-2.20-2014.11.so
b41d5000 b41e0000 r-xp /lib/libnss_nis-2.20-2014.11.so
b41e2000 b41f9000 r-xp /lib/libnsl-2.20-2014.11.so
b41fd000 b4205000 r-xp /lib/libnss_compat-2.20-2014.11.so
b4207000 b422b000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b422c000 b422d000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b422e000 b4231000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4232000 b4239000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b423a000 b4244000 r-xp /usr/lib/libsensord-share.so
b4245000 b4261000 r-xp /usr/lib/libsensor.so.1.2.0
b4263000 b426c000 r-xp /usr/lib/libappcore-common.so.1.1
b426f000 b4271000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b4286000 b4288000 r-xp /usr/lib/libXau.so.6.0.0
b4289000 b42ab000 r-xp /usr/lib/libxcb.so.1.1.0
b42ad000 b42b6000 r-xp /lib/libcrypt-2.20-2014.11.so
b42df000 b42e1000 r-xp /usr/lib/libiri.so
b42e2000 b4308000 r-xp /lib/libexpat.so.1.5.2
b430a000 b4375000 r-xp /usr/lib/libssl.so.1.0.0
b437b000 b4387000 r-xp /usr/lib/libethumb.so.1.13.0
b4388000 b438c000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b438d000 b45de000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b59000 b5b69000 r-xp /usr/lib/libXi.so.6.1.0
b5b6a000 b5b6c000 r-xp /usr/lib/libXgesture.so.7.0.0
b5b6d000 b5b73000 r-xp /usr/lib/libXtst.so.6.1.0
b5b74000 b5b7e000 r-xp /usr/lib/libXrender.so.1.3.0
b5b7f000 b5b88000 r-xp /usr/lib/libXrandr.so.2.2.0
b5b8a000 b5b8c000 r-xp /usr/lib/libXinerama.so.1.0.0
b5b8d000 b5b92000 r-xp /usr/lib/libXfixes.so.3.1.0
b5b93000 b5ba5000 r-xp /usr/lib/libXext.so.6.4.0
b5ba6000 b5ba8000 r-xp /usr/lib/libXdamage.so.1.1.0
b5ba9000 b5bab000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5bad000 b5cef000 r-xp /usr/lib/libX11.so.6.3.0
b5cf3000 b5cfd000 r-xp /usr/lib/libXcursor.so.1.0.2
b5cfe000 b5d14000 r-xp /usr/lib/libudev.so.1.6.0
b5d17000 b5d1b000 r-xp /lib/libattr.so.1.1.0
b5d1c000 b5d4b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d4d000 b5d53000 r-xp /usr/lib/libffi.so.6.0.2
b5d54000 b5d77000 r-xp /lib/libz.so.1.2.8
b5d78000 b5d7b000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5d7c000 b5ed8000 r-xp /usr/lib/libxml2.so.2.9.2
b5ede000 b5fc5000 r-xp /usr/lib/libstdc++.so.6.0.20
b5fd2000 b5fd5000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5fd6000 b5ff8000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5ff9000 b600d000 r-xp /lib/libresolv-2.20-2014.11.so
b6011000 b6035000 r-xp /usr/lib/liblzma.so.5.0.3
b6036000 b6038000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b603a000 b6044000 r-xp /usr/lib/libembryo.so.1.13.0
b6045000 b606e000 r-xp /usr/lib/libpng12.so.0.50.0
b606f000 b60b8000 r-xp /usr/lib/libjpeg.so.8.0.2
b60c9000 b60d0000 r-xp /lib/librt-2.20-2014.11.so
b60d2000 b60f1000 r-xp /usr/lib/libector.so.1.13.0
b60f4000 b6121000 r-xp /usr/lib/liblua-5.1.so
b6122000 b61b2000 r-xp /usr/lib/libfreetype.so.6.11.3
b61b6000 b61f4000 r-xp /usr/lib/libfontconfig.so.1.8.0
b61f5000 b620b000 r-xp /usr/lib/libfribidi.so.0.3.1
b620c000 b6265000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6268000 b62b3000 r-xp /lib/libm-2.20-2014.11.so
b62b5000 b62c7000 r-xp /usr/lib/libeio.so.1.13.0
b62c8000 b62cb000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b62cc000 b62d2000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b62d3000 b62f6000 r-xp /usr/lib/libefreet.so.1.13.0
b62f9000 b6324000 r-xp /usr/lib/libeldbus.so.1.13.0
b6325000 b6359000 r-xp /usr/lib/libecore_con.so.1.13.0
b635b000 b6364000 r-xp /usr/lib/libecore_imf.so.1.13.0
b6365000 b636e000 r-xp /usr/lib/libethumb_client.so.1.13.0
b636f000 b6382000 r-xp /usr/lib/libeo.so.1.13.0
b6384000 b6397000 r-xp /usr/lib/libecore_input.so.1.13.0
b6398000 b639f000 r-xp /usr/lib/libecore_file.so.1.13.0
b63a0000 b63c3000 r-xp /usr/lib/libecore_evas.so.1.13.0
b63c4000 b63f0000 r-xp /usr/lib/libeet.so.1.13.0
b63f9000 b6464000 r-xp /usr/lib/libeina.so.1.13.0
b6467000 b647e000 r-xp /usr/lib/libefl.so.1.13.0
b6480000 b65e7000 r-xp /usr/lib/libicuuc.so.51.1
b65f5000 b6801000 r-xp /usr/lib/libicui18n.so.51.1
b6809000 b6858000 r-xp /usr/lib/libecore_x.so.1.13.0
b685a000 b6874000 r-xp /lib/libgcc_s-4.9.so.1
b6876000 b687a000 r-xp /lib/libcap.so.2.21
b687b000 b68c1000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b68c2000 b68c9000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b68cb000 b691d000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b691f000 b6aaa000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6aaf000 b6b7d000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6b80000 b6b84000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6b85000 b6b94000 r-xp /usr/lib/libvconf.so.0.2.45
b6b95000 b6b98000 r-xp /usr/lib/libvasum.so.0.3.1
b6b99000 b6b9c000 r-xp /usr/lib/libttrace.so.1.1
b6b9e000 b6ba2000 r-xp /usr/lib/libiniparser.so.0
b6ba3000 b6bd3000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6bd4000 b6bdd000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6bde000 b6c03000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c04000 b6c14000 r-xp /usr/lib/libunwind.so.8.0.1
b6c1e000 b6dcc000 r-xp /lib/libc-2.20-2014.11.so
b6dd4000 b6f17000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f19000 b6f71000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6f72000 b6fa6000 r-xp /usr/lib/libsystemd.so.0.4.0
b6fa9000 b707d000 r-xp /usr/lib/libedje.so.1.13.0
b7080000 b70ac000 r-xp /usr/lib/libecore.so.1.13.0
b70bd000 b72e3000 r-xp /usr/lib/libevas.so.1.13.0
b730b000 b7323000 r-xp /lib/libpthread-2.20-2014.11.so
b7327000 b76a1000 r-xp /usr/lib/libelementary.so.1.13.0
b76c1000 b76c5000 r-xp /usr/lib/libsmack.so.1.0.0
b76c6000 b76cf000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b76d0000 b76d3000 r-xp /usr/lib/libdlog.so.0.0.0
b76d4000 b76d9000 r-xp /usr/lib/libbundle.so.0.1.22
b76da000 b76dd000 r-xp /lib/libdl-2.20-2014.11.so
b76df000 b7704000 r-xp /usr/lib/libaul.so.0.1.0
b7707000 b7709000 r-xp /usr/lib/libappsvc.so.0.1.0
b770a000 b770f000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b7710000 b7717000 r-xp /usr/lib/libappcore-efl.so.1.1
b7719000 b771e000 r-xp /usr/lib/libsys-assert.so
b7721000 b7722000 r-xp [vdso]
b7722000 b7744000 r-xp /lib/ld-2.20-2014.11.so
b7746000 b774e000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:19028)
Call Stack Count: 74
 0: (0xb6d4fc0b) [/lib/libc.so.6] + 0x131c0b
 1: gl_del_cb + 0xa8 (0xb3784118) [/opt/usr/apps/org.example.example/bin/example] + 0x7118
 2: (0xb74831f9) [/usr/lib/libelementary.so.1] + 0x15c1f9
 3: elm_genlist_clear + 0x9b (0xb748342b) [/usr/lib/libelementary.so.1] + 0x15c42b
 4: (0xb7483669) [/usr/lib/libelementary.so.1] + 0x15c669
 5: evas_obj_smart_del + 0x99 (0xb7147eb9) [/usr/lib/libevas.so.1] + 0x8aeb9
 6: (0xb71496f1) [/usr/lib/libevas.so.1] + 0x8c6f1
 7: (0xb713c75b) [/usr/lib/libevas.so.1] + 0x7f75b
 8: eo_destructor + 0x99 (0xb637a079) [/usr/lib/libeo.so.1] + 0xb079
 9: (0xb759838b) [/usr/lib/libelementary.so.1] + 0x27138b
10: eo_destructor + 0x99 (0xb637a079) [/usr/lib/libeo.so.1] + 0xb079
11: _eo_do_end + 0x15b (0xb63725ab) [/usr/lib/libeo.so.1] + 0x35ab
12: eo_del + 0xb3 (0xb63777a3) [/usr/lib/libeo.so.1] + 0x87a3
13: evas_object_del + 0x81 (0xb7131cc1) [/usr/lib/libevas.so.1] + 0x74cc1
14: (0xb75a6245) [/usr/lib/libelementary.so.1] + 0x27f245
15: evas_obj_smart_del + 0x99 (0xb7147eb9) [/usr/lib/libevas.so.1] + 0x8aeb9
16: (0xb7495bf9) [/usr/lib/libelementary.so.1] + 0x16ebf9
17: evas_obj_smart_del + 0x99 (0xb7147eb9) [/usr/lib/libevas.so.1] + 0x8aeb9
18: (0xb71496f1) [/usr/lib/libevas.so.1] + 0x8c6f1
19: (0xb713c75b) [/usr/lib/libevas.so.1] + 0x7f75b
20: eo_destructor + 0x99 (0xb637a079) [/usr/lib/libeo.so.1] + 0xb079
21: (0xb759838b) [/usr/lib/libelementary.so.1] + 0x27138b
22: eo_destructor + 0x99 (0xb637a079) [/usr/lib/libeo.so.1] + 0xb079
23: _eo_do_end + 0x15b (0xb63725ab) [/usr/lib/libeo.so.1] + 0x35ab
24: eo_del + 0xb3 (0xb63777a3) [/usr/lib/libeo.so.1] + 0x87a3
25: evas_object_del + 0x81 (0xb7131cc1) [/usr/lib/libevas.so.1] + 0x74cc1
26: (0xb75a6245) [/usr/lib/libelementary.so.1] + 0x27f245
27: evas_obj_smart_del + 0x99 (0xb7147eb9) [/usr/lib/libevas.so.1] + 0x8aeb9
28: (0xb74db706) [/usr/lib/libelementary.so.1] + 0x1b4706
29: evas_obj_smart_del + 0x99 (0xb7147eb9) [/usr/lib/libevas.so.1] + 0x8aeb9
30: (0xb74cb53f) [/usr/lib/libelementary.so.1] + 0x1a453f
31: evas_obj_smart_del + 0x99 (0xb7147eb9) [/usr/lib/libevas.so.1] + 0x8aeb9
32: (0xb71496f1) [/usr/lib/libevas.so.1] + 0x8c6f1
33: (0xb713c75b) [/usr/lib/libevas.so.1] + 0x7f75b
34: eo_destructor + 0x99 (0xb637a079) [/usr/lib/libeo.so.1] + 0xb079
35: (0xb759838b) [/usr/lib/libelementary.so.1] + 0x27138b
36: eo_destructor + 0x99 (0xb637a079) [/usr/lib/libeo.so.1] + 0xb079
37: _eo_do_end + 0x15b (0xb63725ab) [/usr/lib/libeo.so.1] + 0x35ab
38: eo_del + 0xb3 (0xb63777a3) [/usr/lib/libeo.so.1] + 0x87a3
39: evas_object_del + 0x81 (0xb7131cc1) [/usr/lib/libevas.so.1] + 0x74cc1
40: (0xb75a6245) [/usr/lib/libelementary.so.1] + 0x27f245
41: evas_obj_smart_del + 0x99 (0xb7147eb9) [/usr/lib/libevas.so.1] + 0x8aeb9
42: (0xb74db706) [/usr/lib/libelementary.so.1] + 0x1b4706
43: evas_obj_smart_del + 0x99 (0xb7147eb9) [/usr/lib/libevas.so.1] + 0x8aeb9
44: (0xb71496f1) [/usr/lib/libevas.so.1] + 0x8c6f1
45: (0xb713c75b) [/usr/lib/libevas.so.1] + 0x7f75b
46: eo_destructor + 0x99 (0xb637a079) [/usr/lib/libeo.so.1] + 0xb079
47: (0xb759838b) [/usr/lib/libelementary.so.1] + 0x27138b
48: eo_destructor + 0x99 (0xb637a079) [/usr/lib/libeo.so.1] + 0xb079
49: _eo_do_end + 0x15b (0xb63725ab) [/usr/lib/libeo.so.1] + 0x35ab
50: eo_del + 0xb3 (0xb63777a3) [/usr/lib/libeo.so.1] + 0x87a3
51: evas_object_del + 0x81 (0xb7131cc1) [/usr/lib/libevas.so.1] + 0x74cc1
52: (0xb75959d1) [/usr/lib/libelementary.so.1] + 0x26e9d1
53: eo_destructor + 0x99 (0xb637a079) [/usr/lib/libeo.so.1] + 0xb079
54: (0xb73c76af) [/usr/lib/libelementary.so.1] + 0xa06af
55: eo_destructor + 0x99 (0xb637a079) [/usr/lib/libeo.so.1] + 0xb079
56: _eo_do_end + 0x15b (0xb63725ab) [/usr/lib/libeo.so.1] + 0x35ab
57: (0xb73c6646) [/usr/lib/libelementary.so.1] + 0x9f646
58: (0xb74d1626) [/usr/lib/libelementary.so.1] + 0x1aa626
59: (0xb702cf39) [/usr/lib/libedje.so.1] + 0x83f39
60: (0xb7033a11) [/usr/lib/libedje.so.1] + 0x8aa11
61: (0xb702dfdc) [/usr/lib/libedje.so.1] + 0x84fdc
62: (0xb702e4cb) [/usr/lib/libedje.so.1] + 0x854cb
63: (0xb702e68f) [/usr/lib/libedje.so.1] + 0x8568f
64: (0xb7093702) [/usr/lib/libecore.so.1] + 0x13702
65: (0xb708d055) [/usr/lib/libecore.so.1] + 0xd055
66: (0xb70961b9) [/usr/lib/libecore.so.1] + 0x161b9
67: ecore_main_loop_begin + 0x57 (0xb7096587) [/usr/lib/libecore.so.1] + 0x16587
68: elm_run + 0x2d (0xb74ef22d) [/usr/lib/libelementary.so.1] + 0x1c822d
69: appcore_efl_main + 0x4de (0xb7713dde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
70: ui_app_main + 0x140 (0xb770cc80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
71: main + 0x296 (0xb37857f6) [/opt/usr/apps/org.example.example/bin/example] + 0x87f6
72: (0xb7748148) [/opt/usr/apps/org.example.example/bin/example] + 0xb7748148
73: __libc_start_main + 0xde (0xb6c35e4e) [/lib/libc.so.6] + 0x17e4e
End of Call Stack

Package Information
Package Name: org.example.example
Package ID : org.example.example
Version: 1.0.0
Package Type: tpk
App Name: forpet
App ID: org.example.example
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
aunchpad(107) > [launchpad] enter, type: 0
06-04 04:53:43.374+0900 D/AUL     (19235): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
06-04 04:53:43.374+0900 D/AUL     (19235): process_pool.c: __connect_to_launchpad(132) > send(19235) : 4
06-04 04:53:43.374+0900 D/AUL_PAD ( 2913): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
06-04 04:53:43.374+0900 D/AUL_PAD ( 2913): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
06-04 04:53:43.374+0900 D/AUL_PAD ( 2913): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-04 04:53:43.374+0900 D/AUL_PAD ( 2913): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-04 04:53:43.374+0900 D/AUL_PAD ( 2913): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-04 04:53:43.374+0900 D/AUL_PAD ( 2913): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-04 04:53:43.374+0900 D/AUL_PAD ( 2913): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-04 04:53:43.374+0900 D/AUL_PAD ( 2913): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
06-04 04:53:43.374+0900 D/AUL_PAD ( 2913): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 19235
06-04 04:53:43.374+0900 D/AUL     (19235): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
06-04 04:53:43.374+0900 E/RESOURCED( 2841): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1701
06-04 04:53:43.434+0900 D/AUL_PAD (19235): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
06-04 04:53:43.434+0900 D/AUL_PAD (19235): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
06-04 04:53:43.434+0900 D/AUL_PAD (19235): launchpad_loader.c: main(693) > [candidate] ecore handler add
06-04 04:53:43.434+0900 D/AUL_PAD (19235): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
06-04 04:53:43.504+0900 D/PROCESSMGR( 2690): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x6044f9 
06-04 04:53:43.654+0900 E/EFL     (19028): edje<19028> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:53:43.654+0900 E/EFL     (19028): edje<19028> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:53:43.694+0900 E/EFL     (19028): edje<19028> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:53:43.694+0900 E/EFL     (19028): edje<19028> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:53:43.694+0900 E/EFL     (19028): edje<19028> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:53:43.694+0900 E/EFL     (19028): edje<19028> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:53:43.694+0900 E/EFL     (19028): edje<19028> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:53:43.694+0900 E/EFL     (19028): edje<19028> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:53:43.704+0900 E/EFL     (19028): edje<19028> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:53:43.704+0900 D/IMMODULE(19028): isf_imf_context.cpp: initialize(3406) > Initializing Ecore ISF IMModule...
06-04 04:53:43.704+0900 D/ISF_SOCKET(19028): scim_socket.cpp: connect(515) > ppid:2913  trying connect() to local:/tmp/scim-socket-frontend, example
06-04 04:53:43.704+0900 D/ISF_SOCKET(19028): scim_socket.cpp: connect(524) > connect() succeeded
06-04 04:53:43.704+0900 D/ISF_SOCKET(19028): scim_socket.cpp: connect(515) > ppid:2913  trying connect() to local:/tmp/scim-socket-frontend, example
06-04 04:53:43.704+0900 D/ISF_SOCKET(19028): scim_socket.cpp: connect(524) > connect() succeeded
06-04 04:53:43.714+0900 D/ISF_SOCKET(19028): scim_socket.cpp: connect(515) > ppid:2913  trying connect() to local:/tmp/scim-socket-frontend, example
06-04 04:53:43.714+0900 D/ISF_SOCKET(19028): scim_socket.cpp: connect(524) > connect() succeeded
06-04 04:53:43.714+0900 D/ISF_QUERY(19028): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="ise-default", label="Tizen keyboard", pkgid="ise-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-helper-launcher", mname="ise-default", mpath="/usr/lib/scim-1.0/1.4.0/Helper", mode=1, options=13, is_enabled=1, is_preinstalled=1, has_option=1, disp_lang="en_US.UTF-8"
06-04 04:53:43.714+0900 D/ISF_QUERY(19028): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-anthy", label="Japanese keyboard", pkgid="ise-engine-anthy", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-anthy", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 04:53:43.724+0900 D/ISF_QUERY(19028): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-default", label="Default keyboard", pkgid="ise-engine-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-default", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 04:53:43.724+0900 D/ISF_QUERY(19028): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-hangul", label="Hangul keyboard", pkgid="hangul", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="hangul", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 04:53:43.724+0900 D/ISF_QUERY(19028): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-sunpinyin", label="Chinese (sunpinyin) keyboard", pkgid="ise-engine-sunpinyin", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-sunpinyin", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 04:53:43.724+0900 D/ISF_QUERY(19028): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.cangjie3", label="CanJie 3 keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 04:53:43.724+0900 D/ISF_QUERY(19028): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.zhuyin-big", label="ZhuYin Big keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 04:53:43.724+0900 D/ISF_SOCKET(19028): scim_socket.cpp: connect(515) > ppid:2913  trying connect() to local:/tmp/scim-socket-frontend, example
06-04 04:53:43.724+0900 D/ISF_SOCKET(19028): scim_socket.cpp: connect(524) > connect() succeeded
06-04 04:53:43.724+0900 D/IMMODULE(19028): scim_panel_client.cpp: open_connection(162) > 
06-04 04:53:43.724+0900 D/ISF_SOCKET(19028): scim_socket.cpp: connect(515) > ppid:2913  trying connect() to local:/tmp/scim-panel-socket:0, example
06-04 04:53:43.724+0900 D/ISF_SOCKET(19028): scim_socket.cpp: connect(524) > connect() succeeded
06-04 04:53:43.724+0900 D/ISF_SOCKET(19028): scim_socket.cpp: connect(515) > ppid:2913  trying connect() to local:/tmp/scim-panel-socket:0, example
06-04 04:53:43.724+0900 D/ISF_SOCKET(19028): scim_socket.cpp: connect(524) > connect() succeeded
06-04 04:53:43.724+0900 D/IMMODULE(19028): isf_imf_control_ui.cpp: isf_imf_input_panel_init(516) > keyboard mode(0:H/W Keyboard, 1:S/W Keyboard): 0
06-04 04:53:44.314+0900 D/PROCESSMGR( 2690): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x6044f9 
06-04 04:53:44.374+0900 E/EFL     (19028): edje<19028> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
06-04 04:53:44.374+0900 E/EFL     (19028): By the power of Grayskull, your previous Embryo stack is now broken!
06-04 04:53:44.584+0900 I/tag     (19028): insert
06-04 04:53:44.584+0900 I/user_tag(19028): 04:53 AM
06-04 04:53:44.594+0900 E/EFL     (19028): edje<19028> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:53:44.604+0900 E/EFL     (19028): edje<19028> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:53:44.604+0900 E/EFL     (19028): edje<19028> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:53:44.604+0900 E/EFL     (19028): edje<19028> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:53:44.604+0900 E/EFL     (19028): edje<19028> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:53:44.844+0900 D/PROCESSMGR( 2690): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x6044f9 
06-04 04:53:45.854+0900 D/PROCESSMGR( 2690): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2400002
06-04 04:53:46.704+0900 D/APP_CORE( 2863): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
06-04 04:53:46.704+0900 I/APP_CORE( 2863): appcore-efl.c: __do_app(496) > [APP 2863] Event: MEM_FLUSH State: PAUSED
06-04 04:53:46.704+0900 D/APP_CORE( 2863): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
06-04 04:53:46.704+0900 D/APP_CORE( 2863): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 2863
06-04 04:53:46.704+0900 D/APP_CORE( 2863): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
06-04 04:53:46.704+0900 D/RESOURCED( 2841): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 2863
06-04 04:53:50.854+0900 D/PROCESSMGR( 2690): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x6044f9 bd->visible=1
06-04 04:53:53.524+0900 D/PROCESSMGR( 2690): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x6044f9 
06-04 04:53:54.694+0900 D/PROCESSMGR( 2690): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x6044f9 
06-04 04:53:54.814+0900 E/EFL     (19028): edje<19028> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
06-04 04:53:54.814+0900 E/EFL     (19028): By the power of Grayskull, your previous Embryo stack is now broken!
06-04 04:53:55.184+0900 I/tag     (19028): 0
06-04 04:53:55.184+0900 I/tag     (19028): delete~~~
06-04 04:53:55.184+0900 I/tag     (19028): DELETE FROM feeding WHERE TM_HOUR = '4' AND TM_MIN = '53';
06-04 04:53:55.194+0900 I/tag     (19028): 0
06-04 04:53:55.194+0900 I/tag     (19028): 1
06-04 04:53:55.194+0900 I/tag     (19028): 눈누나나1
06-04 04:53:55.194+0900 I/tag     (19028): 지우고~
06-04 04:53:55.204+0900 I/tag     (19028): 팝업 지워~
06-04 04:53:55.204+0900 I/tag     (19028): 끝
06-04 04:53:57.514+0900 E/CAPI_NETWORK_WIFI( 2846): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-04 04:53:57.514+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
06-04 04:53:57.514+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-04 04:53:57.514+0900 E/INDICATOR( 2846): 
06-04 04:54:00.644+0900 D/INDICATOR( 2846): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
06-04 04:54:00.644+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
06-04 04:54:00.644+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
06-04 04:54:00.644+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 4:54 4 h"
06-04 04:54:00.644+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 4:54"
06-04 04:54:00.644+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 4&#x2236;54"
06-04 04:54:00.644+0900 D/INDICATOR( 2846): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2146011840 Time: <font_size=33>4&#x2236;54</font_size> <font_size=32>AM</font_size></font>
06-04 04:54:17.534+0900 E/CAPI_NETWORK_WIFI( 2846): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-04 04:54:17.534+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
06-04 04:54:17.534+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-04 04:54:17.534+0900 E/INDICATOR( 2846): 
06-04 04:54:20.144+0900 D/RESOURCED( 2841): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
06-04 04:54:20.144+0900 I/RESOURCED( 2841): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
06-04 04:54:20.144+0900 D/RESOURCED( 2841): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
06-04 04:54:20.144+0900 I/RESOURCED( 2841): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
06-04 04:54:37.554+0900 E/CAPI_NETWORK_WIFI( 2846): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-04 04:54:37.554+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
06-04 04:54:37.554+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-04 04:54:37.554+0900 E/INDICATOR( 2846): 
06-04 04:54:57.583+0900 E/CAPI_NETWORK_WIFI( 2846): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-04 04:54:57.583+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
06-04 04:54:57.583+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-04 04:54:57.583+0900 E/INDICATOR( 2846): 
06-04 04:55:00.653+0900 D/INDICATOR( 2846): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
06-04 04:55:00.653+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
06-04 04:55:00.653+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
06-04 04:55:00.653+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 4:55 4 h"
06-04 04:55:00.653+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 4:55"
06-04 04:55:00.653+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 4&#x2236;55"
06-04 04:55:00.653+0900 D/INDICATOR( 2846): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2146009788 Time: <font_size=33>4&#x2236;55</font_size> <font_size=32>AM</font_size></font>
06-04 04:55:17.613+0900 E/CAPI_NETWORK_WIFI( 2846): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-04 04:55:17.613+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
06-04 04:55:17.613+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-04 04:55:17.613+0900 E/INDICATOR( 2846): 
06-04 04:55:20.193+0900 D/RESOURCED( 2841): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
06-04 04:55:20.193+0900 I/RESOURCED( 2841): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
06-04 04:55:20.193+0900 D/RESOURCED( 2841): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
06-04 04:55:20.193+0900 I/RESOURCED( 2841): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
06-04 04:55:37.643+0900 E/CAPI_NETWORK_WIFI( 2846): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-04 04:55:37.643+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
06-04 04:55:37.643+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-04 04:55:37.643+0900 E/INDICATOR( 2846): 
06-04 04:55:45.143+0900 D/PROCESSMGR( 2690): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x6044f9 
06-04 04:55:45.223+0900 E/EFL     (19028): edje<19028> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:55:45.223+0900 E/EFL     (19028): edje<19028> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:55:45.273+0900 E/EFL     (19028): edje<19028> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:55:45.273+0900 E/EFL     (19028): edje<19028> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:55:45.273+0900 E/EFL     (19028): edje<19028> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:55:45.283+0900 E/EFL     (19028): edje<19028> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:55:45.283+0900 E/EFL     (19028): edje<19028> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:55:45.283+0900 E/EFL     (19028): edje<19028> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:55:45.283+0900 E/EFL     (19028): edje<19028> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:55:46.153+0900 D/PROCESSMGR( 2690): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2400002
06-04 04:55:46.393+0900 D/PROCESSMGR( 2690): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x6044f9 
06-04 04:55:46.503+0900 I/tag     (19028): insert
06-04 04:55:46.513+0900 I/user_tag(19028): 04:55 AM
06-04 04:55:46.513+0900 E/EFL     (19028): edje<19028> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:55:46.523+0900 E/EFL     (19028): edje<19028> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:55:46.523+0900 E/EFL     (19028): edje<19028> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:55:46.533+0900 E/EFL     (19028): edje<19028> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:55:46.533+0900 E/EFL     (19028): edje<19028> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:55:47.203+0900 D/PROCESSMGR( 2690): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x6044f9 
06-04 04:55:47.993+0900 D/PROCESSMGR( 2690): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x6044f9 
06-04 04:55:48.143+0900 E/EFL     (19028): edje<19028> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
06-04 04:55:48.143+0900 E/EFL     (19028): By the power of Grayskull, your previous Embryo stack is now broken!
06-04 04:55:48.523+0900 I/tag     (19028): 0
06-04 04:55:48.523+0900 I/tag     (19028): delete~~~
06-04 04:55:48.523+0900 I/tag     (19028): DELETE FROM feeding WHERE TM_HOUR = '4' AND TM_MIN = '55';
06-04 04:55:48.523+0900 I/tag     (19028): 0
06-04 04:55:48.523+0900 I/tag     (19028): 1
06-04 04:55:48.523+0900 I/tag     (19028): 눈누나나1
06-04 04:55:48.523+0900 I/tag     (19028): 지우고~
06-04 04:55:48.543+0900 I/tag     (19028): 팝업 지워~
06-04 04:55:48.543+0900 I/tag     (19028): 끝
06-04 04:55:49.123+0900 D/PROCESSMGR( 2690): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x6044f9 
06-04 04:55:50.443+0900 I/user_tag0(19028): /opt/usr/apps/org.example.example/data/feeding.db
06-04 04:55:50.443+0900 I/tag     (19028): eonji~
06-04 04:55:50.533+0900 D/PROCESSMGR( 2690): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x6044f9 
06-04 04:55:51.153+0900 D/PROCESSMGR( 2690): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x6044f9 bd->visible=1
06-04 04:55:52.133+0900 D/PROCESSMGR( 2690): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x6044f9 
06-04 04:55:54.153+0900 I/user_tag0(19028): /opt/usr/apps/org.example.example/data/feeding.db
06-04 04:55:54.153+0900 I/tag     (19028): eonji~
06-04 04:55:54.223+0900 D/PROCESSMGR( 2690): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x6044f9 
06-04 04:55:55.163+0900 D/PROCESSMGR( 2690): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x6044f9 
06-04 04:55:57.653+0900 E/CAPI_NETWORK_WIFI( 2846): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-04 04:55:57.653+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
06-04 04:55:57.653+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-04 04:55:57.653+0900 E/INDICATOR( 2846): 
06-04 04:56:00.662+0900 D/INDICATOR( 2846): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
06-04 04:56:00.662+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
06-04 04:56:00.662+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
06-04 04:56:00.662+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 4:56 4 h"
06-04 04:56:00.662+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 4:56"
06-04 04:56:00.662+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 4&#x2236;56"
06-04 04:56:00.662+0900 D/INDICATOR( 2846): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2146007736 Time: <font_size=33>4&#x2236;56</font_size> <font_size=32>AM</font_size></font>
06-04 04:56:16.842+0900 D/PROCESSMGR( 2690): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x6044f9 
06-04 04:56:17.652+0900 E/CAPI_NETWORK_WIFI( 2846): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-04 04:56:17.652+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
06-04 04:56:17.652+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-04 04:56:17.652+0900 E/INDICATOR( 2846): 
06-04 04:56:17.852+0900 D/PROCESSMGR( 2690): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2400002
06-04 04:56:20.162+0900 D/RESOURCED( 2841): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
06-04 04:56:20.162+0900 I/RESOURCED( 2841): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
06-04 04:56:20.162+0900 D/RESOURCED( 2841): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
06-04 04:56:20.162+0900 I/RESOURCED( 2841): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
06-04 04:56:22.862+0900 D/PROCESSMGR( 2690): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x6044f9 bd->visible=1
06-04 04:56:36.912+0900 I/user_tag0(19028): /opt/usr/apps/org.example.example/data/feeding.db
06-04 04:56:36.912+0900 I/tag     (19028): eonji~
06-04 04:56:36.992+0900 D/PROCESSMGR( 2690): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x6044f9 
06-04 04:56:37.652+0900 E/CAPI_NETWORK_WIFI( 2846): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-04 04:56:37.652+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
06-04 04:56:37.652+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-04 04:56:37.652+0900 E/INDICATOR( 2846): 
06-04 04:56:38.022+0900 D/PROCESSMGR( 2690): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2400002
06-04 04:56:39.202+0900 D/PROCESSMGR( 2690): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x6044f9 
06-04 04:56:43.022+0900 D/PROCESSMGR( 2690): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x6044f9 bd->visible=1
06-04 04:56:57.682+0900 E/CAPI_NETWORK_WIFI( 2846): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-04 04:56:57.682+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
06-04 04:56:57.682+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-04 04:56:57.682+0900 E/INDICATOR( 2846): 
06-04 04:57:00.672+0900 D/INDICATOR( 2846): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
06-04 04:57:00.672+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
06-04 04:57:00.672+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
06-04 04:57:00.672+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 4:57 4 h"
06-04 04:57:00.672+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 4:57"
06-04 04:57:00.672+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 4&#x2236;57"
06-04 04:57:00.672+0900 D/INDICATOR( 2846): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2146005684 Time: <font_size=33>4&#x2236;57</font_size> <font_size=32>AM</font_size></font>
06-04 04:57:17.711+0900 E/CAPI_NETWORK_WIFI( 2846): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-04 04:57:17.711+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
06-04 04:57:17.711+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-04 04:57:17.711+0900 E/INDICATOR( 2846): 
06-04 04:57:20.191+0900 D/RESOURCED( 2841): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
06-04 04:57:20.191+0900 I/RESOURCED( 2841): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
06-04 04:57:20.191+0900 D/RESOURCED( 2841): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
06-04 04:57:20.191+0900 I/RESOURCED( 2841): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
06-04 04:57:37.731+0900 E/CAPI_NETWORK_WIFI( 2846): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-04 04:57:37.731+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
06-04 04:57:37.731+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-04 04:57:37.731+0900 E/INDICATOR( 2846): 
06-04 04:57:57.771+0900 E/CAPI_NETWORK_WIFI( 2846): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-04 04:57:57.771+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
06-04 04:57:57.771+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-04 04:57:57.771+0900 E/INDICATOR( 2846): 
06-04 04:58:00.691+0900 D/INDICATOR( 2846): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
06-04 04:58:00.691+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
06-04 04:58:00.691+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
06-04 04:58:00.691+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 4:58 4 h"
06-04 04:58:00.691+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 4:58"
06-04 04:58:00.691+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 4&#x2236;58"
06-04 04:58:00.691+0900 D/INDICATOR( 2846): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2146003632 Time: <font_size=33>4&#x2236;58</font_size> <font_size=32>AM</font_size></font>
06-04 04:58:17.791+0900 E/CAPI_NETWORK_WIFI( 2846): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-04 04:58:17.791+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
06-04 04:58:17.791+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-04 04:58:17.791+0900 E/INDICATOR( 2846): 
06-04 04:58:20.201+0900 D/RESOURCED( 2841): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
06-04 04:58:20.201+0900 I/RESOURCED( 2841): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
06-04 04:58:20.201+0900 D/RESOURCED( 2841): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
06-04 04:58:20.201+0900 I/RESOURCED( 2841): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
06-04 04:58:37.810+0900 E/CAPI_NETWORK_WIFI( 2846): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-04 04:58:37.810+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
06-04 04:58:37.810+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-04 04:58:37.810+0900 E/INDICATOR( 2846): 
06-04 04:58:57.840+0900 E/CAPI_NETWORK_WIFI( 2846): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-04 04:58:57.840+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
06-04 04:58:57.840+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-04 04:58:57.840+0900 E/INDICATOR( 2846): 
06-04 04:59:00.690+0900 D/INDICATOR( 2846): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
06-04 04:59:00.690+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
06-04 04:59:00.690+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
06-04 04:59:00.690+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 4:59 4 h"
06-04 04:59:00.690+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 4:59"
06-04 04:59:00.690+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 4&#x2236;59"
06-04 04:59:00.690+0900 D/INDICATOR( 2846): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2146001580 Time: <font_size=33>4&#x2236;59</font_size> <font_size=32>AM</font_size></font>
06-04 04:59:17.850+0900 E/CAPI_NETWORK_WIFI( 2846): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-04 04:59:17.850+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
06-04 04:59:17.850+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-04 04:59:17.850+0900 E/INDICATOR( 2846): 
06-04 04:59:20.200+0900 D/RESOURCED( 2841): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
06-04 04:59:20.200+0900 I/RESOURCED( 2841): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
06-04 04:59:20.200+0900 D/RESOURCED( 2841): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
06-04 04:59:20.200+0900 I/RESOURCED( 2841): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
06-04 04:59:20.210+0900 I/RESOURCED( 2841): logging.c: logging_save_to_storage(978) > battery cache is empty
06-04 04:59:20.210+0900 I/RESOURCED( 2841): logging.c: logging_save_to_storage(978) > storage cache is empty
06-04 04:59:20.210+0900 D/RESOURCED( 2841): heart-cpu.c: heart_cpu_update(576) > org.tizen.lockscreen org.tizen.lockscreen 1496519362 24 18 18612 2
06-04 04:59:20.210+0900 D/RESOURCED( 2841): heart-cpu.c: heart_cpu_update(576) > org.tizen.homescreen org.tizen.homescreen 1496519390 686 531 2863 1
06-04 04:59:20.210+0900 D/RESOURCED( 2841): heart-cpu.c: heart_cpu_update(576) > org.example.example org.example.example 1496519453 32 5 18644 1
06-04 04:59:20.210+0900 D/RESOURCED( 2841): heart-cpu.c: heart_cpu_update(576) > org.tizen.homescreen org.tizen.homescreen 1496519488 697 535 2863 1
06-04 04:59:20.210+0900 D/RESOURCED( 2841): heart-cpu.c: heart_cpu_update(576) > org.example.example org.example.example 1496519493 32 5 18863 1
06-04 04:59:20.210+0900 D/RESOURCED( 2841): heart-cpu.c: heart_cpu_update(576) > org.tizen.homescreen org.tizen.homescreen 1496519617 706 543 2863 1
06-04 04:59:20.210+0900 D/RESOURCED( 2841): heart-cpu.c: heart_cpu_update(576) > org.example.example org.example.example 1496519621 31 7 19028 1
06-04 04:59:37.880+0900 E/CAPI_NETWORK_WIFI( 2846): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-04 04:59:37.880+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
06-04 04:59:37.880+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-04 04:59:37.880+0900 E/INDICATOR( 2846): 
06-04 04:59:52.130+0900 I/user_tag0(19028): /opt/usr/apps/org.example.example/data/feeding.db
06-04 04:59:52.140+0900 I/tag     (19028): eonji~
06-04 04:59:52.220+0900 D/PROCESSMGR( 2690): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x6044f9 
06-04 04:59:53.190+0900 D/PROCESSMGR( 2690): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x6044f9 
06-04 04:59:53.960+0900 D/PROCESSMGR( 2690): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x6044f9 
06-04 04:59:54.300+0900 I/user_tag0(19028): /opt/usr/apps/org.example.example/data/feeding.db
06-04 04:59:54.300+0900 I/tag     (19028): eonji~
06-04 04:59:54.360+0900 D/PROCESSMGR( 2690): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x6044f9 
06-04 04:59:55.140+0900 D/PROCESSMGR( 2690): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x6044f9 
06-04 04:59:55.230+0900 E/EFL     (19028): edje<19028> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:59:55.230+0900 E/EFL     (19028): edje<19028> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:59:55.270+0900 E/EFL     (19028): edje<19028> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:59:55.270+0900 E/EFL     (19028): edje<19028> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:59:55.270+0900 E/EFL     (19028): edje<19028> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:59:55.270+0900 E/EFL     (19028): edje<19028> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:59:55.280+0900 E/EFL     (19028): edje<19028> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:59:55.280+0900 E/EFL     (19028): edje<19028> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:59:55.280+0900 E/EFL     (19028): edje<19028> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:59:56.140+0900 D/PROCESSMGR( 2690): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2400002
06-04 04:59:56.230+0900 D/PROCESSMGR( 2690): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x6044f9 
06-04 04:59:56.390+0900 I/tag     (19028): insert
06-04 04:59:56.390+0900 I/user_tag(19028): 04:59 AM
06-04 04:59:56.400+0900 E/EFL     (19028): edje<19028> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:59:56.400+0900 E/EFL     (19028): edje<19028> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:59:56.400+0900 E/EFL     (19028): edje<19028> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:59:56.410+0900 E/EFL     (19028): edje<19028> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:59:56.410+0900 E/EFL     (19028): edje<19028> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:59:57.879+0900 E/CAPI_NETWORK_WIFI( 2846): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-04 04:59:57.879+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
06-04 04:59:57.879+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-04 04:59:57.879+0900 E/INDICATOR( 2846): 
06-04 04:59:58.179+0900 D/PROCESSMGR( 2690): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x6044f9 
06-04 04:59:58.409+0900 I/tag     (19028): 0
06-04 04:59:58.459+0900 W/CRASH_MANAGER(19245): worker.c: worker_job(1204) > 1119028657861149651999
