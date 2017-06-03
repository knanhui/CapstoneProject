S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 17894
Date: 2017-06-04 04:26:24+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0x00000008, esi = 0xbfe2bbf0
ebp = 0xbfe2bc48, esp = 0xbfe2bbec
eax = 0xb3772b43, ebx = 0xb3775000
ecx = 0x00000050, edx = 0x00000000
eip = 0xb6d39c0b

Memory Information
MemTotal:      123 KB
MemFree:        25 KB
Buffers:        10 KB
Cached:     161616 KB
VmPeak:     122308 KB
VmSize:     116180 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       35308 KB
VmRSS:       29152 KB
VmData:      46564 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34636 KB
VmPTE:         104 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 17894 TID = 17894
17894 17895 18112 18117 

Maps Information
b0e68000 b0e80000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b180e000 b1815000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b1818000 b181f000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b1856000 b185a000 r-xp /usr/lib/elementary/modules/datetime_input_spinner/v-1.13.0/module.so
b2b2f000 b2b39000 r-xp /usr/lib/libfeedback.so.0.1.4
b2b3f000 b2b4b000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2b4c000 b2b6d000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2b72000 b2b73000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2b74000 b2b79000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2b7a000 b2b7b000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2b7c000 b2b7e000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2b7f000 b2b81000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2b82000 b2b8e000 r-xp /usr/lib/libdrm.so.2.4.0
b2b8f000 b2b92000 r-xp /usr/lib/libdri2.so.0.0.0
b2b93000 b2b9d000 r-xp /usr/lib/libtbm.so.1.0.0
b2b9e000 b2bb3000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2bb4000 b2bc6000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b33c8000 b33f9000 r-xp /usr/lib/libidn.so.11.5.44
b33fa000 b341c000 r-xp /usr/lib/libnghttp2.so.5.4.0
b341d000 b342d000 r-xp /usr/lib/libcares.so.2.1.0
b342e000 b3437000 r-xp /usr/lib/libeventsystem.so.0.0.1
b3438000 b3441000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3442000 b34b9000 r-xp /usr/lib/libcurl.so.4.3.0
b34bb000 b34cd000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b34ce000 b34ef000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b34f6000 b34f7000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b34f8000 b34f9000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b34fa000 b34fd000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b34fe000 b3501000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3609000 b360f000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3610000 b3754000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b3765000 b3766000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b3767000 b3774000 r-xp /opt/usr/apps/org.example.example/bin/example
b3776000 b37af000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b41b2000 b41bd000 r-xp /lib/libnss_files-2.20-2014.11.so
b41bf000 b41ca000 r-xp /lib/libnss_nis-2.20-2014.11.so
b41cc000 b41e3000 r-xp /lib/libnsl-2.20-2014.11.so
b41e7000 b41ef000 r-xp /lib/libnss_compat-2.20-2014.11.so
b41f1000 b4215000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b4216000 b4217000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b4218000 b421b000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b421c000 b4223000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4224000 b422e000 r-xp /usr/lib/libsensord-share.so
b422f000 b424b000 r-xp /usr/lib/libsensor.so.1.2.0
b424d000 b4256000 r-xp /usr/lib/libappcore-common.so.1.1
b4259000 b425b000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b4270000 b4272000 r-xp /usr/lib/libXau.so.6.0.0
b4273000 b4295000 r-xp /usr/lib/libxcb.so.1.1.0
b4297000 b42a0000 r-xp /lib/libcrypt-2.20-2014.11.so
b42c9000 b42cb000 r-xp /usr/lib/libiri.so
b42cc000 b42f2000 r-xp /lib/libexpat.so.1.5.2
b42f4000 b435f000 r-xp /usr/lib/libssl.so.1.0.0
b4365000 b4371000 r-xp /usr/lib/libethumb.so.1.13.0
b4372000 b4376000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4377000 b45c8000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b43000 b5b53000 r-xp /usr/lib/libXi.so.6.1.0
b5b54000 b5b56000 r-xp /usr/lib/libXgesture.so.7.0.0
b5b57000 b5b5d000 r-xp /usr/lib/libXtst.so.6.1.0
b5b5e000 b5b68000 r-xp /usr/lib/libXrender.so.1.3.0
b5b69000 b5b72000 r-xp /usr/lib/libXrandr.so.2.2.0
b5b74000 b5b76000 r-xp /usr/lib/libXinerama.so.1.0.0
b5b77000 b5b7c000 r-xp /usr/lib/libXfixes.so.3.1.0
b5b7d000 b5b8f000 r-xp /usr/lib/libXext.so.6.4.0
b5b90000 b5b92000 r-xp /usr/lib/libXdamage.so.1.1.0
b5b93000 b5b95000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5b97000 b5cd9000 r-xp /usr/lib/libX11.so.6.3.0
b5cdd000 b5ce7000 r-xp /usr/lib/libXcursor.so.1.0.2
b5ce8000 b5cfe000 r-xp /usr/lib/libudev.so.1.6.0
b5d01000 b5d05000 r-xp /lib/libattr.so.1.1.0
b5d06000 b5d35000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d37000 b5d3d000 r-xp /usr/lib/libffi.so.6.0.2
b5d3e000 b5d61000 r-xp /lib/libz.so.1.2.8
b5d62000 b5d65000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5d66000 b5ec2000 r-xp /usr/lib/libxml2.so.2.9.2
b5ec8000 b5faf000 r-xp /usr/lib/libstdc++.so.6.0.20
b5fbc000 b5fbf000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5fc0000 b5fe2000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5fe3000 b5ff7000 r-xp /lib/libresolv-2.20-2014.11.so
b5ffb000 b601f000 r-xp /usr/lib/liblzma.so.5.0.3
b6020000 b6022000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b6024000 b602e000 r-xp /usr/lib/libembryo.so.1.13.0
b602f000 b6058000 r-xp /usr/lib/libpng12.so.0.50.0
b6059000 b60a2000 r-xp /usr/lib/libjpeg.so.8.0.2
b60b3000 b60ba000 r-xp /lib/librt-2.20-2014.11.so
b60bc000 b60db000 r-xp /usr/lib/libector.so.1.13.0
b60de000 b610b000 r-xp /usr/lib/liblua-5.1.so
b610c000 b619c000 r-xp /usr/lib/libfreetype.so.6.11.3
b61a0000 b61de000 r-xp /usr/lib/libfontconfig.so.1.8.0
b61df000 b61f5000 r-xp /usr/lib/libfribidi.so.0.3.1
b61f6000 b624f000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6252000 b629d000 r-xp /lib/libm-2.20-2014.11.so
b629f000 b62b1000 r-xp /usr/lib/libeio.so.1.13.0
b62b2000 b62b5000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b62b6000 b62bc000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b62bd000 b62e0000 r-xp /usr/lib/libefreet.so.1.13.0
b62e3000 b630e000 r-xp /usr/lib/libeldbus.so.1.13.0
b630f000 b6343000 r-xp /usr/lib/libecore_con.so.1.13.0
b6345000 b634e000 r-xp /usr/lib/libecore_imf.so.1.13.0
b634f000 b6358000 r-xp /usr/lib/libethumb_client.so.1.13.0
b6359000 b636c000 r-xp /usr/lib/libeo.so.1.13.0
b636e000 b6381000 r-xp /usr/lib/libecore_input.so.1.13.0
b6382000 b6389000 r-xp /usr/lib/libecore_file.so.1.13.0
b638a000 b63ad000 r-xp /usr/lib/libecore_evas.so.1.13.0
b63ae000 b63da000 r-xp /usr/lib/libeet.so.1.13.0
b63e3000 b644e000 r-xp /usr/lib/libeina.so.1.13.0
b6451000 b6468000 r-xp /usr/lib/libefl.so.1.13.0
b646a000 b65d1000 r-xp /usr/lib/libicuuc.so.51.1
b65df000 b67eb000 r-xp /usr/lib/libicui18n.so.51.1
b67f3000 b6842000 r-xp /usr/lib/libecore_x.so.1.13.0
b6844000 b685e000 r-xp /lib/libgcc_s-4.9.so.1
b6860000 b6864000 r-xp /lib/libcap.so.2.21
b6865000 b68ab000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b68ac000 b68b3000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b68b5000 b6907000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b6909000 b6a94000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6a99000 b6b67000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6b6a000 b6b6e000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6b6f000 b6b7e000 r-xp /usr/lib/libvconf.so.0.2.45
b6b7f000 b6b82000 r-xp /usr/lib/libvasum.so.0.3.1
b6b83000 b6b86000 r-xp /usr/lib/libttrace.so.1.1
b6b88000 b6b8c000 r-xp /usr/lib/libiniparser.so.0
b6b8d000 b6bbd000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6bbe000 b6bc7000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6bc8000 b6bed000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6bee000 b6bfe000 r-xp /usr/lib/libunwind.so.8.0.1
b6c08000 b6db6000 r-xp /lib/libc-2.20-2014.11.so
b6dbe000 b6f01000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f03000 b6f5b000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6f5c000 b6f90000 r-xp /usr/lib/libsystemd.so.0.4.0
b6f93000 b7067000 r-xp /usr/lib/libedje.so.1.13.0
b706a000 b7096000 r-xp /usr/lib/libecore.so.1.13.0
b70a7000 b72cd000 r-xp /usr/lib/libevas.so.1.13.0
b72f5000 b730d000 r-xp /lib/libpthread-2.20-2014.11.so
b7311000 b768b000 r-xp /usr/lib/libelementary.so.1.13.0
b76ab000 b76af000 r-xp /usr/lib/libsmack.so.1.0.0
b76b0000 b76b9000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b76ba000 b76bd000 r-xp /usr/lib/libdlog.so.0.0.0
b76be000 b76c3000 r-xp /usr/lib/libbundle.so.0.1.22
b76c4000 b76c7000 r-xp /lib/libdl-2.20-2014.11.so
b76c9000 b76ee000 r-xp /usr/lib/libaul.so.0.1.0
b76f1000 b76f3000 r-xp /usr/lib/libappsvc.so.0.1.0
b76f4000 b76f9000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b76fa000 b7701000 r-xp /usr/lib/libappcore-efl.so.1.1
b7703000 b7708000 r-xp /usr/lib/libsys-assert.so
b770b000 b770c000 r-xp [vdso]
b770c000 b772e000 r-xp /lib/ld-2.20-2014.11.so
b7730000 b7738000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:17894)
Call Stack Count: 97
 0: (0xb6d39c0b) [/lib/libc.so.6] + 0x131c0b
 1: gl_del_cb + 0xa8 (0xb376e118) [/opt/usr/apps/org.example.example/bin/example] + 0x7118
 2: (0xb746d1f9) [/usr/lib/libelementary.so.1] + 0x15c1f9
 3: elm_genlist_clear + 0x9b (0xb746d42b) [/usr/lib/libelementary.so.1] + 0x15c42b
 4: (0xb746d669) [/usr/lib/libelementary.so.1] + 0x15c669
 5: evas_obj_smart_del + 0x99 (0xb7131eb9) [/usr/lib/libevas.so.1] + 0x8aeb9
 6: (0xb71336f1) [/usr/lib/libevas.so.1] + 0x8c6f1
 7: (0xb712675b) [/usr/lib/libevas.so.1] + 0x7f75b
 8: eo_destructor + 0x99 (0xb6364079) [/usr/lib/libeo.so.1] + 0xb079
 9: (0xb758238b) [/usr/lib/libelementary.so.1] + 0x27138b
10: eo_destructor + 0x99 (0xb6364079) [/usr/lib/libeo.so.1] + 0xb079
11: _eo_do_end + 0x15b (0xb635c5ab) [/usr/lib/libeo.so.1] + 0x35ab
12: eo_del + 0xb3 (0xb63617a3) [/usr/lib/libeo.so.1] + 0x87a3
13: evas_object_del + 0x81 (0xb711bcc1) [/usr/lib/libevas.so.1] + 0x74cc1
14: (0xb7590245) [/usr/lib/libelementary.so.1] + 0x27f245
15: evas_obj_smart_del + 0x99 (0xb7131eb9) [/usr/lib/libevas.so.1] + 0x8aeb9
16: (0xb747fbf9) [/usr/lib/libelementary.so.1] + 0x16ebf9
17: evas_obj_smart_del + 0x99 (0xb7131eb9) [/usr/lib/libevas.so.1] + 0x8aeb9
18: (0xb71336f1) [/usr/lib/libevas.so.1] + 0x8c6f1
19: (0xb712675b) [/usr/lib/libevas.so.1] + 0x7f75b
20: eo_destructor + 0x99 (0xb6364079) [/usr/lib/libeo.so.1] + 0xb079
21: (0xb758238b) [/usr/lib/libelementary.so.1] + 0x27138b
22: eo_destructor + 0x99 (0xb6364079) [/usr/lib/libeo.so.1] + 0xb079
23: _eo_do_end + 0x15b (0xb635c5ab) [/usr/lib/libeo.so.1] + 0x35ab
24: eo_del + 0xb3 (0xb63617a3) [/usr/lib/libeo.so.1] + 0x87a3
25: evas_object_del + 0x81 (0xb711bcc1) [/usr/lib/libevas.so.1] + 0x74cc1
26: (0xb7590245) [/usr/lib/libelementary.so.1] + 0x27f245
27: evas_obj_smart_del + 0x99 (0xb7131eb9) [/usr/lib/libevas.so.1] + 0x8aeb9
28: (0xb74c5706) [/usr/lib/libelementary.so.1] + 0x1b4706
29: evas_obj_smart_del + 0x99 (0xb7131eb9) [/usr/lib/libevas.so.1] + 0x8aeb9
30: (0xb74b553f) [/usr/lib/libelementary.so.1] + 0x1a453f
31: evas_obj_smart_del + 0x99 (0xb7131eb9) [/usr/lib/libevas.so.1] + 0x8aeb9
32: (0xb71336f1) [/usr/lib/libevas.so.1] + 0x8c6f1
33: (0xb712675b) [/usr/lib/libevas.so.1] + 0x7f75b
34: eo_destructor + 0x99 (0xb6364079) [/usr/lib/libeo.so.1] + 0xb079
35: (0xb758238b) [/usr/lib/libelementary.so.1] + 0x27138b
36: eo_destructor + 0x99 (0xb6364079) [/usr/lib/libeo.so.1] + 0xb079
37: _eo_do_end + 0x15b (0xb635c5ab) [/usr/lib/libeo.so.1] + 0x35ab
38: eo_del + 0xb3 (0xb63617a3) [/usr/lib/libeo.so.1] + 0x87a3
39: evas_object_del + 0x81 (0xb711bcc1) [/usr/lib/libevas.so.1] + 0x74cc1
40: (0xb7590245) [/usr/lib/libelementary.so.1] + 0x27f245
41: evas_obj_smart_del + 0x99 (0xb7131eb9) [/usr/lib/libevas.so.1] + 0x8aeb9
42: (0xb74c5706) [/usr/lib/libelementary.so.1] + 0x1b4706
43: evas_obj_smart_del + 0x99 (0xb7131eb9) [/usr/lib/libevas.so.1] + 0x8aeb9
44: (0xb71336f1) [/usr/lib/libevas.so.1] + 0x8c6f1
45: (0xb712675b) [/usr/lib/libevas.so.1] + 0x7f75b
46: eo_destructor + 0x99 (0xb6364079) [/usr/lib/libeo.so.1] + 0xb079
47: (0xb758238b) [/usr/lib/libelementary.so.1] + 0x27138b
48: eo_destructor + 0x99 (0xb6364079) [/usr/lib/libeo.so.1] + 0xb079
49: _eo_do_end + 0x15b (0xb635c5ab) [/usr/lib/libeo.so.1] + 0x35ab
50: eo_del + 0xb3 (0xb63617a3) [/usr/lib/libeo.so.1] + 0x87a3
51: evas_object_del + 0x81 (0xb711bcc1) [/usr/lib/libevas.so.1] + 0x74cc1
52: (0xb757f9d1) [/usr/lib/libelementary.so.1] + 0x26e9d1
53: eo_destructor + 0x99 (0xb6364079) [/usr/lib/libeo.so.1] + 0xb079
54: (0xb73b16af) [/usr/lib/libelementary.so.1] + 0xa06af
55: eo_destructor + 0x99 (0xb6364079) [/usr/lib/libeo.so.1] + 0xb079
56: _eo_do_end + 0x15b (0xb635c5ab) [/usr/lib/libeo.so.1] + 0x35ab
57: (0xb73b0b61) [/usr/lib/libelementary.so.1] + 0x9fb61
58: evas_obj_smart_del + 0x99 (0xb7131eb9) [/usr/lib/libevas.so.1] + 0x8aeb9
59: (0xb71336f1) [/usr/lib/libevas.so.1] + 0x8c6f1
60: (0xb712675b) [/usr/lib/libevas.so.1] + 0x7f75b
61: eo_destructor + 0x99 (0xb6364079) [/usr/lib/libeo.so.1] + 0xb079
62: (0xb758238b) [/usr/lib/libelementary.so.1] + 0x27138b
63: eo_destructor + 0x99 (0xb6364079) [/usr/lib/libeo.so.1] + 0xb079
64: _eo_do_end + 0x15b (0xb635c5ab) [/usr/lib/libeo.so.1] + 0x35ab
65: eo_del + 0xb3 (0xb63617a3) [/usr/lib/libeo.so.1] + 0x87a3
66: evas_object_del + 0x81 (0xb711bcc1) [/usr/lib/libevas.so.1] + 0x74cc1
67: (0xb7590245) [/usr/lib/libelementary.so.1] + 0x27f245
68: evas_obj_smart_del + 0x99 (0xb7131eb9) [/usr/lib/libevas.so.1] + 0x8aeb9
69: (0xb74c5706) [/usr/lib/libelementary.so.1] + 0x1b4706
70: evas_obj_smart_del + 0x99 (0xb7131eb9) [/usr/lib/libevas.so.1] + 0x8aeb9
71: (0xb740b425) [/usr/lib/libelementary.so.1] + 0xfa425
72: evas_obj_smart_del + 0x99 (0xb7131eb9) [/usr/lib/libevas.so.1] + 0x8aeb9
73: (0xb71336f1) [/usr/lib/libevas.so.1] + 0x8c6f1
74: (0xb712675b) [/usr/lib/libevas.so.1] + 0x7f75b
75: eo_destructor + 0x99 (0xb6364079) [/usr/lib/libeo.so.1] + 0xb079
76: (0xb758238b) [/usr/lib/libelementary.so.1] + 0x27138b
77: eo_destructor + 0x99 (0xb6364079) [/usr/lib/libeo.so.1] + 0xb079
78: _eo_do_end + 0x15b (0xb635c5ab) [/usr/lib/libeo.so.1] + 0x35ab
79: eo_del + 0xb3 (0xb63617a3) [/usr/lib/libeo.so.1] + 0x87a3
80: evas_object_del + 0x81 (0xb711bcc1) [/usr/lib/libevas.so.1] + 0x74cc1
81: (0xb7133087) [/usr/lib/libevas.so.1] + 0x8c087
82: (0xb7135ebb) [/usr/lib/libevas.so.1] + 0x8eebb
83: evas_obj_smart_del + 0x99 (0xb7131eb9) [/usr/lib/libevas.so.1] + 0x8aeb9
84: (0xb713df8c) [/usr/lib/libevas.so.1] + 0x96f8c
85: evas_obj_smart_del + 0x99 (0xb7131eb9) [/usr/lib/libevas.so.1] + 0x8aeb9
86: (0xb71336f1) [/usr/lib/libevas.so.1] + 0x8c6f1
87: (0xb712675b) [/usr/lib/libevas.so.1] + 0x7f75b
88: eo_destructor + 0x99 (0xb6364079) [/usr/lib/libeo.so.1] + 0xb079
89: _eo_do_end + 0x15b (0xb635c5ab) [/usr/lib/libeo.so.1] + 0x35ab
90: eo_del + 0xb3 (0xb63617a3) [/usr/lib/libeo.so.1] + 0x87a3
91: evas_object_del + 0x81 (0xb711bcc1) [/usr/lib/libevas.so.1] + 0x74cc1
92: (0xb75a1f44) [/usr/lib/libelementary.so.1] + 0x290f44
93: evas_obj_smart_del + 0x99 (0xb7131eb9) [/usr/lib/libevas.so.1] + 0x8aeb9
94: (0xb71336f1) [/usr/lib/libevas.so.1] + 0x8c6f1
95: (0xb712675b) [/usr/lib/libevas.so.1] + 0x7f75b
96: eo_destructor + 0x99 (0xb6364079) [/usr/lib/libeo.so.1] + 0xb079
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
44.357+0900 E/cluster-home( 2863): homescreen.cpp: OnPause(84) >  app pause
06-04 04:23:44.357+0900 D/cluster-view( 2863): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
06-04 04:23:44.357+0900 D/cluster-view( 2863): homescreen-view-manager.cpp: AppPause(923) >  END
06-04 04:23:44.357+0900 D/APP_CORE( 2863): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-04 04:23:44.357+0900 E/APP_CORE( 2863): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-04 04:23:44.357+0900 D/AUL_AMD ( 2771): amd_status.c: _status_update_app_info_list(456) > pid(2863) status(4)
06-04 04:23:44.357+0900 D/AUL_AMD ( 2771): amd_status.c: _status_update_app_info_list(468) > pid(2863) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
06-04 04:23:44.357+0900 D/AUL     ( 2771): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
06-04 04:23:44.357+0900 W/AUL     ( 2771): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2863, appid: org.tizen.homescreen, status: bg
06-04 04:23:44.357+0900 D/AUL_AMD ( 2771): amd_launch.c: __e17_status_handler(2891) > pid(17894) status(3)
06-04 04:23:44.357+0900 D/AUL_AMD ( 2771): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
06-04 04:23:44.357+0900 W/AUL_AMD ( 2771): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-04 04:23:44.357+0900 W/AUL_AMD ( 2771): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
06-04 04:23:44.357+0900 D/AUL_AMD ( 2771): amd_status.c: _status_update_app_info_list(456) > pid(17894) status(3)
06-04 04:23:44.357+0900 D/AUL_AMD ( 2771): amd_status.c: _status_update_app_info_list(468) > pid(17894) appid(org.example.example) pkgid(org.example.example) status(3)
06-04 04:23:44.357+0900 D/AUL     ( 2771): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.example
06-04 04:23:44.357+0900 W/AUL     ( 2771): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 17894, appid: org.example.example, status: fg
06-04 04:23:44.357+0900 D/RESOURCED( 2841): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 17894
06-04 04:23:44.357+0900 D/RESOURCED( 2841): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 17894, proc_name: org.example.example, cg_name: foreground, oom_score_adj: 200
06-04 04:23:44.357+0900 D/RESOURCED( 2841): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 17894
06-04 04:23:44.367+0900 D/DATA_PROVIDER_MASTER( 2915): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2863 is paused
06-04 04:23:44.367+0900 D/DATA_PROVIDER_MASTER( 2915): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
06-04 04:23:44.367+0900 I/CAPI_WIDGET_APPLICATION( 3019): widget_app.c: __provider_pause_cb(294) > widget obj was paused
06-04 04:23:44.367+0900 I/CAPI_WIDGET_APPLICATION( 3019): widget_app.c: __check_status_for_cgroup(142) > enter background group
06-04 04:23:44.367+0900 W/AUL     ( 3019): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3019, appid: org.tizen.calendar.widget, status: bg
06-04 04:23:44.407+0900 D/APP_CORE(17894): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2400002 fully_obscured 0
06-04 04:23:44.407+0900 D/APP_CORE(17894): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
06-04 04:23:44.407+0900 D/APP_CORE(17894): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
06-04 04:23:44.407+0900 I/APP_CORE(17894): appcore-efl.c: __do_app(496) > [APP 17894] Event: RESUME State: CREATED
06-04 04:23:44.407+0900 D/LAUNCH  (17894): appcore-efl.c: __do_app(597) > [example:Application:resume:start]
06-04 04:23:44.407+0900 D/APP_CORE(17894): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
06-04 04:23:44.407+0900 D/APP_CORE(17894): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-04 04:23:44.407+0900 D/APP_CORE(17894): appcore-efl.c: __do_app(607) > [APP 17894] RESUME
06-04 04:23:44.407+0900 I/APP_CORE(17894): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
06-04 04:23:44.407+0900 I/APP_CORE(17894): appcore-efl.c: __do_app(614) > [APP 17894] Initial Launching, call the resume_cb
06-04 04:23:44.407+0900 I/CAPI_APPFW_APPLICATION(17894): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
06-04 04:23:44.407+0900 D/LAUNCH  (17894): appcore-efl.c: __do_app(636) > [example:Application:resume:done]
06-04 04:23:44.407+0900 D/LAUNCH  (17894): appcore-efl.c: __do_app(638) > [example:Application:Launching:done]
06-04 04:23:44.407+0900 D/APP_CORE(17894): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-04 04:23:44.407+0900 E/APP_CORE(17894): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-04 04:23:44.417+0900 D/RESOURCED( 2841): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 17894, appname = org.example.example, pkgname = org.example.example
06-04 04:23:44.417+0900 D/RESOURCED( 2841): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 17894, appname = org.example.example
06-04 04:23:44.417+0900 D/RESOURCED( 2841): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 17894
06-04 04:23:44.417+0900 D/RESOURCED( 2841): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3019, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
06-04 04:23:44.417+0900 D/RESOURCED( 2841): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 3019
06-04 04:23:44.417+0900 D/RESOURCED( 2841): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 3019, appname = org.tizen.calendar.widget
06-04 04:23:44.417+0900 D/RESOURCED( 2841): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 3019
06-04 04:23:44.417+0900 I/RESOURCED( 2841): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
06-04 04:23:44.417+0900 I/RESOURCED( 2841): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
06-04 04:23:44.497+0900 D/AUL_AMD ( 2771): amd_launch.c: __e17_status_handler(2910) > pid(17894) status(0)
06-04 04:23:44.787+0900 D/AUL_AMD ( 2771): amd_status.c: __app_terminate_timer_cb(442) > pid(17718)
06-04 04:23:44.787+0900 W/AUL_AMD ( 2771): amd_status.c: __app_terminate_timer_cb(446) > send SIGKILL: No such process
06-04 04:23:44.787+0900 D/AUL_AMD ( 2771): amd_status.c: __app_terminate_timer_cb(442) > pid(17718)
06-04 04:23:44.787+0900 W/AUL_AMD ( 2771): amd_status.c: __app_terminate_timer_cb(446) > send SIGKILL: No such process
06-04 04:23:44.927+0900 D/AUL_PAD ( 2913): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
06-04 04:23:44.927+0900 D/AUL_PAD (18114): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
06-04 04:23:44.937+0900 D/AUL_PAD ( 2913): sigchild.h: __send_app_launch_signal(131) > send launch signal done
06-04 04:23:44.937+0900 E/RESOURCED( 2841): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1583
06-04 04:23:44.997+0900 E/PKGMGR_SERVER(18038): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-04 04:23:44.997+0900 E/PKGMGR_SERVER(18038): pkgmgr-server.c: main(2265) > package manager server terminated.
06-04 04:23:45.217+0900 I/user_tag0(17894): /opt/usr/apps/org.example.example/data/feeding.db
06-04 04:23:45.217+0900 I/tag     (17894): eonji~
06-04 04:23:45.277+0900 D/PROCESSMGR( 2690): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x603fa0 
06-04 04:23:45.437+0900 D/AUL_AMD ( 2771): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.example /opt/usr/apps/org.example.example/bin/example
06-04 04:23:45.437+0900 D/RUA     ( 2771): rua.c: rua_add_history(179) > rua_add_history start
06-04 04:23:45.447+0900 D/RUA     ( 2771): rua.c: rua_add_history(247) > rua_add_history ok
06-04 04:23:45.957+0900 D/AUL_PAD (18114): launchpad_loader.c: main(588) > sleeping 1 sec...
06-04 04:23:45.957+0900 D/AUL_PAD (18114): preload.h: __preload_init(52) > max_cmdline_size = 1053
06-04 04:23:45.967+0900 D/AUL_PAD (18114): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b8b17760
06-04 04:23:45.967+0900 D/AUL_PAD (18114): preload.h: __preload_init(69) > get pre-initialization function
06-04 04:23:45.967+0900 D/AUL_PAD (18114): preload.h: __preload_init(73) > get shutdown function
06-04 04:23:45.977+0900 D/AUL_PAD (18114): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b8b17a40
06-04 04:23:45.977+0900 D/AUL_PAD (18114): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b8b19640
06-04 04:23:45.977+0900 D/AUL_PAD (18114): preload.h: __preload_init(69) > get pre-initialization function
06-04 04:23:45.977+0900 D/AUL_PAD (18114): preload.h: __preload_init(73) > get shutdown function
06-04 04:23:45.977+0900 D/AUL_PAD (18114): preexec.h: __preexec_init(76) > preexec start
06-04 04:23:45.977+0900 D/AUL_PAD (18114): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
06-04 04:23:45.977+0900 D/AUL     (18114): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
06-04 04:23:45.977+0900 D/AUL     (18114): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
06-04 04:23:45.977+0900 D/AUL_PAD ( 2913): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
06-04 04:23:45.977+0900 D/AUL_PAD ( 2913): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
06-04 04:23:45.977+0900 D/AUL_PAD ( 2913): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-04 04:23:45.977+0900 D/AUL_PAD ( 2913): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-04 04:23:45.977+0900 D/AUL_PAD ( 2913): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-04 04:23:45.977+0900 D/AUL_PAD ( 2913): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-04 04:23:45.977+0900 D/AUL_PAD ( 2913): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-04 04:23:45.977+0900 D/AUL_PAD ( 2913): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
06-04 04:23:45.977+0900 D/AUL_PAD ( 2913): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 18114
06-04 04:23:45.977+0900 D/AUL     (18114): process_pool.c: __connect_to_launchpad(132) > send(18114) : 4
06-04 04:23:45.977+0900 D/AUL     (18114): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
06-04 04:23:46.047+0900 D/AUL_PAD (18114): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
06-04 04:23:46.057+0900 D/AUL_PAD (18114): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
06-04 04:23:46.057+0900 D/AUL_PAD (18114): launchpad_loader.c: main(693) > [candidate] ecore handler add
06-04 04:23:46.057+0900 D/AUL_PAD (18114): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
06-04 04:23:46.287+0900 D/PROCESSMGR( 2690): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2400002
06-04 04:23:46.317+0900 D/PROCESSMGR( 2690): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x603fa0 
06-04 04:23:46.777+0900 D/PROCESSMGR( 2690): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x603fa0 
06-04 04:23:46.887+0900 E/EFL     (17894): edje<17894> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:23:46.887+0900 E/EFL     (17894): edje<17894> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:23:46.927+0900 E/EFL     (17894): edje<17894> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:23:46.937+0900 E/EFL     (17894): edje<17894> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:23:46.937+0900 E/EFL     (17894): edje<17894> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:23:46.937+0900 E/EFL     (17894): edje<17894> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:23:46.937+0900 E/EFL     (17894): edje<17894> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:23:46.937+0900 E/EFL     (17894): edje<17894> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:23:46.937+0900 E/EFL     (17894): edje<17894> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:23:46.947+0900 D/IMMODULE(17894): isf_imf_context.cpp: initialize(3406) > Initializing Ecore ISF IMModule...
06-04 04:23:46.947+0900 D/ISF_SOCKET(17894): scim_socket.cpp: connect(515) > ppid:2913  trying connect() to local:/tmp/scim-socket-frontend, example
06-04 04:23:46.947+0900 D/ISF_SOCKET(17894): scim_socket.cpp: connect(524) > connect() succeeded
06-04 04:23:46.947+0900 D/ISF_SOCKET(17894): scim_socket.cpp: connect(515) > ppid:2913  trying connect() to local:/tmp/scim-socket-frontend, example
06-04 04:23:46.947+0900 D/ISF_SOCKET(17894): scim_socket.cpp: connect(524) > connect() succeeded
06-04 04:23:46.957+0900 D/ISF_SOCKET(17894): scim_socket.cpp: connect(515) > ppid:2913  trying connect() to local:/tmp/scim-socket-frontend, example
06-04 04:23:46.957+0900 D/ISF_SOCKET(17894): scim_socket.cpp: connect(524) > connect() succeeded
06-04 04:23:46.957+0900 D/ISF_QUERY(17894): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="ise-default", label="Tizen keyboard", pkgid="ise-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-helper-launcher", mname="ise-default", mpath="/usr/lib/scim-1.0/1.4.0/Helper", mode=1, options=13, is_enabled=1, is_preinstalled=1, has_option=1, disp_lang="en_US.UTF-8"
06-04 04:23:46.957+0900 D/ISF_QUERY(17894): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-anthy", label="Japanese keyboard", pkgid="ise-engine-anthy", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-anthy", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 04:23:46.957+0900 D/ISF_QUERY(17894): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-default", label="Default keyboard", pkgid="ise-engine-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-default", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 04:23:46.957+0900 D/ISF_QUERY(17894): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-hangul", label="Hangul keyboard", pkgid="hangul", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="hangul", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 04:23:46.957+0900 D/ISF_QUERY(17894): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-sunpinyin", label="Chinese (sunpinyin) keyboard", pkgid="ise-engine-sunpinyin", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-sunpinyin", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 04:23:46.957+0900 D/ISF_QUERY(17894): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.cangjie3", label="CanJie 3 keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 04:23:46.957+0900 D/ISF_QUERY(17894): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.zhuyin-big", label="ZhuYin Big keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 04:23:46.957+0900 D/ISF_SOCKET(17894): scim_socket.cpp: connect(515) > ppid:2913  trying connect() to local:/tmp/scim-socket-frontend, example
06-04 04:23:46.957+0900 D/ISF_SOCKET(17894): scim_socket.cpp: connect(524) > connect() succeeded
06-04 04:23:46.957+0900 D/IMMODULE(17894): scim_panel_client.cpp: open_connection(162) > 
06-04 04:23:46.957+0900 D/ISF_SOCKET(17894): scim_socket.cpp: connect(515) > ppid:2913  trying connect() to local:/tmp/scim-panel-socket:0, example
06-04 04:23:46.957+0900 D/ISF_SOCKET(17894): scim_socket.cpp: connect(524) > connect() succeeded
06-04 04:23:46.967+0900 D/ISF_SOCKET(17894): scim_socket.cpp: connect(515) > ppid:2913  trying connect() to local:/tmp/scim-panel-socket:0, example
06-04 04:23:46.967+0900 D/ISF_SOCKET(17894): scim_socket.cpp: connect(524) > connect() succeeded
06-04 04:23:46.967+0900 D/IMMODULE(17894): isf_imf_control_ui.cpp: isf_imf_input_panel_init(516) > keyboard mode(0:H/W Keyboard, 1:S/W Keyboard): 0
06-04 04:23:47.617+0900 D/PROCESSMGR( 2690): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x603fa0 
06-04 04:23:47.727+0900 I/tag     (17894): insert
06-04 04:23:47.727+0900 I/user_tag(17894): 04:23 AM
06-04 04:23:47.737+0900 E/EFL     (17894): edje<17894> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:23:47.737+0900 E/EFL     (17894): edje<17894> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:23:47.737+0900 E/EFL     (17894): edje<17894> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:23:47.737+0900 E/EFL     (17894): edje<17894> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:23:47.747+0900 E/EFL     (17894): edje<17894> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:23:48.767+0900 D/PROCESSMGR( 2690): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x603fa0 
06-04 04:23:48.907+0900 E/EFL     (17894): edje<17894> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:23:48.917+0900 E/EFL     (17894): edje<17894> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:23:48.947+0900 E/EFL     (17894): edje<17894> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:23:48.947+0900 E/EFL     (17894): edje<17894> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:23:48.957+0900 E/EFL     (17894): edje<17894> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:23:48.957+0900 E/EFL     (17894): edje<17894> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:23:48.957+0900 E/EFL     (17894): edje<17894> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:23:48.957+0900 E/EFL     (17894): edje<17894> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:23:48.957+0900 E/EFL     (17894): edje<17894> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:23:49.367+0900 D/APP_CORE( 2863): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
06-04 04:23:49.367+0900 I/APP_CORE( 2863): appcore-efl.c: __do_app(496) > [APP 2863] Event: MEM_FLUSH State: PAUSED
06-04 04:23:49.367+0900 D/APP_CORE( 2863): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
06-04 04:23:49.367+0900 D/APP_CORE( 2863): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 2863
06-04 04:23:49.367+0900 D/APP_CORE( 2863): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
06-04 04:23:49.367+0900 D/RESOURCED( 2841): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 2863
06-04 04:23:49.807+0900 D/PROCESSMGR( 2690): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x603fa0 
06-04 04:23:49.927+0900 D/PROCESSMGR( 2690): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x603fa0 
06-04 04:23:50.077+0900 D/PROCESSMGR( 2690): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x603fa0 
06-04 04:23:50.417+0900 D/PROCESSMGR( 2690): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x603fa0 
06-04 04:23:50.727+0900 I/tag     (17894): insert
06-04 04:23:50.737+0900 I/user_tag(17894): 04:20 AM
06-04 04:23:50.737+0900 E/EFL     (17894): edje<17894> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:23:50.737+0900 E/EFL     (17894): edje<17894> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:23:50.737+0900 E/EFL     (17894): edje<17894> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:23:50.737+0900 E/EFL     (17894): edje<17894> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:23:50.747+0900 E/EFL     (17894): edje<17894> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 04:23:51.287+0900 D/PROCESSMGR( 2690): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x603fa0 bd->visible=1
06-04 04:23:51.437+0900 D/PROCESSMGR( 2690): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x603fa0 
06-04 04:23:52.397+0900 D/PROCESSMGR( 2690): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x603fa0 
06-04 04:23:52.557+0900 E/EFL     (17894): edje<17894> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
06-04 04:23:52.557+0900 E/EFL     (17894): By the power of Grayskull, your previous Embryo stack is now broken!
06-04 04:23:52.937+0900 I/tag     (17894): 0
06-04 04:23:52.937+0900 I/tag     (17894): delete~~~
06-04 04:23:52.937+0900 I/tag     (17894): DELETE FROM feeding WHERE TM_HOUR = '4' AND TM_MIN = '23';
06-04 04:23:52.947+0900 I/tag     (17894): 0
06-04 04:23:52.947+0900 I/tag     (17894): 1
06-04 04:23:52.947+0900 I/tag     (17894): 지우고~
06-04 04:23:52.957+0900 I/tag     (17894): 팝업 지워~
06-04 04:23:52.957+0900 I/tag     (17894): 끝
06-04 04:23:55.017+0900 E/CAPI_NETWORK_WIFI( 2846): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-04 04:23:55.017+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
06-04 04:23:55.017+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-04 04:23:55.017+0900 E/INDICATOR( 2846): 
06-04 04:24:00.447+0900 D/INDICATOR( 2846): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
06-04 04:24:00.447+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
06-04 04:24:00.447+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
06-04 04:24:00.447+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 4:24 4 h"
06-04 04:24:00.447+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 4:24"
06-04 04:24:00.447+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 4&#x2236;24"
06-04 04:24:00.447+0900 D/INDICATOR( 2846): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2146103154 Time: <font_size=33>4&#x2236;24</font_size> <font_size=32>AM</font_size></font>
06-04 04:24:15.026+0900 E/CAPI_NETWORK_WIFI( 2846): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-04 04:24:15.026+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
06-04 04:24:15.026+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-04 04:24:15.026+0900 E/INDICATOR( 2846): 
06-04 04:24:20.136+0900 D/RESOURCED( 2841): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
06-04 04:24:20.136+0900 I/RESOURCED( 2841): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
06-04 04:24:20.136+0900 D/RESOURCED( 2841): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
06-04 04:24:20.136+0900 I/RESOURCED( 2841): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
06-04 04:24:35.076+0900 E/CAPI_NETWORK_WIFI( 2846): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-04 04:24:35.076+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
06-04 04:24:35.076+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-04 04:24:35.076+0900 E/INDICATOR( 2846): 
06-04 04:24:55.096+0900 E/CAPI_NETWORK_WIFI( 2846): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-04 04:24:55.096+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
06-04 04:24:55.096+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-04 04:24:55.096+0900 E/INDICATOR( 2846): 
06-04 04:25:00.456+0900 D/INDICATOR( 2846): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
06-04 04:25:00.456+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
06-04 04:25:00.456+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
06-04 04:25:00.456+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 4:25 4 h"
06-04 04:25:00.456+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 4:25"
06-04 04:25:00.456+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 4&#x2236;25"
06-04 04:25:00.456+0900 D/INDICATOR( 2846): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2146101102 Time: <font_size=33>4&#x2236;25</font_size> <font_size=32>AM</font_size></font>
06-04 04:25:15.116+0900 E/CAPI_NETWORK_WIFI( 2846): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-04 04:25:15.116+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
06-04 04:25:15.116+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-04 04:25:15.116+0900 E/INDICATOR( 2846): 
06-04 04:25:20.196+0900 D/RESOURCED( 2841): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
06-04 04:25:20.196+0900 I/RESOURCED( 2841): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
06-04 04:25:20.196+0900 D/RESOURCED( 2841): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
06-04 04:25:20.196+0900 I/RESOURCED( 2841): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
06-04 04:25:35.145+0900 E/CAPI_NETWORK_WIFI( 2846): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-04 04:25:35.145+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
06-04 04:25:35.145+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-04 04:25:35.145+0900 E/INDICATOR( 2846): 
06-04 04:25:55.165+0900 E/CAPI_NETWORK_WIFI( 2846): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-04 04:25:55.165+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
06-04 04:25:55.165+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-04 04:25:55.165+0900 E/INDICATOR( 2846): 
06-04 04:26:00.465+0900 D/INDICATOR( 2846): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
06-04 04:26:00.465+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
06-04 04:26:00.465+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
06-04 04:26:00.465+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 4:26 4 h"
06-04 04:26:00.465+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 4:26"
06-04 04:26:00.465+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 4&#x2236;26"
06-04 04:26:00.465+0900 D/INDICATOR( 2846): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2146099050 Time: <font_size=33>4&#x2236;26</font_size> <font_size=32>AM</font_size></font>
06-04 04:26:15.185+0900 E/CAPI_NETWORK_WIFI( 2846): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-04 04:26:15.185+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
06-04 04:26:15.185+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-04 04:26:15.185+0900 E/INDICATOR( 2846): 
06-04 04:26:20.185+0900 D/RESOURCED( 2841): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
06-04 04:26:20.185+0900 I/RESOURCED( 2841): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
06-04 04:26:20.185+0900 D/RESOURCED( 2841): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
06-04 04:26:20.185+0900 I/RESOURCED( 2841): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
06-04 04:26:20.195+0900 I/RESOURCED( 2841): logging.c: logging_save_to_storage(978) > battery cache is empty
06-04 04:26:20.195+0900 D/RESOURCED( 2841): heart-cpu.c: heart_cpu_update(576) > org.tizen.homescreen org.tizen.homescreen 1496517544 637 484 2863 1
06-04 04:26:20.195+0900 D/RESOURCED( 2841): heart-cpu.c: heart_cpu_update(576) > org.tizen.lockscreen org.tizen.lockscreen 1496517555 28 12 17357 2
06-04 04:26:20.195+0900 D/RESOURCED( 2841): heart-cpu.c: heart_cpu_update(576) > org.example.example org.example.example 1496517555 23 6 17370 1
06-04 04:26:20.195+0900 D/RESOURCED( 2841): heart-cpu.c: heart_cpu_update(576) > org.tizen.homescreen org.tizen.homescreen 1496517724 643 488 2863 1
06-04 04:26:20.195+0900 D/RESOURCED( 2841): heart-cpu.c: heart_cpu_update(576) > org.example.example org.example.example 1496517728 20 7 17534 1
06-04 04:26:20.195+0900 D/RESOURCED( 2841): heart-cpu.c: heart_cpu_update(576) > org.tizen.homescreen org.tizen.homescreen 1496517779 651 494 2863 1
06-04 04:26:20.195+0900 D/RESOURCED( 2841): heart-cpu.c: heart_cpu_update(576) > org.example.example org.example.example 1496517783 31 10 17718 1
06-04 04:26:20.195+0900 D/RESOURCED( 2841): heart-cpu.c: heart_cpu_update(576) > org.tizen.homescreen org.tizen.homescreen 1496517819 663 500 2863 1
06-04 04:26:20.195+0900 D/RESOURCED( 2841): heart-cpu.c: heart_cpu_update(576) > org.example.example org.example.example 1496517824 32 3 17894 1
06-04 04:26:24.945+0900 E/PKGMGR_SERVER(18162): pkgmgr-server.c: main(2209) > package manager server start
06-04 04:26:24.945+0900 D/PKGMGR  (18162): comm_pkg_mgr_server.c: pkg_mgr_server_gdbus_init(405) > initialize_gdbus Enter
06-04 04:26:24.945+0900 D/PKGMGR  (18162): comm_pkg_mgr_server.c: pkg_mgr_server_gdbus_init(423) > initialize_gdbus Exit
06-04 04:26:24.955+0900 D/PKGMGR  (18162): comm_pkg_mgr_server.c: on_bus_acquired(376) > on_bus_acquired
06-04 04:26:24.955+0900 D/PKGMGR  (18162): comm_pkg_mgr_server.c: on_bus_acquired(400) > on_bus_acquired done
06-04 04:26:24.965+0900 D/PKGMGR  (18162): comm_pkg_mgr_server.c: pkgmgr_request(145) > Called
06-04 04:26:24.965+0900 D/PKGMGR  (18162): comm_pkg_mgr_server.c: pkgmgr_request(164) > sender_name: :1.1588
06-04 04:26:24.965+0900 D/PKGMGR  (18162): comm_pkg_mgr_server.c: pkg_mgr_get_sender_pid(79) > zone pid : 18160
06-04 04:26:24.965+0900 D/PKGMGR  (18162): comm_pkg_mgr_server.c: pkgmgr_request(166) > sender_pid: 18160
06-04 04:26:24.965+0900 D/PKGMGR  (18162): comm_pkg_mgr_server.c: pkgmgr_request(175) > [SECURE_LOG] Call request callback(obj, org.example.example_1055155530, 14, tpk, org.example.example, , host)
06-04 04:26:24.965+0900 D/PKGMGR_SERVER(18162): pkgmgr-server.c: req_cb(625) > [SECURE_LOG] >> in callback >> Got request: [org.example.example_1055155530] [14] [tpk] [org.example.example] [] [] [host]
06-04 04:26:24.965+0900 D/PKGMGR_SERVER(18162): pkgmgr-server.c: req_cb(646) > req_type=(14)  backend_flag=(0) zone(host)
06-04 04:26:24.965+0900 D/PKGMGR_SERVER(18162): pkgmgr-server.c: queue_job(1880) > target zone(host, host)
06-04 04:26:24.965+0900 D/PKGMGR_SERVER(18165): pkgmgr-server.c: queue_job(1884) > child forked [0] for request type [14]
06-04 04:26:24.965+0900 D/PKGMGR_SERVER(18165): pkgmgr-server.c: queue_job(2057) > kill/check request
06-04 04:26:24.965+0900 D/PKGMGR_SERVER(18162): pkgmgr-server.c: queue_job(1884) > child forked [18165] for request type [14]
06-04 04:26:24.965+0900 D/PKGMGR_SERVER(18162): pkgmgr-server.c: queue_job(2126) > parent exit
06-04 04:26:24.965+0900 D/PKGMGR  (18160): pkgmgr.c: __check_sync_process(868) > info_file file is generated, result = 0
06-04 04:26:24.965+0900 D/PKGMGR  (18160): . 
06-04 04:26:24.965+0900 E/PKGMGR  (18160): pkgmgr.c: __check_sync_process(884) > file is can not remove[/tmp/org.example.example, -1]
06-04 04:26:24.975+0900 D/PKGMGR_SERVER(18165): pkgmgr-server.c: __pkgcmd_app_cb(1458) > sub_cmd(kill), zone_name(host)
06-04 04:26:24.975+0900 D/AUL     (18165): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(14)
06-04 04:26:24.975+0900 D/AUL_AMD ( 2771): amd_request.c: __request_handler(838) > __request_handler: 14
06-04 04:26:24.975+0900 D/AUL_AMD ( 2771): amd_status.c: _status_app_is_running_from_cache(836) > is_running hit cache, return immediately
06-04 04:26:24.975+0900 D/AUL_AMD ( 2771): amd_request.c: __request_handler(1028) > [SECURE_LOG] APP_IS_RUNNING : org.example.example : 17894
06-04 04:26:24.975+0900 W/AUL_AMD ( 2771): amd_request.c: __send_result_to_client(150) > __send_result_to_client, pid: 17894
06-04 04:26:24.975+0900 D/AUL_AMD ( 2771): amd_request.c: __request_handler(838) > __request_handler: 12
06-04 04:26:24.975+0900 D/AUL     (18165): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 293
06-04 04:26:24.975+0900 D/AUL     (18165): launch.c: app_request_to_launchpad(396) > [SECURE_LOG] launch request : 17894
06-04 04:26:24.975+0900 D/AUL     (18165): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(5)
06-04 04:26:24.985+0900 D/AUL_AMD ( 2771): amd_request.c: __request_handler(838) > __request_handler: 5
06-04 04:26:24.985+0900 D/AUL_AMD ( 2771): amd_appinfo.c: appinfo_set_value(905) > [SECURE_LOG] org.example.example : installed : norestart
06-04 04:26:24.985+0900 D/AUL_AMD ( 2771): amd_request.c: __app_process_by_pid(279) > [SECURE_LOG] __app_process_by_pid, pid: 17894, 
06-04 04:26:24.985+0900 D/AUL     ( 2771): app_sock.c: __app_send_raw_with_delay_reply(455) > pid(17894) : cmd(4)
06-04 04:26:24.985+0900 D/AUL_AMD ( 2771): amd_launch.c: _term_app(1076) > term done
06-04 04:26:24.985+0900 D/AUL_AMD ( 2771): amd_launch.c: __set_reply_handler(1015) > listen fd : 31, send fd : 30
06-04 04:26:24.985+0900 D/APP_CORE(17894): appcore.c: __aul_handler(632) > [APP 17894]     AUL event: AUL_TERMINATE
06-04 04:26:24.985+0900 I/APP_CORE(17894): appcore-efl.c: __do_app(496) > [APP 17894] Event: TERMINATE State: RUNNING
06-04 04:26:24.985+0900 D/APP_CORE(17894): appcore-efl.c: __do_app(517) > [APP 17894] TERMINATE
06-04 04:26:24.985+0900 W/AUL_AMD ( 2771): amd_launch.c: __reply_handler(913) > listen fd(31) , send fd(30), pid(17894), cmd(4)
06-04 04:26:24.985+0900 D/AUL     (18165): launch.c: app_request_to_launchpad(425) > launch request result : 0
06-04 04:26:24.985+0900 D/AUL     (18165): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(14)
06-04 04:26:24.985+0900 D/AUL_AMD ( 2771): amd_request.c: __request_handler(838) > __request_handler: 14
06-04 04:26:24.985+0900 D/AUL_AMD ( 2771): amd_status.c: _status_app_is_running_from_cache(836) > is_running hit cache, return immediately
06-04 04:26:24.985+0900 D/AUL_AMD ( 2771): amd_request.c: __request_handler(1028) > [SECURE_LOG] APP_IS_RUNNING : org.example.example : 17894
06-04 04:26:24.985+0900 W/AUL_AMD ( 2771): amd_request.c: __send_result_to_client(150) > __send_result_to_client, pid: 17894
06-04 04:26:24.985+0900 D/RESOURCED( 2841): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 17894
06-04 04:26:24.985+0900 D/AUL     (17894): app_sock.c: __app_send_raw_with_noreply(384) > pid(-2) : cmd(22)
06-04 04:26:24.985+0900 D/AUL_AMD ( 2771): amd_request.c: __request_handler(838) > __request_handler: 22
06-04 04:26:24.985+0900 W/AUL_AMD ( 2771): amd_request.c: __request_handler(1056) > app status : 5
06-04 04:26:24.985+0900 D/AUL_AMD ( 2771): amd_status.c: _status_update_app_info_list(456) > pid(17894) status(5)
06-04 04:26:24.985+0900 D/AUL_AMD ( 2771): amd_status.c: _status_update_app_info_list(468) > pid(17894) appid(org.example.example) pkgid(org.example.example) status(5)
06-04 04:26:24.985+0900 D/AUL     (17894): app_sock.c: __app_send_raw_with_noreply(384) > pid(-2) : cmd(22)
06-04 04:26:24.985+0900 D/AUL_AMD ( 2771): amd_request.c: __request_handler(838) > __request_handler: 22
06-04 04:26:24.985+0900 W/AUL_AMD ( 2771): amd_request.c: __request_handler(1056) > app status : 5
06-04 04:26:24.985+0900 D/AUL_AMD ( 2771): amd_status.c: _status_update_app_info_list(456) > pid(17894) status(5)
06-04 04:26:24.985+0900 D/AUL_AMD ( 2771): amd_status.c: _status_update_app_info_list(468) > pid(17894) appid(org.example.example) pkgid(org.example.example) status(5)
06-04 04:26:24.985+0900 D/APP_CORE(17894): appcore.c: _appcore_fini_suspend_dbus_handler(944) > [__SUSPEND__] suspend signal finalized
06-04 04:26:24.985+0900 D/APP_CORE(17894): appcore-efl.c: __after_loop(1169) > [APP 17894] PAUSE before termination
06-04 04:26:24.985+0900 I/CAPI_APPFW_APPLICATION(17894): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
06-04 04:26:24.985+0900 I/CAPI_APPFW_APPLICATION(17894): app_main.c: _ui_app_appcore_terminate(662) > app_appcore_terminate
06-04 04:26:24.985+0900 E/EFL     (17894): eo<17894> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0x8001a0d1 is not pointing to a valid object. Maybe it has already been freed.
06-04 04:26:24.985+0900 E/EFL     (17894): eo<17894> lib/eo/eo.c:485 _eo_do_internal() Obj (0x8001a0d1) is an invalid ref.
06-04 04:26:24.985+0900 E/EFL     ( 2690): eo<2690> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-04 04:26:24.995+0900 D/AUL_AMD ( 2771): amd_launch.c: __e17_status_handler(2891) > pid(2863) status(3)
06-04 04:26:24.995+0900 D/AUL_AMD ( 2771): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
06-04 04:26:24.995+0900 W/AUL_AMD ( 2771): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-04 04:26:24.995+0900 W/AUL_AMD ( 2771): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
06-04 04:26:24.995+0900 D/AUL_AMD ( 2771): amd_status.c: _status_update_app_info_list(456) > pid(2863) status(3)
06-04 04:26:24.995+0900 D/AUL_AMD ( 2771): amd_status.c: _status_update_app_info_list(468) > pid(2863) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(3)
06-04 04:26:24.995+0900 D/AUL     ( 2771): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.tizen.homescreen
06-04 04:26:24.995+0900 W/AUL     ( 2771): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2863, appid: org.tizen.homescreen, status: fg
06-04 04:26:24.995+0900 D/RESOURCED( 2841): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 2863
06-04 04:26:24.995+0900 D/RESOURCED( 2841): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 2863, appname = org.tizen.homescreen, pkgname = org.tizen.homescreen
06-04 04:26:24.995+0900 D/RESOURCED( 2841): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 2863, appname = org.tizen.homescreen
06-04 04:26:24.995+0900 D/RESOURCED( 2841): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 2863
06-04 04:26:24.995+0900 I/tag     (17894): 0
06-04 04:26:25.005+0900 E/E17     ( 2690): e_border.c: e_border_show(2088) > BD_SHOW(0x01600002)
06-04 04:26:25.015+0900 E/E17     ( 2690): e_border.c: e_border_hide(2248) > BD_HIDE(0x02400002), visible:1
06-04 04:26:25.015+0900 D/INDICATOR( 2846): main.c: _property_changed_cb(432) > UNSNIFF API 2400002
06-04 04:26:25.015+0900 D/INDICATOR( 2846): util.c: util_signal_emit_by_win(116) > emission bg.translucent
06-04 04:26:25.015+0900 D/INDICATOR( 2846): main.c: _rotate_window(229) > Indicator angle is 0 degree
06-04 04:26:25.015+0900 D/INDICATOR( 2846): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
06-04 04:26:25.015+0900 D/INDICATOR( 2846): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
06-04 04:26:25.015+0900 D/INDICATOR( 2846): main.c: _rotate_window(252) > port :: hide more icon
06-04 04:26:25.045+0900 W/CRASH_MANAGER(18167): worker.c: worker_job(1204) > 1117894657861149651798
