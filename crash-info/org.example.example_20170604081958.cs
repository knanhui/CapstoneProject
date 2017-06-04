S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 10132
Date: 2017-06-04 08:19:58+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x8000aa56

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0x8000aa56, esi = 0xb868e3e4
ebp = 0xbf932b78, esp = 0xbf932a60
eax = 0x8000aa56, ebx = 0xb645e7fc
ecx = 0xb8615680, edx = 0x00000003
eip = 0xb6421817

Memory Information
MemTotal:      123 KB
MemFree:        12 KB
Buffers:         8 KB
Cached:     210364 KB
VmPeak:     124584 KB
VmSize:     114756 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       37624 KB
VmRSS:       27704 KB
VmData:      45140 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34636 KB
VmPTE:         104 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 10132 TID = 10132
10132 10136 10296 10301 

Maps Information
b1805000 b180c000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b180f000 b1827000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b1828000 b182f000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b1866000 b186a000 r-xp /usr/lib/elementary/modules/datetime_input_spinner/v-1.13.0/module.so
b2b3f000 b2b49000 r-xp /usr/lib/libfeedback.so.0.1.4
b2b4f000 b2b5b000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2b5c000 b2b7d000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2b82000 b2b83000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2b84000 b2b89000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2b8a000 b2b8b000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2b8c000 b2b8e000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2b8f000 b2b91000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2b92000 b2b9e000 r-xp /usr/lib/libdrm.so.2.4.0
b2b9f000 b2ba2000 r-xp /usr/lib/libdri2.so.0.0.0
b2ba3000 b2bad000 r-xp /usr/lib/libtbm.so.1.0.0
b2bae000 b2bc3000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2bc4000 b2bd6000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b33d8000 b3409000 r-xp /usr/lib/libidn.so.11.5.44
b340a000 b342c000 r-xp /usr/lib/libnghttp2.so.5.4.0
b342d000 b343d000 r-xp /usr/lib/libcares.so.2.1.0
b343e000 b3447000 r-xp /usr/lib/libeventsystem.so.0.0.1
b3448000 b3451000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3452000 b34c9000 r-xp /usr/lib/libcurl.so.4.3.0
b34cb000 b34dd000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b34de000 b34ff000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b3506000 b3507000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3508000 b3509000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b350a000 b350d000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b350e000 b3511000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3619000 b361f000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3620000 b3764000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b3775000 b3776000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b3777000 b3784000 r-xp /opt/usr/apps/org.example.example/bin/example
b3786000 b37bf000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b41c2000 b41cd000 r-xp /lib/libnss_files-2.20-2014.11.so
b41cf000 b41da000 r-xp /lib/libnss_nis-2.20-2014.11.so
b41dc000 b41f3000 r-xp /lib/libnsl-2.20-2014.11.so
b41f7000 b41ff000 r-xp /lib/libnss_compat-2.20-2014.11.so
b4201000 b4225000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b4226000 b4227000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b4228000 b422b000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b422c000 b4233000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4234000 b423e000 r-xp /usr/lib/libsensord-share.so
b423f000 b425b000 r-xp /usr/lib/libsensor.so.1.2.0
b425d000 b4266000 r-xp /usr/lib/libappcore-common.so.1.1
b4269000 b426b000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b4280000 b4282000 r-xp /usr/lib/libXau.so.6.0.0
b4283000 b42a5000 r-xp /usr/lib/libxcb.so.1.1.0
b42a7000 b42b0000 r-xp /lib/libcrypt-2.20-2014.11.so
b42d9000 b42db000 r-xp /usr/lib/libiri.so
b42dc000 b4302000 r-xp /lib/libexpat.so.1.5.2
b4304000 b436f000 r-xp /usr/lib/libssl.so.1.0.0
b4375000 b4381000 r-xp /usr/lib/libethumb.so.1.13.0
b4382000 b4386000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4387000 b45d8000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b53000 b5b63000 r-xp /usr/lib/libXi.so.6.1.0
b5b64000 b5b66000 r-xp /usr/lib/libXgesture.so.7.0.0
b5b67000 b5b6d000 r-xp /usr/lib/libXtst.so.6.1.0
b5b6e000 b5b78000 r-xp /usr/lib/libXrender.so.1.3.0
b5b79000 b5b82000 r-xp /usr/lib/libXrandr.so.2.2.0
b5b84000 b5b86000 r-xp /usr/lib/libXinerama.so.1.0.0
b5b87000 b5b8c000 r-xp /usr/lib/libXfixes.so.3.1.0
b5b8d000 b5b9f000 r-xp /usr/lib/libXext.so.6.4.0
b5ba0000 b5ba2000 r-xp /usr/lib/libXdamage.so.1.1.0
b5ba3000 b5ba5000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5ba7000 b5ce9000 r-xp /usr/lib/libX11.so.6.3.0
b5ced000 b5cf7000 r-xp /usr/lib/libXcursor.so.1.0.2
b5cf8000 b5d0e000 r-xp /usr/lib/libudev.so.1.6.0
b5d11000 b5d15000 r-xp /lib/libattr.so.1.1.0
b5d16000 b5d45000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d47000 b5d4d000 r-xp /usr/lib/libffi.so.6.0.2
b5d4e000 b5d71000 r-xp /lib/libz.so.1.2.8
b5d72000 b5d75000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5d76000 b5ed2000 r-xp /usr/lib/libxml2.so.2.9.2
b5ed8000 b5fbf000 r-xp /usr/lib/libstdc++.so.6.0.20
b5fcc000 b5fcf000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5fd0000 b5ff2000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5ff3000 b6007000 r-xp /lib/libresolv-2.20-2014.11.so
b600b000 b602f000 r-xp /usr/lib/liblzma.so.5.0.3
b6030000 b6032000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b6034000 b603e000 r-xp /usr/lib/libembryo.so.1.13.0
b603f000 b6068000 r-xp /usr/lib/libpng12.so.0.50.0
b6069000 b60b2000 r-xp /usr/lib/libjpeg.so.8.0.2
b60c3000 b60ca000 r-xp /lib/librt-2.20-2014.11.so
b60cc000 b60eb000 r-xp /usr/lib/libector.so.1.13.0
b60ee000 b611b000 r-xp /usr/lib/liblua-5.1.so
b611c000 b61ac000 r-xp /usr/lib/libfreetype.so.6.11.3
b61b0000 b61ee000 r-xp /usr/lib/libfontconfig.so.1.8.0
b61ef000 b6205000 r-xp /usr/lib/libfribidi.so.0.3.1
b6206000 b625f000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6262000 b62ad000 r-xp /lib/libm-2.20-2014.11.so
b62af000 b62c1000 r-xp /usr/lib/libeio.so.1.13.0
b62c2000 b62c5000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b62c6000 b62cc000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b62cd000 b62f0000 r-xp /usr/lib/libefreet.so.1.13.0
b62f3000 b631e000 r-xp /usr/lib/libeldbus.so.1.13.0
b631f000 b6353000 r-xp /usr/lib/libecore_con.so.1.13.0
b6355000 b635e000 r-xp /usr/lib/libecore_imf.so.1.13.0
b635f000 b6368000 r-xp /usr/lib/libethumb_client.so.1.13.0
b6369000 b637c000 r-xp /usr/lib/libeo.so.1.13.0
b637e000 b6391000 r-xp /usr/lib/libecore_input.so.1.13.0
b6392000 b6399000 r-xp /usr/lib/libecore_file.so.1.13.0
b639a000 b63bd000 r-xp /usr/lib/libecore_evas.so.1.13.0
b63be000 b63ea000 r-xp /usr/lib/libeet.so.1.13.0
b63f3000 b645e000 r-xp /usr/lib/libeina.so.1.13.0
b6461000 b6478000 r-xp /usr/lib/libefl.so.1.13.0
b647a000 b65e1000 r-xp /usr/lib/libicuuc.so.51.1
b65ef000 b67fb000 r-xp /usr/lib/libicui18n.so.51.1
b6803000 b6852000 r-xp /usr/lib/libecore_x.so.1.13.0
b6854000 b686e000 r-xp /lib/libgcc_s-4.9.so.1
b6870000 b6874000 r-xp /lib/libcap.so.2.21
b6875000 b68bb000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b68bc000 b68c3000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b68c5000 b6917000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b6919000 b6aa4000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6aa9000 b6b77000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6b7a000 b6b7e000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6b7f000 b6b8e000 r-xp /usr/lib/libvconf.so.0.2.45
b6b8f000 b6b92000 r-xp /usr/lib/libvasum.so.0.3.1
b6b93000 b6b96000 r-xp /usr/lib/libttrace.so.1.1
b6b98000 b6b9c000 r-xp /usr/lib/libiniparser.so.0
b6b9d000 b6bcd000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6bce000 b6bd7000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6bd8000 b6bfd000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6bfe000 b6c0e000 r-xp /usr/lib/libunwind.so.8.0.1
b6c18000 b6dc6000 r-xp /lib/libc-2.20-2014.11.so
b6dce000 b6f11000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f13000 b6f6b000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6f6c000 b6fa0000 r-xp /usr/lib/libsystemd.so.0.4.0
b6fa3000 b7077000 r-xp /usr/lib/libedje.so.1.13.0
b707a000 b70a6000 r-xp /usr/lib/libecore.so.1.13.0
b70b7000 b72dd000 r-xp /usr/lib/libevas.so.1.13.0
b7305000 b731d000 r-xp /lib/libpthread-2.20-2014.11.so
b7321000 b769b000 r-xp /usr/lib/libelementary.so.1.13.0
b76bb000 b76bf000 r-xp /usr/lib/libsmack.so.1.0.0
b76c0000 b76c9000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b76ca000 b76cd000 r-xp /usr/lib/libdlog.so.0.0.0
b76ce000 b76d3000 r-xp /usr/lib/libbundle.so.0.1.22
b76d4000 b76d7000 r-xp /lib/libdl-2.20-2014.11.so
b76d9000 b76fe000 r-xp /usr/lib/libaul.so.0.1.0
b7701000 b7703000 r-xp /usr/lib/libappsvc.so.0.1.0
b7704000 b7709000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b770a000 b7711000 r-xp /usr/lib/libappcore-efl.so.1.1
b7713000 b7718000 r-xp /usr/lib/libsys-assert.so
b771b000 b771c000 r-xp [vdso]
b771c000 b773e000 r-xp /lib/ld-2.20-2014.11.so
b7740000 b7748000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:10132)
Call Stack Count: 29
 0: eina_rbtree_inline_remove + 0x137 (0xb6421817) [/usr/lib/libeina.so.1] + 0x2e817
 1: (0xb64077c7) [/usr/lib/libeina.so.1] + 0x147c7
 2: (0xb6407ce7) [/usr/lib/libeina.so.1] + 0x14ce7
 3: evas_common_font_flush_last + 0x4b (0xb7203d7b) [/usr/lib/libevas.so.1] + 0x14cd7b
 4: evas_common_font_flush + 0x2d (0xb7203dbd) [/usr/lib/libevas.so.1] + 0x14cdbd
 5: evas_common_font_int_unref + 0x4d (0xb7203e2d) [/usr/lib/libevas.so.1] + 0x14ce2d
 6: evas_common_font_free + 0x5a (0xb7203e9a) [/usr/lib/libevas.so.1] + 0x14ce9a
 7: (0xb7245e3d) [/usr/lib/libevas.so.1] + 0x18ee3d
 8: (0xb718a860) [/usr/lib/libevas.so.1] + 0xd3860
 9: (0xb71969e9) [/usr/lib/libevas.so.1] + 0xdf9e9
10: evas_canvas_render_idle_flush + 0x99 (0xb7106d79) [/usr/lib/libevas.so.1] + 0x4fd79
11: evas_render_idle_flush + 0x53 (0xb710c143) [/usr/lib/libevas.so.1] + 0x55143
12: (0xb710c1a8) [/usr/lib/libevas.so.1] + 0x551a8
13: eo_destructor + 0x99 (0xb6374079) [/usr/lib/libeo.so.1] + 0xb079
14: eo_unref + 0x162 (0xb63712c2) [/usr/lib/libeo.so.1] + 0x82c2
15: evas_free + 0x2e (0xb710b35e) [/usr/lib/libevas.so.1] + 0x5435e
16: _ecore_evas_free + 0x14d (0xb63a97ed) [/usr/lib/libecore_evas.so.1] + 0xf7ed
17: ecore_evas_free + 0x58 (0xb63a9a18) [/usr/lib/libecore_evas.so.1] + 0xfa18
18: (0xb75aa52d) [/usr/lib/libelementary.so.1] + 0x28952d
19: (0xb708d702) [/usr/lib/libecore.so.1] + 0x13702
20: (0xb7087055) [/usr/lib/libecore.so.1] + 0xd055
21: (0xb70901b9) [/usr/lib/libecore.so.1] + 0x161b9
22: ecore_main_loop_iterate + 0x36 (0xb7090466) [/usr/lib/libecore.so.1] + 0x16466
23: elm_shutdown + 0x85 (0xb74e85c5) [/usr/lib/libelementary.so.1] + 0x1c75c5
24: appcore_efl_main + 0x5b7 (0xb770deb7) [/usr/lib/libappcore-efl.so.1] + 0x3eb7
25: ui_app_main + 0x140 (0xb7706c80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
26: main + 0x296 (0xb377f7c6) [/opt/usr/apps/org.example.example/bin/example] + 0x87c6
27: (0xb7742148) [/opt/usr/apps/org.example.example/bin/example] + 0xb7742148
28: __libc_start_main + 0xde (0xb6c2fe4e) [/lib/libc.so.6] + 0x17e4e
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
ssage_cb(6439) > _ECORE_X_ATOM_E_VIRTUAL_KEYBOARD_ON_PREPARE_REQUEST
06-04 08:17:51.067+0900 D/ISF_PANEL_EFL( 3017): isf_panel_efl.cpp: x_event_client_message_cb(6446) > _ecore_x_e_virtual_keyboard_on_prepare_done_send (59, 1e00002)
06-04 08:17:51.077+0900 E/E17     ( 2783): e_border.c: e_border_show(2088) > BD_SHOW(0x02000003)
06-04 08:17:51.077+0900 W/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=3026
06-04 08:17:51.097+0900 W/ISF_PANEL_EFL( 3017): isf_panel_efl.cpp: efl_get_window_rotate_angle(3525) > WINDOW angle of 0x1200002 FAILED!
06-04 08:17:51.097+0900 D/AUL_AMD ( 2753): amd_launch.c: __e17_status_handler(2891) > pid(3026) status(3)
06-04 08:17:51.097+0900 D/AUL_AMD ( 2753): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
06-04 08:17:51.097+0900 W/AUL_AMD ( 2753): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-04 08:17:51.097+0900 W/AUL_AMD ( 2753): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
06-04 08:17:51.097+0900 D/AUL_AMD ( 2753): amd_status.c: _status_update_app_info_list(456) > pid(3026) status(3)
06-04 08:17:51.097+0900 W/ISF_PANEL_EFL( 3017): isf_panel_efl.cpp: efl_get_window_rotate_angle(3525) > WINDOW angle of 0x1200002 FAILED!
06-04 08:17:51.097+0900 D/ISF_PANEL_EFL( 3017): isf_panel_efl.cpp: ui_settle_candidate_window(3443) > Moving candidate window to : 0 1196
06-04 08:17:51.217+0900 D/ISF_PANEL_EFL( 3017): isf_panel_efl.cpp: x_event_window_property_cb(6298) > ECORE_X_ATOM_E_VIRTUAL_KEYBOARD_STATE : win : 0x1e00002, atom : 479
06-04 08:17:51.217+0900 D/ISF_PANEL_EFL( 3017): isf_panel_efl.cpp: x_event_window_property_cb(6302) > ECORE_X_VIRTUAL_KEYBOARD_STATE_ON
06-04 08:17:51.217+0900 W/ISF_PANEL_EFL( 3017): isf_panel_efl.cpp: efl_get_window_rotate_angle(3525) > WINDOW angle of 0x2000003 FAILED!
06-04 08:17:51.227+0900 W/ISF_PANEL_EFL( 3017): isf_panel_efl.cpp: efl_get_window_rotate_angle(3525) > WINDOW angle of 0x2000003 FAILED!
06-04 08:17:51.227+0900 D/ISF_PANEL_EFL( 3017): isf_panel_efl.cpp: get_ise_geometry(983) > angle : 0, w_angle : 0, mode : 1, Geometry : 0 838 720 442
06-04 08:17:51.227+0900 D/ISF_PANEL_EFL( 3017): isf_panel_efl.cpp: set_keyboard_geometry_atom_info(1043) > KEYBOARD_GEOMETRY_SET : 0 838 720 442
06-04 08:17:51.227+0900 W/ISF_PANEL_EFL( 3017): isf_panel_efl.cpp: efl_get_window_rotate_angle(3525) > WINDOW angle of 0x1200002 FAILED!
06-04 08:17:51.227+0900 D/ISF_PANEL_EFL( 3017): isf_panel_efl.cpp: ui_settle_candidate_window(3443) > Moving candidate window to : 0 754
06-04 08:17:51.297+0900 D/IMMODULE(10132): isf_imf_control_ui.cpp: _event_callback_call(243) > [SECURE_LOG] [input panel will be shown] ctx : 0xb8888690
06-04 08:17:51.297+0900 E/EFL     (10132): edje<10132> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:17:51.297+0900 E/EFL     (10132): edje<10132> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:17:51.297+0900 E/EFL     (10132): edje<10132> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:17:51.297+0900 E/EFL     (10132): edje<10132> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:17:51.307+0900 E/EFL     (10132): edje<10132> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:17:51.307+0900 E/EFL     (10132): edje<10132> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:17:51.327+0900 D/IMMODULE(10132): isf_imf_control_ui.cpp: _prop_change(172) > conformant_reset_done = 0, candidate_conformant_reset_done = 0, registering _candidate_render_post_cb
06-04 08:17:51.327+0900 D/IMMODULE(10132): isf_imf_control_ui.cpp: _prop_change(179) > [ECORE_X_VIRTUAL_KEYBOARD_STATE_ON] geometry x : 0, y : 838, w : 720, h : 442
06-04 08:17:51.337+0900 W/ISF_PANEL_EFL( 3017): isf_panel_efl.cpp: efl_get_window_rotate_angle(3525) > WINDOW angle of 0x1200002 FAILED!
06-04 08:17:51.387+0900 D/IMMODULE(10132): isf_imf_control_ui.cpp: _event_callback_call(257) > [SECURE_LOG] [input panel geometry is changed] ctx : 0xb8888690
06-04 08:17:51.437+0900 D/IMMODULE(10132): isf_imf_control_ui.cpp: _event_callback_call(240) > [SECURE_LOG] [input panel has been shown] ctx : 0xb8888690
06-04 08:17:51.437+0900 D/IMMODULE(10132): isf_imf_control_ui.cpp: _process_ise_panel_showed(1060) > received_will_hide_event = 0
06-04 08:17:52.037+0900 D/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x4023fd 
06-04 08:17:52.107+0900 D/IMMODULE(10132): isf_imf_context.cpp: isf_imf_context_focus_out(1587) > ctx : 0xb8888690
06-04 08:17:52.107+0900 D/IMMODULE(10132): isf_imf_control_ui.cpp: check_focus_out_by_popup_win(439) > win type : 8
06-04 08:17:52.107+0900 D/IMMODULE(10132): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb8888690
06-04 08:17:52.107+0900 D/ISE_DEFAULT( 3026): ise.cpp: on_focus_out(251) > Enter
06-04 08:17:52.177+0900 I/tag     (10132): insert
06-04 08:17:52.187+0900 I/user_tag(10132): 08:17 AM
06-04 08:17:52.187+0900 E/EFL     (10132): edje<10132> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:17:52.187+0900 E/EFL     (10132): edje<10132> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:17:52.187+0900 E/EFL     (10132): edje<10132> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:17:52.197+0900 E/EFL     (10132): edje<10132> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:17:52.197+0900 E/EFL     (10132): edje<10132> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:17:52.197+0900 D/IMMODULE(10132): isf_imf_context.cpp: isf_imf_context_del(1298) > ctx : 0xb8888690
06-04 08:17:52.197+0900 D/ISF_PANEL_EFL( 3017): isf_panel_efl.cpp: slot_get_ise_state(5871) > state = 0
06-04 08:17:52.197+0900 D/IMMODULE(10132): isf_imf_control_ui.cpp: isf_imf_context_input_panel_state_get(931) >     state:0
06-04 08:17:52.197+0900 D/IMMODULE(10132): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(690) > [SECURE_LOG] ctx : 0xb8888690
06-04 08:17:52.197+0900 D/IMMODULE(10132): isf_imf_control_ui.cpp: _send_input_panel_hide_request(332) > [SECURE_LOG] Send input panel hide request
06-04 08:17:52.217+0900 D/IMMODULE(10132): isf_imf_control_ui.cpp: _event_callback_call(232) > [SECURE_LOG] [input panel has been hidden] ctx : 0xb8888690
06-04 08:17:52.217+0900 D/ISF_PANEL_EFL( 3017): scim_panel_agent.cpp: hide_ise_panel(1905) > prepare to hide ISE, 36 36
06-04 08:17:52.217+0900 D/ISF_PANEL_EFL( 3017): isf_panel_efl.cpp: slot_hide_ise(5796) > slot_hide_ise ()
06-04 08:17:52.217+0900 D/ISF_PANEL_EFL( 3017): isf_panel_efl.cpp: hide_ise(3906) > send request to hide helper
06-04 08:17:52.217+0900 D/ISF_PANEL_EFL( 3017): scim_panel_agent.cpp: hide_helper(1479) > Send ISM_TRANS_CMD_HIDE_ISE_PANEL message
06-04 08:17:52.217+0900 D/SCIM_HELPER( 3026): scim_helper.cpp: filter_event(538) > Helper ISE received ISM_TRANS_CMD_HIDE_ISE_PANEL message
06-04 08:17:52.217+0900 D/LIBSCL_UI( 3026): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000fc7f 0x2000009 (basewin 0x8000321a mag 0x8000fc7f)
06-04 08:17:52.217+0900 D/ISF_PANEL_EFL( 3017): isf_panel_efl.cpp: ui_candidate_hide(2446) > candidate_state = WILL_HIDE
06-04 08:17:52.217+0900 D/ISF_PANEL_EFL( 3017): isf_panel_efl.cpp: delete_candidate_hide_timer(2208) > deleting candidate_hide_timer
06-04 08:17:52.217+0900 D/ISF_PANEL_EFL( 3017): isf_panel_efl.cpp: slot_will_hide_ack(5811) > _ecore_x_e_virtual_keyboard_off_prepare_done_send (59, 1e00002)
06-04 08:17:52.217+0900 D/ISF_PANEL_EFL( 3017): isf_panel_efl.cpp: slot_will_hide_ack(5813) > calling ui_candidate_hide (true, false)
06-04 08:17:52.217+0900 D/ISF_PANEL_EFL( 3017): isf_panel_efl.cpp: delete_candidate_hide_timer(2208) > deleting candidate_hide_timer
06-04 08:17:52.217+0900 D/ISF_PANEL_EFL( 3017): isf_panel_efl.cpp: candidate_window_hide(2222) > evas_object_hide (_candidate_window, 0x1e0000c)
06-04 08:17:52.227+0900 D/LIBSCL_UI( 3026): sclutils-linux.cpp: log(325) > WinEfl_hidewin 0x8000321a 0x2000003 (basewin 0x8000321a mag 0x8000fc7f)
06-04 08:17:52.227+0900 D/ISE_DEFAULT( 3026): ise.cpp: _reset_shift_state(163) > Shift state changed from (0) to (0)
06-04 08:17:52.227+0900 E/E17     ( 2783): e_border.c: e_border_hide(2248) > BD_HIDE(0x02000003), visible:1
06-04 08:17:52.227+0900 D/ISF_PANEL_EFL( 3017): isf_panel_efl.cpp: x_event_client_message_cb(6456) > _ECORE_X_ATOM_E_VIRTUAL_KEYBOARD_OFF_PREPARE_REQUEST
06-04 08:17:52.227+0900 W/ISF_PANEL_EFL( 3017): isf_panel_efl.cpp: efl_get_window_rotate_angle(3525) > WINDOW angle of 0x1200002 FAILED!
06-04 08:17:52.227+0900 D/ISF_PANEL_EFL( 3017): isf_panel_efl.cpp: get_ise_geometry(983) > angle : 0, w_angle : -1, mode : 1, Geometry : 0 1280 0 0
06-04 08:17:52.227+0900 D/ISF_PANEL_EFL( 3017): isf_panel_efl.cpp: set_keyboard_geometry_atom_info(1043) > KEYBOARD_GEOMETRY_SET : 0 1280 0 0
06-04 08:17:52.257+0900 W/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=10132
06-04 08:17:52.287+0900 D/ISF_PANEL_EFL( 3017): isf_panel_efl.cpp: x_event_window_property_cb(6298) > ECORE_X_ATOM_E_VIRTUAL_KEYBOARD_STATE : win : 0x1e00002, atom : 479
06-04 08:17:52.287+0900 D/ISF_PANEL_EFL( 3017): isf_panel_efl.cpp: x_event_window_property_cb(6373) > ECORE_X_VIRTUAL_KEYBOARD_STATE_OFF
06-04 08:17:52.287+0900 D/ISF_PANEL_EFL( 3017): isf_panel_efl.cpp: x_event_window_property_cb(6390) > calling ui_candidate_hide (true, false)
06-04 08:17:52.287+0900 D/ISF_PANEL_EFL( 3017): isf_panel_efl.cpp: delete_candidate_hide_timer(2208) > deleting candidate_hide_timer
06-04 08:17:52.287+0900 D/ISF_PANEL_EFL( 3017): isf_panel_efl.cpp: candidate_window_hide(2222) > evas_object_hide (_candidate_window, 0x1e0000c)
06-04 08:17:52.297+0900 W/ISF_PANEL_EFL( 3017): isf_panel_efl.cpp: efl_get_window_rotate_angle(3525) > WINDOW angle of 0x1200002 FAILED!
06-04 08:17:52.297+0900 D/ISF_PANEL_EFL( 3017): isf_panel_efl.cpp: ui_settle_candidate_window(3443) > Moving candidate window to : 0 1196
06-04 08:17:52.297+0900 D/ISF_PANEL_EFL( 3017): isf_panel_efl.cpp: x_event_window_property_cb(6298) > ECORE_X_ATOM_E_VIRTUAL_KEYBOARD_STATE : win : 0x1e00002, atom : 479
06-04 08:17:52.297+0900 D/ISF_PANEL_EFL( 3017): isf_panel_efl.cpp: x_event_window_property_cb(6373) > ECORE_X_VIRTUAL_KEYBOARD_STATE_OFF
06-04 08:17:52.297+0900 D/ISF_PANEL_EFL( 3017): isf_panel_efl.cpp: x_event_window_property_cb(6390) > calling ui_candidate_hide (true, false)
06-04 08:17:52.297+0900 D/ISF_PANEL_EFL( 3017): isf_panel_efl.cpp: delete_candidate_hide_timer(2208) > deleting candidate_hide_timer
06-04 08:17:52.297+0900 D/ISF_PANEL_EFL( 3017): isf_panel_efl.cpp: candidate_window_hide(2222) > evas_object_hide (_candidate_window, 0x1e0000c)
06-04 08:17:52.297+0900 W/ISF_PANEL_EFL( 3017): isf_panel_efl.cpp: efl_get_window_rotate_angle(3525) > WINDOW angle of 0x1200002 FAILED!
06-04 08:17:52.297+0900 D/IMMODULE(10132): isf_imf_control_ui.cpp: _event_callback_call(257) > [SECURE_LOG] [input panel geometry is changed] ctx : (nil)
06-04 08:17:52.297+0900 D/IMMODULE(10132): isf_imf_control_ui.cpp: _prop_change(162) > conformant_reset_done = 0, candidate_conformant_reset_done = 0, registering _render_post_cb
06-04 08:17:52.297+0900 D/IMMODULE(10132): isf_imf_control_ui.cpp: _prop_change(169) > [ECORE_X_VIRTUAL_KEYBOARD_STATE_OFF] geometry x : 0, y : 1280, w : 0, h : 0
06-04 08:17:52.387+0900 D/IMMODULE(10132): isf_imf_control_ui.cpp: _event_callback_call(260) > [SECURE_LOG] [candidate state is changed] ctx : (nil), 1
06-04 08:17:52.387+0900 D/IMMODULE(10132): isf_imf_control_ui.cpp: _event_callback_call(279) > [SECURE_LOG] received_candidate_will_hide_event != 1, due to notified_state
06-04 08:17:52.387+0900 D/IMMODULE(10132): isf_imf_control_ui.cpp: _event_callback_call(257) > [SECURE_LOG] [input panel geometry is changed] ctx : (nil)
06-04 08:17:52.387+0900 D/IMMODULE(10132): isf_imf_control_ui.cpp: _event_callback_call(260) > [SECURE_LOG] [candidate state is changed] ctx : (nil), 1
06-04 08:17:52.387+0900 D/IMMODULE(10132): isf_imf_control_ui.cpp: _event_callback_call(279) > [SECURE_LOG] received_candidate_will_hide_event != 1, due to notified_state
06-04 08:17:52.387+0900 D/IMMODULE(10132): isf_imf_control_ui.cpp: _event_callback_call(257) > [SECURE_LOG] [input panel geometry is changed] ctx : (nil)
06-04 08:17:52.397+0900 D/IMMODULE(10132): isf_imf_control_ui.cpp: _event_callback_call(232) > [SECURE_LOG] [input panel has been hidden] ctx : (nil)
06-04 08:17:52.397+0900 D/IMMODULE(10132): isf_imf_control_ui.cpp: _process_ise_panel_hided(1080) > received_will_hide_event = 1
06-04 08:17:52.397+0900 D/ISF_PANEL_EFL( 3017): isf_panel_efl.cpp: slot_will_hide_ack(5811) > _ecore_x_e_virtual_keyboard_off_prepare_done_send (59, 1e00002)
06-04 08:17:52.397+0900 D/ISF_PANEL_EFL( 3017): isf_panel_efl.cpp: slot_will_hide_ack(5813) > calling ui_candidate_hide (true, false)
06-04 08:17:52.397+0900 D/ISF_PANEL_EFL( 3017): isf_panel_efl.cpp: delete_candidate_hide_timer(2208) > deleting candidate_hide_timer
06-04 08:17:52.397+0900 D/ISF_PANEL_EFL( 3017): isf_panel_efl.cpp: candidate_window_hide(2222) > evas_object_hide (_candidate_window, 0x1e0000c)
06-04 08:17:52.397+0900 D/IMMODULE(10132): isf_imf_control_ui.cpp: _event_callback_call(257) > [SECURE_LOG] [input panel geometry is changed] ctx : (nil)
06-04 08:17:52.397+0900 D/IMMODULE(10132): isf_imf_control_ui.cpp: _event_callback_call(260) > [SECURE_LOG] [candidate state is changed] ctx : (nil), 1
06-04 08:17:52.397+0900 D/IMMODULE(10132): isf_imf_control_ui.cpp: _event_callback_call(279) > [SECURE_LOG] received_candidate_will_hide_event != 1, due to notified_state
06-04 08:17:52.397+0900 D/IMMODULE(10132): isf_imf_control_ui.cpp: _event_callback_call(257) > [SECURE_LOG] [input panel geometry is changed] ctx : (nil)
06-04 08:17:52.397+0900 D/IMMODULE(10132): isf_imf_control_ui.cpp: _event_callback_call(260) > [SECURE_LOG] [candidate state is changed] ctx : (nil), 1
06-04 08:17:52.397+0900 D/IMMODULE(10132): isf_imf_control_ui.cpp: _event_callback_call(279) > [SECURE_LOG] received_candidate_will_hide_event != 1, due to notified_state
06-04 08:17:52.397+0900 D/IMMODULE(10132): isf_imf_control_ui.cpp: _event_callback_call(257) > [SECURE_LOG] [input panel geometry is changed] ctx : (nil)
06-04 08:17:52.397+0900 D/IMMODULE(10132): isf_imf_control_ui.cpp: _event_callback_call(260) > [SECURE_LOG] [candidate state is changed] ctx : (nil), 1
06-04 08:17:52.397+0900 D/IMMODULE(10132): isf_imf_control_ui.cpp: _event_callback_call(279) > [SECURE_LOG] received_candidate_will_hide_event != 1, due to notified_state
06-04 08:17:53.317+0900 D/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x4023fd 
06-04 08:17:54.017+0900 D/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x4023fd bd->visible=1
06-04 08:17:54.117+0900 I/user_tag0(10132): /opt/usr/apps/org.example.example/data/feeding.db
06-04 08:17:54.117+0900 I/tag     (10132): eonji~
06-04 08:17:54.117+0900 I/tag     (10132): 들어와!
06-04 08:17:54.117+0900 I/tag     (10132): 언지
06-04 08:17:54.117+0900 I/tag     (10132): 8 17
06-04 08:17:54.117+0900 I/tag     (10132): 8 17
06-04 08:17:54.117+0900 I/tag     (10132): aa
06-04 08:17:54.117+0900 E/EFL     (10132): eo<10132> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0x801576c1 is not pointing to a valid object. Maybe it has already been freed.
06-04 08:17:54.117+0900 E/EFL     (10132): eo<10132> lib/eo/eo.c:1699 eo_data_scope_get() Obj (0x801576c1) is an invalid ref.
06-04 08:17:54.137+0900 D/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x4023fd 
06-04 08:17:55.117+0900 D/ISF_PANEL_EFL( 3017): isf_panel_efl.cpp: ui_destroy_candidate_window(3256) > calling ui_candidate_hide (true)
06-04 08:17:55.117+0900 D/IMMODULE(10132): isf_imf_control_ui.cpp: _event_callback_call(257) > [SECURE_LOG] [input panel geometry is changed] ctx : (nil)
06-04 08:17:55.117+0900 W/ISF_PANEL_EFL( 3017): isf_panel_efl.cpp: efl_get_window_rotate_angle(3525) > WINDOW angle of 0x1200002 FAILED!
06-04 08:17:55.117+0900 D/ISF_PANEL_EFL( 3017): isf_panel_efl.cpp: get_ise_geometry(983) > angle : 0, w_angle : -1, mode : 1, Geometry : 0 1280 0 0
06-04 08:17:55.117+0900 D/ISF_PANEL_EFL( 3017): isf_panel_efl.cpp: set_keyboard_geometry_atom_info(1043) > KEYBOARD_GEOMETRY_SET : 0 1280 0 0
06-04 08:17:55.117+0900 D/ISF_PANEL_EFL( 3017): isf_panel_efl.cpp: delete_candidate_hide_timer(2208) > deleting candidate_hide_timer
06-04 08:17:55.117+0900 D/ISF_PANEL_EFL( 3017): isf_panel_efl.cpp: candidate_window_hide(2222) > evas_object_hide (_candidate_window, 0x1e0000c)
06-04 08:17:55.117+0900 D/IMMODULE(10132): isf_imf_control_ui.cpp: _event_callback_call(260) > [SECURE_LOG] [candidate state is changed] ctx : (nil), 1
06-04 08:17:55.117+0900 D/IMMODULE(10132): isf_imf_control_ui.cpp: _event_callback_call(279) > [SECURE_LOG] received_candidate_will_hide_event != 1, due to notified_state
06-04 08:17:55.147+0900 D/IMMODULE(10132): isf_imf_control_ui.cpp: _prop_change(162) > conformant_reset_done = 0, candidate_conformant_reset_done = 0, registering _render_post_cb
06-04 08:17:55.147+0900 D/IMMODULE(10132): isf_imf_control_ui.cpp: _prop_change(169) > [ECORE_X_VIRTUAL_KEYBOARD_STATE_OFF] geometry x : 0, y : 1280, w : 0, h : 0
06-04 08:18:00.337+0900 D/INDICATOR( 2856): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
06-04 08:18:00.337+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
06-04 08:18:00.337+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
06-04 08:18:00.337+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 8:18 4 h"
06-04 08:18:00.337+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 8:18"
06-04 08:18:00.337+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 8&#x2236;18"
06-04 08:18:00.337+0900 D/INDICATOR( 2856): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2146784424 Time: <font_size=33>8&#x2236;18</font_size> <font_size=32>AM</font_size></font>
06-04 08:18:02.657+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-04 08:18:02.657+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f0f9)
06-04 08:18:02.657+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-04 08:18:02.657+0900 E/INDICATOR( 2856): 
06-04 08:18:22.677+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-04 08:18:22.677+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f0f9)
06-04 08:18:22.677+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-04 08:18:22.677+0900 E/INDICATOR( 2856): 
06-04 08:18:31.797+0900 D/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x4023fd 
06-04 08:18:31.837+0900 E/EFL     (10132): edje<10132> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p15';
06-04 08:18:31.837+0900 E/EFL     (10132): By the power of Grayskull, your previous Embryo stack is now broken!
06-04 08:18:31.887+0900 E/EFL     (10132): edje<10132> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:18:31.887+0900 E/EFL     (10132): edje<10132> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:18:31.927+0900 E/EFL     (10132): edje<10132> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:18:31.927+0900 E/EFL     (10132): edje<10132> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:18:31.927+0900 E/EFL     (10132): edje<10132> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:18:31.927+0900 E/EFL     (10132): edje<10132> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:18:31.927+0900 E/EFL     (10132): edje<10132> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:18:31.927+0900 E/EFL     (10132): edje<10132> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:18:31.927+0900 E/EFL     (10132): edje<10132> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:18:32.797+0900 D/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x1200002
06-04 08:18:32.927+0900 D/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x4023fd 
06-04 08:18:33.117+0900 I/tag     (10132): insert
06-04 08:18:33.117+0900 I/user_tag(10132): 08:18 AM
06-04 08:18:33.117+0900 E/EFL     (10132): edje<10132> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:18:33.117+0900 E/EFL     (10132): edje<10132> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:18:33.127+0900 E/EFL     (10132): edje<10132> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:18:33.127+0900 E/EFL     (10132): edje<10132> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:18:33.127+0900 E/EFL     (10132): edje<10132> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:18:33.707+0900 D/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x4023fd 
06-04 08:18:34.457+0900 I/user_tag0(10132): /opt/usr/apps/org.example.example/data/feeding.db
06-04 08:18:34.467+0900 I/tag     (10132): eonji~
06-04 08:18:34.467+0900 I/tag     (10132): 들어와!
06-04 08:18:34.467+0900 I/tag     (10132): 언지
06-04 08:18:34.467+0900 I/tag     (10132): 8 17
06-04 08:18:34.467+0900 I/tag     (10132): 8 17
06-04 08:18:34.467+0900 I/tag     (10132): aa
06-04 08:18:34.467+0900 E/EFL     (10132): eo<10132> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0x800b7d95 is not pointing to a valid object. Maybe it has already been freed.
06-04 08:18:34.467+0900 E/EFL     (10132): eo<10132> lib/eo/eo.c:1699 eo_data_scope_get() Obj (0x800b7d95) is an invalid ref.
06-04 08:18:34.537+0900 D/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x4023fd 
06-04 08:18:35.897+0900 D/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x4023fd 
06-04 08:18:36.607+0900 D/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x4023fd 
06-04 08:18:36.677+0900 I/tag     (10132): �
06-04 08:18:36.677+0900 E/EFL     (10132): <10132> elc_popup.c:1915 elm_popup_add() safety check failed: parent == NULL
06-04 08:18:36.677+0900 E/EFL     (10132): <10132> elm_label.c:947 elm_label_add() safety check failed: parent == NULL
06-04 08:18:36.677+0900 E/EFL     (10132): <10132> elm_main.c:1218 elm_object_part_text_set() safety check failed: obj == NULL
06-04 08:18:36.677+0900 E/EFL     (10132): <10132> elm_main.c:1265 elm_object_part_content_set() safety check failed: obj == NULL
06-04 08:18:36.677+0900 E/EFL     (10132): <10132> elm_button.c:339 elm_button_add() safety check failed: parent == NULL
06-04 08:18:36.677+0900 E/EFL     (10132): <10132> elm_button.c:339 elm_button_add() safety check failed: parent == NULL
06-04 08:18:36.677+0900 E/EFL     (10132): <10132> elm_main.c:1287 elm_object_style_set() safety check failed: obj == NULL
06-04 08:18:36.677+0900 E/EFL     (10132): <10132> elm_main.c:1218 elm_object_part_text_set() safety check failed: obj == NULL
06-04 08:18:36.677+0900 E/EFL     (10132): <10132> elm_main.c:1265 elm_object_part_content_set() safety check failed: obj == NULL
06-04 08:18:36.677+0900 E/EFL     (10132): <10132> elm_main.c:1287 elm_object_style_set() safety check failed: obj == NULL
06-04 08:18:36.677+0900 E/EFL     (10132): <10132> elm_main.c:1218 elm_object_part_text_set() safety check failed: obj == NULL
06-04 08:18:36.677+0900 E/EFL     (10132): <10132> elm_main.c:1265 elm_object_part_content_set() safety check failed: obj == NULL
06-04 08:18:36.677+0900 E/efl-extension(10132): eext_events.c: _eext_key_grab_obj_create(299) > Failed to grab BACK KEY
06-04 08:18:36.677+0900 E/efl-extension(10132): eext_events.c: _eext_key_grab_obj_create(302) > Failed to grab MENU KEY
06-04 08:18:37.796+0900 D/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x4023fd bd->visible=1
06-04 08:18:42.696+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-04 08:18:42.696+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f0f9)
06-04 08:18:42.696+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-04 08:18:42.696+0900 E/INDICATOR( 2856): 
06-04 08:18:50.446+0900 D/RESOURCED( 2854): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
06-04 08:18:50.446+0900 I/RESOURCED( 2854): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
06-04 08:18:50.446+0900 D/RESOURCED( 2854): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
06-04 08:18:50.446+0900 I/RESOURCED( 2854): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
06-04 08:18:50.446+0900 D/RESOURCED( 2854): heart-cpu.c: heart_cpu_update(576) > org.tizen.homescreen org.tizen.homescreen 1496530708 212 185 2867 1
06-04 08:18:50.446+0900 D/RESOURCED( 2854): heart-cpu.c: heart_cpu_update(576) > org.example.example org.example.example 1496530712 21 7 7980 1
06-04 08:18:50.446+0900 D/RESOURCED( 2854): heart-cpu.c: heart_cpu_update(576) > org.tizen.homescreen org.tizen.homescreen 1496530774 223 190 2867 1
06-04 08:18:50.446+0900 D/RESOURCED( 2854): heart-cpu.c: heart_cpu_update(576) > org.example.example org.example.example 1496530779 24 6 8144 1
06-04 08:18:50.446+0900 D/RESOURCED( 2854): heart-cpu.c: heart_cpu_update(576) > org.tizen.homescreen org.tizen.homescreen 1496530828 236 195 2867 1
06-04 08:18:50.446+0900 D/RESOURCED( 2854): heart-cpu.c: heart_cpu_update(576) > org.example.example org.example.example 1496530833 27 2 8309 1
06-04 08:18:50.446+0900 D/RESOURCED( 2854): heart-cpu.c: heart_cpu_update(576) > org.tizen.homescreen org.tizen.homescreen 1496530861 241 203 2867 1
06-04 08:18:50.446+0900 D/RESOURCED( 2854): heart-cpu.c: heart_cpu_update(576) > org.example.example org.example.example 1496530866 25 6 8474 1
06-04 08:18:50.446+0900 D/RESOURCED( 2854): heart-cpu.c: heart_cpu_update(576) > org.tizen.homescreen org.tizen.homescreen 1496530897 245 210 2867 1
06-04 08:18:50.446+0900 D/RESOURCED( 2854): heart-cpu.c: heart_cpu_update(576) > org.example.example org.example.example 1496530902 31 2 8640 1
06-04 08:18:50.446+0900 D/RESOURCED( 2854): heart-cpu.c: heart_cpu_update(576) > org.tizen.homescreen org.tizen.homescreen 1496530958 253 215 2867 1
06-04 08:18:50.446+0900 D/RESOURCED( 2854): heart-cpu.c: heart_cpu_update(576) > org.example.example org.example.example 1496530962 28 1 8804 1
06-04 08:18:50.446+0900 D/RESOURCED( 2854): heart-cpu.c: heart_cpu_update(576) > org.tizen.homescreen org.tizen.homescreen 1496531030 260 221 2867 1
06-04 08:18:50.446+0900 D/RESOURCED( 2854): heart-cpu.c: heart_cpu_update(576) > org.example.example org.example.example 1496531035 29 4 8969 1
06-04 08:18:50.446+0900 D/RESOURCED( 2854): heart-cpu.c: heart_cpu_update(576) > org.tizen.homescreen org.tizen.homescreen 1496531174 267 227 2867 1
06-04 08:18:50.446+0900 D/RESOURCED( 2854): heart-cpu.c: heart_cpu_update(576) > org.example.example org.example.example 1496531178 27 8 9134 1
06-04 08:18:50.446+0900 D/RESOURCED( 2854): heart-cpu.c: heart_cpu_update(576) > org.tizen.homescreen org.tizen.homescreen 1496531241 275 237 2867 1
06-04 08:18:50.446+0900 D/RESOURCED( 2854): heart-cpu.c: heart_cpu_update(576) > org.example.example org.example.example 1496531246 26 8 9300 1
06-04 08:18:50.456+0900 I/RESOURCED( 2854): logging.c: logging_save_to_storage(978) > battery cache is empty
06-04 08:19:00.356+0900 D/INDICATOR( 2856): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
06-04 08:19:00.356+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
06-04 08:19:00.356+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
06-04 08:19:00.356+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 8:19 4 h"
06-04 08:19:00.356+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 8:19"
06-04 08:19:00.356+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 8&#x2236;19"
06-04 08:19:00.356+0900 D/INDICATOR( 2856): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2146782372 Time: <font_size=33>8&#x2236;19</font_size> <font_size=32>AM</font_size></font>
06-04 08:19:02.696+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-04 08:19:02.696+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f0f9)
06-04 08:19:02.696+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-04 08:19:02.696+0900 E/INDICATOR( 2856): 
06-04 08:19:22.706+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-04 08:19:22.706+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f0f9)
06-04 08:19:22.706+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-04 08:19:22.706+0900 E/INDICATOR( 2856): 
06-04 08:19:42.726+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-04 08:19:42.726+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f0f9)
06-04 08:19:42.726+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-04 08:19:42.726+0900 E/INDICATOR( 2856): 
06-04 08:19:50.496+0900 D/RESOURCED( 2854): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
06-04 08:19:50.496+0900 I/RESOURCED( 2854): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
06-04 08:19:50.496+0900 D/RESOURCED( 2854): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
06-04 08:19:50.496+0900 I/RESOURCED( 2854): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
06-04 08:19:58.205+0900 E/PKGMGR_SERVER(10335): pkgmgr-server.c: main(2209) > package manager server start
06-04 08:19:58.205+0900 D/PKGMGR  (10335): comm_pkg_mgr_server.c: pkg_mgr_server_gdbus_init(405) > initialize_gdbus Enter
06-04 08:19:58.205+0900 D/PKGMGR  (10335): comm_pkg_mgr_server.c: pkg_mgr_server_gdbus_init(423) > initialize_gdbus Exit
06-04 08:19:58.215+0900 D/PKGMGR  (10335): comm_pkg_mgr_server.c: on_bus_acquired(376) > on_bus_acquired
06-04 08:19:58.215+0900 D/PKGMGR  (10335): comm_pkg_mgr_server.c: on_bus_acquired(400) > on_bus_acquired done
06-04 08:19:58.225+0900 D/PKGMGR  (10335): comm_pkg_mgr_server.c: pkgmgr_request(145) > Called
06-04 08:19:58.225+0900 D/PKGMGR  (10335): comm_pkg_mgr_server.c: pkgmgr_request(164) > sender_name: :1.872
06-04 08:19:58.225+0900 D/PKGMGR  (10335): comm_pkg_mgr_server.c: pkg_mgr_get_sender_pid(79) > zone pid : 10333
06-04 08:19:58.225+0900 D/PKGMGR  (10335): comm_pkg_mgr_server.c: pkgmgr_request(166) > sender_pid: 10333
06-04 08:19:58.225+0900 D/PKGMGR  (10335): comm_pkg_mgr_server.c: pkgmgr_request(175) > [SECURE_LOG] Call request callback(obj, org.example.example_-2111449917, 14, tpk, org.example.example, , host)
06-04 08:19:58.225+0900 D/PKGMGR_SERVER(10335): pkgmgr-server.c: req_cb(625) > [SECURE_LOG] >> in callback >> Got request: [org.example.example_-2111449917] [14] [tpk] [org.example.example] [] [] [host]
06-04 08:19:58.225+0900 D/PKGMGR_SERVER(10335): pkgmgr-server.c: req_cb(646) > req_type=(14)  backend_flag=(0) zone(host)
06-04 08:19:58.225+0900 D/PKGMGR_SERVER(10335): pkgmgr-server.c: queue_job(1880) > target zone(host, host)
06-04 08:19:58.225+0900 D/PKGMGR_SERVER(10335): pkgmgr-server.c: queue_job(1884) > child forked [10338] for request type [14]
06-04 08:19:58.225+0900 D/PKGMGR_SERVER(10335): pkgmgr-server.c: queue_job(2126) > parent exit
06-04 08:19:58.225+0900 D/PKGMGR_SERVER(10338): pkgmgr-server.c: queue_job(1884) > child forked [0] for request type [14]
06-04 08:19:58.225+0900 D/PKGMGR_SERVER(10338): pkgmgr-server.c: queue_job(2057) > kill/check request
06-04 08:19:58.225+0900 D/PKGMGR  (10333): pkgmgr.c: __check_sync_process(868) > info_file file is generated, result = 0
06-04 08:19:58.225+0900 D/PKGMGR  (10333): . 
06-04 08:19:58.225+0900 E/PKGMGR  (10333): pkgmgr.c: __check_sync_process(884) > file is can not remove[/tmp/org.example.example, -1]
06-04 08:19:58.235+0900 D/PKGMGR_SERVER(10338): pkgmgr-server.c: __pkgcmd_app_cb(1458) > sub_cmd(kill), zone_name(host)
06-04 08:19:58.245+0900 D/AUL     (10338): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(14)
06-04 08:19:58.245+0900 D/AUL_AMD ( 2753): amd_request.c: __request_handler(838) > __request_handler: 14
06-04 08:19:58.245+0900 D/AUL_AMD ( 2753): amd_status.c: _status_app_is_running_from_cache(836) > is_running hit cache, return immediately
06-04 08:19:58.245+0900 D/AUL_AMD ( 2753): amd_request.c: __request_handler(1028) > [SECURE_LOG] APP_IS_RUNNING : org.example.example : 10132
06-04 08:19:58.245+0900 W/AUL_AMD ( 2753): amd_request.c: __send_result_to_client(150) > __send_result_to_client, pid: 10132
06-04 08:19:58.245+0900 D/AUL_AMD ( 2753): amd_request.c: __request_handler(838) > __request_handler: 12
06-04 08:19:58.245+0900 D/AUL     (10338): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 359
06-04 08:19:58.245+0900 D/AUL     (10338): launch.c: app_request_to_launchpad(396) > [SECURE_LOG] launch request : 10132
06-04 08:19:58.245+0900 D/AUL     (10338): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(5)
06-04 08:19:58.245+0900 D/AUL_AMD ( 2753): amd_request.c: __request_handler(838) > __request_handler: 5
06-04 08:19:58.245+0900 D/AUL_AMD ( 2753): amd_appinfo.c: appinfo_set_value(905) > [SECURE_LOG] org.example.example : installed : norestart
06-04 08:19:58.245+0900 D/AUL_AMD ( 2753): amd_request.c: __app_process_by_pid(279) > [SECURE_LOG] __app_process_by_pid, pid: 10132, 
06-04 08:19:58.245+0900 D/AUL     ( 2753): app_sock.c: __app_send_raw_with_delay_reply(455) > pid(10132) : cmd(4)
06-04 08:19:58.245+0900 D/AUL_AMD ( 2753): amd_launch.c: _term_app(1076) > term done
06-04 08:19:58.245+0900 D/AUL_AMD ( 2753): amd_launch.c: __set_reply_handler(1015) > listen fd : 31, send fd : 30
06-04 08:19:58.245+0900 D/APP_CORE(10132): appcore.c: __aul_handler(632) > [APP 10132]     AUL event: AUL_TERMINATE
06-04 08:19:58.245+0900 I/APP_CORE(10132): appcore-efl.c: __do_app(496) > [APP 10132] Event: TERMINATE State: RUNNING
06-04 08:19:58.245+0900 D/APP_CORE(10132): appcore-efl.c: __do_app(517) > [APP 10132] TERMINATE
06-04 08:19:58.245+0900 W/AUL_AMD ( 2753): amd_launch.c: __reply_handler(913) > listen fd(31) , send fd(30), pid(10132), cmd(4)
06-04 08:19:58.245+0900 D/AUL     (10338): launch.c: app_request_to_launchpad(425) > launch request result : 0
06-04 08:19:58.245+0900 D/AUL     (10338): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(14)
06-04 08:19:58.245+0900 D/AUL_AMD ( 2753): amd_request.c: __request_handler(838) > __request_handler: 14
06-04 08:19:58.245+0900 D/AUL_AMD ( 2753): amd_status.c: _status_app_is_running_from_cache(836) > is_running hit cache, return immediately
06-04 08:19:58.245+0900 D/AUL_AMD ( 2753): amd_request.c: __request_handler(1028) > [SECURE_LOG] APP_IS_RUNNING : org.example.example : 10132
06-04 08:19:58.245+0900 W/AUL_AMD ( 2753): amd_request.c: __send_result_to_client(150) > __send_result_to_client, pid: 10132
06-04 08:19:58.245+0900 D/RESOURCED( 2854): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 10132
06-04 08:19:58.245+0900 D/AUL     (10132): app_sock.c: __app_send_raw_with_noreply(384) > pid(-2) : cmd(22)
06-04 08:19:58.245+0900 D/AUL_AMD ( 2753): amd_request.c: __request_handler(838) > __request_handler: 22
06-04 08:19:58.245+0900 W/AUL_AMD ( 2753): amd_request.c: __request_handler(1056) > app status : 5
06-04 08:19:58.245+0900 D/AUL_AMD ( 2753): amd_status.c: _status_update_app_info_list(456) > pid(10132) status(5)
06-04 08:19:58.245+0900 D/AUL_AMD ( 2753): amd_status.c: _status_update_app_info_list(468) > pid(10132) appid(org.example.example) pkgid(org.example.example) status(5)
06-04 08:19:58.245+0900 D/AUL     (10132): app_sock.c: __app_send_raw_with_noreply(384) > pid(-2) : cmd(22)
06-04 08:19:58.245+0900 D/AUL_AMD ( 2753): amd_request.c: __request_handler(838) > __request_handler: 22
06-04 08:19:58.245+0900 W/AUL_AMD ( 2753): amd_request.c: __request_handler(1056) > app status : 5
06-04 08:19:58.245+0900 D/AUL_AMD ( 2753): amd_status.c: _status_update_app_info_list(456) > pid(10132) status(5)
06-04 08:19:58.245+0900 D/AUL_AMD ( 2753): amd_status.c: _status_update_app_info_list(468) > pid(10132) appid(org.example.example) pkgid(org.example.example) status(5)
06-04 08:19:58.245+0900 D/APP_CORE(10132): appcore.c: _appcore_fini_suspend_dbus_handler(944) > [__SUSPEND__] suspend signal finalized
06-04 08:19:58.245+0900 D/APP_CORE(10132): appcore-efl.c: __after_loop(1169) > [APP 10132] PAUSE before termination
06-04 08:19:58.245+0900 I/CAPI_APPFW_APPLICATION(10132): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
06-04 08:19:58.245+0900 I/CAPI_APPFW_APPLICATION(10132): app_main.c: _ui_app_appcore_terminate(662) > app_appcore_terminate
06-04 08:19:58.245+0900 E/EFL     (10132): eo<10132> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0x8001a0d1 is not pointing to a valid object. Maybe it has already been freed.
06-04 08:19:58.245+0900 E/EFL     (10132): eo<10132> lib/eo/eo.c:485 _eo_do_internal() Obj (0x8001a0d1) is an invalid ref.
06-04 08:19:58.245+0900 E/EFL     ( 2783): eo<2783> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-04 08:19:58.255+0900 D/AUL_AMD ( 2753): amd_launch.c: __e17_status_handler(2891) > pid(2867) status(3)
06-04 08:19:58.255+0900 D/AUL_AMD ( 2753): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
06-04 08:19:58.255+0900 W/AUL_AMD ( 2753): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-04 08:19:58.255+0900 W/AUL_AMD ( 2753): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
06-04 08:19:58.255+0900 D/AUL_AMD ( 2753): amd_status.c: _status_update_app_info_list(456) > pid(2867) status(3)
06-04 08:19:58.255+0900 D/AUL_AMD ( 2753): amd_status.c: _status_update_app_info_list(468) > pid(2867) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(3)
06-04 08:19:58.255+0900 D/AUL     ( 2753): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.tizen.homescreen
06-04 08:19:58.255+0900 W/AUL     ( 2753): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2867, appid: org.tizen.homescreen, status: fg
06-04 08:19:58.255+0900 D/RESOURCED( 2854): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 2867
06-04 08:19:58.255+0900 D/RESOURCED( 2854): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 2867, appname = org.tizen.homescreen, pkgname = org.tizen.homescreen
06-04 08:19:58.255+0900 D/RESOURCED( 2854): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 2867, appname = org.tizen.homescreen
06-04 08:19:58.255+0900 D/RESOURCED( 2854): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 2867
06-04 08:19:58.275+0900 E/E17     ( 2783): e_border.c: e_border_show(2088) > BD_SHOW(0x01600002)
06-04 08:19:58.275+0900 E/E17     ( 2783): e_border.c: e_border_hide(2248) > BD_HIDE(0x01200002), visible:1
06-04 08:19:58.275+0900 D/INDICATOR( 2856): main.c: _property_changed_cb(432) > UNSNIFF API 1200002
06-04 08:19:58.275+0900 D/INDICATOR( 2856): util.c: util_signal_emit_by_win(116) > emission bg.translucent
06-04 08:19:58.275+0900 D/INDICATOR( 2856): main.c: _rotate_window(229) > Indicator angle is 0 degree
06-04 08:19:58.275+0900 D/INDICATOR( 2856): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
06-04 08:19:58.275+0900 D/INDICATOR( 2856): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
06-04 08:19:58.275+0900 D/INDICATOR( 2856): main.c: _rotate_window(252) > port :: hide more icon
06-04 08:19:58.345+0900 D/AUL     (10338): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(14)
06-04 08:19:58.345+0900 D/AUL_AMD ( 2753): amd_request.c: __request_handler(838) > __request_handler: 14
06-04 08:19:58.345+0900 D/AUL_AMD ( 2753): amd_status.c: _status_app_is_running_from_cache(836) > is_running hit cache, return immediately
06-04 08:19:58.345+0900 D/AUL_AMD ( 2753): amd_request.c: __request_handler(1028) > [SECURE_LOG] APP_IS_RUNNING : org.example.example : 10132
06-04 08:19:58.345+0900 D/AUL_AMD ( 2753): amd_request.c: __request_handler(1030) > [SECURE_LOG] APP_IS_RUNNING: 10132 is dying
06-04 08:19:58.345+0900 W/AUL_AMD ( 2753): amd_request.c: __send_result_to_client(150) > __send_result_to_client, pid: -1
06-04 08:19:58.345+0900 D/PKGMGR_SERVER(10338): pkgmgr-server.c: __make_pid_info_file(1384) > cano_path(tmp/org.example.example)
06-04 08:19:58.345+0900 D/PKGMGR_SERVER(10338): pkgmgr-server.c: __make_pid_info_file(1403) > security_server_label_access(tmp/org.example.example, *) is ok.
06-04 08:19:58.355+0900 D/PKGMGR_SERVER(10335): pkgmgr-server.c: sighandler(387) > child exit [10338]
06-04 08:19:58.355+0900 E/PKGMGR_SERVER(10335): pkgmgr-server.c: sighandler(402) > child NORMAL exit [10338]
06-04 08:19:58.565+0900 W/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=2867
06-04 08:19:58.575+0900 W/CRASH_MANAGER(10340): worker.c: worker_job(1204) > 1110132657861149653199
