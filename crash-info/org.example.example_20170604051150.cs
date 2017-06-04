S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 20201
Date: 2017-06-04 05:11:50+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0x00000008, esi = 0xbfc9cda0
ebp = 0xbfc9cdf8, esp = 0xbfc9cd9c
eax = 0xb37c3b83, ebx = 0xb37c6000
ecx = 0x00000050, edx = 0x00000000
eip = 0xb6d8ac0b

Memory Information
MemTotal:      123 KB
MemFree:        15 KB
Buffers:        11 KB
Cached:     176988 KB
VmPeak:     121292 KB
VmSize:     119784 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       34076 KB
VmRSS:       32604 KB
VmData:      50168 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34636 KB
VmPTE:         108 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 20201 TID = 20201
20201 20204 20365 20370 

Maps Information
b1800000 b1807000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b180a000 b1822000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b1823000 b182a000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b18a7000 b18ab000 r-xp /usr/lib/elementary/modules/datetime_input_spinner/v-1.13.0/module.so
b2b80000 b2b8a000 r-xp /usr/lib/libfeedback.so.0.1.4
b2b90000 b2b9c000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2b9d000 b2bbe000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2bc3000 b2bc4000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2bc5000 b2bca000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2bcb000 b2bcc000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2bcd000 b2bcf000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2bd0000 b2bd2000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2bd3000 b2bdf000 r-xp /usr/lib/libdrm.so.2.4.0
b2be0000 b2be3000 r-xp /usr/lib/libdri2.so.0.0.0
b2be4000 b2bee000 r-xp /usr/lib/libtbm.so.1.0.0
b2bef000 b2c04000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2c05000 b2c17000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b3419000 b344a000 r-xp /usr/lib/libidn.so.11.5.44
b344b000 b346d000 r-xp /usr/lib/libnghttp2.so.5.4.0
b346e000 b347e000 r-xp /usr/lib/libcares.so.2.1.0
b347f000 b3488000 r-xp /usr/lib/libeventsystem.so.0.0.1
b3489000 b3492000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3493000 b350a000 r-xp /usr/lib/libcurl.so.4.3.0
b350c000 b351e000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b351f000 b3540000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b3547000 b3548000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3549000 b354a000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b354b000 b354e000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b354f000 b3552000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b365a000 b3660000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3661000 b37a5000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b37b6000 b37b7000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b37b8000 b37c5000 r-xp /opt/usr/apps/org.example.example/bin/example
b37c7000 b3800000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b4203000 b420e000 r-xp /lib/libnss_files-2.20-2014.11.so
b4210000 b421b000 r-xp /lib/libnss_nis-2.20-2014.11.so
b421d000 b4234000 r-xp /lib/libnsl-2.20-2014.11.so
b4238000 b4240000 r-xp /lib/libnss_compat-2.20-2014.11.so
b4242000 b4266000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b4267000 b4268000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b4269000 b426c000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b426d000 b4274000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4275000 b427f000 r-xp /usr/lib/libsensord-share.so
b4280000 b429c000 r-xp /usr/lib/libsensor.so.1.2.0
b429e000 b42a7000 r-xp /usr/lib/libappcore-common.so.1.1
b42aa000 b42ac000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b42c1000 b42c3000 r-xp /usr/lib/libXau.so.6.0.0
b42c4000 b42e6000 r-xp /usr/lib/libxcb.so.1.1.0
b42e8000 b42f1000 r-xp /lib/libcrypt-2.20-2014.11.so
b431a000 b431c000 r-xp /usr/lib/libiri.so
b431d000 b4343000 r-xp /lib/libexpat.so.1.5.2
b4345000 b43b0000 r-xp /usr/lib/libssl.so.1.0.0
b43b6000 b43c2000 r-xp /usr/lib/libethumb.so.1.13.0
b43c3000 b43c7000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b43c8000 b4619000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b94000 b5ba4000 r-xp /usr/lib/libXi.so.6.1.0
b5ba5000 b5ba7000 r-xp /usr/lib/libXgesture.so.7.0.0
b5ba8000 b5bae000 r-xp /usr/lib/libXtst.so.6.1.0
b5baf000 b5bb9000 r-xp /usr/lib/libXrender.so.1.3.0
b5bba000 b5bc3000 r-xp /usr/lib/libXrandr.so.2.2.0
b5bc5000 b5bc7000 r-xp /usr/lib/libXinerama.so.1.0.0
b5bc8000 b5bcd000 r-xp /usr/lib/libXfixes.so.3.1.0
b5bce000 b5be0000 r-xp /usr/lib/libXext.so.6.4.0
b5be1000 b5be3000 r-xp /usr/lib/libXdamage.so.1.1.0
b5be4000 b5be6000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5be8000 b5d2a000 r-xp /usr/lib/libX11.so.6.3.0
b5d2e000 b5d38000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d39000 b5d4f000 r-xp /usr/lib/libudev.so.1.6.0
b5d52000 b5d56000 r-xp /lib/libattr.so.1.1.0
b5d57000 b5d86000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d88000 b5d8e000 r-xp /usr/lib/libffi.so.6.0.2
b5d8f000 b5db2000 r-xp /lib/libz.so.1.2.8
b5db3000 b5db6000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5db7000 b5f13000 r-xp /usr/lib/libxml2.so.2.9.2
b5f19000 b6000000 r-xp /usr/lib/libstdc++.so.6.0.20
b600d000 b6010000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6011000 b6033000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6034000 b6048000 r-xp /lib/libresolv-2.20-2014.11.so
b604c000 b6070000 r-xp /usr/lib/liblzma.so.5.0.3
b6071000 b6073000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b6075000 b607f000 r-xp /usr/lib/libembryo.so.1.13.0
b6080000 b60a9000 r-xp /usr/lib/libpng12.so.0.50.0
b60aa000 b60f3000 r-xp /usr/lib/libjpeg.so.8.0.2
b6104000 b610b000 r-xp /lib/librt-2.20-2014.11.so
b610d000 b612c000 r-xp /usr/lib/libector.so.1.13.0
b612f000 b615c000 r-xp /usr/lib/liblua-5.1.so
b615d000 b61ed000 r-xp /usr/lib/libfreetype.so.6.11.3
b61f1000 b622f000 r-xp /usr/lib/libfontconfig.so.1.8.0
b6230000 b6246000 r-xp /usr/lib/libfribidi.so.0.3.1
b6247000 b62a0000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b62a3000 b62ee000 r-xp /lib/libm-2.20-2014.11.so
b62f0000 b6302000 r-xp /usr/lib/libeio.so.1.13.0
b6303000 b6306000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b6307000 b630d000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b630e000 b6331000 r-xp /usr/lib/libefreet.so.1.13.0
b6334000 b635f000 r-xp /usr/lib/libeldbus.so.1.13.0
b6360000 b6394000 r-xp /usr/lib/libecore_con.so.1.13.0
b6396000 b639f000 r-xp /usr/lib/libecore_imf.so.1.13.0
b63a0000 b63a9000 r-xp /usr/lib/libethumb_client.so.1.13.0
b63aa000 b63bd000 r-xp /usr/lib/libeo.so.1.13.0
b63bf000 b63d2000 r-xp /usr/lib/libecore_input.so.1.13.0
b63d3000 b63da000 r-xp /usr/lib/libecore_file.so.1.13.0
b63db000 b63fe000 r-xp /usr/lib/libecore_evas.so.1.13.0
b63ff000 b642b000 r-xp /usr/lib/libeet.so.1.13.0
b6434000 b649f000 r-xp /usr/lib/libeina.so.1.13.0
b64a2000 b64b9000 r-xp /usr/lib/libefl.so.1.13.0
b64bb000 b6622000 r-xp /usr/lib/libicuuc.so.51.1
b6630000 b683c000 r-xp /usr/lib/libicui18n.so.51.1
b6844000 b6893000 r-xp /usr/lib/libecore_x.so.1.13.0
b6895000 b68af000 r-xp /lib/libgcc_s-4.9.so.1
b68b1000 b68b5000 r-xp /lib/libcap.so.2.21
b68b6000 b68fc000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b68fd000 b6904000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6906000 b6958000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b695a000 b6ae5000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6aea000 b6bb8000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6bbb000 b6bbf000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6bc0000 b6bcf000 r-xp /usr/lib/libvconf.so.0.2.45
b6bd0000 b6bd3000 r-xp /usr/lib/libvasum.so.0.3.1
b6bd4000 b6bd7000 r-xp /usr/lib/libttrace.so.1.1
b6bd9000 b6bdd000 r-xp /usr/lib/libiniparser.so.0
b6bde000 b6c0e000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6c0f000 b6c18000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c19000 b6c3e000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c3f000 b6c4f000 r-xp /usr/lib/libunwind.so.8.0.1
b6c59000 b6e07000 r-xp /lib/libc-2.20-2014.11.so
b6e0f000 b6f52000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f54000 b6fac000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6fad000 b6fe1000 r-xp /usr/lib/libsystemd.so.0.4.0
b6fe4000 b70b8000 r-xp /usr/lib/libedje.so.1.13.0
b70bb000 b70e7000 r-xp /usr/lib/libecore.so.1.13.0
b70f8000 b731e000 r-xp /usr/lib/libevas.so.1.13.0
b7346000 b735e000 r-xp /lib/libpthread-2.20-2014.11.so
b7362000 b76dc000 r-xp /usr/lib/libelementary.so.1.13.0
b76fc000 b7700000 r-xp /usr/lib/libsmack.so.1.0.0
b7701000 b770a000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b770b000 b770e000 r-xp /usr/lib/libdlog.so.0.0.0
b770f000 b7714000 r-xp /usr/lib/libbundle.so.0.1.22
b7715000 b7718000 r-xp /lib/libdl-2.20-2014.11.so
b771a000 b773f000 r-xp /usr/lib/libaul.so.0.1.0
b7742000 b7744000 r-xp /usr/lib/libappsvc.so.0.1.0
b7745000 b774a000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b774b000 b7752000 r-xp /usr/lib/libappcore-efl.so.1.1
b7754000 b7759000 r-xp /usr/lib/libsys-assert.so
b775c000 b775d000 r-xp [vdso]
b775d000 b777f000 r-xp /lib/ld-2.20-2014.11.so
b7781000 b7789000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:20201)
Call Stack Count: 97
 0: (0xb6d8ac0b) [/lib/libc.so.6] + 0x131c0b
 1: gl_del_cb + 0xa8 (0xb37bf118) [/opt/usr/apps/org.example.example/bin/example] + 0x7118
 2: (0xb74be1f9) [/usr/lib/libelementary.so.1] + 0x15c1f9
 3: elm_genlist_clear + 0x9b (0xb74be42b) [/usr/lib/libelementary.so.1] + 0x15c42b
 4: (0xb74be669) [/usr/lib/libelementary.so.1] + 0x15c669
 5: evas_obj_smart_del + 0x99 (0xb7182eb9) [/usr/lib/libevas.so.1] + 0x8aeb9
 6: (0xb71846f1) [/usr/lib/libevas.so.1] + 0x8c6f1
 7: (0xb717775b) [/usr/lib/libevas.so.1] + 0x7f75b
 8: eo_destructor + 0x99 (0xb63b5079) [/usr/lib/libeo.so.1] + 0xb079
 9: (0xb75d338b) [/usr/lib/libelementary.so.1] + 0x27138b
10: eo_destructor + 0x99 (0xb63b5079) [/usr/lib/libeo.so.1] + 0xb079
11: _eo_do_end + 0x15b (0xb63ad5ab) [/usr/lib/libeo.so.1] + 0x35ab
12: eo_del + 0xb3 (0xb63b27a3) [/usr/lib/libeo.so.1] + 0x87a3
13: evas_object_del + 0x81 (0xb716ccc1) [/usr/lib/libevas.so.1] + 0x74cc1
14: (0xb75e1245) [/usr/lib/libelementary.so.1] + 0x27f245
15: evas_obj_smart_del + 0x99 (0xb7182eb9) [/usr/lib/libevas.so.1] + 0x8aeb9
16: (0xb74d0bf9) [/usr/lib/libelementary.so.1] + 0x16ebf9
17: evas_obj_smart_del + 0x99 (0xb7182eb9) [/usr/lib/libevas.so.1] + 0x8aeb9
18: (0xb71846f1) [/usr/lib/libevas.so.1] + 0x8c6f1
19: (0xb717775b) [/usr/lib/libevas.so.1] + 0x7f75b
20: eo_destructor + 0x99 (0xb63b5079) [/usr/lib/libeo.so.1] + 0xb079
21: (0xb75d338b) [/usr/lib/libelementary.so.1] + 0x27138b
22: eo_destructor + 0x99 (0xb63b5079) [/usr/lib/libeo.so.1] + 0xb079
23: _eo_do_end + 0x15b (0xb63ad5ab) [/usr/lib/libeo.so.1] + 0x35ab
24: eo_del + 0xb3 (0xb63b27a3) [/usr/lib/libeo.so.1] + 0x87a3
25: evas_object_del + 0x81 (0xb716ccc1) [/usr/lib/libevas.so.1] + 0x74cc1
26: (0xb75e1245) [/usr/lib/libelementary.so.1] + 0x27f245
27: evas_obj_smart_del + 0x99 (0xb7182eb9) [/usr/lib/libevas.so.1] + 0x8aeb9
28: (0xb7516706) [/usr/lib/libelementary.so.1] + 0x1b4706
29: evas_obj_smart_del + 0x99 (0xb7182eb9) [/usr/lib/libevas.so.1] + 0x8aeb9
30: (0xb750653f) [/usr/lib/libelementary.so.1] + 0x1a453f
31: evas_obj_smart_del + 0x99 (0xb7182eb9) [/usr/lib/libevas.so.1] + 0x8aeb9
32: (0xb71846f1) [/usr/lib/libevas.so.1] + 0x8c6f1
33: (0xb717775b) [/usr/lib/libevas.so.1] + 0x7f75b
34: eo_destructor + 0x99 (0xb63b5079) [/usr/lib/libeo.so.1] + 0xb079
35: (0xb75d338b) [/usr/lib/libelementary.so.1] + 0x27138b
36: eo_destructor + 0x99 (0xb63b5079) [/usr/lib/libeo.so.1] + 0xb079
37: _eo_do_end + 0x15b (0xb63ad5ab) [/usr/lib/libeo.so.1] + 0x35ab
38: eo_del + 0xb3 (0xb63b27a3) [/usr/lib/libeo.so.1] + 0x87a3
39: evas_object_del + 0x81 (0xb716ccc1) [/usr/lib/libevas.so.1] + 0x74cc1
40: (0xb75e1245) [/usr/lib/libelementary.so.1] + 0x27f245
41: evas_obj_smart_del + 0x99 (0xb7182eb9) [/usr/lib/libevas.so.1] + 0x8aeb9
42: (0xb7516706) [/usr/lib/libelementary.so.1] + 0x1b4706
43: evas_obj_smart_del + 0x99 (0xb7182eb9) [/usr/lib/libevas.so.1] + 0x8aeb9
44: (0xb71846f1) [/usr/lib/libevas.so.1] + 0x8c6f1
45: (0xb717775b) [/usr/lib/libevas.so.1] + 0x7f75b
46: eo_destructor + 0x99 (0xb63b5079) [/usr/lib/libeo.so.1] + 0xb079
47: (0xb75d338b) [/usr/lib/libelementary.so.1] + 0x27138b
48: eo_destructor + 0x99 (0xb63b5079) [/usr/lib/libeo.so.1] + 0xb079
49: _eo_do_end + 0x15b (0xb63ad5ab) [/usr/lib/libeo.so.1] + 0x35ab
50: eo_del + 0xb3 (0xb63b27a3) [/usr/lib/libeo.so.1] + 0x87a3
51: evas_object_del + 0x81 (0xb716ccc1) [/usr/lib/libevas.so.1] + 0x74cc1
52: (0xb75d09d1) [/usr/lib/libelementary.so.1] + 0x26e9d1
53: eo_destructor + 0x99 (0xb63b5079) [/usr/lib/libeo.so.1] + 0xb079
54: (0xb74026af) [/usr/lib/libelementary.so.1] + 0xa06af
55: eo_destructor + 0x99 (0xb63b5079) [/usr/lib/libeo.so.1] + 0xb079
56: _eo_do_end + 0x15b (0xb63ad5ab) [/usr/lib/libeo.so.1] + 0x35ab
57: (0xb7401b61) [/usr/lib/libelementary.so.1] + 0x9fb61
58: evas_obj_smart_del + 0x99 (0xb7182eb9) [/usr/lib/libevas.so.1] + 0x8aeb9
59: (0xb71846f1) [/usr/lib/libevas.so.1] + 0x8c6f1
60: (0xb717775b) [/usr/lib/libevas.so.1] + 0x7f75b
61: eo_destructor + 0x99 (0xb63b5079) [/usr/lib/libeo.so.1] + 0xb079
62: (0xb75d338b) [/usr/lib/libelementary.so.1] + 0x27138b
63: eo_destructor + 0x99 (0xb63b5079) [/usr/lib/libeo.so.1] + 0xb079
64: _eo_do_end + 0x15b (0xb63ad5ab) [/usr/lib/libeo.so.1] + 0x35ab
65: eo_del + 0xb3 (0xb63b27a3) [/usr/lib/libeo.so.1] + 0x87a3
66: evas_object_del + 0x81 (0xb716ccc1) [/usr/lib/libevas.so.1] + 0x74cc1
67: (0xb75e1245) [/usr/lib/libelementary.so.1] + 0x27f245
68: evas_obj_smart_del + 0x99 (0xb7182eb9) [/usr/lib/libevas.so.1] + 0x8aeb9
69: (0xb7516706) [/usr/lib/libelementary.so.1] + 0x1b4706
70: evas_obj_smart_del + 0x99 (0xb7182eb9) [/usr/lib/libevas.so.1] + 0x8aeb9
71: (0xb745c425) [/usr/lib/libelementary.so.1] + 0xfa425
72: evas_obj_smart_del + 0x99 (0xb7182eb9) [/usr/lib/libevas.so.1] + 0x8aeb9
73: (0xb71846f1) [/usr/lib/libevas.so.1] + 0x8c6f1
74: (0xb717775b) [/usr/lib/libevas.so.1] + 0x7f75b
75: eo_destructor + 0x99 (0xb63b5079) [/usr/lib/libeo.so.1] + 0xb079
76: (0xb75d338b) [/usr/lib/libelementary.so.1] + 0x27138b
77: eo_destructor + 0x99 (0xb63b5079) [/usr/lib/libeo.so.1] + 0xb079
78: _eo_do_end + 0x15b (0xb63ad5ab) [/usr/lib/libeo.so.1] + 0x35ab
79: eo_del + 0xb3 (0xb63b27a3) [/usr/lib/libeo.so.1] + 0x87a3
80: evas_object_del + 0x81 (0xb716ccc1) [/usr/lib/libevas.so.1] + 0x74cc1
81: (0xb7184087) [/usr/lib/libevas.so.1] + 0x8c087
82: (0xb7186ebb) [/usr/lib/libevas.so.1] + 0x8eebb
83: evas_obj_smart_del + 0x99 (0xb7182eb9) [/usr/lib/libevas.so.1] + 0x8aeb9
84: (0xb718ef8c) [/usr/lib/libevas.so.1] + 0x96f8c
85: evas_obj_smart_del + 0x99 (0xb7182eb9) [/usr/lib/libevas.so.1] + 0x8aeb9
86: (0xb71846f1) [/usr/lib/libevas.so.1] + 0x8c6f1
87: (0xb717775b) [/usr/lib/libevas.so.1] + 0x7f75b
88: eo_destructor + 0x99 (0xb63b5079) [/usr/lib/libeo.so.1] + 0xb079
89: _eo_do_end + 0x15b (0xb63ad5ab) [/usr/lib/libeo.so.1] + 0x35ab
90: eo_del + 0xb3 (0xb63b27a3) [/usr/lib/libeo.so.1] + 0x87a3
91: evas_object_del + 0x81 (0xb716ccc1) [/usr/lib/libevas.so.1] + 0x74cc1
92: (0xb75f2f44) [/usr/lib/libelementary.so.1] + 0x290f44
93: evas_obj_smart_del + 0x99 (0xb7182eb9) [/usr/lib/libevas.so.1] + 0x8aeb9
94: (0xb71846f1) [/usr/lib/libevas.so.1] + 0x8c6f1
95: (0xb717775b) [/usr/lib/libevas.so.1] + 0x7f75b
96: eo_destructor + 0x99 (0xb63b5079) [/usr/lib/libeo.so.1] + 0xb079
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
x0
06-04 05:11:03.221+0900 D/AUL_PAD ( 2913): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-04 05:11:03.221+0900 D/AUL_PAD ( 2913): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-04 05:11:03.221+0900 D/AUL_PAD ( 2913): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-04 05:11:03.221+0900 D/AUL_PAD ( 2913): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-04 05:11:03.221+0900 D/AUL_PAD ( 2913): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
06-04 05:11:03.221+0900 D/AUL_PAD ( 2913): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
06-04 05:11:03.221+0900 D/AUL_PAD ( 2913): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
06-04 05:11:03.221+0900 D/AUL_PAD ( 2913): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
06-04 05:11:03.221+0900 D/AUL_PAD ( 2913): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
06-04 05:11:03.221+0900 D/AUL_PAD ( 2913): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
06-04 05:11:03.221+0900 D/AUL_PAD ( 2913): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
06-04 05:11:03.221+0900 W/AUL_PAD ( 2913): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
06-04 05:11:03.221+0900 D/AUL     ( 2913): process_pool.c: __send_pkt_raw_data(219) > send(11) : 624 / 624
06-04 05:11:03.221+0900 D/AUL_PAD ( 2913): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 20201, bin path: /opt/usr/apps/org.example.example/bin/example
06-04 05:11:03.221+0900 W/AUL_PAD ( 2913): launchpad.c: __send_result_to_caller(265) > Check app launching
06-04 05:11:03.221+0900 D/AUL_PAD ( 2913): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
06-04 05:11:03.221+0900 D/AUL_PAD (20201): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
06-04 05:11:03.221+0900 D/AUL_PAD (20201): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 624, pkt->len: 616
06-04 05:11:03.221+0900 D/AUL_PAD (20201): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
06-04 05:11:03.221+0900 D/AUL_PAD (20201): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
06-04 05:11:03.221+0900 D/AUL_PAD (20201): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
06-04 05:11:03.221+0900 D/AUL_PAD (20201): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
06-04 05:11:03.221+0900 D/AUL     (20201): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (20204) is sent.
06-04 05:11:03.221+0900 D/AUL     (20201): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 20204, signo: 10
06-04 05:11:03.221+0900 D/RESOURCED( 2841): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
06-04 05:11:03.221+0900 D/RESOURCED( 2841): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 1
06-04 05:11:03.221+0900 E/RESOURCED( 2841): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-04 05:11:03.221+0900 D/AUL     (20201): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
06-04 05:11:03.221+0900 D/AUL_PAD (20201): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
06-04 05:11:03.221+0900 D/AUL_PAD (20201): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
06-04 05:11:03.221+0900 D/AUL_PAD (20201): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
06-04 05:11:03.221+0900 D/AUL_PAD (20201): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
06-04 05:11:03.221+0900 D/AUL_PAD (20201): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0OTY1MjA2NjMvMjI5NDQwAA==##
06-04 05:11:03.221+0900 D/AUL_PAD (20201): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
06-04 05:11:03.221+0900 D/AUL_PAD (20201): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KQAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAYAAAAyMDM2MAA=##
06-04 05:11:03.221+0900 D/AUL_PAD (20201): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
06-04 05:11:03.221+0900 D/AUL_PAD (20201): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
06-04 05:11:03.221+0900 D/AUL_PAD (20201): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 8
06-04 05:11:03.221+0900 D/AUL_PAD (20201): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
06-04 05:11:03.221+0900 D/AUL_PAD (20201): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
06-04 05:11:03.231+0900 I/CAPI_APPFW_APPLICATION(20201): app_main.c: ui_app_main(788) > app_efl_main
06-04 05:11:03.231+0900 D/LAUNCH  (20201): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
06-04 05:11:03.231+0900 D/APP_CORE(20201): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
06-04 05:11:03.231+0900 D/APP_CORE(20201): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
06-04 05:11:03.231+0900 D/APP_CORE(20201): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
06-04 05:11:03.231+0900 D/APP_CORE(20201): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
06-04 05:11:03.231+0900 D/AUL     (20201): app_sock.c: __create_server_sock(156) > pg path - already exists
06-04 05:11:03.231+0900 D/APP_CORE(20201): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb42a7520
06-04 05:11:03.231+0900 D/LAUNCH  (20201): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
06-04 05:11:03.231+0900 I/CAPI_APPFW_APPLICATION(20201): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
06-04 05:11:03.261+0900 D/LAUNCH  (20201): appcore-efl.c: __before_loop(1154) > [example:Application:create:done]
06-04 05:11:03.271+0900 E/E17     ( 2690): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x01200002)
06-04 05:11:03.271+0900 D/APP_CORE(20201): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
06-04 05:11:03.271+0900 E/E17     ( 2690): e_border.c: e_border_show(2088) > BD_SHOW(0x01200002)
06-04 05:11:03.281+0900 D/APP_CORE(20201): appcore.c: __aul_handler(587) > [APP 20201]     AUL event: AUL_START
06-04 05:11:03.281+0900 I/APP_CORE(20201): appcore-efl.c: __do_app(496) > [APP 20201] Event: RESET State: CREATED
06-04 05:11:03.281+0900 D/APP_CORE(20201): appcore-efl.c: __do_app(527) > [APP 20201] RESET
06-04 05:11:03.281+0900 D/LAUNCH  (20201): appcore-efl.c: __do_app(529) > [example:Application:reset:start]
06-04 05:11:03.281+0900 D/APP_CORE(20201): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
06-04 05:11:03.281+0900 D/APP_CORE(20201): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-04 05:11:03.281+0900 I/CAPI_APPFW_APPLICATION(20201): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
06-04 05:11:03.281+0900 D/AUL     (20201): service.c: __set_bundle(186) > __set_bundle
06-04 05:11:03.281+0900 D/LAUNCH  (20201): appcore-efl.c: __do_app(544) > [example:Application:reset:done]
06-04 05:11:03.281+0900 D/APP_CORE(20201): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
06-04 05:11:03.281+0900 E/EFL     (20201): edje<20201> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-04 05:11:03.281+0900 E/EFL     (20201): By the power of Grayskull, your previous Embryo stack is now broken!
06-04 05:11:03.281+0900 E/EFL     (20201): edje<20201> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-04 05:11:03.281+0900 E/EFL     (20201): By the power of Grayskull, your previous Embryo stack is now broken!
06-04 05:11:03.281+0900 E/EFL     (20201): edje<20201> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-04 05:11:03.281+0900 E/EFL     (20201): By the power of Grayskull, your previous Embryo stack is now broken!
06-04 05:11:03.281+0900 E/EFL     (20201): edje<20201> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-04 05:11:03.281+0900 E/EFL     (20201): By the power of Grayskull, your previous Embryo stack is now broken!
06-04 05:11:03.281+0900 E/EFL     (20201): edje<20201> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-04 05:11:03.281+0900 E/EFL     (20201): By the power of Grayskull, your previous Embryo stack is now broken!
06-04 05:11:03.281+0900 W/PROCESSMGR( 2690): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=20201
06-04 05:11:03.281+0900 W/APP_CORE(20201): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1200002
06-04 05:11:03.281+0900 D/APP_CORE(20201): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:1200002
06-04 05:11:03.281+0900 D/APP_CORE(20201): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
06-04 05:11:03.281+0900 D/AUL     (20201): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
06-04 05:11:03.281+0900 E/EFL     ( 2690): eo<2690> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-04 05:11:03.281+0900 E/EFL     ( 2690): eo<2690> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-04 05:11:03.291+0900 D/INDICATOR( 2846): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
06-04 05:11:03.291+0900 D/INDICATOR( 2846): util.c: util_signal_emit_by_win(116) > emission bg.opaque
06-04 05:11:03.291+0900 D/INDICATOR( 2846): main.c: _rotate_window(229) > Indicator angle is 0 degree
06-04 05:11:03.291+0900 D/INDICATOR( 2846): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
06-04 05:11:03.291+0900 D/INDICATOR( 2846): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
06-04 05:11:03.291+0900 D/INDICATOR( 2846): main.c: _rotate_window(252) > port :: hide more icon
06-04 05:11:03.321+0900 D/AUL_PAD ( 2913): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
06-04 05:11:03.321+0900 W/AUL     ( 2771): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 20201, appid: org.example.example
06-04 05:11:03.321+0900 D/AUL     ( 2771): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
06-04 05:11:03.321+0900 E/AUL     ( 2771): simple_util.c: __trm_app_info_send_socket(330) > access
06-04 05:11:03.321+0900 D/AUL_AMD ( 2771): amd_launch.c: _start_app(2700) > add app group info
06-04 05:11:03.321+0900 E/AUL     ( 2771): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
06-04 05:11:03.321+0900 D/AUL_AMD ( 2771): amd_status.c: _status_add_app_info_list(427) > pid(20201) appid(org.example.example) pkgid(org.example.example) comp(uiapp)
06-04 05:11:03.321+0900 D/AUL_AMD ( 2771): amd_request.c: __request_handler(838) > __request_handler: 34
06-04 05:11:03.321+0900 D/AUL_AMD ( 2771): amd_request.c: __request_handler(838) > __request_handler: 15
06-04 05:11:03.321+0900 D/RESOURCED( 2841): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.example, 20201
06-04 05:11:03.321+0900 D/RESOURCED( 2841): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.example with pkgname
06-04 05:11:03.321+0900 E/RESOURCED( 2841): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.example
06-04 05:11:03.321+0900 D/PKGMGR_INFO( 2771): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-04 05:11:03.321+0900 D/PKGMGR_INFO( 2771): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-04 05:11:03.321+0900 D/RESOURCED( 2841): proc-main.c: resourced_proc_status_change(888) > available memory = 290
06-04 05:11:03.321+0900 D/AUL_AMD ( 2771): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 20201 is org.example.example
06-04 05:11:03.321+0900 D/AUL_AMD ( 2771): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 20201 : 0
06-04 05:11:03.321+0900 D/AUL     ( 2939): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
06-04 05:11:03.601+0900 D/APP_CORE(20201): appcore.c: __prt_ltime(236) > [APP 20201] first idle after reset: 389 msec
06-04 05:11:03.681+0900 E/E17     ( 2690): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
06-04 05:11:03.681+0900 D/APP_CORE( 2863): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
06-04 05:11:03.681+0900 D/APP_CORE( 2863): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
06-04 05:11:03.681+0900 D/APP_CORE( 2863): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
06-04 05:11:03.681+0900 I/APP_CORE( 2863): appcore-efl.c: __do_app(496) > [APP 2863] Event: PAUSE State: RUNNING
06-04 05:11:03.681+0900 D/APP_CORE( 2863): appcore-efl.c: __do_app(565) > [APP 2863] PAUSE
06-04 05:11:03.681+0900 I/CAPI_APPFW_APPLICATION( 2863): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
06-04 05:11:03.681+0900 E/cluster-home( 2863): homescreen.cpp: OnPause(84) >  app pause
06-04 05:11:03.681+0900 D/cluster-view( 2863): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
06-04 05:11:03.681+0900 D/cluster-view( 2863): homescreen-view-manager.cpp: AppPause(923) >  END
06-04 05:11:03.681+0900 D/APP_CORE( 2863): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-04 05:11:03.681+0900 E/APP_CORE( 2863): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-04 05:11:03.681+0900 D/AUL_AMD ( 2771): amd_status.c: _status_update_app_info_list(456) > pid(2863) status(4)
06-04 05:11:03.681+0900 D/AUL_AMD ( 2771): amd_status.c: _status_update_app_info_list(468) > pid(2863) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
06-04 05:11:03.681+0900 D/AUL     ( 2771): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
06-04 05:11:03.681+0900 W/AUL     ( 2771): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2863, appid: org.tizen.homescreen, status: bg
06-04 05:11:03.691+0900 D/AUL_AMD ( 2771): amd_launch.c: __e17_status_handler(2891) > pid(20201) status(3)
06-04 05:11:03.691+0900 D/AUL_AMD ( 2771): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
06-04 05:11:03.691+0900 W/AUL_AMD ( 2771): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-04 05:11:03.691+0900 W/AUL_AMD ( 2771): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
06-04 05:11:03.691+0900 D/AUL_AMD ( 2771): amd_status.c: _status_update_app_info_list(456) > pid(20201) status(3)
06-04 05:11:03.691+0900 D/AUL_AMD ( 2771): amd_status.c: _status_update_app_info_list(468) > pid(20201) appid(org.example.example) pkgid(org.example.example) status(3)
06-04 05:11:03.691+0900 D/AUL     ( 2771): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.example
06-04 05:11:03.691+0900 W/AUL     ( 2771): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 20201, appid: org.example.example, status: fg
06-04 05:11:03.691+0900 D/RESOURCED( 2841): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 20201
06-04 05:11:03.691+0900 D/RESOURCED( 2841): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 20201, proc_name: org.example.example, cg_name: foreground, oom_score_adj: 200
06-04 05:11:03.691+0900 D/RESOURCED( 2841): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 20201
06-04 05:11:03.691+0900 D/DATA_PROVIDER_MASTER( 2915): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2863 is paused
06-04 05:11:03.691+0900 D/DATA_PROVIDER_MASTER( 2915): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
06-04 05:11:03.691+0900 I/CAPI_WIDGET_APPLICATION( 3019): widget_app.c: __provider_pause_cb(294) > widget obj was paused
06-04 05:11:03.691+0900 I/CAPI_WIDGET_APPLICATION( 3019): widget_app.c: __check_status_for_cgroup(142) > enter background group
06-04 05:11:03.691+0900 W/AUL     ( 3019): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3019, appid: org.tizen.calendar.widget, status: bg
06-04 05:11:03.711+0900 D/APP_CORE(20201): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1200002 fully_obscured 0
06-04 05:11:03.711+0900 D/APP_CORE(20201): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
06-04 05:11:03.711+0900 D/APP_CORE(20201): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
06-04 05:11:03.711+0900 I/APP_CORE(20201): appcore-efl.c: __do_app(496) > [APP 20201] Event: RESUME State: CREATED
06-04 05:11:03.711+0900 D/LAUNCH  (20201): appcore-efl.c: __do_app(597) > [example:Application:resume:start]
06-04 05:11:03.711+0900 D/APP_CORE(20201): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
06-04 05:11:03.711+0900 D/APP_CORE(20201): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-04 05:11:03.711+0900 D/APP_CORE(20201): appcore-efl.c: __do_app(607) > [APP 20201] RESUME
06-04 05:11:03.711+0900 D/AUL_AMD ( 2771): amd_launch.c: __e17_status_handler(2910) > pid(20201) status(0)
06-04 05:11:03.711+0900 I/APP_CORE(20201): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
06-04 05:11:03.711+0900 I/APP_CORE(20201): appcore-efl.c: __do_app(614) > [APP 20201] Initial Launching, call the resume_cb
06-04 05:11:03.711+0900 I/CAPI_APPFW_APPLICATION(20201): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
06-04 05:11:03.711+0900 D/LAUNCH  (20201): appcore-efl.c: __do_app(636) > [example:Application:resume:done]
06-04 05:11:03.711+0900 D/LAUNCH  (20201): appcore-efl.c: __do_app(638) > [example:Application:Launching:done]
06-04 05:11:03.711+0900 D/APP_CORE(20201): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-04 05:11:03.711+0900 E/APP_CORE(20201): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-04 05:11:03.731+0900 D/RESOURCED( 2841): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 20201, appname = org.example.example, pkgname = org.example.example
06-04 05:11:03.731+0900 D/RESOURCED( 2841): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 20201, appname = org.example.example
06-04 05:11:03.731+0900 D/RESOURCED( 2841): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 20201
06-04 05:11:03.731+0900 D/RESOURCED( 2841): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3019, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
06-04 05:11:03.731+0900 D/RESOURCED( 2841): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 3019
06-04 05:11:03.731+0900 D/RESOURCED( 2841): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 3019, appname = org.tizen.calendar.widget
06-04 05:11:03.731+0900 D/RESOURCED( 2841): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 3019
06-04 05:11:03.731+0900 I/RESOURCED( 2841): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
06-04 05:11:03.731+0900 I/RESOURCED( 2841): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
06-04 05:11:04.001+0900 E/PKGMGR_SERVER(20291): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-04 05:11:04.001+0900 E/PKGMGR_SERVER(20291): pkgmgr-server.c: main(2265) > package manager server terminated.
06-04 05:11:04.321+0900 D/AUL_PAD ( 2913): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
06-04 05:11:04.321+0900 D/AUL_PAD (20368): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
06-04 05:11:04.331+0900 D/AUL_PAD ( 2913): sigchild.h: __send_app_launch_signal(131) > send launch signal done
06-04 05:11:04.331+0900 E/RESOURCED( 2841): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1832
06-04 05:11:04.831+0900 D/AUL_AMD ( 2771): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.example /opt/usr/apps/org.example.example/bin/example
06-04 05:11:04.831+0900 D/RUA     ( 2771): rua.c: rua_add_history(179) > rua_add_history start
06-04 05:11:04.831+0900 D/RUA     ( 2771): rua.c: rua_add_history(247) > rua_add_history ok
06-04 05:11:05.351+0900 D/AUL_PAD (20368): launchpad_loader.c: main(588) > sleeping 1 sec...
06-04 05:11:05.351+0900 D/AUL_PAD (20368): preload.h: __preload_init(52) > max_cmdline_size = 1053
06-04 05:11:05.371+0900 D/AUL_PAD (20368): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b85dc760
06-04 05:11:05.371+0900 D/AUL_PAD (20368): preload.h: __preload_init(69) > get pre-initialization function
06-04 05:11:05.371+0900 D/AUL_PAD (20368): preload.h: __preload_init(73) > get shutdown function
06-04 05:11:05.371+0900 D/AUL_PAD (20368): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b85dca40
06-04 05:11:05.381+0900 D/AUL_PAD (20368): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b85de640
06-04 05:11:05.381+0900 D/AUL_PAD (20368): preload.h: __preload_init(69) > get pre-initialization function
06-04 05:11:05.381+0900 D/AUL_PAD (20368): preload.h: __preload_init(73) > get shutdown function
06-04 05:11:05.381+0900 D/AUL_PAD (20368): preexec.h: __preexec_init(76) > preexec start
06-04 05:11:05.381+0900 D/AUL_PAD (20368): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
06-04 05:11:05.381+0900 D/AUL     (20368): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
06-04 05:11:05.381+0900 D/AUL     (20368): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
06-04 05:11:05.381+0900 D/AUL     (20368): process_pool.c: __connect_to_launchpad(132) > send(20368) : 4
06-04 05:11:05.381+0900 D/AUL     (20368): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
06-04 05:11:05.381+0900 D/AUL_PAD ( 2913): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
06-04 05:11:05.381+0900 D/AUL_PAD ( 2913): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
06-04 05:11:05.381+0900 D/AUL_PAD ( 2913): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-04 05:11:05.381+0900 D/AUL_PAD ( 2913): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-04 05:11:05.381+0900 D/AUL_PAD ( 2913): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-04 05:11:05.381+0900 D/AUL_PAD ( 2913): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-04 05:11:05.381+0900 D/AUL_PAD ( 2913): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-04 05:11:05.381+0900 D/AUL_PAD ( 2913): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
06-04 05:11:05.381+0900 D/AUL_PAD ( 2913): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 20368
06-04 05:11:05.451+0900 D/AUL_PAD (20368): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
06-04 05:11:05.451+0900 D/AUL_PAD (20368): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
06-04 05:11:05.451+0900 D/AUL_PAD (20368): launchpad_loader.c: main(693) > [candidate] ecore handler add
06-04 05:11:05.451+0900 D/AUL_PAD (20368): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
06-04 05:11:06.591+0900 I/user_tag0(20201): /opt/usr/apps/org.example.example/data/feeding.db
06-04 05:11:06.611+0900 I/tag     (20201): eonji~
06-04 05:11:06.631+0900 D/PROCESSMGR( 2690): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x604b96 
06-04 05:11:07.471+0900 D/PROCESSMGR( 2690): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x604b96 
06-04 05:11:07.611+0900 E/EFL     (20201): edje<20201> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 05:11:07.611+0900 E/EFL     (20201): edje<20201> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 05:11:07.641+0900 E/EFL     (20201): edje<20201> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 05:11:07.641+0900 E/EFL     (20201): edje<20201> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 05:11:07.641+0900 E/EFL     (20201): edje<20201> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 05:11:07.651+0900 E/EFL     (20201): edje<20201> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 05:11:07.651+0900 E/EFL     (20201): edje<20201> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 05:11:07.651+0900 E/EFL     (20201): edje<20201> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 05:11:07.651+0900 E/EFL     (20201): edje<20201> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 05:11:07.661+0900 D/IMMODULE(20201): isf_imf_context.cpp: initialize(3406) > Initializing Ecore ISF IMModule...
06-04 05:11:07.661+0900 D/ISF_SOCKET(20201): scim_socket.cpp: connect(515) > ppid:2913  trying connect() to local:/tmp/scim-socket-frontend, example
06-04 05:11:07.661+0900 D/ISF_SOCKET(20201): scim_socket.cpp: connect(524) > connect() succeeded
06-04 05:11:07.661+0900 D/ISF_SOCKET(20201): scim_socket.cpp: connect(515) > ppid:2913  trying connect() to local:/tmp/scim-socket-frontend, example
06-04 05:11:07.661+0900 D/ISF_SOCKET(20201): scim_socket.cpp: connect(524) > connect() succeeded
06-04 05:11:07.671+0900 D/ISF_SOCKET(20201): scim_socket.cpp: connect(515) > ppid:2913  trying connect() to local:/tmp/scim-socket-frontend, example
06-04 05:11:07.671+0900 D/ISF_SOCKET(20201): scim_socket.cpp: connect(524) > connect() succeeded
06-04 05:11:07.671+0900 D/ISF_QUERY(20201): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="ise-default", label="Tizen keyboard", pkgid="ise-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-helper-launcher", mname="ise-default", mpath="/usr/lib/scim-1.0/1.4.0/Helper", mode=1, options=13, is_enabled=1, is_preinstalled=1, has_option=1, disp_lang="en_US.UTF-8"
06-04 05:11:07.671+0900 D/ISF_QUERY(20201): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-anthy", label="Japanese keyboard", pkgid="ise-engine-anthy", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-anthy", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 05:11:07.671+0900 D/ISF_QUERY(20201): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-default", label="Default keyboard", pkgid="ise-engine-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-default", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 05:11:07.671+0900 D/ISF_QUERY(20201): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-hangul", label="Hangul keyboard", pkgid="hangul", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="hangul", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 05:11:07.671+0900 D/ISF_QUERY(20201): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-sunpinyin", label="Chinese (sunpinyin) keyboard", pkgid="ise-engine-sunpinyin", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-sunpinyin", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 05:11:07.671+0900 D/ISF_QUERY(20201): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.cangjie3", label="CanJie 3 keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 05:11:07.671+0900 D/ISF_QUERY(20201): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.zhuyin-big", label="ZhuYin Big keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 05:11:07.671+0900 D/ISF_SOCKET(20201): scim_socket.cpp: connect(515) > ppid:2913  trying connect() to local:/tmp/scim-socket-frontend, example
06-04 05:11:07.671+0900 D/ISF_SOCKET(20201): scim_socket.cpp: connect(524) > connect() succeeded
06-04 05:11:07.671+0900 D/IMMODULE(20201): scim_panel_client.cpp: open_connection(162) > 
06-04 05:11:07.671+0900 D/ISF_SOCKET(20201): scim_socket.cpp: connect(515) > ppid:2913  trying connect() to local:/tmp/scim-panel-socket:0, example
06-04 05:11:07.671+0900 D/ISF_SOCKET(20201): scim_socket.cpp: connect(524) > connect() succeeded
06-04 05:11:07.671+0900 D/ISF_SOCKET(20201): scim_socket.cpp: connect(515) > ppid:2913  trying connect() to local:/tmp/scim-panel-socket:0, example
06-04 05:11:07.671+0900 D/ISF_SOCKET(20201): scim_socket.cpp: connect(524) > connect() succeeded
06-04 05:11:07.671+0900 D/IMMODULE(20201): isf_imf_control_ui.cpp: isf_imf_input_panel_init(516) > keyboard mode(0:H/W Keyboard, 1:S/W Keyboard): 0
06-04 05:11:08.391+0900 D/PROCESSMGR( 2690): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x604b96 
06-04 05:11:08.541+0900 I/tag     (20201): insert
06-04 05:11:08.541+0900 I/user_tag(20201): 05:11 AM
06-04 05:11:08.551+0900 E/EFL     (20201): edje<20201> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 05:11:08.551+0900 E/EFL     (20201): edje<20201> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 05:11:08.551+0900 E/EFL     (20201): edje<20201> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 05:11:08.561+0900 E/EFL     (20201): edje<20201> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 05:11:08.561+0900 E/EFL     (20201): edje<20201> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 05:11:08.691+0900 D/APP_CORE( 2863): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
06-04 05:11:08.691+0900 I/APP_CORE( 2863): appcore-efl.c: __do_app(496) > [APP 2863] Event: MEM_FLUSH State: PAUSED
06-04 05:11:08.691+0900 D/APP_CORE( 2863): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
06-04 05:11:08.691+0900 D/APP_CORE( 2863): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 2863
06-04 05:11:08.691+0900 D/APP_CORE( 2863): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
06-04 05:11:08.691+0900 D/RESOURCED( 2841): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 2863
06-04 05:11:09.301+0900 D/PROCESSMGR( 2690): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x604b96 
06-04 05:11:09.371+0900 I/tag     (20201): `´€Bƒ€0ô¸ÐÃ¸¨î
06-04 05:11:09.371+0900 I/tag     (20201): ¸@Jn·XïÉ¿Ð!L·0ô¸Bƒ€`´€€Jb·‚kb·M
06-04 05:11:10.301+0900 D/PROCESSMGR( 2690): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x1200002
06-04 05:11:15.311+0900 D/PROCESSMGR( 2690): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x604b96 bd->visible=1
06-04 05:11:18.531+0900 E/CAPI_NETWORK_WIFI( 2846): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-04 05:11:18.531+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
06-04 05:11:18.531+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-04 05:11:18.531+0900 E/INDICATOR( 2846): 
06-04 05:11:20.141+0900 D/RESOURCED( 2841): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
06-04 05:11:20.141+0900 I/RESOURCED( 2841): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
06-04 05:11:20.141+0900 D/RESOURCED( 2841): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
06-04 05:11:20.141+0900 I/RESOURCED( 2841): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
06-04 05:11:20.141+0900 I/RESOURCED( 2841): logging.c: logging_save_to_storage(978) > storage cache is empty
06-04 05:11:38.561+0900 E/CAPI_NETWORK_WIFI( 2846): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-04 05:11:38.561+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
06-04 05:11:38.561+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-04 05:11:38.561+0900 E/INDICATOR( 2846): 
06-04 05:11:50.661+0900 E/PKGMGR_SERVER(20404): pkgmgr-server.c: main(2209) > package manager server start
06-04 05:11:50.661+0900 D/PKGMGR  (20404): comm_pkg_mgr_server.c: pkg_mgr_server_gdbus_init(405) > initialize_gdbus Enter
06-04 05:11:50.661+0900 D/PKGMGR  (20404): comm_pkg_mgr_server.c: pkg_mgr_server_gdbus_init(423) > initialize_gdbus Exit
06-04 05:11:50.661+0900 D/PKGMGR  (20404): comm_pkg_mgr_server.c: on_bus_acquired(376) > on_bus_acquired
06-04 05:11:50.661+0900 D/PKGMGR  (20404): comm_pkg_mgr_server.c: on_bus_acquired(400) > on_bus_acquired done
06-04 05:11:50.661+0900 D/PKGMGR  (20404): comm_pkg_mgr_server.c: pkgmgr_request(145) > Called
06-04 05:11:50.661+0900 D/PKGMGR  (20404): comm_pkg_mgr_server.c: pkgmgr_request(164) > sender_name: :1.1837
06-04 05:11:50.661+0900 D/PKGMGR  (20404): comm_pkg_mgr_server.c: pkg_mgr_get_sender_pid(79) > zone pid : 20402
06-04 05:11:50.671+0900 D/PKGMGR  (20404): comm_pkg_mgr_server.c: pkgmgr_request(166) > sender_pid: 20402
06-04 05:11:50.671+0900 D/PKGMGR  (20404): comm_pkg_mgr_server.c: pkgmgr_request(175) > [SECURE_LOG] Call request callback(obj, org.example.example_-514101446, 14, tpk, org.example.example, , host)
06-04 05:11:50.671+0900 D/PKGMGR_SERVER(20404): pkgmgr-server.c: req_cb(625) > [SECURE_LOG] >> in callback >> Got request: [org.example.example_-514101446] [14] [tpk] [org.example.example] [] [] [host]
06-04 05:11:50.671+0900 D/PKGMGR_SERVER(20404): pkgmgr-server.c: req_cb(646) > req_type=(14)  backend_flag=(0) zone(host)
06-04 05:11:50.671+0900 D/PKGMGR_SERVER(20404): pkgmgr-server.c: queue_job(1880) > target zone(host, host)
06-04 05:11:50.671+0900 D/PKGMGR_SERVER(20404): pkgmgr-server.c: queue_job(1884) > child forked [20407] for request type [14]
06-04 05:11:50.671+0900 D/PKGMGR_SERVER(20407): pkgmgr-server.c: queue_job(1884) > child forked [0] for request type [14]
06-04 05:11:50.671+0900 D/PKGMGR_SERVER(20407): pkgmgr-server.c: queue_job(2057) > kill/check request
06-04 05:11:50.671+0900 D/PKGMGR_SERVER(20404): pkgmgr-server.c: queue_job(2126) > parent exit
06-04 05:11:50.671+0900 D/PKGMGR  (20402): pkgmgr.c: __check_sync_process(868) > info_file file is generated, result = 0
06-04 05:11:50.671+0900 D/PKGMGR  (20402): . 
06-04 05:11:50.671+0900 E/PKGMGR  (20402): pkgmgr.c: __check_sync_process(884) > file is can not remove[/tmp/org.example.example, -1]
06-04 05:11:50.671+0900 D/PKGMGR_SERVER(20407): pkgmgr-server.c: __pkgcmd_app_cb(1458) > sub_cmd(kill), zone_name(host)
06-04 05:11:50.681+0900 D/AUL     (20407): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(14)
06-04 05:11:50.681+0900 D/AUL_AMD ( 2771): amd_request.c: __request_handler(838) > __request_handler: 14
06-04 05:11:50.681+0900 D/AUL_AMD ( 2771): amd_status.c: _status_app_is_running_from_cache(836) > is_running hit cache, return immediately
06-04 05:11:50.681+0900 D/AUL_AMD ( 2771): amd_request.c: __request_handler(1028) > [SECURE_LOG] APP_IS_RUNNING : org.example.example : 20201
06-04 05:11:50.681+0900 W/AUL_AMD ( 2771): amd_request.c: __send_result_to_client(150) > __send_result_to_client, pid: 20201
06-04 05:11:50.681+0900 D/AUL_AMD ( 2771): amd_request.c: __request_handler(838) > __request_handler: 12
06-04 05:11:50.681+0900 D/AUL     (20407): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 360
06-04 05:11:50.681+0900 D/AUL     (20407): launch.c: app_request_to_launchpad(396) > [SECURE_LOG] launch request : 20201
06-04 05:11:50.681+0900 D/AUL     (20407): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(5)
06-04 05:11:50.681+0900 D/AUL_AMD ( 2771): amd_request.c: __request_handler(838) > __request_handler: 5
06-04 05:11:50.681+0900 D/AUL_AMD ( 2771): amd_appinfo.c: appinfo_set_value(905) > [SECURE_LOG] org.example.example : installed : norestart
06-04 05:11:50.681+0900 D/AUL_AMD ( 2771): amd_request.c: __app_process_by_pid(279) > [SECURE_LOG] __app_process_by_pid, pid: 20201, 
06-04 05:11:50.681+0900 D/AUL     ( 2771): app_sock.c: __app_send_raw_with_delay_reply(455) > pid(20201) : cmd(4)
06-04 05:11:50.681+0900 D/AUL_AMD ( 2771): amd_launch.c: _term_app(1076) > term done
06-04 05:11:50.681+0900 D/AUL_AMD ( 2771): amd_launch.c: __set_reply_handler(1015) > listen fd : 31, send fd : 30
06-04 05:11:50.681+0900 D/APP_CORE(20201): appcore.c: __aul_handler(632) > [APP 20201]     AUL event: AUL_TERMINATE
06-04 05:11:50.681+0900 W/AUL_AMD ( 2771): amd_launch.c: __reply_handler(913) > listen fd(31) , send fd(30), pid(20201), cmd(4)
06-04 05:11:50.681+0900 I/APP_CORE(20201): appcore-efl.c: __do_app(496) > [APP 20201] Event: TERMINATE State: RUNNING
06-04 05:11:50.681+0900 D/APP_CORE(20201): appcore-efl.c: __do_app(517) > [APP 20201] TERMINATE
06-04 05:11:50.681+0900 D/RESOURCED( 2841): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 20201
06-04 05:11:50.681+0900 D/AUL     (20407): launch.c: app_request_to_launchpad(425) > launch request result : 0
06-04 05:11:50.681+0900 D/AUL     (20407): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(14)
06-04 05:11:50.681+0900 D/AUL_AMD ( 2771): amd_request.c: __request_handler(838) > __request_handler: 14
06-04 05:11:50.681+0900 D/AUL_AMD ( 2771): amd_status.c: _status_app_is_running_from_cache(836) > is_running hit cache, return immediately
06-04 05:11:50.681+0900 D/AUL_AMD ( 2771): amd_request.c: __request_handler(1028) > [SECURE_LOG] APP_IS_RUNNING : org.example.example : 20201
06-04 05:11:50.681+0900 W/AUL_AMD ( 2771): amd_request.c: __send_result_to_client(150) > __send_result_to_client, pid: 20201
06-04 05:11:50.681+0900 D/AUL     (20201): app_sock.c: __app_send_raw_with_noreply(384) > pid(-2) : cmd(22)
06-04 05:11:50.681+0900 D/AUL_AMD ( 2771): amd_request.c: __request_handler(838) > __request_handler: 22
06-04 05:11:50.681+0900 W/AUL_AMD ( 2771): amd_request.c: __request_handler(1056) > app status : 5
06-04 05:11:50.681+0900 D/AUL_AMD ( 2771): amd_status.c: _status_update_app_info_list(456) > pid(20201) status(5)
06-04 05:11:50.681+0900 D/AUL_AMD ( 2771): amd_status.c: _status_update_app_info_list(468) > pid(20201) appid(org.example.example) pkgid(org.example.example) status(5)
06-04 05:11:50.681+0900 D/AUL     (20201): app_sock.c: __app_send_raw_with_noreply(384) > pid(-2) : cmd(22)
06-04 05:11:50.681+0900 D/AUL_AMD ( 2771): amd_request.c: __request_handler(838) > __request_handler: 22
06-04 05:11:50.681+0900 W/AUL_AMD ( 2771): amd_request.c: __request_handler(1056) > app status : 5
06-04 05:11:50.681+0900 D/AUL_AMD ( 2771): amd_status.c: _status_update_app_info_list(456) > pid(20201) status(5)
06-04 05:11:50.691+0900 D/AUL_AMD ( 2771): amd_status.c: _status_update_app_info_list(468) > pid(20201) appid(org.example.example) pkgid(org.example.example) status(5)
06-04 05:11:50.691+0900 D/APP_CORE(20201): appcore.c: _appcore_fini_suspend_dbus_handler(944) > [__SUSPEND__] suspend signal finalized
06-04 05:11:50.691+0900 D/APP_CORE(20201): appcore-efl.c: __after_loop(1169) > [APP 20201] PAUSE before termination
06-04 05:11:50.691+0900 I/CAPI_APPFW_APPLICATION(20201): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
06-04 05:11:50.691+0900 I/CAPI_APPFW_APPLICATION(20201): app_main.c: _ui_app_appcore_terminate(662) > app_appcore_terminate
06-04 05:11:50.691+0900 E/EFL     (20201): eo<20201> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0x8001a0d1 is not pointing to a valid object. Maybe it has already been freed.
06-04 05:11:50.691+0900 E/EFL     (20201): eo<20201> lib/eo/eo.c:485 _eo_do_internal() Obj (0x8001a0d1) is an invalid ref.
06-04 05:11:50.691+0900 E/EFL     ( 2690): eo<2690> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-04 05:11:50.691+0900 D/AUL_AMD ( 2771): amd_launch.c: __e17_status_handler(2891) > pid(2863) status(3)
06-04 05:11:50.691+0900 D/AUL_AMD ( 2771): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
06-04 05:11:50.691+0900 W/AUL_AMD ( 2771): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-04 05:11:50.691+0900 W/AUL_AMD ( 2771): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
06-04 05:11:50.691+0900 D/AUL_AMD ( 2771): amd_status.c: _status_update_app_info_list(456) > pid(2863) status(3)
06-04 05:11:50.691+0900 D/AUL_AMD ( 2771): amd_status.c: _status_update_app_info_list(468) > pid(2863) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(3)
06-04 05:11:50.691+0900 D/AUL     ( 2771): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.tizen.homescreen
06-04 05:11:50.691+0900 W/AUL     ( 2771): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2863, appid: org.tizen.homescreen, status: fg
06-04 05:11:50.691+0900 D/RESOURCED( 2841): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 2863
06-04 05:11:50.691+0900 D/RESOURCED( 2841): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 2863, appname = org.tizen.homescreen, pkgname = org.tizen.homescreen
06-04 05:11:50.691+0900 D/RESOURCED( 2841): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 2863, appname = org.tizen.homescreen
06-04 05:11:50.691+0900 D/RESOURCED( 2841): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 2863
06-04 05:11:50.701+0900 I/tag     (20201): 0
06-04 05:11:50.721+0900 E/E17     ( 2690): e_border.c: e_border_show(2088) > BD_SHOW(0x01600002)
06-04 05:11:50.721+0900 E/E17     ( 2690): e_border.c: e_border_hide(2248) > BD_HIDE(0x01200002), visible:1
06-04 05:11:50.731+0900 D/INDICATOR( 2846): main.c: _property_changed_cb(432) > UNSNIFF API 1200002
06-04 05:11:50.731+0900 D/INDICATOR( 2846): util.c: util_signal_emit_by_win(116) > emission bg.translucent
06-04 05:11:50.731+0900 W/CRASH_MANAGER(20409): worker.c: worker_job(1204) > 1120201657861149652071
