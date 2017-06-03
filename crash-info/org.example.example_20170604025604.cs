S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 8582
Date: 2017-06-04 02:56:04+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0x00000008, esi = 0xbfeb3970
ebp = 0xbfeb3ad8, esp = 0xbfeb396c
eax = 0xb37a0912, ebx = 0xb37a3000
ecx = 0x00000050, edx = 0x00000000
eip = 0xb6d67c0b

Memory Information
MemTotal:      123 KB
MemFree:        21 KB
Buffers:         7 KB
Cached:     180808 KB
VmPeak:     122124 KB
VmSize:     112904 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       35068 KB
VmRSS:       26908 KB
VmData:      44720 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34636 KB
VmPTE:         100 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 8582 TID = 8582
8582 8583 8674 8680 

Maps Information
b0ea4000 b0eab000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b0eae000 b0ec6000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b1800000 b1807000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b1884000 b1888000 r-xp /usr/lib/elementary/modules/datetime_input_spinner/v-1.13.0/module.so
b2b5d000 b2b67000 r-xp /usr/lib/libfeedback.so.0.1.4
b2b6d000 b2b79000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2b7a000 b2b9b000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2ba0000 b2ba1000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2ba2000 b2ba7000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2ba8000 b2ba9000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2baa000 b2bac000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2bad000 b2baf000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2bb0000 b2bbc000 r-xp /usr/lib/libdrm.so.2.4.0
b2bbd000 b2bc0000 r-xp /usr/lib/libdri2.so.0.0.0
b2bc1000 b2bcb000 r-xp /usr/lib/libtbm.so.1.0.0
b2bcc000 b2be1000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2be2000 b2bf4000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b33f6000 b3427000 r-xp /usr/lib/libidn.so.11.5.44
b3428000 b344a000 r-xp /usr/lib/libnghttp2.so.5.4.0
b344b000 b345b000 r-xp /usr/lib/libcares.so.2.1.0
b345c000 b3465000 r-xp /usr/lib/libeventsystem.so.0.0.1
b3466000 b346f000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3470000 b34e7000 r-xp /usr/lib/libcurl.so.4.3.0
b34e9000 b34fb000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b34fc000 b351d000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b3524000 b3525000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3526000 b3527000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b3528000 b352b000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b352c000 b352f000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3637000 b363d000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b363e000 b3782000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b3793000 b3794000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b3795000 b37a2000 r-xp /opt/usr/apps/org.example.example/bin/example
b37a4000 b37dd000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b41e0000 b41eb000 r-xp /lib/libnss_files-2.20-2014.11.so
b41ed000 b41f8000 r-xp /lib/libnss_nis-2.20-2014.11.so
b41fa000 b4211000 r-xp /lib/libnsl-2.20-2014.11.so
b4215000 b421d000 r-xp /lib/libnss_compat-2.20-2014.11.so
b421f000 b4243000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b4244000 b4245000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b4246000 b4249000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b424a000 b4251000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4252000 b425c000 r-xp /usr/lib/libsensord-share.so
b425d000 b4279000 r-xp /usr/lib/libsensor.so.1.2.0
b427b000 b4284000 r-xp /usr/lib/libappcore-common.so.1.1
b4287000 b4289000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b429e000 b42a0000 r-xp /usr/lib/libXau.so.6.0.0
b42a1000 b42c3000 r-xp /usr/lib/libxcb.so.1.1.0
b42c5000 b42ce000 r-xp /lib/libcrypt-2.20-2014.11.so
b42f7000 b42f9000 r-xp /usr/lib/libiri.so
b42fa000 b4320000 r-xp /lib/libexpat.so.1.5.2
b4322000 b438d000 r-xp /usr/lib/libssl.so.1.0.0
b4393000 b439f000 r-xp /usr/lib/libethumb.so.1.13.0
b43a0000 b43a4000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b43a5000 b45f6000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b71000 b5b81000 r-xp /usr/lib/libXi.so.6.1.0
b5b82000 b5b84000 r-xp /usr/lib/libXgesture.so.7.0.0
b5b85000 b5b8b000 r-xp /usr/lib/libXtst.so.6.1.0
b5b8c000 b5b96000 r-xp /usr/lib/libXrender.so.1.3.0
b5b97000 b5ba0000 r-xp /usr/lib/libXrandr.so.2.2.0
b5ba2000 b5ba4000 r-xp /usr/lib/libXinerama.so.1.0.0
b5ba5000 b5baa000 r-xp /usr/lib/libXfixes.so.3.1.0
b5bab000 b5bbd000 r-xp /usr/lib/libXext.so.6.4.0
b5bbe000 b5bc0000 r-xp /usr/lib/libXdamage.so.1.1.0
b5bc1000 b5bc3000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5bc5000 b5d07000 r-xp /usr/lib/libX11.so.6.3.0
b5d0b000 b5d15000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d16000 b5d2c000 r-xp /usr/lib/libudev.so.1.6.0
b5d2f000 b5d33000 r-xp /lib/libattr.so.1.1.0
b5d34000 b5d63000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d65000 b5d6b000 r-xp /usr/lib/libffi.so.6.0.2
b5d6c000 b5d8f000 r-xp /lib/libz.so.1.2.8
b5d90000 b5d93000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5d94000 b5ef0000 r-xp /usr/lib/libxml2.so.2.9.2
b5ef6000 b5fdd000 r-xp /usr/lib/libstdc++.so.6.0.20
b5fea000 b5fed000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5fee000 b6010000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6011000 b6025000 r-xp /lib/libresolv-2.20-2014.11.so
b6029000 b604d000 r-xp /usr/lib/liblzma.so.5.0.3
b604e000 b6050000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b6052000 b605c000 r-xp /usr/lib/libembryo.so.1.13.0
b605d000 b6086000 r-xp /usr/lib/libpng12.so.0.50.0
b6087000 b60d0000 r-xp /usr/lib/libjpeg.so.8.0.2
b60e1000 b60e8000 r-xp /lib/librt-2.20-2014.11.so
b60ea000 b6109000 r-xp /usr/lib/libector.so.1.13.0
b610c000 b6139000 r-xp /usr/lib/liblua-5.1.so
b613a000 b61ca000 r-xp /usr/lib/libfreetype.so.6.11.3
b61ce000 b620c000 r-xp /usr/lib/libfontconfig.so.1.8.0
b620d000 b6223000 r-xp /usr/lib/libfribidi.so.0.3.1
b6224000 b627d000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6280000 b62cb000 r-xp /lib/libm-2.20-2014.11.so
b62cd000 b62df000 r-xp /usr/lib/libeio.so.1.13.0
b62e0000 b62e3000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b62e4000 b62ea000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b62eb000 b630e000 r-xp /usr/lib/libefreet.so.1.13.0
b6311000 b633c000 r-xp /usr/lib/libeldbus.so.1.13.0
b633d000 b6371000 r-xp /usr/lib/libecore_con.so.1.13.0
b6373000 b637c000 r-xp /usr/lib/libecore_imf.so.1.13.0
b637d000 b6386000 r-xp /usr/lib/libethumb_client.so.1.13.0
b6387000 b639a000 r-xp /usr/lib/libeo.so.1.13.0
b639c000 b63af000 r-xp /usr/lib/libecore_input.so.1.13.0
b63b0000 b63b7000 r-xp /usr/lib/libecore_file.so.1.13.0
b63b8000 b63db000 r-xp /usr/lib/libecore_evas.so.1.13.0
b63dc000 b6408000 r-xp /usr/lib/libeet.so.1.13.0
b6411000 b647c000 r-xp /usr/lib/libeina.so.1.13.0
b647f000 b6496000 r-xp /usr/lib/libefl.so.1.13.0
b6498000 b65ff000 r-xp /usr/lib/libicuuc.so.51.1
b660d000 b6819000 r-xp /usr/lib/libicui18n.so.51.1
b6821000 b6870000 r-xp /usr/lib/libecore_x.so.1.13.0
b6872000 b688c000 r-xp /lib/libgcc_s-4.9.so.1
b688e000 b6892000 r-xp /lib/libcap.so.2.21
b6893000 b68d9000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b68da000 b68e1000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b68e3000 b6935000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b6937000 b6ac2000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6ac7000 b6b95000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6b98000 b6b9c000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6b9d000 b6bac000 r-xp /usr/lib/libvconf.so.0.2.45
b6bad000 b6bb0000 r-xp /usr/lib/libvasum.so.0.3.1
b6bb1000 b6bb4000 r-xp /usr/lib/libttrace.so.1.1
b6bb6000 b6bba000 r-xp /usr/lib/libiniparser.so.0
b6bbb000 b6beb000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6bec000 b6bf5000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6bf6000 b6c1b000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c1c000 b6c2c000 r-xp /usr/lib/libunwind.so.8.0.1
b6c36000 b6de4000 r-xp /lib/libc-2.20-2014.11.so
b6dec000 b6f2f000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f31000 b6f89000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6f8a000 b6fbe000 r-xp /usr/lib/libsystemd.so.0.4.0
b6fc1000 b7095000 r-xp /usr/lib/libedje.so.1.13.0
b7098000 b70c4000 r-xp /usr/lib/libecore.so.1.13.0
b70d5000 b72fb000 r-xp /usr/lib/libevas.so.1.13.0
b7323000 b733b000 r-xp /lib/libpthread-2.20-2014.11.so
b733f000 b76b9000 r-xp /usr/lib/libelementary.so.1.13.0
b76d9000 b76dd000 r-xp /usr/lib/libsmack.so.1.0.0
b76de000 b76e7000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b76e8000 b76eb000 r-xp /usr/lib/libdlog.so.0.0.0
b76ec000 b76f1000 r-xp /usr/lib/libbundle.so.0.1.22
b76f2000 b76f5000 r-xp /lib/libdl-2.20-2014.11.so
b76f7000 b771c000 r-xp /usr/lib/libaul.so.0.1.0
b771f000 b7721000 r-xp /usr/lib/libappsvc.so.0.1.0
b7722000 b7727000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b7728000 b772f000 r-xp /usr/lib/libappcore-efl.so.1.1
b7731000 b7736000 r-xp /usr/lib/libsys-assert.so
b7739000 b773a000 r-xp [vdso]
b773a000 b775c000 r-xp /lib/ld-2.20-2014.11.so
b775e000 b7766000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:8582)
Call Stack Count: 97
 0: (0xb6d67c0b) [/lib/libc.so.6] + 0x131c0b
 1: gl_del_cb + 0x7d (0xb379c02d) [/opt/usr/apps/org.example.example/bin/example] + 0x702d
 2: (0xb749b1f9) [/usr/lib/libelementary.so.1] + 0x15c1f9
 3: elm_genlist_clear + 0x9b (0xb749b42b) [/usr/lib/libelementary.so.1] + 0x15c42b
 4: (0xb749b669) [/usr/lib/libelementary.so.1] + 0x15c669
 5: evas_obj_smart_del + 0x99 (0xb715feb9) [/usr/lib/libevas.so.1] + 0x8aeb9
 6: (0xb71616f1) [/usr/lib/libevas.so.1] + 0x8c6f1
 7: (0xb715475b) [/usr/lib/libevas.so.1] + 0x7f75b
 8: eo_destructor + 0x99 (0xb6392079) [/usr/lib/libeo.so.1] + 0xb079
 9: (0xb75b038b) [/usr/lib/libelementary.so.1] + 0x27138b
10: eo_destructor + 0x99 (0xb6392079) [/usr/lib/libeo.so.1] + 0xb079
11: _eo_do_end + 0x15b (0xb638a5ab) [/usr/lib/libeo.so.1] + 0x35ab
12: eo_del + 0xb3 (0xb638f7a3) [/usr/lib/libeo.so.1] + 0x87a3
13: evas_object_del + 0x81 (0xb7149cc1) [/usr/lib/libevas.so.1] + 0x74cc1
14: (0xb75be245) [/usr/lib/libelementary.so.1] + 0x27f245
15: evas_obj_smart_del + 0x99 (0xb715feb9) [/usr/lib/libevas.so.1] + 0x8aeb9
16: (0xb74adbf9) [/usr/lib/libelementary.so.1] + 0x16ebf9
17: evas_obj_smart_del + 0x99 (0xb715feb9) [/usr/lib/libevas.so.1] + 0x8aeb9
18: (0xb71616f1) [/usr/lib/libevas.so.1] + 0x8c6f1
19: (0xb715475b) [/usr/lib/libevas.so.1] + 0x7f75b
20: eo_destructor + 0x99 (0xb6392079) [/usr/lib/libeo.so.1] + 0xb079
21: (0xb75b038b) [/usr/lib/libelementary.so.1] + 0x27138b
22: eo_destructor + 0x99 (0xb6392079) [/usr/lib/libeo.so.1] + 0xb079
23: _eo_do_end + 0x15b (0xb638a5ab) [/usr/lib/libeo.so.1] + 0x35ab
24: eo_del + 0xb3 (0xb638f7a3) [/usr/lib/libeo.so.1] + 0x87a3
25: evas_object_del + 0x81 (0xb7149cc1) [/usr/lib/libevas.so.1] + 0x74cc1
26: (0xb75be245) [/usr/lib/libelementary.so.1] + 0x27f245
27: evas_obj_smart_del + 0x99 (0xb715feb9) [/usr/lib/libevas.so.1] + 0x8aeb9
28: (0xb74f3706) [/usr/lib/libelementary.so.1] + 0x1b4706
29: evas_obj_smart_del + 0x99 (0xb715feb9) [/usr/lib/libevas.so.1] + 0x8aeb9
30: (0xb74e353f) [/usr/lib/libelementary.so.1] + 0x1a453f
31: evas_obj_smart_del + 0x99 (0xb715feb9) [/usr/lib/libevas.so.1] + 0x8aeb9
32: (0xb71616f1) [/usr/lib/libevas.so.1] + 0x8c6f1
33: (0xb715475b) [/usr/lib/libevas.so.1] + 0x7f75b
34: eo_destructor + 0x99 (0xb6392079) [/usr/lib/libeo.so.1] + 0xb079
35: (0xb75b038b) [/usr/lib/libelementary.so.1] + 0x27138b
36: eo_destructor + 0x99 (0xb6392079) [/usr/lib/libeo.so.1] + 0xb079
37: _eo_do_end + 0x15b (0xb638a5ab) [/usr/lib/libeo.so.1] + 0x35ab
38: eo_del + 0xb3 (0xb638f7a3) [/usr/lib/libeo.so.1] + 0x87a3
39: evas_object_del + 0x81 (0xb7149cc1) [/usr/lib/libevas.so.1] + 0x74cc1
40: (0xb75be245) [/usr/lib/libelementary.so.1] + 0x27f245
41: evas_obj_smart_del + 0x99 (0xb715feb9) [/usr/lib/libevas.so.1] + 0x8aeb9
42: (0xb74f3706) [/usr/lib/libelementary.so.1] + 0x1b4706
43: evas_obj_smart_del + 0x99 (0xb715feb9) [/usr/lib/libevas.so.1] + 0x8aeb9
44: (0xb71616f1) [/usr/lib/libevas.so.1] + 0x8c6f1
45: (0xb715475b) [/usr/lib/libevas.so.1] + 0x7f75b
46: eo_destructor + 0x99 (0xb6392079) [/usr/lib/libeo.so.1] + 0xb079
47: (0xb75b038b) [/usr/lib/libelementary.so.1] + 0x27138b
48: eo_destructor + 0x99 (0xb6392079) [/usr/lib/libeo.so.1] + 0xb079
49: _eo_do_end + 0x15b (0xb638a5ab) [/usr/lib/libeo.so.1] + 0x35ab
50: eo_del + 0xb3 (0xb638f7a3) [/usr/lib/libeo.so.1] + 0x87a3
51: evas_object_del + 0x81 (0xb7149cc1) [/usr/lib/libevas.so.1] + 0x74cc1
52: (0xb75ad9d1) [/usr/lib/libelementary.so.1] + 0x26e9d1
53: eo_destructor + 0x99 (0xb6392079) [/usr/lib/libeo.so.1] + 0xb079
54: (0xb73df6af) [/usr/lib/libelementary.so.1] + 0xa06af
55: eo_destructor + 0x99 (0xb6392079) [/usr/lib/libeo.so.1] + 0xb079
56: _eo_do_end + 0x15b (0xb638a5ab) [/usr/lib/libeo.so.1] + 0x35ab
57: (0xb73deb61) [/usr/lib/libelementary.so.1] + 0x9fb61
58: evas_obj_smart_del + 0x99 (0xb715feb9) [/usr/lib/libevas.so.1] + 0x8aeb9
59: (0xb71616f1) [/usr/lib/libevas.so.1] + 0x8c6f1
60: (0xb715475b) [/usr/lib/libevas.so.1] + 0x7f75b
61: eo_destructor + 0x99 (0xb6392079) [/usr/lib/libeo.so.1] + 0xb079
62: (0xb75b038b) [/usr/lib/libelementary.so.1] + 0x27138b
63: eo_destructor + 0x99 (0xb6392079) [/usr/lib/libeo.so.1] + 0xb079
64: _eo_do_end + 0x15b (0xb638a5ab) [/usr/lib/libeo.so.1] + 0x35ab
65: eo_del + 0xb3 (0xb638f7a3) [/usr/lib/libeo.so.1] + 0x87a3
66: evas_object_del + 0x81 (0xb7149cc1) [/usr/lib/libevas.so.1] + 0x74cc1
67: (0xb75be245) [/usr/lib/libelementary.so.1] + 0x27f245
68: evas_obj_smart_del + 0x99 (0xb715feb9) [/usr/lib/libevas.so.1] + 0x8aeb9
69: (0xb74f3706) [/usr/lib/libelementary.so.1] + 0x1b4706
70: evas_obj_smart_del + 0x99 (0xb715feb9) [/usr/lib/libevas.so.1] + 0x8aeb9
71: (0xb7439425) [/usr/lib/libelementary.so.1] + 0xfa425
72: evas_obj_smart_del + 0x99 (0xb715feb9) [/usr/lib/libevas.so.1] + 0x8aeb9
73: (0xb71616f1) [/usr/lib/libevas.so.1] + 0x8c6f1
74: (0xb715475b) [/usr/lib/libevas.so.1] + 0x7f75b
75: eo_destructor + 0x99 (0xb6392079) [/usr/lib/libeo.so.1] + 0xb079
76: (0xb75b038b) [/usr/lib/libelementary.so.1] + 0x27138b
77: eo_destructor + 0x99 (0xb6392079) [/usr/lib/libeo.so.1] + 0xb079
78: _eo_do_end + 0x15b (0xb638a5ab) [/usr/lib/libeo.so.1] + 0x35ab
79: eo_del + 0xb3 (0xb638f7a3) [/usr/lib/libeo.so.1] + 0x87a3
80: evas_object_del + 0x81 (0xb7149cc1) [/usr/lib/libevas.so.1] + 0x74cc1
81: (0xb7161087) [/usr/lib/libevas.so.1] + 0x8c087
82: (0xb7163ebb) [/usr/lib/libevas.so.1] + 0x8eebb
83: evas_obj_smart_del + 0x99 (0xb715feb9) [/usr/lib/libevas.so.1] + 0x8aeb9
84: (0xb716bf8c) [/usr/lib/libevas.so.1] + 0x96f8c
85: evas_obj_smart_del + 0x99 (0xb715feb9) [/usr/lib/libevas.so.1] + 0x8aeb9
86: (0xb71616f1) [/usr/lib/libevas.so.1] + 0x8c6f1
87: (0xb715475b) [/usr/lib/libevas.so.1] + 0x7f75b
88: eo_destructor + 0x99 (0xb6392079) [/usr/lib/libeo.so.1] + 0xb079
89: _eo_do_end + 0x15b (0xb638a5ab) [/usr/lib/libeo.so.1] + 0x35ab
90: eo_del + 0xb3 (0xb638f7a3) [/usr/lib/libeo.so.1] + 0x87a3
91: evas_object_del + 0x81 (0xb7149cc1) [/usr/lib/libevas.so.1] + 0x74cc1
92: (0xb75cff44) [/usr/lib/libelementary.so.1] + 0x290f44
93: evas_obj_smart_del + 0x99 (0xb715feb9) [/usr/lib/libevas.so.1] + 0x8aeb9
94: (0xb71616f1) [/usr/lib/libevas.so.1] + 0x8c6f1
95: (0xb715475b) [/usr/lib/libevas.so.1] + 0x7f75b
96: eo_destructor + 0x99 (0xb6392079) [/usr/lib/libeo.so.1] + 0xb079
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
ound_manager_private.c: __convert_sound_manager_error_code(74) > [sound_manager_get_volume(82)] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-04 02:51:30.416+0900 D/AUL_AMD ( 2771): amd_request.c: __request_handler(838) > __request_handler: 15
06-04 02:51:30.416+0900 D/PKGMGR_INFO( 2771): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/apps/org.tizen.lockscreen/bin/lockscreen' and package_app_info.app_disable IN ('false','False')
06-04 02:51:30.416+0900 D/PKGMGR_INFO( 2771): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/apps/org.tizen.lockscreen/bin/lockscreen' and package_app_info.app_disable IN ('false','False')
06-04 02:51:30.416+0900 D/AUL_AMD ( 2771): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 8676 is org.tizen.lockscreen
06-04 02:51:30.416+0900 D/AUL_AMD ( 2771): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 8676 : 0
06-04 02:51:30.416+0900 D/AUL     ( 2939): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 29
06-04 02:51:30.436+0900 D/INDICATOR( 2846): main.c: _property_changed_cb(432) > UNSNIFF API 2400002
06-04 02:51:30.446+0900 D/INDICATOR( 2846): util.c: util_signal_emit_by_win(116) > emission bg.opaque
06-04 02:51:30.446+0900 E/EFL     ( 2690): eo<2690> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-04 02:51:30.456+0900 D/INDICATOR( 2846): main.c: _rotate_window(229) > Indicator angle is 0 degree
06-04 02:51:30.456+0900 D/INDICATOR( 2846): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
06-04 02:51:30.456+0900 D/INDICATOR( 2846): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
06-04 02:51:30.456+0900 D/INDICATOR( 2846): main.c: _rotate_window(252) > port :: hide more icon
06-04 02:51:30.456+0900 E/EFL     ( 2690): eo<2690> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-04 02:51:30.506+0900 D/APP_CORE( 8676): appcore.c: __prt_ltime(236) > [APP 8676] first idle after reset: 475 msec
06-04 02:51:30.506+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8676): system_settings.c: system_settings_get_value_bool(502) > Enter [system_settings_get_value_bool]
06-04 02:51:30.506+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8676): system_settings.c: system_settings_get_value(404) > Enter [system_settings_get_value]
06-04 02:51:30.506+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8676): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=14
06-04 02:51:30.506+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8676): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 13, key = 14, type = 2
06-04 02:51:30.506+0900 D/SYSTEM-SETTINGS( 8676): system_setting_platform.c: system_setting_get_locale_timeformat_24hour(1564) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_get_locale_timeformat_24hour. [0m
06-04 02:51:30.506+0900 I/TIZEN_N_SYSTEM_SETTINGS( 8676): system_settings.c: system_settings_get_value_bool(512) > [SECURE_LOG] [0;36m inf (flag) value : 0 [0m
06-04 02:51:30.506+0900 I/TIZEN_N_SYSTEM_SETTINGS( 8676): system_settings.c: system_settings_get_value_bool(515) > [SECURE_LOG] [0;36m flag == 0 [0m
06-04 02:51:30.506+0900 D/LOCKSCREEN( 8676): property.c: lock_property_get_bool(105) > [lock_property_get_bool:105:D] SYSTEM SETTINGS : key(14), val(0)
06-04 02:51:30.506+0900 D/LOCKSCREEN( 8676): lock_time.c: _formatter_create(644) > [_formatter_create:644:D] TIMEFORMAT : 12
06-04 02:51:30.506+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8676): system_settings.c: system_settings_get_value_string(540) > Enter [system_settings_get_value_string]
06-04 02:51:30.506+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8676): system_settings.c: system_settings_get_value(404) > Enter [system_settings_get_value]
06-04 02:51:30.506+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8676): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=12
06-04 02:51:30.506+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8676): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 11, key = 12, type = 0
06-04 02:51:30.506+0900 D/SYSTEM-SETTINGS( 8676): system_setting_platform.c: system_setting_get_locale_country(1460) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_get_locale_country. [0m
06-04 02:51:30.506+0900 D/LOCKSCREEN( 8676): lock_time.c: _util_time_timezone_id_get(595) > [_util_time_timezone_id_get:595:D] timezone is Asia/Seoul 
06-04 02:51:30.506+0900 D/LOCKSCREEN( 8676): lock_time.c: __util_time_time_formatter_get(255) > [__util_time_time_formatter_get:255:D] best pattern : h:mm a
06-04 02:51:30.506+0900 D/LOCKSCREEN( 8676): lock_time.c: _formatter_create(659) > [_formatter_create:659:D] 1 en_US Asia/Seoul
06-04 02:51:30.506+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8676): system_settings.c: system_settings_set_changed_cb(552) > Enter [system_settings_set_changed_cb]
06-04 02:51:30.506+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8676): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=16
06-04 02:51:30.506+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8676): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 15, key = 16, type = 1
06-04 02:51:30.506+0900 D/SYSTEM-SETTINGS( 8676): system_setting_platform.c: system_setting_set_changed_callback_time_changed(1663) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_set_changed_callback_time_changed. [0m
06-04 02:51:30.506+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8676): system_settings.c: system_settings_set_changed_cb(552) > Enter [system_settings_set_changed_cb]
06-04 02:51:30.506+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8676): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=14
06-04 02:51:30.506+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8676): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 13, key = 14, type = 2
06-04 02:51:30.506+0900 D/SYSTEM-SETTINGS( 8676): system_setting_platform.c: system_setting_set_changed_callback_locale_timeformat_24hour(1608) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_set_changed_callback_locale_timeformat_24hour. [0m
06-04 02:51:30.506+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8676): system_settings.c: system_settings_set_changed_cb(552) > Enter [system_settings_set_changed_cb]
06-04 02:51:30.506+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8676): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=12
06-04 02:51:30.506+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8676): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 11, key = 12, type = 0
06-04 02:51:30.506+0900 D/SYSTEM-SETTINGS( 8676): system_setting_platform.c: system_setting_set_changed_callback_locale_country(1498) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_set_changed_callback_locale_country. [0m
06-04 02:51:30.506+0900 D/LOCKSCREEN( 8676): lock_time.c: __util_time_formatted_time_get(345) > [__util_time_formatted_time_get:345:D] time(1496512290) formatted(Sun, June 4)
06-04 02:51:30.506+0900 D/LOCKSCREEN( 8676): lock_time.c: __util_time_formatted_time_get(345) > [__util_time_formatted_time_get:345:D] time(1496512290) formatted(2:51)
06-04 02:51:30.506+0900 D/LOCKSCREEN( 8676): lock_time.c: __util_time_formatted_time_get(345) > [__util_time_formatted_time_get:345:D] time(1496512290) formatted(AM)
06-04 02:51:30.506+0900 D/LOCKSCREEN( 8676): battery.c: _battery_charger_changed_cb(239) > [_battery_charger_changed_cb:239:D] _battery_charger_changed_cb
06-04 02:51:30.506+0900 D/LOCKSCREEN( 8676): property.c: lock_property_get_bool(119) > [lock_property_get_bool:119:D] RUNTIME INFO : key(24), val(0)
06-04 02:51:30.506+0900 D/LOCKSCREEN( 8676): battery.c: _battery_charger_changed_cb(249) > [_battery_charger_changed_cb:249:D] charger connected : 0
06-04 02:51:30.506+0900 D/LOCKSCREEN( 8676): battery.c: _battery_charger_changed_cb(262) > [_battery_charger_changed_cb:262:D] hide battery inforamtion
06-04 02:51:30.506+0900 E/LOCKSCREEN( 8676): battery.c: lock_battery_hide(226) > [lock_battery_hide:226:E] Failed to remove device callback : DEVICE_CALLBCK_BATTERY_CAPACITY(-22)
06-04 02:51:30.506+0900 E/LOCKSCREEN( 8676): battery.c: lock_battery_hide(231) > [lock_battery_hide:231:E] Failed to remove device callback : DEVICE_CALLBCK_BATTERY_LEVEL(-22)
06-04 02:51:30.506+0900 D/LOCKSCREEN( 8676): property.c: lock_property_get_bool(126) > [lock_property_get_bool:126:D] vconfkey : key(memory/telephony/telephony_ready), val(1)
06-04 02:51:30.506+0900 D/LOCKSCREEN( 8676): sim_state.c: lock_sim_state_init(576) > [lock_sim_state_init:576:D] Telephony Ready : 1
06-04 02:51:30.556+0900 E/LOCKSCREEN( 8676): sim_state.c: _tel_init(398) > [_tel_init:398:E] s_info.handle[0] = VMODEM0; ptr = 0xb7fc05b8
06-04 02:51:30.556+0900 E/LOCKSCREEN( 8676): sim_state.c: _sim_callback_register(497) > [_sim_callback_register:497:E] SIM card status changed event registered
06-04 02:51:30.556+0900 E/LOCKSCREEN( 8676): sim_state.c: _sim_callback_register(520) > [_sim_callback_register:520:E] No handle [1]
06-04 02:51:30.576+0900 I/LOCKSCREEN( 8676): sim_state.c: _sim_status_print(278) > [_sim_status_print:278:I] Sim card status: TAPI_SIM_STATUS_SIM_INIT_COMPLETED
06-04 02:51:30.576+0900 I/LOCKSCREEN( 8676): sim_state.c: _sim_status_print(318) > [_sim_status_print:318:I] Sim_card_changed: 0
06-04 02:51:30.576+0900 D/CALL_MGR_CLIENT( 8676): <LIB:cm_init:370> cm_init
06-04 02:51:30.576+0900 D/CALL_MGR_CLIENT( 8676): <LIB:__cm_set_cb:280> noti_id: '/org/tizen/callmgr:org.tizen.callmgr:CallStatus'
06-04 02:51:30.576+0900 D/CALL_MGR_CLIENT( 8676): <LIB:__cm_set_cb:295> id = 3
06-04 02:51:30.576+0900 D/LOCKSCREEN( 8676): property.c: lock_property_get_bool(126) > [lock_property_get_bool:126:D] vconfkey : key(db/telephony/flight_mode), val(0)
06-04 02:51:30.586+0900 I/LOCKSCREEN( 8676): sim_state.c: _plmn_spn_network_get(199) > [_plmn_spn_network_get:199:I] PLMN/SPN - Sim 0xb7fc05b8 using SPN: TIZEN, PLMN: SDK
06-04 02:51:30.586+0900 D/LOCKSCREEN( 8676): sim_state.c: _plmn_spn_network_get(240) > [_plmn_spn_network_get:240:D] handle[0][0xb7fc05b8] service_type[7], name_option[3] >> [SDK - TIZEN]
06-04 02:51:30.596+0900 D/LOCKSCREEN( 8676): property.c: lock_property_get_bool(126) > [lock_property_get_bool:126:D] vconfkey : key(db/lockscreen/camera_quick_access), val(1)
06-04 02:51:30.606+0900 I/MINICONTROL( 8676): minicontrol-viewer.c: minicontrol_viewer_set_event_cb(100) > [SECURE_LOG] [minicontrol_viewer_set_event_cb : 100] g_minicontrol_viewer_h [(nil)]
06-04 02:51:30.606+0900 I/MINICONTROL( 8676): minicontrol-internal.c: _minictrl_dbus_sig_handle_attach(347) > [SECURE_LOG] [_minictrl_dbus_sig_handle_attach : 347] success to attach signal[minicontrol_signal_to_viewer]-[0xb3478350, (nil)]
06-04 02:51:30.606+0900 I/MINICONTROL( 8676): minicontrol-viewer.c: minicontrol_viewer_set_event_cb(125) > [SECURE_LOG] [minicontrol_viewer_set_event_cb : 125] callback[0xb34e4c30], data[(nil)]
06-04 02:51:30.616+0900 E/NOTIFICATION( 8676): notification_ipc.c: notification_ipc_is_master_ready(134) > [SECURE_LOG] [notification_ipc_is_master_ready : 134] the master has been started
06-04 02:51:30.616+0900 E/NOTIFICATION( 8676): notification_ipc.c: notification_ipc_monitor_register(1112) > [SECURE_LOG] [notification_ipc_monitor_register : 1112] register a service
06-04 02:51:30.616+0900 E/NOTIFICATION( 8676): 
06-04 02:51:30.616+0900 D/COM_CORE( 8676): com-core_thread.c: tcb_create(564) > [SECURE_LOG] [41] New TCB created: R(42), W(43)
06-04 02:51:30.616+0900 D/DATA_PROVIDER_MASTER( 2915): service_common.c: tcb_create(482) > [SECURE_LOG] Create a new service thread [50]
06-04 02:51:30.616+0900 D/COM_CORE( 8676): com-core_thread.c: client_cb(350) > [SECURE_LOG] Thread is created for 41 (server: -1)
06-04 02:51:30.616+0900 D/NOTIFICATION( 8676): notification_ipc.c: notification_ipc_monitor_register(1129) > [SECURE_LOG] [notification_ipc_monitor_register : 1129] Service register sent: 0
06-04 02:51:30.616+0900 D/NOTIFICATION( 8676): 
06-04 02:51:30.616+0900 D/DATA_PROVIDER_MASTER( 2915): service_common.c: client_packet_pump_main(353) > [SECURE_LOG] Packet received: 60 bytes
06-04 02:51:30.616+0900 D/NOTIFICATION( 8676): notification_ipc.c: notification_ipc_monitor_register(1139) > [SECURE_LOG] [notification_ipc_monitor_register : 1139] Server FD: 41
06-04 02:51:30.616+0900 D/NOTIFICATION( 8676): 
06-04 02:51:30.616+0900 D/DATA_PROVIDER_MASTER( 2915): notification_service.c: service_thread_main(864) > [SECURE_LOG] 0xb1e00540 REQ: Command: [service_register]
06-04 02:51:30.616+0900 D/DATA_PROVIDER_MASTER( 2915): service_common.c: tcb_client_type_set(1105) > [SECURE_LOG] TCB[0xb1e00540] Client type is changed to 1 from 0
06-04 02:51:30.616+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8676): system_settings.c: system_settings_get_value_bool(502) > Enter [system_settings_get_value_bool]
06-04 02:51:30.616+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8676): system_settings.c: system_settings_get_value(404) > Enter [system_settings_get_value]
06-04 02:51:30.616+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8676): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=17
06-04 02:51:30.616+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8676): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 16, key = 17, type = 2
06-04 02:51:30.616+0900 D/DATA_PROVIDER_MASTER( 2915): service_common.c: service_common_unicast_packet(1134) > [SECURE_LOG] Unicast packet
06-04 02:51:30.616+0900 D/SYSTEM-SETTINGS( 8676): system_setting_platform.c: system_setting_get_sound_lock(1678) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_get_sound_lock. [0m
06-04 02:51:30.616+0900 I/TIZEN_N_SYSTEM_SETTINGS( 8676): system_settings.c: system_settings_get_value_bool(512) > [SECURE_LOG] [0;36m inf (flag) value : 1 [0m
06-04 02:51:30.616+0900 I/TIZEN_N_SYSTEM_SETTINGS( 8676): system_settings.c: system_settings_get_value_bool(518) > [SECURE_LOG] [0;36m flag == 1 [0m
06-04 02:51:30.616+0900 D/LOCKSCREEN( 8676): property.c: lock_property_get_bool(105) > [lock_property_get_bool:105:D] SYSTEM SETTINGS : key(17), val(1)
06-04 02:51:30.616+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8676): system_settings.c: system_settings_get_value_bool(502) > Enter [system_settings_get_value_bool]
06-04 02:51:30.616+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8676): system_settings.c: system_settings_get_value(404) > Enter [system_settings_get_value]
06-04 02:51:30.616+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8676): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=19
06-04 02:51:30.616+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8676): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 18, key = 19, type = 2
06-04 02:51:30.616+0900 D/SYSTEM-SETTINGS( 8676): system_setting_platform.c: system_setting_get_sound_touch(1791) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_get_sound_touch. [0m
06-04 02:51:30.616+0900 I/TIZEN_N_SYSTEM_SETTINGS( 8676): system_settings.c: system_settings_get_value_bool(512) > [SECURE_LOG] [0;36m inf (flag) value : 1 [0m
06-04 02:51:30.616+0900 I/TIZEN_N_SYSTEM_SETTINGS( 8676): system_settings.c: system_settings_get_value_bool(518) > [SECURE_LOG] [0;36m flag == 1 [0m
06-04 02:51:30.616+0900 D/LOCKSCREEN( 8676): property.c: lock_property_get_bool(105) > [lock_property_get_bool:105:D] SYSTEM SETTINGS : key(19), val(1)
06-04 02:51:30.616+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8676): system_settings.c: system_settings_get_value_bool(502) > Enter [system_settings_get_value_bool]
06-04 02:51:30.616+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8676): system_settings.c: system_settings_get_value(404) > Enter [system_settings_get_value]
06-04 02:51:30.616+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8676): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=20
06-04 02:51:30.616+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8676): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 19, key = 20, type = 2
06-04 02:51:30.616+0900 D/SYSTEM-SETTINGS( 8676): system_setting_platform.c: system_setting_get_auto_rotation_mode(1831) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_get_auto_rotation_mode. [0m
06-04 02:51:30.616+0900 I/TIZEN_N_SYSTEM_SETTINGS( 8676): system_settings.c: system_settings_get_value_bool(512) > [SECURE_LOG] [0;36m inf (flag) value : 1 [0m
06-04 02:51:30.616+0900 I/TIZEN_N_SYSTEM_SETTINGS( 8676): system_settings.c: system_settings_get_value_bool(518) > [SECURE_LOG] [0;36m flag == 1 [0m
06-04 02:51:30.616+0900 D/LOCKSCREEN( 8676): property.c: lock_property_get_bool(105) > [lock_property_get_bool:105:D] SYSTEM SETTINGS : key(20), val(1)
06-04 02:51:30.616+0900 D/LOCKSCREEN( 8676): property.c: lock_property_register(238) > [lock_property_register:238:D] sound_lock(1), sound_touch(1), rotation(1)
06-04 02:51:30.616+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8676): system_settings.c: system_settings_set_changed_cb(552) > Enter [system_settings_set_changed_cb]
06-04 02:51:30.616+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8676): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=17
06-04 02:51:30.616+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8676): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 16, key = 17, type = 2
06-04 02:51:30.616+0900 D/SYSTEM-SETTINGS( 8676): system_setting_platform.c: system_setting_set_changed_callback_sound_lock(1691) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_set_changed_callback_sound_lock. [0m
06-04 02:51:30.616+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8676): system_settings.c: system_settings_set_changed_cb(552) > Enter [system_settings_set_changed_cb]
06-04 02:51:30.616+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8676): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=19
06-04 02:51:30.616+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8676): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 18, key = 19, type = 2
06-04 02:51:30.616+0900 D/SYSTEM-SETTINGS( 8676): system_setting_platform.c: system_setting_set_changed_callback_sound_touch(1804) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_set_changed_callback_sound_touch. [0m
06-04 02:51:30.626+0900 E/EFL     ( 8676): edje<8676> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-04 02:51:30.626+0900 E/EFL     ( 8676): By the power of Grayskull, your previous Embryo stack is now broken!
06-04 02:51:30.626+0900 E/EFL     ( 8676): edje<8676> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-04 02:51:30.626+0900 E/EFL     ( 8676): By the power of Grayskull, your previous Embryo stack is now broken!
06-04 02:51:30.626+0900 E/EFL     ( 8676): edje<8676> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-04 02:51:30.626+0900 E/EFL     ( 8676): By the power of Grayskull, your previous Embryo stack is now broken!
06-04 02:51:30.626+0900 E/EFL     ( 8676): edje<8676> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-04 02:51:30.626+0900 E/EFL     ( 8676): By the power of Grayskull, your previous Embryo stack is now broken!
06-04 02:51:30.626+0900 E/LOCKSCREEN( 8676): missed_event.c: _noti_changed_cb(664) > [_noti_changed_cb:664:E] delete missed event item(call)
06-04 02:51:30.626+0900 E/LOCKSCREEN( 8676): contextual_event.c: lock_contextual_event_page_get(388) > [lock_contextual_event_page_get:388:E] (!s_info.box) -> lock_contextual_event_page_get() return
06-04 02:51:30.626+0900 E/LOCKSCREEN( 8676): contextual_event.c: lock_contextual_event_missed_event_item_del(574) > [lock_contextual_event_missed_event_item_del:574:E] (!page) -> lock_contextual_event_missed_event_item_del() return
06-04 02:51:30.626+0900 E/LOCKSCREEN( 8676): missed_event.c: _noti_changed_cb(669) > [_noti_changed_cb:669:E] delete missed event item(msg)
06-04 02:51:30.626+0900 E/LOCKSCREEN( 8676): contextual_event.c: lock_contextual_event_page_get(388) > [lock_contextual_event_page_get:388:E] (!s_info.box) -> lock_contextual_event_page_get() return
06-04 02:51:30.626+0900 E/LOCKSCREEN( 8676): contextual_event.c: lock_contextual_event_missed_event_item_del(574) > [lock_contextual_event_missed_event_item_del:574:E] (!page) -> lock_contextual_event_missed_event_item_del() return
06-04 02:51:30.716+0900 D/APP_CORE( 8676): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1200007 fully_obscured 0
06-04 02:51:30.716+0900 D/APP_CORE( 8676): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
06-04 02:51:30.716+0900 D/APP_CORE( 8676): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
06-04 02:51:30.716+0900 W/APP_CORE( 8676): appcore-efl.c: __visibility_cb(983) > LCD status is off, skip the AE_RESUME event
06-04 02:51:30.716+0900 D/APP_CORE( 8582): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2400002 fully_obscured 1
06-04 02:51:30.716+0900 D/APP_CORE( 8582): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
06-04 02:51:30.716+0900 D/APP_CORE( 8582): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
06-04 02:51:30.716+0900 I/APP_CORE( 8582): appcore-efl.c: __do_app(496) > [APP 8582] Event: PAUSE State: RUNNING
06-04 02:51:30.716+0900 D/APP_CORE( 8582): appcore-efl.c: __do_app(565) > [APP 8582] PAUSE
06-04 02:51:30.716+0900 I/CAPI_APPFW_APPLICATION( 8582): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
06-04 02:51:30.716+0900 D/APP_CORE( 8582): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-04 02:51:30.716+0900 E/APP_CORE( 8582): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-04 02:51:30.716+0900 D/AUL_AMD ( 2771): amd_launch.c: __e17_status_handler(2891) > pid(8676) status(3)
06-04 02:51:30.716+0900 D/AUL_AMD ( 2771): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
06-04 02:51:30.716+0900 W/AUL_AMD ( 2771): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-04 02:51:30.716+0900 W/AUL_AMD ( 2771): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
06-04 02:51:30.716+0900 D/AUL_AMD ( 2771): amd_status.c: _status_update_app_info_list(456) > pid(8676) status(3)
06-04 02:51:30.716+0900 D/AUL_AMD ( 2771): amd_status.c: _status_update_app_info_list(468) > pid(8676) appid(org.tizen.lockscreen) pkgid(org.tizen.lockscreen) status(3)
06-04 02:51:30.716+0900 D/AUL     ( 2771): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.tizen.lockscreen
06-04 02:51:30.716+0900 W/AUL     ( 2771): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 8676, appid: org.tizen.lockscreen, status: fg
06-04 02:51:30.716+0900 D/RESOURCED( 2841): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 8676
06-04 02:51:30.716+0900 D/RESOURCED( 2841): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 8676, appname = org.tizen.lockscreen, pkgname = org.tizen.lockscreen
06-04 02:51:30.716+0900 D/RESOURCED( 2841): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 8676, appname = org.tizen.lockscreen
06-04 02:51:30.716+0900 D/RESOURCED( 2841): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 8676
06-04 02:51:31.156+0900 D/AUL_PAD ( 2913): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
06-04 02:51:31.156+0900 D/AUL_PAD ( 8700): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
06-04 02:51:31.166+0900 D/AUL_PAD ( 2913): sigchild.h: __send_app_launch_signal(131) > send launch signal done
06-04 02:51:31.176+0900 E/RESOURCED( 2841): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.661
06-04 02:51:31.196+0900 D/STARTER ( 2838): process_mgr.c: _set_lock_priority_cb(327) > [_set_lock_priority_cb:327] error : 1
06-04 02:51:31.656+0900 D/AUL_AMD ( 2771): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.tizen.lockscreen /usr/apps/org.tizen.lockscreen/bin/lockscreen
06-04 02:51:31.656+0900 D/RUA     ( 2771): rua.c: rua_add_history(179) > rua_add_history start
06-04 02:51:31.656+0900 D/RUA     ( 2771): rua.c: rua_add_history(247) > rua_add_history ok
06-04 02:51:32.216+0900 D/AUL_PAD ( 8700): launchpad_loader.c: main(588) > sleeping 1 sec...
06-04 02:51:32.216+0900 D/AUL_PAD ( 8700): preload.h: __preload_init(52) > max_cmdline_size = 1053
06-04 02:51:32.216+0900 D/AUL_PAD ( 8700): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b867c760
06-04 02:51:32.216+0900 D/AUL_PAD ( 8700): preload.h: __preload_init(69) > get pre-initialization function
06-04 02:51:32.216+0900 D/AUL_PAD ( 8700): preload.h: __preload_init(73) > get shutdown function
06-04 02:51:32.216+0900 D/AUL_PAD ( 8700): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b867ca40
06-04 02:51:32.216+0900 D/AUL_PAD ( 8700): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b867e640
06-04 02:51:32.216+0900 D/AUL_PAD ( 8700): preload.h: __preload_init(69) > get pre-initialization function
06-04 02:51:32.216+0900 D/AUL_PAD ( 8700): preload.h: __preload_init(73) > get shutdown function
06-04 02:51:32.216+0900 D/AUL_PAD ( 8700): preexec.h: __preexec_init(76) > preexec start
06-04 02:51:32.216+0900 D/AUL_PAD ( 8700): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
06-04 02:51:32.216+0900 D/AUL     ( 8700): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
06-04 02:51:32.216+0900 D/AUL     ( 8700): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
06-04 02:51:32.216+0900 D/AUL     ( 8700): process_pool.c: __connect_to_launchpad(132) > send(8700) : 4
06-04 02:51:32.216+0900 D/AUL_PAD ( 2913): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
06-04 02:51:32.216+0900 D/AUL_PAD ( 2913): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
06-04 02:51:32.216+0900 D/AUL_PAD ( 2913): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-04 02:51:32.216+0900 D/AUL_PAD ( 2913): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-04 02:51:32.216+0900 D/AUL_PAD ( 2913): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-04 02:51:32.216+0900 D/AUL_PAD ( 2913): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-04 02:51:32.216+0900 D/AUL_PAD ( 2913): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-04 02:51:32.216+0900 D/AUL_PAD ( 2913): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
06-04 02:51:32.216+0900 D/AUL_PAD ( 2913): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 8700
06-04 02:51:32.216+0900 D/AUL     ( 8700): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
06-04 02:51:32.276+0900 D/STARTER ( 2838): lock_mgr.c: _lock_create_cb(306) > [_lock_create_cb:306] lockw(0xb870d8a8), lock_pid(8676)
06-04 02:51:32.276+0900 E/STARTER ( 2838): window_mgr.c: window_mgr_set_effect(239) > [window_mgr_set_effect:239] (ret != 1) -> window_mgr_set_effect() return
06-04 02:51:32.286+0900 D/AUL_PAD ( 8700): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
06-04 02:51:32.296+0900 D/AUL_PAD ( 8700): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
06-04 02:51:32.296+0900 D/AUL_PAD ( 8700): launchpad_loader.c: main(693) > [candidate] ecore handler add
06-04 02:51:32.296+0900 D/AUL_PAD ( 8700): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
06-04 02:51:35.726+0900 D/APP_CORE( 8582): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
06-04 02:51:35.726+0900 I/APP_CORE( 8582): appcore-efl.c: __do_app(496) > [APP 8582] Event: MEM_FLUSH State: PAUSED
06-04 02:51:35.726+0900 D/APP_CORE( 8582): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
06-04 02:51:35.726+0900 D/APP_CORE( 8582): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 8582
06-04 02:51:35.726+0900 D/APP_CORE( 8582): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
06-04 02:51:35.726+0900 D/RESOURCED( 2841): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 8582
06-04 02:51:40.636+0900 I/LOCKSCREEN( 8676): lockscreen.c: _lcd_off_timer_cb(98) > [_lcd_off_timer_cb:98:I] lcd off : 10sec
06-04 02:51:49.406+0900 E/CAPI_NETWORK_WIFI( 2846): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-04 02:51:49.406+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
06-04 02:51:49.406+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-04 02:51:49.406+0900 E/INDICATOR( 2846): 
06-04 02:52:00.526+0900 D/LOCKSCREEN( 8676): lock_time.c: __util_time_formatted_time_get(345) > [__util_time_formatted_time_get:345:D] time(1496512320) formatted(Sun, June 4)
06-04 02:52:00.526+0900 D/LOCKSCREEN( 8676): lock_time.c: __util_time_formatted_time_get(345) > [__util_time_formatted_time_get:345:D] time(1496512320) formatted(2:52)
06-04 02:52:00.526+0900 D/LOCKSCREEN( 8676): lock_time.c: __util_time_formatted_time_get(345) > [__util_time_formatted_time_get:345:D] time(1496512320) formatted(AM)
06-04 02:52:09.426+0900 E/CAPI_NETWORK_WIFI( 2846): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-04 02:52:09.426+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
06-04 02:52:09.426+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-04 02:52:09.426+0900 E/INDICATOR( 2846): 
06-04 02:52:20.176+0900 D/RESOURCED( 2841): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
06-04 02:52:20.176+0900 I/RESOURCED( 2841): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
06-04 02:52:20.176+0900 D/RESOURCED( 2841): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
06-04 02:52:20.176+0900 I/RESOURCED( 2841): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
06-04 02:52:29.426+0900 E/CAPI_NETWORK_WIFI( 2846): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-04 02:52:29.426+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
06-04 02:52:29.426+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-04 02:52:29.426+0900 E/INDICATOR( 2846): 
06-04 02:52:49.455+0900 E/CAPI_NETWORK_WIFI( 2846): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-04 02:52:49.455+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
06-04 02:52:49.455+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-04 02:52:49.455+0900 E/INDICATOR( 2846): 
06-04 02:53:00.525+0900 D/LOCKSCREEN( 8676): lock_time.c: __util_time_formatted_time_get(345) > [__util_time_formatted_time_get:345:D] time(1496512380) formatted(Sun, June 4)
06-04 02:53:00.525+0900 D/LOCKSCREEN( 8676): lock_time.c: __util_time_formatted_time_get(345) > [__util_time_formatted_time_get:345:D] time(1496512380) formatted(2:53)
06-04 02:53:00.525+0900 D/LOCKSCREEN( 8676): lock_time.c: __util_time_formatted_time_get(345) > [__util_time_formatted_time_get:345:D] time(1496512380) formatted(AM)
06-04 02:53:09.485+0900 E/CAPI_NETWORK_WIFI( 2846): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-04 02:53:09.485+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
06-04 02:53:09.485+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-04 02:53:09.485+0900 E/INDICATOR( 2846): 
06-04 02:53:20.195+0900 D/RESOURCED( 2841): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
06-04 02:53:20.195+0900 I/RESOURCED( 2841): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
06-04 02:53:20.195+0900 D/RESOURCED( 2841): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
06-04 02:53:20.195+0900 I/RESOURCED( 2841): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
06-04 02:53:20.195+0900 I/RESOURCED( 2841): logging.c: logging_save_to_storage(978) > storage cache is empty
06-04 02:53:29.505+0900 E/CAPI_NETWORK_WIFI( 2846): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-04 02:53:29.505+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
06-04 02:53:29.505+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-04 02:53:29.505+0900 E/INDICATOR( 2846): 
06-04 02:53:49.525+0900 E/CAPI_NETWORK_WIFI( 2846): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-04 02:53:49.525+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
06-04 02:53:49.525+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-04 02:53:49.525+0900 E/INDICATOR( 2846): 
06-04 02:54:00.544+0900 D/LOCKSCREEN( 8676): lock_time.c: __util_time_formatted_time_get(345) > [__util_time_formatted_time_get:345:D] time(1496512440) formatted(Sun, June 4)
06-04 02:54:00.544+0900 D/LOCKSCREEN( 8676): lock_time.c: __util_time_formatted_time_get(345) > [__util_time_formatted_time_get:345:D] time(1496512440) formatted(2:54)
06-04 02:54:00.544+0900 D/LOCKSCREEN( 8676): lock_time.c: __util_time_formatted_time_get(345) > [__util_time_formatted_time_get:345:D] time(1496512440) formatted(AM)
06-04 02:54:09.554+0900 E/CAPI_NETWORK_WIFI( 2846): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-04 02:54:09.554+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
06-04 02:54:09.554+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-04 02:54:09.554+0900 E/INDICATOR( 2846): 
06-04 02:54:20.194+0900 D/RESOURCED( 2841): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
06-04 02:54:20.194+0900 I/RESOURCED( 2841): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
06-04 02:54:20.194+0900 D/RESOURCED( 2841): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
06-04 02:54:20.194+0900 I/RESOURCED( 2841): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
06-04 02:54:29.574+0900 E/CAPI_NETWORK_WIFI( 2846): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-04 02:54:29.574+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
06-04 02:54:29.574+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-04 02:54:29.574+0900 E/INDICATOR( 2846): 
06-04 02:54:49.604+0900 E/CAPI_NETWORK_WIFI( 2846): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-04 02:54:49.604+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
06-04 02:54:49.604+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-04 02:54:49.604+0900 E/INDICATOR( 2846): 
06-04 02:55:00.554+0900 D/LOCKSCREEN( 8676): lock_time.c: __util_time_formatted_time_get(345) > [__util_time_formatted_time_get:345:D] time(1496512500) formatted(Sun, June 4)
06-04 02:55:00.554+0900 D/LOCKSCREEN( 8676): lock_time.c: __util_time_formatted_time_get(345) > [__util_time_formatted_time_get:345:D] time(1496512500) formatted(2:55)
06-04 02:55:00.554+0900 D/LOCKSCREEN( 8676): lock_time.c: __util_time_formatted_time_get(345) > [__util_time_formatted_time_get:345:D] time(1496512500) formatted(AM)
06-04 02:55:09.614+0900 E/CAPI_NETWORK_WIFI( 2846): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-04 02:55:09.614+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
06-04 02:55:09.614+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-04 02:55:09.614+0900 E/INDICATOR( 2846): 
06-04 02:55:20.193+0900 D/RESOURCED( 2841): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
06-04 02:55:20.193+0900 I/RESOURCED( 2841): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
06-04 02:55:20.193+0900 D/RESOURCED( 2841): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
06-04 02:55:20.193+0900 I/RESOURCED( 2841): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
06-04 02:55:29.623+0900 E/CAPI_NETWORK_WIFI( 2846): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-04 02:55:29.623+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
06-04 02:55:29.623+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-04 02:55:29.623+0900 E/INDICATOR( 2846): 
06-04 02:55:49.653+0900 E/CAPI_NETWORK_WIFI( 2846): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-04 02:55:49.653+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
06-04 02:55:49.653+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-04 02:55:49.653+0900 E/INDICATOR( 2846): 
06-04 02:56:00.563+0900 D/LOCKSCREEN( 8676): lock_time.c: __util_time_formatted_time_get(345) > [__util_time_formatted_time_get:345:D] time(1496512560) formatted(Sun, June 4)
06-04 02:56:00.563+0900 D/LOCKSCREEN( 8676): lock_time.c: __util_time_formatted_time_get(345) > [__util_time_formatted_time_get:345:D] time(1496512560) formatted(2:56)
06-04 02:56:00.563+0900 D/LOCKSCREEN( 8676): lock_time.c: __util_time_formatted_time_get(345) > [__util_time_formatted_time_get:345:D] time(1496512560) formatted(AM)
06-04 02:56:04.513+0900 E/PKGMGR_SERVER( 8749): pkgmgr-server.c: main(2209) > package manager server start
06-04 02:56:04.513+0900 D/PKGMGR  ( 8749): comm_pkg_mgr_server.c: pkg_mgr_server_gdbus_init(405) > initialize_gdbus Enter
06-04 02:56:04.513+0900 D/PKGMGR  ( 8749): comm_pkg_mgr_server.c: pkg_mgr_server_gdbus_init(423) > initialize_gdbus Exit
06-04 02:56:04.523+0900 D/PKGMGR  ( 8749): comm_pkg_mgr_server.c: on_bus_acquired(376) > on_bus_acquired
06-04 02:56:04.523+0900 D/PKGMGR  ( 8749): comm_pkg_mgr_server.c: on_bus_acquired(400) > on_bus_acquired done
06-04 02:56:04.523+0900 D/PKGMGR  ( 8749): comm_pkg_mgr_server.c: pkgmgr_request(145) > Called
06-04 02:56:04.523+0900 D/PKGMGR  ( 8749): comm_pkg_mgr_server.c: pkgmgr_request(164) > sender_name: :1.664
06-04 02:56:04.523+0900 D/PKGMGR  ( 8749): comm_pkg_mgr_server.c: pkg_mgr_get_sender_pid(79) > zone pid : 8747
06-04 02:56:04.523+0900 D/PKGMGR  ( 8749): comm_pkg_mgr_server.c: pkgmgr_request(166) > sender_pid: 8747
06-04 02:56:04.523+0900 D/PKGMGR  ( 8749): comm_pkg_mgr_server.c: pkgmgr_request(175) > [SECURE_LOG] Call request callback(obj, org.example.example_-70308434, 14, tpk, org.example.example, , host)
06-04 02:56:04.523+0900 D/PKGMGR_SERVER( 8749): pkgmgr-server.c: req_cb(625) > [SECURE_LOG] >> in callback >> Got request: [org.example.example_-70308434] [14] [tpk] [org.example.example] [] [] [host]
06-04 02:56:04.523+0900 D/PKGMGR_SERVER( 8749): pkgmgr-server.c: req_cb(646) > req_type=(14)  backend_flag=(0) zone(host)
06-04 02:56:04.523+0900 D/PKGMGR_SERVER( 8749): pkgmgr-server.c: queue_job(1880) > target zone(host, host)
06-04 02:56:04.523+0900 D/PKGMGR_SERVER( 8749): pkgmgr-server.c: queue_job(1884) > child forked [8752] for request type [14]
06-04 02:56:04.523+0900 D/PKGMGR_SERVER( 8749): pkgmgr-server.c: queue_job(2126) > parent exit
06-04 02:56:04.523+0900 D/PKGMGR_SERVER( 8752): pkgmgr-server.c: queue_job(1884) > child forked [0] for request type [14]
06-04 02:56:04.523+0900 D/PKGMGR_SERVER( 8752): pkgmgr-server.c: queue_job(2057) > kill/check request
06-04 02:56:04.523+0900 D/PKGMGR  ( 8747): pkgmgr.c: __check_sync_process(868) > info_file file is generated, result = 0
06-04 02:56:04.523+0900 D/PKGMGR  ( 8747): . 
06-04 02:56:04.523+0900 E/PKGMGR  ( 8747): pkgmgr.c: __check_sync_process(884) > file is can not remove[/tmp/org.example.example, -1]
06-04 02:56:04.533+0900 D/PKGMGR_SERVER( 8752): pkgmgr-server.c: __pkgcmd_app_cb(1458) > sub_cmd(kill), zone_name(host)
06-04 02:56:04.533+0900 D/AUL     ( 8752): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(14)
06-04 02:56:04.533+0900 D/AUL_AMD ( 2771): amd_request.c: __request_handler(838) > __request_handler: 14
06-04 02:56:04.533+0900 D/AUL_AMD ( 2771): amd_status.c: _status_app_is_running_from_cache(836) > is_running hit cache, return immediately
06-04 02:56:04.533+0900 D/AUL_AMD ( 2771): amd_request.c: __request_handler(1028) > [SECURE_LOG] APP_IS_RUNNING : org.example.example : 8582
06-04 02:56:04.533+0900 W/AUL_AMD ( 2771): amd_request.c: __send_result_to_client(150) > __send_result_to_client, pid: 8582
06-04 02:56:04.533+0900 D/AUL_AMD ( 2771): amd_request.c: __request_handler(838) > __request_handler: 12
06-04 02:56:04.533+0900 D/AUL     ( 8752): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 364
06-04 02:56:04.533+0900 D/AUL     ( 8752): launch.c: app_request_to_launchpad(396) > [SECURE_LOG] launch request : 8582
06-04 02:56:04.533+0900 D/AUL     ( 8752): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(5)
06-04 02:56:04.533+0900 D/AUL_AMD ( 2771): amd_request.c: __request_handler(838) > __request_handler: 5
06-04 02:56:04.533+0900 D/AUL_AMD ( 2771): amd_appinfo.c: appinfo_set_value(905) > [SECURE_LOG] org.example.example : norestart : norestart
06-04 02:56:04.543+0900 D/AUL_AMD ( 2771): amd_request.c: __app_process_by_pid(279) > [SECURE_LOG] __app_process_by_pid, pid: 8582, 
06-04 02:56:04.543+0900 D/AUL     ( 2771): app_sock.c: __app_send_raw_with_delay_reply(455) > pid(8582) : cmd(4)
06-04 02:56:04.543+0900 D/AUL_AMD ( 2771): amd_launch.c: _term_app(1076) > term done
06-04 02:56:04.543+0900 D/AUL_AMD ( 2771): amd_launch.c: __set_reply_handler(1015) > listen fd : 31, send fd : 30
06-04 02:56:04.543+0900 D/APP_CORE( 8582): appcore.c: __aul_handler(632) > [APP 8582]     AUL event: AUL_TERMINATE
06-04 02:56:04.543+0900 I/APP_CORE( 8582): appcore-efl.c: __do_app(496) > [APP 8582] Event: TERMINATE State: PAUSED
06-04 02:56:04.543+0900 D/APP_CORE( 8582): appcore-efl.c: __do_app(517) > [APP 8582] TERMINATE
06-04 02:56:04.543+0900 W/AUL_AMD ( 2771): amd_launch.c: __reply_handler(913) > listen fd(31) , send fd(30), pid(8582), cmd(4)
06-04 02:56:04.543+0900 D/RESOURCED( 2841): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 8582
06-04 02:56:04.543+0900 D/AUL     ( 8752): launch.c: app_request_to_launchpad(425) > launch request result : 0
06-04 02:56:04.543+0900 D/AUL     ( 8752): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(14)
06-04 02:56:04.543+0900 D/AUL_AMD ( 2771): amd_request.c: __request_handler(838) > __request_handler: 14
06-04 02:56:04.543+0900 D/AUL_AMD ( 2771): amd_status.c: _status_app_is_running_from_cache(836) > is_running hit cache, return immediately
06-04 02:56:04.543+0900 D/AUL_AMD ( 2771): amd_request.c: __request_handler(1028) > [SECURE_LOG] APP_IS_RUNNING : org.example.example : 8582
06-04 02:56:04.543+0900 W/AUL_AMD ( 2771): amd_request.c: __send_result_to_client(150) > __send_result_to_client, pid: 8582
06-04 02:56:04.543+0900 D/AUL     ( 8582): app_sock.c: __app_send_raw_with_noreply(384) > pid(-2) : cmd(22)
06-04 02:56:04.543+0900 D/AUL_AMD ( 2771): amd_request.c: __request_handler(838) > __request_handler: 22
06-04 02:56:04.543+0900 W/AUL_AMD ( 2771): amd_request.c: __request_handler(1056) > app status : 5
06-04 02:56:04.543+0900 D/AUL_AMD ( 2771): amd_status.c: _status_update_app_info_list(456) > pid(8582) status(5)
06-04 02:56:04.543+0900 D/AUL_AMD ( 2771): amd_status.c: _status_update_app_info_list(468) > pid(8582) appid(org.example.example) pkgid(org.example.example) status(5)
06-04 02:56:04.543+0900 D/AUL     ( 8582): app_sock.c: __app_send_raw_with_noreply(384) > pid(-2) : cmd(22)
06-04 02:56:04.543+0900 D/AUL_AMD ( 2771): amd_request.c: __request_handler(838) > __request_handler: 22
06-04 02:56:04.543+0900 W/AUL_AMD ( 2771): amd_request.c: __request_handler(1056) > app status : 5
06-04 02:56:04.543+0900 D/AUL_AMD ( 2771): amd_status.c: _status_update_app_info_list(456) > pid(8582) status(5)
06-04 02:56:04.543+0900 D/AUL_AMD ( 2771): amd_status.c: _status_update_app_info_list(468) > pid(8582) appid(org.example.example) pkgid(org.example.example) status(5)
06-04 02:56:04.543+0900 D/APP_CORE( 8582): appcore.c: _appcore_fini_suspend_dbus_handler(944) > [__SUSPEND__] suspend signal finalized
06-04 02:56:04.543+0900 I/CAPI_APPFW_APPLICATION( 8582): app_main.c: _ui_app_appcore_terminate(662) > app_appcore_terminate
06-04 02:56:04.543+0900 E/EFL     ( 8582): eo<8582> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0x8001a0d1 is not pointing to a valid object. Maybe it has already been freed.
06-04 02:56:04.543+0900 E/EFL     ( 8582): eo<8582> lib/eo/eo.c:485 _eo_do_internal() Obj (0x8001a0d1) is an invalid ref.
06-04 02:56:04.543+0900 D/AUL_AMD ( 2771): amd_launch.c: __e17_status_handler(2891) > pid(2863) status(3)
06-04 02:56:04.543+0900 D/AUL_AMD ( 2771): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
06-04 02:56:04.543+0900 W/AUL_AMD ( 2771): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-04 02:56:04.543+0900 W/AUL_AMD ( 2771): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
06-04 02:56:04.543+0900 D/AUL_AMD ( 2771): amd_status.c: _status_update_app_info_list(456) > pid(2863) status(3)
06-04 02:56:04.543+0900 D/AUL_AMD ( 2771): amd_status.c: _status_update_app_info_list(468) > pid(2863) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(3)
06-04 02:56:04.543+0900 D/AUL     ( 2771): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.tizen.homescreen
06-04 02:56:04.543+0900 W/AUL     ( 2771): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2863, appid: org.tizen.homescreen, status: fg
06-04 02:56:04.543+0900 D/RESOURCED( 2841): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 2863
06-04 02:56:04.543+0900 D/RESOURCED( 2841): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 2863, appname = org.tizen.homescreen, pkgname = org.tizen.homescreen
06-04 02:56:04.543+0900 D/RESOURCED( 2841): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 2863, appname = org.tizen.homescreen
06-04 02:56:04.543+0900 D/RESOURCED( 2841): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 2863
06-04 02:56:04.543+0900 E/E17     ( 2690): e_border.c: e_border_show(2088) > BD_SHOW(0x01600002)
06-04 02:56:04.553+0900 E/E17     ( 2690): e_border.c: e_border_hide(2248) > BD_HIDE(0x02400002), visible:1
06-04 02:56:04.553+0900 I/tag     ( 8582): abc
06-04 02:56:04.593+0900 W/CRASH_MANAGER( 8754): worker.c: worker_job(1204) > 1108582657861149651256
