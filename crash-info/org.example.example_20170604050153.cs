S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 19622
Date: 2017-06-04 05:01:53+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0x00000008, esi = 0xbfe410d0
ebp = 0xbfe41128, esp = 0xbfe410cc
eax = 0xb3838b43, ebx = 0xb383b000
ecx = 0x00000050, edx = 0x00000000
eip = 0xb6dffc0b

Memory Information
MemTotal:      123 KB
MemFree:        19 KB
Buffers:        11 KB
Cached:     164000 KB
VmPeak:     121304 KB
VmSize:     118188 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       34108 KB
VmRSS:       31024 KB
VmData:      48276 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34636 KB
VmPTE:         100 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 19622 TID = 19622
19622 19624 19784 19785 19790 

Maps Information
b0f32000 b0f4a000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b190a000 b1911000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b1914000 b191b000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b191c000 b1920000 r-xp /usr/lib/elementary/modules/datetime_input_spinner/v-1.13.0/module.so
b2bf5000 b2bff000 r-xp /usr/lib/libfeedback.so.0.1.4
b2c05000 b2c11000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2c12000 b2c33000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2c38000 b2c39000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2c3a000 b2c3f000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2c40000 b2c41000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2c42000 b2c44000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2c45000 b2c47000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2c48000 b2c54000 r-xp /usr/lib/libdrm.so.2.4.0
b2c55000 b2c58000 r-xp /usr/lib/libdri2.so.0.0.0
b2c59000 b2c63000 r-xp /usr/lib/libtbm.so.1.0.0
b2c64000 b2c79000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2c7a000 b2c8c000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b348e000 b34bf000 r-xp /usr/lib/libidn.so.11.5.44
b34c0000 b34e2000 r-xp /usr/lib/libnghttp2.so.5.4.0
b34e3000 b34f3000 r-xp /usr/lib/libcares.so.2.1.0
b34f4000 b34fd000 r-xp /usr/lib/libeventsystem.so.0.0.1
b34fe000 b3507000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3508000 b357f000 r-xp /usr/lib/libcurl.so.4.3.0
b3581000 b3593000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b3594000 b35b5000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b35bc000 b35bd000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b35be000 b35bf000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b35c0000 b35c3000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b35c4000 b35c7000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b36cf000 b36d5000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b36d6000 b381a000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b382b000 b382c000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b382d000 b383a000 r-xp /opt/usr/apps/org.example.example/bin/example
b383c000 b3875000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b4278000 b4283000 r-xp /lib/libnss_files-2.20-2014.11.so
b4285000 b4290000 r-xp /lib/libnss_nis-2.20-2014.11.so
b4292000 b42a9000 r-xp /lib/libnsl-2.20-2014.11.so
b42ad000 b42b5000 r-xp /lib/libnss_compat-2.20-2014.11.so
b42b7000 b42db000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b42dc000 b42dd000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b42de000 b42e1000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b42e2000 b42e9000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b42ea000 b42f4000 r-xp /usr/lib/libsensord-share.so
b42f5000 b4311000 r-xp /usr/lib/libsensor.so.1.2.0
b4313000 b431c000 r-xp /usr/lib/libappcore-common.so.1.1
b431f000 b4321000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b4336000 b4338000 r-xp /usr/lib/libXau.so.6.0.0
b4339000 b435b000 r-xp /usr/lib/libxcb.so.1.1.0
b435d000 b4366000 r-xp /lib/libcrypt-2.20-2014.11.so
b438f000 b4391000 r-xp /usr/lib/libiri.so
b4392000 b43b8000 r-xp /lib/libexpat.so.1.5.2
b43ba000 b4425000 r-xp /usr/lib/libssl.so.1.0.0
b442b000 b4437000 r-xp /usr/lib/libethumb.so.1.13.0
b4438000 b443c000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b443d000 b468e000 r-xp /usr/lib/libcrypto.so.1.0.0
b5c09000 b5c19000 r-xp /usr/lib/libXi.so.6.1.0
b5c1a000 b5c1c000 r-xp /usr/lib/libXgesture.so.7.0.0
b5c1d000 b5c23000 r-xp /usr/lib/libXtst.so.6.1.0
b5c24000 b5c2e000 r-xp /usr/lib/libXrender.so.1.3.0
b5c2f000 b5c38000 r-xp /usr/lib/libXrandr.so.2.2.0
b5c3a000 b5c3c000 r-xp /usr/lib/libXinerama.so.1.0.0
b5c3d000 b5c42000 r-xp /usr/lib/libXfixes.so.3.1.0
b5c43000 b5c55000 r-xp /usr/lib/libXext.so.6.4.0
b5c56000 b5c58000 r-xp /usr/lib/libXdamage.so.1.1.0
b5c59000 b5c5b000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5c5d000 b5d9f000 r-xp /usr/lib/libX11.so.6.3.0
b5da3000 b5dad000 r-xp /usr/lib/libXcursor.so.1.0.2
b5dae000 b5dc4000 r-xp /usr/lib/libudev.so.1.6.0
b5dc7000 b5dcb000 r-xp /lib/libattr.so.1.1.0
b5dcc000 b5dfb000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5dfd000 b5e03000 r-xp /usr/lib/libffi.so.6.0.2
b5e04000 b5e27000 r-xp /lib/libz.so.1.2.8
b5e28000 b5e2b000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5e2c000 b5f88000 r-xp /usr/lib/libxml2.so.2.9.2
b5f8e000 b6075000 r-xp /usr/lib/libstdc++.so.6.0.20
b6082000 b6085000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6086000 b60a8000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b60a9000 b60bd000 r-xp /lib/libresolv-2.20-2014.11.so
b60c1000 b60e5000 r-xp /usr/lib/liblzma.so.5.0.3
b60e6000 b60e8000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b60ea000 b60f4000 r-xp /usr/lib/libembryo.so.1.13.0
b60f5000 b611e000 r-xp /usr/lib/libpng12.so.0.50.0
b611f000 b6168000 r-xp /usr/lib/libjpeg.so.8.0.2
b6179000 b6180000 r-xp /lib/librt-2.20-2014.11.so
b6182000 b61a1000 r-xp /usr/lib/libector.so.1.13.0
b61a4000 b61d1000 r-xp /usr/lib/liblua-5.1.so
b61d2000 b6262000 r-xp /usr/lib/libfreetype.so.6.11.3
b6266000 b62a4000 r-xp /usr/lib/libfontconfig.so.1.8.0
b62a5000 b62bb000 r-xp /usr/lib/libfribidi.so.0.3.1
b62bc000 b6315000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6318000 b6363000 r-xp /lib/libm-2.20-2014.11.so
b6365000 b6377000 r-xp /usr/lib/libeio.so.1.13.0
b6378000 b637b000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b637c000 b6382000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b6383000 b63a6000 r-xp /usr/lib/libefreet.so.1.13.0
b63a9000 b63d4000 r-xp /usr/lib/libeldbus.so.1.13.0
b63d5000 b6409000 r-xp /usr/lib/libecore_con.so.1.13.0
b640b000 b6414000 r-xp /usr/lib/libecore_imf.so.1.13.0
b6415000 b641e000 r-xp /usr/lib/libethumb_client.so.1.13.0
b641f000 b6432000 r-xp /usr/lib/libeo.so.1.13.0
b6434000 b6447000 r-xp /usr/lib/libecore_input.so.1.13.0
b6448000 b644f000 r-xp /usr/lib/libecore_file.so.1.13.0
b6450000 b6473000 r-xp /usr/lib/libecore_evas.so.1.13.0
b6474000 b64a0000 r-xp /usr/lib/libeet.so.1.13.0
b64a9000 b6514000 r-xp /usr/lib/libeina.so.1.13.0
b6517000 b652e000 r-xp /usr/lib/libefl.so.1.13.0
b6530000 b6697000 r-xp /usr/lib/libicuuc.so.51.1
b66a5000 b68b1000 r-xp /usr/lib/libicui18n.so.51.1
b68b9000 b6908000 r-xp /usr/lib/libecore_x.so.1.13.0
b690a000 b6924000 r-xp /lib/libgcc_s-4.9.so.1
b6926000 b692a000 r-xp /lib/libcap.so.2.21
b692b000 b6971000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6972000 b6979000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b697b000 b69cd000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b69cf000 b6b5a000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6b5f000 b6c2d000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6c30000 b6c34000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6c35000 b6c44000 r-xp /usr/lib/libvconf.so.0.2.45
b6c45000 b6c48000 r-xp /usr/lib/libvasum.so.0.3.1
b6c49000 b6c4c000 r-xp /usr/lib/libttrace.so.1.1
b6c4e000 b6c52000 r-xp /usr/lib/libiniparser.so.0
b6c53000 b6c83000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6c84000 b6c8d000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c8e000 b6cb3000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6cb4000 b6cc4000 r-xp /usr/lib/libunwind.so.8.0.1
b6cce000 b6e7c000 r-xp /lib/libc-2.20-2014.11.so
b6e84000 b6fc7000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6fc9000 b7021000 r-xp /usr/lib/libdbus-1.so.3.8.11
b7022000 b7056000 r-xp /usr/lib/libsystemd.so.0.4.0
b7059000 b712d000 r-xp /usr/lib/libedje.so.1.13.0
b7130000 b715c000 r-xp /usr/lib/libecore.so.1.13.0
b716d000 b7393000 r-xp /usr/lib/libevas.so.1.13.0
b73bb000 b73d3000 r-xp /lib/libpthread-2.20-2014.11.so
b73d7000 b7751000 r-xp /usr/lib/libelementary.so.1.13.0
b7771000 b7775000 r-xp /usr/lib/libsmack.so.1.0.0
b7776000 b777f000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7780000 b7783000 r-xp /usr/lib/libdlog.so.0.0.0
b7784000 b7789000 r-xp /usr/lib/libbundle.so.0.1.22
b778a000 b778d000 r-xp /lib/libdl-2.20-2014.11.so
b778f000 b77b4000 r-xp /usr/lib/libaul.so.0.1.0
b77b7000 b77b9000 r-xp /usr/lib/libappsvc.so.0.1.0
b77ba000 b77bf000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b77c0000 b77c7000 r-xp /usr/lib/libappcore-efl.so.1.1
b77c9000 b77ce000 r-xp /usr/lib/libsys-assert.so
b77d1000 b77d2000 r-xp [vdso]
b77d2000 b77f4000 r-xp /lib/ld-2.20-2014.11.so
b77f6000 b77fe000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:19622)
Call Stack Count: 74
 0: (0xb6dffc0b) [/lib/libc.so.6] + 0x131c0b
 1: gl_del_cb + 0xa8 (0xb3834118) [/opt/usr/apps/org.example.example/bin/example] + 0x7118
 2: (0xb75331f9) [/usr/lib/libelementary.so.1] + 0x15c1f9
 3: elm_genlist_clear + 0x9b (0xb753342b) [/usr/lib/libelementary.so.1] + 0x15c42b
 4: (0xb7533669) [/usr/lib/libelementary.so.1] + 0x15c669
 5: evas_obj_smart_del + 0x99 (0xb71f7eb9) [/usr/lib/libevas.so.1] + 0x8aeb9
 6: (0xb71f96f1) [/usr/lib/libevas.so.1] + 0x8c6f1
 7: (0xb71ec75b) [/usr/lib/libevas.so.1] + 0x7f75b
 8: eo_destructor + 0x99 (0xb642a079) [/usr/lib/libeo.so.1] + 0xb079
 9: (0xb764838b) [/usr/lib/libelementary.so.1] + 0x27138b
10: eo_destructor + 0x99 (0xb642a079) [/usr/lib/libeo.so.1] + 0xb079
11: _eo_do_end + 0x15b (0xb64225ab) [/usr/lib/libeo.so.1] + 0x35ab
12: eo_del + 0xb3 (0xb64277a3) [/usr/lib/libeo.so.1] + 0x87a3
13: evas_object_del + 0x81 (0xb71e1cc1) [/usr/lib/libevas.so.1] + 0x74cc1
14: (0xb7656245) [/usr/lib/libelementary.so.1] + 0x27f245
15: evas_obj_smart_del + 0x99 (0xb71f7eb9) [/usr/lib/libevas.so.1] + 0x8aeb9
16: (0xb7545bf9) [/usr/lib/libelementary.so.1] + 0x16ebf9
17: evas_obj_smart_del + 0x99 (0xb71f7eb9) [/usr/lib/libevas.so.1] + 0x8aeb9
18: (0xb71f96f1) [/usr/lib/libevas.so.1] + 0x8c6f1
19: (0xb71ec75b) [/usr/lib/libevas.so.1] + 0x7f75b
20: eo_destructor + 0x99 (0xb642a079) [/usr/lib/libeo.so.1] + 0xb079
21: (0xb764838b) [/usr/lib/libelementary.so.1] + 0x27138b
22: eo_destructor + 0x99 (0xb642a079) [/usr/lib/libeo.so.1] + 0xb079
23: _eo_do_end + 0x15b (0xb64225ab) [/usr/lib/libeo.so.1] + 0x35ab
24: eo_del + 0xb3 (0xb64277a3) [/usr/lib/libeo.so.1] + 0x87a3
25: evas_object_del + 0x81 (0xb71e1cc1) [/usr/lib/libevas.so.1] + 0x74cc1
26: (0xb7656245) [/usr/lib/libelementary.so.1] + 0x27f245
27: evas_obj_smart_del + 0x99 (0xb71f7eb9) [/usr/lib/libevas.so.1] + 0x8aeb9
28: (0xb758b706) [/usr/lib/libelementary.so.1] + 0x1b4706
29: evas_obj_smart_del + 0x99 (0xb71f7eb9) [/usr/lib/libevas.so.1] + 0x8aeb9
30: (0xb757b53f) [/usr/lib/libelementary.so.1] + 0x1a453f
31: evas_obj_smart_del + 0x99 (0xb71f7eb9) [/usr/lib/libevas.so.1] + 0x8aeb9
32: (0xb71f96f1) [/usr/lib/libevas.so.1] + 0x8c6f1
33: (0xb71ec75b) [/usr/lib/libevas.so.1] + 0x7f75b
34: eo_destructor + 0x99 (0xb642a079) [/usr/lib/libeo.so.1] + 0xb079
35: (0xb764838b) [/usr/lib/libelementary.so.1] + 0x27138b
36: eo_destructor + 0x99 (0xb642a079) [/usr/lib/libeo.so.1] + 0xb079
37: _eo_do_end + 0x15b (0xb64225ab) [/usr/lib/libeo.so.1] + 0x35ab
38: eo_del + 0xb3 (0xb64277a3) [/usr/lib/libeo.so.1] + 0x87a3
39: evas_object_del + 0x81 (0xb71e1cc1) [/usr/lib/libevas.so.1] + 0x74cc1
40: (0xb7656245) [/usr/lib/libelementary.so.1] + 0x27f245
41: evas_obj_smart_del + 0x99 (0xb71f7eb9) [/usr/lib/libevas.so.1] + 0x8aeb9
42: (0xb758b706) [/usr/lib/libelementary.so.1] + 0x1b4706
43: evas_obj_smart_del + 0x99 (0xb71f7eb9) [/usr/lib/libevas.so.1] + 0x8aeb9
44: (0xb71f96f1) [/usr/lib/libevas.so.1] + 0x8c6f1
45: (0xb71ec75b) [/usr/lib/libevas.so.1] + 0x7f75b
46: eo_destructor + 0x99 (0xb642a079) [/usr/lib/libeo.so.1] + 0xb079
47: (0xb764838b) [/usr/lib/libelementary.so.1] + 0x27138b
48: eo_destructor + 0x99 (0xb642a079) [/usr/lib/libeo.so.1] + 0xb079
49: _eo_do_end + 0x15b (0xb64225ab) [/usr/lib/libeo.so.1] + 0x35ab
50: eo_del + 0xb3 (0xb64277a3) [/usr/lib/libeo.so.1] + 0x87a3
51: evas_object_del + 0x81 (0xb71e1cc1) [/usr/lib/libevas.so.1] + 0x74cc1
52: (0xb76459d1) [/usr/lib/libelementary.so.1] + 0x26e9d1
53: eo_destructor + 0x99 (0xb642a079) [/usr/lib/libeo.so.1] + 0xb079
54: (0xb74776af) [/usr/lib/libelementary.so.1] + 0xa06af
55: eo_destructor + 0x99 (0xb642a079) [/usr/lib/libeo.so.1] + 0xb079
56: _eo_do_end + 0x15b (0xb64225ab) [/usr/lib/libeo.so.1] + 0x35ab
57: (0xb7476646) [/usr/lib/libelementary.so.1] + 0x9f646
58: (0xb7581626) [/usr/lib/libelementary.so.1] + 0x1aa626
59: (0xb70dcf39) [/usr/lib/libedje.so.1] + 0x83f39
60: (0xb70e3a11) [/usr/lib/libedje.so.1] + 0x8aa11
61: (0xb70ddfdc) [/usr/lib/libedje.so.1] + 0x84fdc
62: (0xb70de4cb) [/usr/lib/libedje.so.1] + 0x854cb
63: (0xb70de68f) [/usr/lib/libedje.so.1] + 0x8568f
64: (0xb7143702) [/usr/lib/libecore.so.1] + 0x13702
65: (0xb713d055) [/usr/lib/libecore.so.1] + 0xd055
66: (0xb71461b9) [/usr/lib/libecore.so.1] + 0x161b9
67: ecore_main_loop_begin + 0x57 (0xb7146587) [/usr/lib/libecore.so.1] + 0x16587
68: elm_run + 0x2d (0xb759f22d) [/usr/lib/libelementary.so.1] + 0x1c822d
69: appcore_efl_main + 0x4de (0xb77c3dde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
70: ui_app_main + 0x140 (0xb77bcc80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
71: main + 0x296 (0xb38357c6) [/opt/usr/apps/org.example.example/bin/example] + 0x87c6
72: (0xb77f8148) [/opt/usr/apps/org.example.example/bin/example] + 0xb77f8148
73: __libc_start_main + 0xde (0xb6ce5e4e) [/lib/libc.so.6] + 0x17e4e
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
les] Icon[/usr/share/icons/default/small/org.tizen.myfile.png] enable[1] system[1]
06-04 05:01:37.818+0900 D/BADGE   ( 2863): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.myfile'], count[0]
06-04 05:01:37.818+0900 E/cluster-home( 2863): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.myfile][-17956860][0]
06-04 05:01:37.818+0900 D/cluster-home( 2863): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.myfile]
06-04 05:01:37.818+0900 D/cluster-view( 2863): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[My Files] pos[3, 3] pageId[100001]
06-04 05:01:37.818+0900 D/cluster-view( 2863): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[9]
06-04 05:01:37.818+0900 D/cluster-view( 2863): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[11], [3, 3]
06-04 05:01:37.818+0900 D/cluster-view( 2863): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-04 05:01:37.818+0900 D/cluster-view( 2863): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-04 05:01:37.818+0900 E/cluster-home( 2863): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.phone] Name[Phone] Icon[/usr/share/icons/default/small/org.tizen.phone.png] enable[1] system[1]
06-04 05:01:37.818+0900 D/BADGE   ( 2863): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.phone'], count[0]
06-04 05:01:37.818+0900 E/cluster-home( 2863): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.phone][-17956860][0]
06-04 05:01:37.818+0900 D/cluster-home( 2863): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.phone]
06-04 05:01:37.818+0900 D/cluster-view( 2863): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Phone] pos[4, 3] pageId[100001]
06-04 05:01:37.818+0900 D/cluster-view( 2863): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[10]
06-04 05:01:37.818+0900 D/cluster-view( 2863): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[12], [4, 3]
06-04 05:01:37.818+0900 D/cluster-view( 2863): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-04 05:01:37.818+0900 D/cluster-view( 2863): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-04 05:01:37.818+0900 E/cluster-home( 2863): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.setting] Name[Settings] Icon[/usr/share/icons/default/small/org.tizen.setting.png] enable[1] system[1]
06-04 05:01:37.818+0900 D/BADGE   ( 2863): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.setting'], count[0]
06-04 05:01:37.818+0900 E/cluster-home( 2863): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.setting][-17956860][0]
06-04 05:01:37.818+0900 D/cluster-home( 2863): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.setting]
06-04 05:01:37.818+0900 D/cluster-view( 2863): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Settings] pos[1, 4] pageId[100001]
06-04 05:01:37.818+0900 D/cluster-view( 2863): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[11]
06-04 05:01:37.818+0900 D/cluster-view( 2863): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[13], [1, 4]
06-04 05:01:37.818+0900 D/cluster-view( 2863): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-04 05:01:37.818+0900 D/cluster-view( 2863): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-04 05:01:37.818+0900 E/cluster-home( 2863): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.videos] Name[Video] Icon[/usr/share/icons/default/small/org.tizen.videos.png] enable[1] system[1]
06-04 05:01:37.818+0900 D/BADGE   ( 2863): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.videos'], count[0]
06-04 05:01:37.818+0900 E/cluster-home( 2863): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.videos][-17956860][0]
06-04 05:01:37.818+0900 D/cluster-home( 2863): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.videos]
06-04 05:01:37.818+0900 D/cluster-view( 2863): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Video] pos[2, 4] pageId[100001]
06-04 05:01:37.818+0900 D/cluster-view( 2863): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[12]
06-04 05:01:37.818+0900 D/cluster-view( 2863): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[14], [2, 4]
06-04 05:01:37.818+0900 D/cluster-view( 2863): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-04 05:01:37.818+0900 D/cluster-view( 2863): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-04 05:01:37.818+0900 D/cluster-view( 2863): mainmenu-apps-view-impl.cpp: RearrangeItems(243) >  view type [1]
06-04 05:01:37.908+0900 E/CAPI_NETWORK_WIFI( 2846): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-04 05:01:37.908+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
06-04 05:01:37.908+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-04 05:01:37.908+0900 E/INDICATOR( 2846): 
06-04 05:01:37.928+0900 D/rpm-installer(19726): rpm-installer-privilege.c: __ri_privilege_perm_end(55) > [smack] perm_end, result=[0]
06-04 05:01:37.928+0900 D/rpm-installer(19726): rpm-appcore-intf.c: main(259) > ------------------------------------------------
06-04 05:01:37.928+0900 D/rpm-installer(19726): rpm-appcore-intf.c: main(260) >  [END] rpm-installer: result=[0]
06-04 05:01:37.928+0900 D/rpm-installer(19726): rpm-appcore-intf.c: main(261) > ------------------------------------------------
06-04 05:01:37.928+0900 D/PKGMGR_SERVER(19711): pkgmgr-server.c: sighandler(387) > child exit [19726]
06-04 05:01:37.938+0900 E/PKGMGR_SERVER(19711): pkgmgr-server.c: sighandler(402) > child NORMAL exit [19726]
06-04 05:01:38.348+0900 D/AUL_AMD ( 2771): amd_request.c: __request_handler(838) > __request_handler: 0
06-04 05:01:38.348+0900 D/AUL_AMD ( 2771): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.example
06-04 05:01:38.348+0900 D/PKGMGR_INFO( 2771): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-04 05:01:38.348+0900 D/PKGMGR_INFO( 2771): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-04 05:01:38.348+0900 I/AUL     ( 2771): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
06-04 05:01:38.348+0900 D/AUL     ( 2771): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 19778, pid = 19780
06-04 05:01:38.348+0900 D/PKGMGR_INFO( 2771): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-04 05:01:38.348+0900 D/PKGMGR_INFO( 2771): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-04 05:01:38.348+0900 I/AUL     ( 2771): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
06-04 05:01:38.348+0900 E/AUL_AMD ( 2771): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
06-04 05:01:38.348+0900 W/AUL_AMD ( 2771): amd_launch.c: _start_app(2233) > caller pid : 19780
06-04 05:01:38.348+0900 E/AUL_AMD ( 2771): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
06-04 05:01:38.358+0900 W/AUL_AMD ( 2771): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.example) pkgid(org.example.example) attribute(600)
06-04 05:01:38.358+0900 D/AUL_AMD ( 2771): amd_launch.c: _start_app(2648) > process_pool: false
06-04 05:01:38.358+0900 D/AUL_AMD ( 2771): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
06-04 05:01:38.358+0900 D/AUL_AMD ( 2771): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.example
06-04 05:01:38.358+0900 W/AUL_AMD ( 2771): amd_launch.c: _start_app(2665) > pad pid(-5)
06-04 05:01:38.358+0900 D/AUL_AMD ( 2771): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
06-04 05:01:38.358+0900 D/AUL_AMD ( 2771): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
06-04 05:01:38.358+0900 D/AUL     ( 2771): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
06-04 05:01:38.358+0900 D/AUL_PAD ( 2913): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
06-04 05:01:38.358+0900 D/AUL_PAD ( 2913): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
06-04 05:01:38.358+0900 D/AUL_PAD ( 2913): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-04 05:01:38.358+0900 D/AUL_PAD ( 2913): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-04 05:01:38.358+0900 D/AUL_PAD ( 2913): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-04 05:01:38.358+0900 D/AUL_PAD ( 2913): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-04 05:01:38.358+0900 D/AUL_PAD ( 2913): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-04 05:01:38.358+0900 D/AUL_PAD ( 2913): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
06-04 05:01:38.358+0900 D/AUL_PAD ( 2913): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
06-04 05:01:38.358+0900 D/AUL_PAD ( 2913): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
06-04 05:01:38.358+0900 D/AUL_PAD ( 2913): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
06-04 05:01:38.358+0900 D/AUL_PAD ( 2913): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
06-04 05:01:38.358+0900 D/AUL_PAD ( 2913): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
06-04 05:01:38.358+0900 D/AUL_PAD ( 2913): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
06-04 05:01:38.358+0900 W/AUL_PAD ( 2913): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
06-04 05:01:38.358+0900 D/AUL     ( 2913): process_pool.c: __send_pkt_raw_data(219) > send(11) : 624 / 624
06-04 05:01:38.358+0900 D/AUL_PAD ( 2913): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 19622, bin path: /opt/usr/apps/org.example.example/bin/example
06-04 05:01:38.358+0900 W/AUL_PAD ( 2913): launchpad.c: __send_result_to_caller(265) > Check app launching
06-04 05:01:38.358+0900 D/AUL_PAD ( 2913): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
06-04 05:01:38.358+0900 D/RESOURCED( 2841): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
06-04 05:01:38.358+0900 D/RESOURCED( 2841): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 1
06-04 05:01:38.358+0900 E/RESOURCED( 2841): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-04 05:01:38.358+0900 D/AUL_PAD (19622): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
06-04 05:01:38.358+0900 D/AUL_PAD (19622): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 624, pkt->len: 616
06-04 05:01:38.358+0900 D/AUL_PAD (19622): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
06-04 05:01:38.358+0900 D/AUL_PAD (19622): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
06-04 05:01:38.358+0900 D/AUL_PAD (19622): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
06-04 05:01:38.358+0900 D/AUL_PAD (19622): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
06-04 05:01:38.358+0900 D/AUL     (19622): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (19624) is sent.
06-04 05:01:38.358+0900 D/AUL     (19622): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 19624, signo: 10
06-04 05:01:38.358+0900 D/AUL     (19622): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
06-04 05:01:38.358+0900 D/AUL_PAD (19622): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
06-04 05:01:38.358+0900 D/AUL_PAD (19622): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
06-04 05:01:38.358+0900 D/AUL_PAD (19622): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
06-04 05:01:38.358+0900 D/AUL_PAD (19622): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
06-04 05:01:38.358+0900 D/AUL_PAD (19622): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0OTY1MjAwOTgvMzU1ODYzAA==##
06-04 05:01:38.358+0900 D/AUL_PAD (19622): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
06-04 05:01:38.358+0900 D/AUL_PAD (19622): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KQAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAYAAAAxOTc4MAA=##
06-04 05:01:38.358+0900 D/AUL_PAD (19622): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
06-04 05:01:38.358+0900 D/AUL_PAD (19622): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
06-04 05:01:38.358+0900 D/AUL_PAD (19622): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 8
06-04 05:01:38.358+0900 D/AUL_PAD (19622): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
06-04 05:01:38.358+0900 D/AUL_PAD (19622): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
06-04 05:01:38.358+0900 I/CAPI_APPFW_APPLICATION(19622): app_main.c: ui_app_main(788) > app_efl_main
06-04 05:01:38.358+0900 D/LAUNCH  (19622): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
06-04 05:01:38.358+0900 D/APP_CORE(19622): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
06-04 05:01:38.358+0900 D/APP_CORE(19622): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
06-04 05:01:38.358+0900 D/APP_CORE(19622): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
06-04 05:01:38.368+0900 D/APP_CORE(19622): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
06-04 05:01:38.368+0900 D/AUL     (19622): app_sock.c: __create_server_sock(156) > pg path - already exists
06-04 05:01:38.368+0900 D/APP_CORE(19622): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb431c520
06-04 05:01:38.368+0900 D/LAUNCH  (19622): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
06-04 05:01:38.368+0900 I/CAPI_APPFW_APPLICATION(19622): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
06-04 05:01:38.398+0900 D/LAUNCH  (19622): appcore-efl.c: __before_loop(1154) > [example:Application:create:done]
06-04 05:01:38.398+0900 E/E17     ( 2690): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x02c00002)
06-04 05:01:38.398+0900 D/APP_CORE(19622): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
06-04 05:01:38.408+0900 E/E17     ( 2690): e_border.c: e_border_show(2088) > BD_SHOW(0x02c00002)
06-04 05:01:38.408+0900 W/PROCESSMGR( 2690): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=19622
06-04 05:01:38.418+0900 D/APP_CORE(19622): appcore.c: __aul_handler(587) > [APP 19622]     AUL event: AUL_START
06-04 05:01:38.418+0900 I/APP_CORE(19622): appcore-efl.c: __do_app(496) > [APP 19622] Event: RESET State: CREATED
06-04 05:01:38.418+0900 D/APP_CORE(19622): appcore-efl.c: __do_app(527) > [APP 19622] RESET
06-04 05:01:38.418+0900 D/LAUNCH  (19622): appcore-efl.c: __do_app(529) > [example:Application:reset:start]
06-04 05:01:38.418+0900 D/APP_CORE(19622): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
06-04 05:01:38.418+0900 D/APP_CORE(19622): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-04 05:01:38.418+0900 I/CAPI_APPFW_APPLICATION(19622): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
06-04 05:01:38.418+0900 D/AUL     (19622): service.c: __set_bundle(186) > __set_bundle
06-04 05:01:38.418+0900 D/LAUNCH  (19622): appcore-efl.c: __do_app(544) > [example:Application:reset:done]
06-04 05:01:38.418+0900 D/APP_CORE(19622): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
06-04 05:01:38.418+0900 E/EFL     (19622): edje<19622> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-04 05:01:38.418+0900 E/EFL     (19622): By the power of Grayskull, your previous Embryo stack is now broken!
06-04 05:01:38.418+0900 E/EFL     (19622): edje<19622> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-04 05:01:38.418+0900 E/EFL     (19622): By the power of Grayskull, your previous Embryo stack is now broken!
06-04 05:01:38.418+0900 E/EFL     (19622): edje<19622> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-04 05:01:38.418+0900 E/EFL     (19622): By the power of Grayskull, your previous Embryo stack is now broken!
06-04 05:01:38.418+0900 E/EFL     (19622): edje<19622> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-04 05:01:38.418+0900 E/EFL     (19622): By the power of Grayskull, your previous Embryo stack is now broken!
06-04 05:01:38.418+0900 E/EFL     (19622): edje<19622> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-04 05:01:38.418+0900 E/EFL     (19622): By the power of Grayskull, your previous Embryo stack is now broken!
06-04 05:01:38.418+0900 E/EFL     ( 2690): eo<2690> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-04 05:01:38.418+0900 E/EFL     ( 2690): eo<2690> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-04 05:01:38.418+0900 W/APP_CORE(19622): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2c00002
06-04 05:01:38.418+0900 D/APP_CORE(19622): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:2c00002
06-04 05:01:38.418+0900 D/APP_CORE(19622): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
06-04 05:01:38.418+0900 D/AUL     (19622): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
06-04 05:01:38.418+0900 D/INDICATOR( 2846): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
06-04 05:01:38.428+0900 D/INDICATOR( 2846): util.c: util_signal_emit_by_win(116) > emission bg.opaque
06-04 05:01:38.428+0900 D/INDICATOR( 2846): main.c: _rotate_window(229) > Indicator angle is 0 degree
06-04 05:01:38.428+0900 D/INDICATOR( 2846): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
06-04 05:01:38.428+0900 D/INDICATOR( 2846): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
06-04 05:01:38.428+0900 D/INDICATOR( 2846): main.c: _rotate_window(252) > port :: hide more icon
06-04 05:01:38.458+0900 D/AUL_PAD ( 2913): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
06-04 05:01:38.458+0900 W/AUL     ( 2771): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 19622, appid: org.example.example
06-04 05:01:38.458+0900 D/AUL     ( 2771): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
06-04 05:01:38.458+0900 E/AUL     ( 2771): simple_util.c: __trm_app_info_send_socket(330) > access
06-04 05:01:38.458+0900 D/AUL_AMD ( 2771): amd_launch.c: _start_app(2700) > add app group info
06-04 05:01:38.458+0900 E/AUL     ( 2771): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
06-04 05:01:38.458+0900 D/AUL_AMD ( 2771): amd_status.c: _status_add_app_info_list(427) > pid(19622) appid(org.example.example) pkgid(org.example.example) comp(uiapp)
06-04 05:01:38.458+0900 D/AUL_AMD ( 2771): amd_request.c: __request_handler(838) > __request_handler: 15
06-04 05:01:38.458+0900 D/PKGMGR_INFO( 2771): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-04 05:01:38.458+0900 D/PKGMGR_INFO( 2771): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-04 05:01:38.458+0900 D/RESOURCED( 2841): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.example, 19622
06-04 05:01:38.458+0900 D/RESOURCED( 2841): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.example with pkgname
06-04 05:01:38.458+0900 E/RESOURCED( 2841): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.example
06-04 05:01:38.458+0900 D/RESOURCED( 2841): proc-main.c: resourced_proc_status_change(888) > available memory = 287
06-04 05:01:38.458+0900 D/AUL_AMD ( 2771): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 19622 is org.example.example
06-04 05:01:38.458+0900 D/AUL_AMD ( 2771): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 19622 : 0
06-04 05:01:38.458+0900 D/AUL_AMD ( 2771): amd_request.c: __request_handler(838) > __request_handler: 34
06-04 05:01:38.458+0900 D/AUL     ( 2939): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
06-04 05:01:38.798+0900 D/APP_CORE(19622): appcore.c: __prt_ltime(236) > [APP 19622] first idle after reset: 449 msec
06-04 05:01:38.878+0900 E/E17     ( 2690): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
06-04 05:01:38.878+0900 D/APP_CORE( 2863): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
06-04 05:01:38.878+0900 D/APP_CORE( 2863): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
06-04 05:01:38.878+0900 D/APP_CORE( 2863): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
06-04 05:01:38.878+0900 I/APP_CORE( 2863): appcore-efl.c: __do_app(496) > [APP 2863] Event: PAUSE State: RUNNING
06-04 05:01:38.878+0900 D/APP_CORE( 2863): appcore-efl.c: __do_app(565) > [APP 2863] PAUSE
06-04 05:01:38.878+0900 I/CAPI_APPFW_APPLICATION( 2863): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
06-04 05:01:38.878+0900 E/cluster-home( 2863): homescreen.cpp: OnPause(84) >  app pause
06-04 05:01:38.878+0900 D/cluster-view( 2863): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
06-04 05:01:38.878+0900 D/cluster-view( 2863): homescreen-view-manager.cpp: AppPause(923) >  END
06-04 05:01:38.878+0900 D/APP_CORE( 2863): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-04 05:01:38.878+0900 E/APP_CORE( 2863): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-04 05:01:38.908+0900 D/DATA_PROVIDER_MASTER( 2915): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2863 is paused
06-04 05:01:38.908+0900 D/DATA_PROVIDER_MASTER( 2915): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
06-04 05:01:38.908+0900 D/AUL_AMD ( 2771): amd_status.c: _status_update_app_info_list(456) > pid(2863) status(4)
06-04 05:01:38.908+0900 D/AUL_AMD ( 2771): amd_status.c: _status_update_app_info_list(468) > pid(2863) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
06-04 05:01:38.908+0900 D/AUL     ( 2771): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
06-04 05:01:38.908+0900 W/AUL     ( 2771): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2863, appid: org.tizen.homescreen, status: bg
06-04 05:01:38.918+0900 D/AUL_AMD ( 2771): amd_launch.c: __e17_status_handler(2891) > pid(19622) status(3)
06-04 05:01:38.918+0900 D/AUL_AMD ( 2771): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
06-04 05:01:38.918+0900 I/CAPI_WIDGET_APPLICATION( 3019): widget_app.c: __provider_pause_cb(294) > widget obj was paused
06-04 05:01:38.918+0900 I/CAPI_WIDGET_APPLICATION( 3019): widget_app.c: __check_status_for_cgroup(142) > enter background group
06-04 05:01:38.918+0900 W/AUL     ( 3019): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3019, appid: org.tizen.calendar.widget, status: bg
06-04 05:01:38.918+0900 W/AUL_AMD ( 2771): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-04 05:01:38.918+0900 W/AUL_AMD ( 2771): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
06-04 05:01:38.918+0900 D/AUL_AMD ( 2771): amd_status.c: _status_update_app_info_list(456) > pid(19622) status(3)
06-04 05:01:38.918+0900 D/AUL_AMD ( 2771): amd_status.c: _status_update_app_info_list(468) > pid(19622) appid(org.example.example) pkgid(org.example.example) status(3)
06-04 05:01:38.918+0900 D/AUL     ( 2771): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.example
06-04 05:01:38.918+0900 W/AUL     ( 2771): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 19622, appid: org.example.example, status: fg
06-04 05:01:38.928+0900 D/RESOURCED( 2841): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3019, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
06-04 05:01:38.928+0900 D/RESOURCED( 2841): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 3019
06-04 05:01:38.928+0900 D/RESOURCED( 2841): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 3019, appname = org.tizen.calendar.widget
06-04 05:01:38.928+0900 D/RESOURCED( 2841): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 3019
06-04 05:01:38.928+0900 D/RESOURCED( 2841): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 19622
06-04 05:01:38.928+0900 D/RESOURCED( 2841): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 19622, proc_name: org.example.example, cg_name: foreground, oom_score_adj: 200
06-04 05:01:38.928+0900 D/RESOURCED( 2841): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 19622
06-04 05:01:38.968+0900 D/APP_CORE(19622): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2c00002 fully_obscured 0
06-04 05:01:38.968+0900 D/APP_CORE(19622): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
06-04 05:01:38.968+0900 D/APP_CORE(19622): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
06-04 05:01:38.968+0900 I/APP_CORE(19622): appcore-efl.c: __do_app(496) > [APP 19622] Event: RESUME State: CREATED
06-04 05:01:38.968+0900 D/LAUNCH  (19622): appcore-efl.c: __do_app(597) > [example:Application:resume:start]
06-04 05:01:38.968+0900 D/APP_CORE(19622): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
06-04 05:01:38.968+0900 D/APP_CORE(19622): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-04 05:01:38.968+0900 D/APP_CORE(19622): appcore-efl.c: __do_app(607) > [APP 19622] RESUME
06-04 05:01:38.968+0900 D/AUL_AMD ( 2771): amd_launch.c: __e17_status_handler(2910) > pid(19622) status(0)
06-04 05:01:38.968+0900 I/APP_CORE(19622): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
06-04 05:01:38.968+0900 I/APP_CORE(19622): appcore-efl.c: __do_app(614) > [APP 19622] Initial Launching, call the resume_cb
06-04 05:01:38.968+0900 I/CAPI_APPFW_APPLICATION(19622): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
06-04 05:01:38.968+0900 D/LAUNCH  (19622): appcore-efl.c: __do_app(636) > [example:Application:resume:done]
06-04 05:01:38.968+0900 D/LAUNCH  (19622): appcore-efl.c: __do_app(638) > [example:Application:Launching:done]
06-04 05:01:38.968+0900 D/APP_CORE(19622): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-04 05:01:38.968+0900 E/APP_CORE(19622): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-04 05:01:38.978+0900 D/RESOURCED( 2841): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 19622, appname = org.example.example, pkgname = org.example.example
06-04 05:01:38.978+0900 D/RESOURCED( 2841): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 19622, appname = org.example.example
06-04 05:01:38.978+0900 D/RESOURCED( 2841): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 19622
06-04 05:01:38.978+0900 I/RESOURCED( 2841): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
06-04 05:01:38.978+0900 I/RESOURCED( 2841): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
06-04 05:01:39.458+0900 D/AUL_PAD ( 2913): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
06-04 05:01:39.458+0900 D/AUL_PAD (19787): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
06-04 05:01:39.458+0900 D/AUL_PAD ( 2913): sigchild.h: __send_app_launch_signal(131) > send launch signal done
06-04 05:01:39.468+0900 E/RESOURCED( 2841): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1773
06-04 05:01:39.468+0900 D/AUL_AMD ( 2771): amd_status.c: __app_terminate_timer_cb(442) > pid(19528)
06-04 05:01:39.468+0900 W/AUL_AMD ( 2771): amd_status.c: __app_terminate_timer_cb(446) > send SIGKILL: No such process
06-04 05:01:39.468+0900 D/AUL_AMD ( 2771): amd_status.c: __app_terminate_timer_cb(442) > pid(19528)
06-04 05:01:39.468+0900 W/AUL_AMD ( 2771): amd_status.c: __app_terminate_timer_cb(446) > send SIGKILL: No such process
06-04 05:01:39.958+0900 D/AUL_AMD ( 2771): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.example /opt/usr/apps/org.example.example/bin/example
06-04 05:01:39.958+0900 D/RUA     ( 2771): rua.c: rua_add_history(179) > rua_add_history start
06-04 05:01:39.968+0900 D/RUA     ( 2771): rua.c: rua_add_history(247) > rua_add_history ok
06-04 05:01:39.998+0900 E/PKGMGR_SERVER(19711): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-04 05:01:39.998+0900 E/PKGMGR_SERVER(19711): pkgmgr-server.c: main(2265) > package manager server terminated.
06-04 05:01:40.488+0900 D/AUL_PAD (19787): launchpad_loader.c: main(588) > sleeping 1 sec...
06-04 05:01:40.488+0900 D/AUL_PAD (19787): preload.h: __preload_init(52) > max_cmdline_size = 1053
06-04 05:01:40.498+0900 D/AUL_PAD (19787): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b92c2760
06-04 05:01:40.498+0900 D/AUL_PAD (19787): preload.h: __preload_init(69) > get pre-initialization function
06-04 05:01:40.498+0900 D/AUL_PAD (19787): preload.h: __preload_init(73) > get shutdown function
06-04 05:01:40.498+0900 D/AUL_PAD (19787): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b92c2a40
06-04 05:01:40.498+0900 D/AUL_PAD (19787): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b92c4640
06-04 05:01:40.498+0900 D/AUL_PAD (19787): preload.h: __preload_init(69) > get pre-initialization function
06-04 05:01:40.498+0900 D/AUL_PAD (19787): preload.h: __preload_init(73) > get shutdown function
06-04 05:01:40.498+0900 D/AUL_PAD (19787): preexec.h: __preexec_init(76) > preexec start
06-04 05:01:40.498+0900 D/AUL_PAD (19787): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
06-04 05:01:40.498+0900 D/AUL     (19787): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
06-04 05:01:40.498+0900 D/AUL     (19787): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
06-04 05:01:40.508+0900 D/AUL_PAD ( 2913): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
06-04 05:01:40.508+0900 D/AUL_PAD ( 2913): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
06-04 05:01:40.508+0900 D/AUL_PAD ( 2913): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-04 05:01:40.508+0900 D/AUL_PAD ( 2913): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-04 05:01:40.508+0900 D/AUL_PAD ( 2913): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-04 05:01:40.508+0900 D/AUL_PAD ( 2913): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-04 05:01:40.508+0900 D/AUL_PAD ( 2913): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-04 05:01:40.508+0900 D/AUL_PAD ( 2913): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
06-04 05:01:40.508+0900 D/AUL     (19787): process_pool.c: __connect_to_launchpad(132) > send(19787) : 4
06-04 05:01:40.508+0900 D/AUL     (19787): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
06-04 05:01:40.508+0900 D/AUL_PAD ( 2913): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 19787
06-04 05:01:40.568+0900 D/AUL_PAD (19787): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
06-04 05:01:40.578+0900 D/AUL_PAD (19787): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
06-04 05:01:40.578+0900 D/AUL_PAD (19787): launchpad_loader.c: main(693) > [candidate] ecore handler add
06-04 05:01:40.578+0900 D/AUL_PAD (19787): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
06-04 05:01:43.888+0900 D/APP_CORE( 2863): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
06-04 05:01:43.888+0900 I/APP_CORE( 2863): appcore-efl.c: __do_app(496) > [APP 2863] Event: MEM_FLUSH State: PAUSED
06-04 05:01:43.888+0900 D/APP_CORE( 2863): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
06-04 05:01:43.888+0900 D/APP_CORE( 2863): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 2863
06-04 05:01:43.888+0900 D/APP_CORE( 2863): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
06-04 05:01:43.898+0900 D/RESOURCED( 2841): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 2863
06-04 05:01:48.688+0900 I/user_tag0(19622): /opt/usr/apps/org.example.example/data/feeding.db
06-04 05:01:48.688+0900 I/tag     (19622): eonji~
06-04 05:01:48.738+0900 D/PROCESSMGR( 2690): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x60493a 
06-04 05:01:49.748+0900 D/PROCESSMGR( 2690): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2c00002
06-04 05:01:49.868+0900 D/PROCESSMGR( 2690): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x60493a 
06-04 05:01:49.898+0900 E/EFL     (19622): edje<19622> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p15';
06-04 05:01:49.898+0900 E/EFL     (19622): By the power of Grayskull, your previous Embryo stack is now broken!
06-04 05:01:50.038+0900 E/EFL     (19622): edje<19622> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 05:01:50.048+0900 E/EFL     (19622): edje<19622> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 05:01:50.088+0900 E/EFL     (19622): edje<19622> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 05:01:50.088+0900 E/EFL     (19622): edje<19622> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 05:01:50.088+0900 E/EFL     (19622): edje<19622> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 05:01:50.088+0900 E/EFL     (19622): edje<19622> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 05:01:50.088+0900 E/EFL     (19622): edje<19622> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 05:01:50.098+0900 E/EFL     (19622): edje<19622> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 05:01:50.098+0900 E/EFL     (19622): edje<19622> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 05:01:50.098+0900 D/IMMODULE(19622): isf_imf_context.cpp: initialize(3406) > Initializing Ecore ISF IMModule...
06-04 05:01:50.098+0900 D/ISF_SOCKET(19622): scim_socket.cpp: connect(515) > ppid:2913  trying connect() to local:/tmp/scim-socket-frontend, example
06-04 05:01:50.098+0900 D/ISF_SOCKET(19622): scim_socket.cpp: connect(524) > connect() succeeded
06-04 05:01:50.098+0900 D/ISF_SOCKET(19622): scim_socket.cpp: connect(515) > ppid:2913  trying connect() to local:/tmp/scim-socket-frontend, example
06-04 05:01:50.108+0900 D/ISF_SOCKET(19622): scim_socket.cpp: connect(524) > connect() succeeded
06-04 05:01:50.108+0900 D/ISF_SOCKET(19622): scim_socket.cpp: connect(515) > ppid:2913  trying connect() to local:/tmp/scim-socket-frontend, example
06-04 05:01:50.108+0900 D/ISF_SOCKET(19622): scim_socket.cpp: connect(524) > connect() succeeded
06-04 05:01:50.108+0900 D/ISF_QUERY(19622): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="ise-default", label="Tizen keyboard", pkgid="ise-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-helper-launcher", mname="ise-default", mpath="/usr/lib/scim-1.0/1.4.0/Helper", mode=1, options=13, is_enabled=1, is_preinstalled=1, has_option=1, disp_lang="en_US.UTF-8"
06-04 05:01:50.108+0900 D/ISF_QUERY(19622): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-anthy", label="Japanese keyboard", pkgid="ise-engine-anthy", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-anthy", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 05:01:50.108+0900 D/ISF_QUERY(19622): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-default", label="Default keyboard", pkgid="ise-engine-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-default", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 05:01:50.108+0900 D/ISF_QUERY(19622): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-hangul", label="Hangul keyboard", pkgid="hangul", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="hangul", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 05:01:50.108+0900 D/ISF_QUERY(19622): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-sunpinyin", label="Chinese (sunpinyin) keyboard", pkgid="ise-engine-sunpinyin", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-sunpinyin", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 05:01:50.108+0900 D/ISF_QUERY(19622): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.cangjie3", label="CanJie 3 keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 05:01:50.108+0900 D/ISF_QUERY(19622): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.zhuyin-big", label="ZhuYin Big keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 05:01:50.108+0900 D/ISF_SOCKET(19622): scim_socket.cpp: connect(515) > ppid:2913  trying connect() to local:/tmp/scim-socket-frontend, example
06-04 05:01:50.118+0900 D/ISF_SOCKET(19622): scim_socket.cpp: connect(524) > connect() succeeded
06-04 05:01:50.118+0900 D/IMMODULE(19622): scim_panel_client.cpp: open_connection(162) > 
06-04 05:01:50.118+0900 D/ISF_SOCKET(19622): scim_socket.cpp: connect(515) > ppid:2913  trying connect() to local:/tmp/scim-panel-socket:0, example
06-04 05:01:50.118+0900 D/ISF_SOCKET(19622): scim_socket.cpp: connect(524) > connect() succeeded
06-04 05:01:50.118+0900 D/ISF_SOCKET(19622): scim_socket.cpp: connect(515) > ppid:2913  trying connect() to local:/tmp/scim-panel-socket:0, example
06-04 05:01:50.118+0900 D/ISF_SOCKET(19622): scim_socket.cpp: connect(524) > connect() succeeded
06-04 05:01:50.118+0900 D/IMMODULE(19622): isf_imf_control_ui.cpp: isf_imf_input_panel_init(516) > keyboard mode(0:H/W Keyboard, 1:S/W Keyboard): 0
06-04 05:01:51.078+0900 D/PROCESSMGR( 2690): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x60493a 
06-04 05:01:51.248+0900 I/tag     (19622): insert
06-04 05:01:51.248+0900 I/user_tag(19622): 05:01 AM
06-04 05:01:51.248+0900 E/EFL     (19622): edje<19622> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 05:01:51.248+0900 E/EFL     (19622): edje<19622> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 05:01:51.258+0900 E/EFL     (19622): edje<19622> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 05:01:51.258+0900 E/EFL     (19622): edje<19622> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 05:01:51.258+0900 E/EFL     (19622): edje<19622> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 05:01:52.928+0900 D/PROCESSMGR( 2690): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x60493a 
06-04 05:01:53.198+0900 I/tag     (19622): 0
06-04 05:01:53.228+0900 W/CRASH_MANAGER(19791): worker.c: worker_job(1204) > 1119622657861149652011
