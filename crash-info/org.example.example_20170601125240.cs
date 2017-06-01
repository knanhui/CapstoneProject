S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 6064
Date: 2017-06-01 12:52:40+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x14

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb966b200, esi = 0x8001a8d5
ebp = 0xbfaca4d8, esp = 0xbfaca4a0
eax = 0x00000000, ebx = 0xb73365f0
ecx = 0x00000393, edx = 0x00000015
eip = 0xb718dbbf

Memory Information
MemTotal:      123 KB
MemFree:        32 KB
Buffers:         5 KB
Cached:     165576 KB
VmPeak:     100304 KB
VmSize:     100304 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       22092 KB
VmRSS:       22092 KB
VmData:      32752 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34456 KB
VmPTE:          80 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 6064 TID = 6064
6064 6069 6260 6261 

Maps Information
b2b99000 b2ba3000 r-xp /usr/lib/libfeedback.so.0.1.4
b2ba9000 b2bb5000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2bb6000 b2bd7000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2bdc000 b2bdd000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2bde000 b2be3000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2be4000 b2be5000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2be6000 b2be8000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2be9000 b2bf5000 r-xp /usr/lib/libdrm.so.2.4.0
b2bf6000 b2bf9000 r-xp /usr/lib/libdri2.so.0.0.0
b2bfa000 b2c04000 r-xp /usr/lib/libtbm.so.1.0.0
b2c05000 b2c1a000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2c1b000 b2c2d000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b342f000 b3460000 r-xp /usr/lib/libidn.so.11.5.44
b3461000 b3483000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3484000 b3494000 r-xp /usr/lib/libcares.so.2.1.0
b3495000 b349e000 r-xp /usr/lib/libeventsystem.so.0.0.1
b349f000 b34a8000 r-xp /usr/lib/libefl-extension.so.0.1.0
b34a9000 b3520000 r-xp /usr/lib/libcurl.so.4.3.0
b3522000 b3534000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b3535000 b3556000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b355d000 b355e000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b355f000 b3560000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b3561000 b3564000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b3565000 b3568000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3670000 b3676000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3677000 b37bb000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b37cb000 b37cd000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b37ce000 b37cf000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b37d0000 b37da000 r-xp /opt/usr/apps/org.example.example/bin/example
b37dd000 b3816000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b4219000 b4224000 r-xp /lib/libnss_files-2.20-2014.11.so
b4226000 b4231000 r-xp /lib/libnss_nis-2.20-2014.11.so
b4233000 b424a000 r-xp /lib/libnsl-2.20-2014.11.so
b424e000 b4256000 r-xp /lib/libnss_compat-2.20-2014.11.so
b4258000 b427c000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b427d000 b427e000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b427f000 b4282000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4283000 b428a000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b428b000 b4295000 r-xp /usr/lib/libsensord-share.so
b4296000 b42b2000 r-xp /usr/lib/libsensor.so.1.2.0
b42b4000 b42bd000 r-xp /usr/lib/libappcore-common.so.1.1
b42c0000 b42c2000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b42d7000 b42d9000 r-xp /usr/lib/libXau.so.6.0.0
b42da000 b42fc000 r-xp /usr/lib/libxcb.so.1.1.0
b42fe000 b4307000 r-xp /lib/libcrypt-2.20-2014.11.so
b4330000 b4332000 r-xp /usr/lib/libiri.so
b4333000 b4359000 r-xp /lib/libexpat.so.1.5.2
b435b000 b43c6000 r-xp /usr/lib/libssl.so.1.0.0
b43cc000 b43d8000 r-xp /usr/lib/libethumb.so.1.13.0
b43d9000 b43dd000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b43de000 b462f000 r-xp /usr/lib/libcrypto.so.1.0.0
b5baa000 b5bba000 r-xp /usr/lib/libXi.so.6.1.0
b5bbb000 b5bbd000 r-xp /usr/lib/libXgesture.so.7.0.0
b5bbe000 b5bc4000 r-xp /usr/lib/libXtst.so.6.1.0
b5bc5000 b5bcf000 r-xp /usr/lib/libXrender.so.1.3.0
b5bd0000 b5bd9000 r-xp /usr/lib/libXrandr.so.2.2.0
b5bdb000 b5bdd000 r-xp /usr/lib/libXinerama.so.1.0.0
b5bde000 b5be3000 r-xp /usr/lib/libXfixes.so.3.1.0
b5be4000 b5bf6000 r-xp /usr/lib/libXext.so.6.4.0
b5bf7000 b5bf9000 r-xp /usr/lib/libXdamage.so.1.1.0
b5bfa000 b5bfc000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5bfe000 b5d40000 r-xp /usr/lib/libX11.so.6.3.0
b5d44000 b5d4e000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d4f000 b5d65000 r-xp /usr/lib/libudev.so.1.6.0
b5d68000 b5d6c000 r-xp /lib/libattr.so.1.1.0
b5d6d000 b5d9c000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d9e000 b5da4000 r-xp /usr/lib/libffi.so.6.0.2
b5da5000 b5dc8000 r-xp /lib/libz.so.1.2.8
b5dc9000 b5dcc000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5dcd000 b5f29000 r-xp /usr/lib/libxml2.so.2.9.2
b5f2f000 b6016000 r-xp /usr/lib/libstdc++.so.6.0.20
b6023000 b6026000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6027000 b6049000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b604a000 b605e000 r-xp /lib/libresolv-2.20-2014.11.so
b6062000 b6086000 r-xp /usr/lib/liblzma.so.5.0.3
b6087000 b6089000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b608b000 b6095000 r-xp /usr/lib/libembryo.so.1.13.0
b6096000 b60bf000 r-xp /usr/lib/libpng12.so.0.50.0
b60c0000 b6109000 r-xp /usr/lib/libjpeg.so.8.0.2
b611a000 b6121000 r-xp /lib/librt-2.20-2014.11.so
b6123000 b6142000 r-xp /usr/lib/libector.so.1.13.0
b6145000 b6172000 r-xp /usr/lib/liblua-5.1.so
b6173000 b6203000 r-xp /usr/lib/libfreetype.so.6.11.3
b6207000 b6245000 r-xp /usr/lib/libfontconfig.so.1.8.0
b6246000 b625c000 r-xp /usr/lib/libfribidi.so.0.3.1
b625d000 b62b6000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b62b9000 b6304000 r-xp /lib/libm-2.20-2014.11.so
b6306000 b6318000 r-xp /usr/lib/libeio.so.1.13.0
b6319000 b631c000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b631d000 b6323000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b6324000 b6347000 r-xp /usr/lib/libefreet.so.1.13.0
b634a000 b6375000 r-xp /usr/lib/libeldbus.so.1.13.0
b6376000 b63aa000 r-xp /usr/lib/libecore_con.so.1.13.0
b63ac000 b63b5000 r-xp /usr/lib/libecore_imf.so.1.13.0
b63b6000 b63bf000 r-xp /usr/lib/libethumb_client.so.1.13.0
b63c0000 b63d3000 r-xp /usr/lib/libeo.so.1.13.0
b63d5000 b63e8000 r-xp /usr/lib/libecore_input.so.1.13.0
b63e9000 b63f0000 r-xp /usr/lib/libecore_file.so.1.13.0
b63f1000 b6414000 r-xp /usr/lib/libecore_evas.so.1.13.0
b6415000 b6441000 r-xp /usr/lib/libeet.so.1.13.0
b644a000 b64b5000 r-xp /usr/lib/libeina.so.1.13.0
b64b8000 b64cf000 r-xp /usr/lib/libefl.so.1.13.0
b64d1000 b6638000 r-xp /usr/lib/libicuuc.so.51.1
b6646000 b6852000 r-xp /usr/lib/libicui18n.so.51.1
b685a000 b68a9000 r-xp /usr/lib/libecore_x.so.1.13.0
b68ab000 b68c5000 r-xp /lib/libgcc_s-4.9.so.1
b68c7000 b68cb000 r-xp /lib/libcap.so.2.21
b68cc000 b6912000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6913000 b691a000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b691c000 b696e000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b6970000 b6afb000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6b00000 b6bce000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6bd1000 b6bd5000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6bd6000 b6be5000 r-xp /usr/lib/libvconf.so.0.2.45
b6be6000 b6be9000 r-xp /usr/lib/libvasum.so.0.3.1
b6bea000 b6bed000 r-xp /usr/lib/libttrace.so.1.1
b6bef000 b6bf3000 r-xp /usr/lib/libiniparser.so.0
b6bf4000 b6c24000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6c25000 b6c2e000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c2f000 b6c54000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c55000 b6c65000 r-xp /usr/lib/libunwind.so.8.0.1
b6c6f000 b6e1d000 r-xp /lib/libc-2.20-2014.11.so
b6e25000 b6f68000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f6a000 b6fc2000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6fc3000 b6ff7000 r-xp /usr/lib/libsystemd.so.0.4.0
b6ffa000 b70ce000 r-xp /usr/lib/libedje.so.1.13.0
b70d1000 b70fd000 r-xp /usr/lib/libecore.so.1.13.0
b710e000 b7334000 r-xp /usr/lib/libevas.so.1.13.0
b735c000 b7374000 r-xp /lib/libpthread-2.20-2014.11.so
b7378000 b76f2000 r-xp /usr/lib/libelementary.so.1.13.0
b7712000 b7716000 r-xp /usr/lib/libsmack.so.1.0.0
b7717000 b7720000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7721000 b7724000 r-xp /usr/lib/libdlog.so.0.0.0
b7725000 b772a000 r-xp /usr/lib/libbundle.so.0.1.22
b772b000 b772e000 r-xp /lib/libdl-2.20-2014.11.so
b7730000 b7755000 r-xp /usr/lib/libaul.so.0.1.0
b7758000 b775a000 r-xp /usr/lib/libappsvc.so.0.1.0
b775b000 b7760000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b7761000 b7768000 r-xp /usr/lib/libappcore-efl.so.1.1
b776a000 b776f000 r-xp /usr/lib/libsys-assert.so
b7772000 b7773000 r-xp [vdso]
b7773000 b7795000 r-xp /lib/ld-2.20-2014.11.so
b7797000 b779f000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:6064)
Call Stack Count: 41
 0: (0xb718dbbf) [/usr/lib/libevas.so.1] + 0x7fbbf
 1: (0xb717fce8) [/usr/lib/libevas.so.1] + 0x71ce8
 2: evas_obj_size_hint_min_set + 0xb9 (0xb717a629) [/usr/lib/libevas.so.1] + 0x6c629
 3: evas_object_size_hint_min_set + 0x60 (0xb7187fa0) [/usr/lib/libevas.so.1] + 0x79fa0
 4: (0xb758bd29) [/usr/lib/libelementary.so.1] + 0x213d29
 5: elm_obj_layout_sizing_eval + 0x99 (0xb7523559) [/usr/lib/libelementary.so.1] + 0x1ab559
 6: (0xb752a205) [/usr/lib/libelementary.so.1] + 0x1b2205
 7: evas_obj_smart_add + 0x99 (0xb7198809) [/usr/lib/libevas.so.1] + 0x8a809
 8: (0xb751c79a) [/usr/lib/libelementary.so.1] + 0x1a479a
 9: evas_obj_smart_add + 0x99 (0xb7198809) [/usr/lib/libevas.so.1] + 0x8a809
10: (0xb759027b) [/usr/lib/libelementary.so.1] + 0x21827b
11: evas_obj_smart_add + 0x99 (0xb7198809) [/usr/lib/libevas.so.1] + 0x8a809
12: (0xb719bd8b) [/usr/lib/libevas.so.1] + 0x8dd8b
13: eo_constructor + 0x99 (0xb63ca899) [/usr/lib/libeo.so.1] + 0xa899
14: (0xb75e94a6) [/usr/lib/libelementary.so.1] + 0x2714a6
15: eo_constructor + 0x99 (0xb63ca899) [/usr/lib/libeo.so.1] + 0xa899
16: (0xb752bc37) [/usr/lib/libelementary.so.1] + 0x1b3c37
17: eo_constructor + 0x99 (0xb63ca899) [/usr/lib/libeo.so.1] + 0xa899
18: (0xb751c879) [/usr/lib/libelementary.so.1] + 0x1a4879
19: eo_constructor + 0x99 (0xb63ca899) [/usr/lib/libeo.so.1] + 0xa899
20: (0xb75907c2) [/usr/lib/libelementary.so.1] + 0x2187c2
21: eo_constructor + 0x99 (0xb63ca899) [/usr/lib/libeo.so.1] + 0xa899
22: elm_scroller_add + 0x77 (0xb758edb7) [/usr/lib/libelementary.so.1] + 0x216db7
23: setting_view_cb + 0x45 (0xb37d8505) [/opt/usr/apps/org.example.example/bin/example] + 0x8505
24: (0xb7142449) [/usr/lib/libevas.so.1] + 0x34449
25: (0xb63ce319) [/usr/lib/libeo.so.1] + 0xe319
26: eo_event_callback_call + 0xb3 (0xb63cbd63) [/usr/lib/libeo.so.1] + 0xbd63
27: (0xb7142a62) [/usr/lib/libevas.so.1] + 0x34a62
28: (0xb7151441) [/usr/lib/libevas.so.1] + 0x43441
29: evas_canvas_event_feed_mouse_down + 0xcf (0xb715b20f) [/usr/lib/libevas.so.1] + 0x4d20f
30: evas_event_feed_mouse_down + 0x6a (0xb7161c2a) [/usr/lib/libevas.so.1] + 0x53c2a
31: (0xb43db49c) [/usr/lib/libecore_input_evas.so.1] + 0x249c
32: (0xb70de055) [/usr/lib/libecore.so.1] + 0xd055
33: (0xb70e71b9) [/usr/lib/libecore.so.1] + 0x161b9
34: ecore_main_loop_begin + 0x57 (0xb70e7587) [/usr/lib/libecore.so.1] + 0x16587
35: elm_run + 0x2d (0xb754022d) [/usr/lib/libelementary.so.1] + 0x1c822d
36: appcore_efl_main + 0x4de (0xb7764dde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
37: ui_app_main + 0x140 (0xb775dc80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
38: main + 0x2a5 (0xb37d7605) [/opt/usr/apps/org.example.example/bin/example] + 0x7605
39: (0xb7799148) [/opt/usr/apps/org.example.example/bin/example] + 0xb7799148
40: __libc_start_main + 0xde (0xb6c86e4e) [/lib/libc.so.6] + 0x17e4e
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
[2, 1]
06-01 12:52:37.068+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[2], [2, 1]
06-01 12:52:37.068+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 12:52:37.068+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.calendar] Name[calendar] Icon[/opt/usr/apps/org.example.calendar/shared/res/calendar.png] enable[1] system[0]
06-01 12:52:37.068+0900 D/BADGE   ( 2945): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.calendar'], count[0]
06-01 12:52:37.068+0900 E/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.example.calendar][-17956860][0]
06-01 12:52:37.068+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.example.calendar]
06-01 12:52:37.068+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[calendar] pos[3, 1] pageId[100001]
06-01 12:52:37.068+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[16]
06-01 12:52:37.068+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[3], [3, 1]
06-01 12:52:37.068+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[3], [3, 1]
06-01 12:52:37.068+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 12:52:37.068+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.camera-app] Name[Camera] Icon[/usr/share/icons/default/small/org.tizen.camera-app.png] enable[1] system[1]
06-01 12:52:37.068+0900 D/BADGE   ( 2945): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.camera-app'], count[0]
06-01 12:52:37.068+0900 E/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.camera-app][-17956860][0]
06-01 12:52:37.068+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.camera-app]
06-01 12:52:37.068+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Camera] pos[4, 1] pageId[100001]
06-01 12:52:37.068+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[3]
06-01 12:52:37.068+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[4], [4, 1]
06-01 12:52:37.068+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[4], [4, 1]
06-01 12:52:37.068+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 12:52:37.068+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.contacts] Name[Contacts] Icon[/usr/share/icons/default/small/org.tizen.contacts.png] enable[1] system[1]
06-01 12:52:37.068+0900 D/BADGE   ( 2945): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.contacts'], count[0]
06-01 12:52:37.068+0900 E/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.contacts][-17956860][0]
06-01 12:52:37.068+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.contacts]
06-01 12:52:37.068+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Contacts] pos[1, 2] pageId[100001]
06-01 12:52:37.068+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[4]
06-01 12:52:37.068+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[5], [1, 2]
06-01 12:52:37.068+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[5], [1, 2]
06-01 12:52:37.068+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 12:52:37.068+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.email] Name[Email] Icon[/usr/apps/org.tizen.email/shared/res/org.tizen.email.png] enable[1] system[1]
06-01 12:52:37.068+0900 D/BADGE   ( 2945): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.email'], count[1]
06-01 12:52:37.068+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.email]
06-01 12:52:37.068+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Email] pos[2, 2] pageId[100001]
06-01 12:52:37.068+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[5]
06-01 12:52:37.068+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[6], [2, 2]
06-01 12:52:37.068+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[6], [2, 2]
06-01 12:52:37.068+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 12:52:37.068+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.example] Name[forpet] Icon[/opt/usr/apps/org.example.example/shared/res/1.jpg] enable[1] system[0]
06-01 12:52:37.068+0900 D/BADGE   ( 2945): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.example'], count[0]
06-01 12:52:37.068+0900 E/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.example.example][-17956860][0]
06-01 12:52:37.068+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.example.example]
06-01 12:52:37.068+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[forpet] pos[3, 2] pageId[100001]
06-01 12:52:37.068+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[0]
06-01 12:52:37.068+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(787) >  AddBoxToMenuView
06-01 12:52:37.068+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: AddBoxToMenuView(347) >  AddBox Name[forpet] pageid[100001] pos[3, 2]
06-01 12:52:37.068+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: AddBoxToMenuView(354) >  menuPage.GetPageId() = 100001, boxPageId = 100001
06-01 12:52:37.068+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: AddBoxToPage(112) >  void ClusterHome3D::Internal::CMainMenuPage::AddBoxToPage(std::shared_ptr<CMainMenuBoxData>) : 112
06-01 12:52:37.068+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: AddBoxToPage(122) >  void ClusterHome3D::Internal::CMainMenuPage::AddBoxToPage(std::shared_ptr<CMainMenuBoxData>) : 122
06-01 12:52:37.068+0900 D/test-log( 2945): mainmenu-page-impl.cpp: AddBoxToPage(123) >  create box[org.example.example] [3,2]
06-01 12:52:37.068+0900 D/test-log( 2945): mainmenu-box-impl.cpp: CMainMenuBox(148) >  create box
06-01 12:52:37.068+0900 D/test-log( 2945): mainmenu-box-impl.cpp: SetPosition(459) >  cut Animation : forpet
06-01 12:52:37.068+0900 D/test-log( 2945): mainmenu-page-impl.cpp: AddBoxToPage(177) >  add created box
06-01 12:52:37.068+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.gallery] Name[Gallery] Icon[/usr/share/icons/default/small/org.tizen.gallery.png] enable[1] system[1]
06-01 12:52:37.068+0900 D/BADGE   ( 2945): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.gallery'], count[0]
06-01 12:52:37.068+0900 E/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.gallery][-17956860][0]
06-01 12:52:37.068+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.gallery]
06-01 12:52:37.068+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Gallery] pos[4, 2] pageId[100001]
06-01 12:52:37.068+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[6]
06-01 12:52:37.068+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[8], [4, 2]
06-01 12:52:37.068+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[7], [3, 2]
06-01 12:52:37.068+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 12:52:37.068+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.imageutil] Name[imageutil] Icon[/opt/usr/apps/org.example.imageutil/shared/res/imageutil.png] enable[1] system[0]
06-01 12:52:37.068+0900 D/BADGE   ( 2945): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.imageutil'], count[0]
06-01 12:52:37.068+0900 E/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.example.imageutil][-17956860][0]
06-01 12:52:37.068+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.example.imageutil]
06-01 12:52:37.068+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[imageutil] pos[1, 3] pageId[100001]
06-01 12:52:37.068+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[15]
06-01 12:52:37.068+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[9], [1, 3]
06-01 12:52:37.068+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 12:52:37.068+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 12:52:37.068+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.browser] Name[Internet] Icon[/usr/share/icons/default/small/org.tizen.browser.png] enable[1] system[1]
06-01 12:52:37.068+0900 D/BADGE   ( 2945): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.browser'], count[0]
06-01 12:52:37.068+0900 E/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.browser][-17956860][0]
06-01 12:52:37.068+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.browser]
06-01 12:52:37.068+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Internet] pos[2, 3] pageId[100001]
06-01 12:52:37.068+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[1]
06-01 12:52:37.068+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[10], [2, 3]
06-01 12:52:37.068+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 12:52:37.068+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 12:52:37.068+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.message] Name[Messages] Icon[/usr/share/icons/default/small/org.tizen.message.png] enable[1] system[1]
06-01 12:52:37.068+0900 D/BADGE   ( 2945): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.message'], count[1]
06-01 12:52:37.068+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.message]
06-01 12:52:37.068+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Messages] pos[3, 3] pageId[100001]
06-01 12:52:37.068+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[7]
06-01 12:52:37.068+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[11], [3, 3]
06-01 12:52:37.068+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 12:52:37.068+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 12:52:37.068+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.music-player] Name[Music] Icon[/usr/share/icons/default/small/org.tizen.music-player.png] enable[1] system[1]
06-01 12:52:37.148+0900 D/BADGE   ( 2945): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.music-player'], count[0]
06-01 12:52:37.148+0900 E/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.music-player][-17956860][0]
06-01 12:52:37.148+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.music-player]
06-01 12:52:37.148+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Music] pos[4, 3] pageId[100001]
06-01 12:52:37.148+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[8]
06-01 12:52:37.148+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[12], [4, 3]
06-01 12:52:37.148+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 12:52:37.148+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 12:52:37.148+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.myfile] Name[My Files] Icon[/usr/share/icons/default/small/org.tizen.myfile.png] enable[1] system[1]
06-01 12:52:37.148+0900 D/BADGE   ( 2945): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.myfile'], count[0]
06-01 12:52:37.148+0900 E/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.myfile][-17956860][0]
06-01 12:52:37.148+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.myfile]
06-01 12:52:37.148+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[My Files] pos[1, 4] pageId[100001]
06-01 12:52:37.148+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[9]
06-01 12:52:37.148+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[13], [1, 4]
06-01 12:52:37.148+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 12:52:37.148+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 12:52:37.148+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.phone] Name[Phone] Icon[/usr/share/icons/default/small/org.tizen.phone.png] enable[1] system[1]
06-01 12:52:37.148+0900 D/BADGE   ( 2945): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.phone'], count[0]
06-01 12:52:37.148+0900 E/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.phone][-17956860][0]
06-01 12:52:37.148+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.phone]
06-01 12:52:37.148+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Phone] pos[2, 4] pageId[100001]
06-01 12:52:37.148+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[10]
06-01 12:52:37.148+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[14], [2, 4]
06-01 12:52:37.148+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 12:52:37.148+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 12:52:37.148+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.setting] Name[Settings] Icon[/usr/share/icons/default/small/org.tizen.setting.png] enable[1] system[1]
06-01 12:52:37.148+0900 D/BADGE   ( 2945): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.setting'], count[0]
06-01 12:52:37.148+0900 E/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.setting][-17956860][0]
06-01 12:52:37.148+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.setting]
06-01 12:52:37.148+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Settings] pos[3, 4] pageId[100001]
06-01 12:52:37.148+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[11]
06-01 12:52:37.148+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[15], [3, 4]
06-01 12:52:37.148+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 12:52:37.148+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 12:52:37.148+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.videos] Name[Video] Icon[/usr/share/icons/default/small/org.tizen.videos.png] enable[1] system[1]
06-01 12:52:37.148+0900 D/BADGE   ( 2945): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.videos'], count[0]
06-01 12:52:37.148+0900 E/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.videos][-17956860][0]
06-01 12:52:37.148+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.videos]
06-01 12:52:37.148+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Video] pos[4, 4] pageId[100001]
06-01 12:52:37.148+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[12]
06-01 12:52:37.148+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[16], [4, 4]
06-01 12:52:37.148+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 12:52:37.148+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 12:52:37.148+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: RearrangeItems(243) >  view type [1]
06-01 12:52:37.388+0900 D/rpm-installer( 6201): rpm-installer-privilege.c: __ri_privilege_perm_end(55) > [smack] perm_end, result=[0]
06-01 12:52:37.388+0900 D/rpm-installer( 6201): rpm-appcore-intf.c: main(259) > ------------------------------------------------
06-01 12:52:37.388+0900 D/rpm-installer( 6201): rpm-appcore-intf.c: main(260) >  [END] rpm-installer: result=[0]
06-01 12:52:37.388+0900 D/rpm-installer( 6201): rpm-appcore-intf.c: main(261) > ------------------------------------------------
06-01 12:52:37.398+0900 D/PKGMGR_SERVER( 6187): pkgmgr-server.c: sighandler(387) > child exit [6201]
06-01 12:52:37.398+0900 E/PKGMGR_SERVER( 6187): pkgmgr-server.c: sighandler(402) > child NORMAL exit [6201]
06-01 12:52:37.998+0900 E/PKGMGR_SERVER( 6187): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-01 12:52:37.998+0900 E/PKGMGR_SERVER( 6187): pkgmgr-server.c: main(2265) > package manager server terminated.
06-01 12:52:38.448+0900 D/AUL_AMD ( 2858): amd_request.c: __request_handler(838) > __request_handler: 0
06-01 12:52:38.458+0900 D/AUL_AMD ( 2858): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.example
06-01 12:52:38.458+0900 D/PKGMGR_INFO( 2858): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-01 12:52:38.458+0900 D/PKGMGR_INFO( 2858): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-01 12:52:38.458+0900 I/AUL     ( 2858): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
06-01 12:52:38.458+0900 D/AUL     ( 2858): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 6254, pid = 6256
06-01 12:52:38.458+0900 D/PKGMGR_INFO( 2858): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-01 12:52:38.458+0900 D/PKGMGR_INFO( 2858): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-01 12:52:38.458+0900 I/AUL     ( 2858): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
06-01 12:52:38.458+0900 E/AUL_AMD ( 2858): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
06-01 12:52:38.458+0900 W/AUL_AMD ( 2858): amd_launch.c: _start_app(2233) > caller pid : 6256
06-01 12:52:38.458+0900 E/AUL_AMD ( 2858): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
06-01 12:52:38.458+0900 W/AUL_AMD ( 2858): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.example) pkgid(org.example.example) attribute(600)
06-01 12:52:38.458+0900 D/AUL_AMD ( 2858): amd_launch.c: _start_app(2648) > process_pool: false
06-01 12:52:38.458+0900 D/AUL_AMD ( 2858): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
06-01 12:52:38.458+0900 D/AUL_AMD ( 2858): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.example
06-01 12:52:38.458+0900 W/AUL_AMD ( 2858): amd_launch.c: _start_app(2665) > pad pid(-5)
06-01 12:52:38.458+0900 D/AUL_AMD ( 2858): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
06-01 12:52:38.458+0900 D/AUL_AMD ( 2858): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
06-01 12:52:38.458+0900 D/AUL     ( 2858): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
06-01 12:52:38.468+0900 D/AUL_PAD ( 3003): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
06-01 12:52:38.468+0900 D/RESOURCED( 2893): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
06-01 12:52:38.468+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
06-01 12:52:38.468+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-01 12:52:38.468+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-01 12:52:38.468+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-01 12:52:38.468+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-01 12:52:38.468+0900 D/RESOURCED( 2893): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 1
06-01 12:52:38.468+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-01 12:52:38.468+0900 D/AUL_PAD ( 3003): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
06-01 12:52:38.468+0900 D/AUL_PAD ( 3003): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
06-01 12:52:38.468+0900 D/AUL_PAD ( 3003): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
06-01 12:52:38.468+0900 D/AUL_PAD ( 3003): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
06-01 12:52:38.468+0900 D/AUL_PAD ( 3003): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
06-01 12:52:38.468+0900 D/AUL_PAD ( 3003): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
06-01 12:52:38.468+0900 D/AUL_PAD ( 3003): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
06-01 12:52:38.468+0900 W/AUL_PAD ( 3003): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
06-01 12:52:38.468+0900 D/AUL     ( 3003): process_pool.c: __send_pkt_raw_data(219) > send(11) : 620 / 620
06-01 12:52:38.468+0900 D/AUL_PAD ( 3003): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 6064, bin path: /opt/usr/apps/org.example.example/bin/example
06-01 12:52:38.468+0900 W/AUL_PAD ( 3003): launchpad.c: __send_result_to_caller(265) > Check app launching
06-01 12:52:38.468+0900 D/AUL_PAD ( 3003): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
06-01 12:52:38.468+0900 E/RESOURCED( 2893): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-01 12:52:38.468+0900 D/AUL_PAD ( 6064): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
06-01 12:52:38.468+0900 D/AUL_PAD ( 6064): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 620, pkt->len: 612
06-01 12:52:38.468+0900 D/AUL_PAD ( 6064): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
06-01 12:52:38.468+0900 D/AUL_PAD ( 6064): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
06-01 12:52:38.468+0900 D/AUL_PAD ( 6064): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
06-01 12:52:38.468+0900 D/AUL_PAD ( 6064): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
06-01 12:52:38.468+0900 D/AUL     ( 6064): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (6069) is sent.
06-01 12:52:38.468+0900 D/AUL     ( 6064): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 6069, signo: 10
06-01 12:52:38.468+0900 D/AUL     ( 6064): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
06-01 12:52:38.468+0900 D/AUL_PAD ( 6064): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
06-01 12:52:38.468+0900 D/AUL_PAD ( 6064): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
06-01 12:52:38.468+0900 D/AUL_PAD ( 6064): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
06-01 12:52:38.468+0900 D/AUL_PAD ( 6064): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
06-01 12:52:38.468+0900 D/AUL_PAD ( 6064): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0OTYyODkxNTgvNDU3NTQ3AA==##
06-01 12:52:38.468+0900 D/AUL_PAD ( 6064): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
06-01 12:52:38.468+0900 D/AUL_PAD ( 6064): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAA2MjU2AA==##
06-01 12:52:38.468+0900 D/AUL_PAD ( 6064): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
06-01 12:52:38.468+0900 D/AUL_PAD ( 6064): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
06-01 12:52:38.468+0900 D/AUL_PAD ( 6064): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 8
06-01 12:52:38.468+0900 D/AUL_PAD ( 6064): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
06-01 12:52:38.468+0900 D/AUL_PAD ( 6064): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
06-01 12:52:38.468+0900 I/CAPI_APPFW_APPLICATION( 6064): app_main.c: ui_app_main(788) > app_efl_main
06-01 12:52:38.468+0900 D/LAUNCH  ( 6064): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
06-01 12:52:38.468+0900 D/APP_CORE( 6064): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
06-01 12:52:38.468+0900 D/APP_CORE( 6064): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
06-01 12:52:38.468+0900 D/APP_CORE( 6064): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
06-01 12:52:38.488+0900 D/APP_CORE( 6064): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
06-01 12:52:38.488+0900 D/AUL     ( 6064): app_sock.c: __create_server_sock(156) > pg path - already exists
06-01 12:52:38.488+0900 D/APP_CORE( 6064): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb42bd520
06-01 12:52:38.488+0900 D/LAUNCH  ( 6064): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
06-01 12:52:38.488+0900 I/CAPI_APPFW_APPLICATION( 6064): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
06-01 12:52:38.568+0900 D/AUL_PAD ( 3003): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
06-01 12:52:38.568+0900 W/AUL     ( 2858): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 6064, appid: org.example.example
06-01 12:52:38.568+0900 D/AUL     ( 2858): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
06-01 12:52:38.568+0900 E/AUL     ( 2858): simple_util.c: __trm_app_info_send_socket(330) > access
06-01 12:52:38.568+0900 D/AUL_AMD ( 2858): amd_launch.c: _start_app(2700) > add app group info
06-01 12:52:38.568+0900 E/AUL     ( 2858): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
06-01 12:52:38.568+0900 D/AUL_AMD ( 2858): amd_status.c: _status_add_app_info_list(427) > pid(6064) appid(org.example.example) pkgid(org.example.example) comp(uiapp)
06-01 12:52:38.568+0900 D/RESOURCED( 2893): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.example, 6064
06-01 12:52:38.568+0900 D/RESOURCED( 2893): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.example with pkgname
06-01 12:52:38.568+0900 E/RESOURCED( 2893): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.example
06-01 12:52:38.568+0900 D/RESOURCED( 2893): proc-main.c: resourced_proc_status_change(888) > available memory = 320
06-01 12:52:38.598+0900 D/LAUNCH  ( 6064): appcore-efl.c: __before_loop(1154) > [example:Application:create:done]
06-01 12:52:38.598+0900 D/APP_CORE( 6064): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
06-01 12:52:38.598+0900 E/E17     ( 2741): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x01e00002)
06-01 12:52:38.638+0900 E/E17     ( 2741): e_border.c: e_border_show(2088) > BD_SHOW(0x01e00002)
06-01 12:52:38.658+0900 D/APP_CORE( 6064): appcore.c: __aul_handler(587) > [APP 6064]     AUL event: AUL_START
06-01 12:52:38.658+0900 I/APP_CORE( 6064): appcore-efl.c: __do_app(496) > [APP 6064] Event: RESET State: CREATED
06-01 12:52:38.658+0900 D/APP_CORE( 6064): appcore-efl.c: __do_app(527) > [APP 6064] RESET
06-01 12:52:38.658+0900 D/LAUNCH  ( 6064): appcore-efl.c: __do_app(529) > [example:Application:reset:start]
06-01 12:52:38.658+0900 D/APP_CORE( 6064): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
06-01 12:52:38.658+0900 D/APP_CORE( 6064): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-01 12:52:38.658+0900 I/CAPI_APPFW_APPLICATION( 6064): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
06-01 12:52:38.658+0900 D/AUL     ( 6064): service.c: __set_bundle(186) > __set_bundle
06-01 12:52:38.658+0900 D/LAUNCH  ( 6064): appcore-efl.c: __do_app(544) > [example:Application:reset:done]
06-01 12:52:38.658+0900 D/APP_CORE( 6064): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
06-01 12:52:38.658+0900 E/EFL     ( 6064): edje<6064> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 12:52:38.658+0900 E/EFL     ( 6064): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 12:52:38.658+0900 E/EFL     ( 6064): edje<6064> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 12:52:38.658+0900 E/EFL     ( 6064): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 12:52:38.658+0900 E/EFL     ( 6064): edje<6064> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 12:52:38.658+0900 E/EFL     ( 6064): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 12:52:38.658+0900 E/EFL     ( 6064): edje<6064> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 12:52:38.658+0900 E/EFL     ( 6064): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 12:52:38.658+0900 E/EFL     ( 6064): edje<6064> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 12:52:38.658+0900 E/EFL     ( 6064): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 12:52:38.688+0900 W/APP_CORE( 6064): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1e00002
06-01 12:52:38.688+0900 W/PROCESSMGR( 2741): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=6064
06-01 12:52:38.688+0900 D/APP_CORE( 6064): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:1e00002
06-01 12:52:38.688+0900 D/APP_CORE( 6064): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
06-01 12:52:38.688+0900 D/AUL     ( 6064): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
06-01 12:52:38.688+0900 D/AUL_AMD ( 2858): amd_request.c: __request_handler(838) > __request_handler: 34
06-01 12:52:38.708+0900 E/EFL     ( 2741): eo<2741> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-01 12:52:38.708+0900 E/EFL     ( 2741): eo<2741> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-01 12:52:38.728+0900 D/INDICATOR( 2934): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
06-01 12:52:38.728+0900 D/AUL_AMD ( 2858): amd_request.c: __request_handler(838) > __request_handler: 15
06-01 12:52:38.728+0900 D/PKGMGR_INFO( 2858): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-01 12:52:38.728+0900 D/PKGMGR_INFO( 2858): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-01 12:52:38.728+0900 D/INDICATOR( 2934): util.c: util_signal_emit_by_win(116) > emission bg.opaque
06-01 12:52:38.728+0900 D/AUL_AMD ( 2858): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 6064 is org.example.example
06-01 12:52:38.728+0900 D/AUL_AMD ( 2858): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 6064 : 0
06-01 12:52:38.728+0900 D/INDICATOR( 2934): main.c: _rotate_window(229) > Indicator angle is 0 degree
06-01 12:52:38.728+0900 D/INDICATOR( 2934): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
06-01 12:52:38.728+0900 D/INDICATOR( 2934): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
06-01 12:52:38.728+0900 D/INDICATOR( 2934): main.c: _rotate_window(252) > port :: hide more icon
06-01 12:52:38.728+0900 D/AUL     ( 3022): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
06-01 12:52:38.988+0900 D/APP_CORE( 6064): appcore.c: __prt_ltime(236) > [APP 6064] first idle after reset: 540 msec
06-01 12:52:39.108+0900 E/E17     ( 2741): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
06-01 12:52:39.118+0900 D/APP_CORE( 6064): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1e00002 fully_obscured 0
06-01 12:52:39.118+0900 D/APP_CORE( 6064): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
06-01 12:52:39.118+0900 D/APP_CORE( 6064): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
06-01 12:52:39.118+0900 I/APP_CORE( 6064): appcore-efl.c: __do_app(496) > [APP 6064] Event: RESUME State: CREATED
06-01 12:52:39.118+0900 D/LAUNCH  ( 6064): appcore-efl.c: __do_app(597) > [example:Application:resume:start]
06-01 12:52:39.118+0900 D/APP_CORE( 6064): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
06-01 12:52:39.118+0900 D/APP_CORE( 6064): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-01 12:52:39.118+0900 D/APP_CORE( 6064): appcore-efl.c: __do_app(607) > [APP 6064] RESUME
06-01 12:52:39.118+0900 I/APP_CORE( 6064): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
06-01 12:52:39.118+0900 I/APP_CORE( 6064): appcore-efl.c: __do_app(614) > [APP 6064] Initial Launching, call the resume_cb
06-01 12:52:39.118+0900 I/CAPI_APPFW_APPLICATION( 6064): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
06-01 12:52:39.118+0900 D/LAUNCH  ( 6064): appcore-efl.c: __do_app(636) > [example:Application:resume:done]
06-01 12:52:39.118+0900 D/LAUNCH  ( 6064): appcore-efl.c: __do_app(638) > [example:Application:Launching:done]
06-01 12:52:39.118+0900 D/APP_CORE( 6064): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-01 12:52:39.118+0900 E/APP_CORE( 6064): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-01 12:52:39.118+0900 D/APP_CORE( 2945): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
06-01 12:52:39.118+0900 D/APP_CORE( 2945): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
06-01 12:52:39.118+0900 D/APP_CORE( 2945): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
06-01 12:52:39.118+0900 I/APP_CORE( 2945): appcore-efl.c: __do_app(496) > [APP 2945] Event: PAUSE State: RUNNING
06-01 12:52:39.118+0900 D/APP_CORE( 2945): appcore-efl.c: __do_app(565) > [APP 2945] PAUSE
06-01 12:52:39.118+0900 I/CAPI_APPFW_APPLICATION( 2945): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
06-01 12:52:39.118+0900 E/cluster-home( 2945): homescreen.cpp: OnPause(84) >  app pause
06-01 12:52:39.118+0900 D/cluster-view( 2945): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
06-01 12:52:39.118+0900 D/cluster-view( 2945): homescreen-view-manager.cpp: AppPause(923) >  END
06-01 12:52:39.128+0900 D/APP_CORE( 2945): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-01 12:52:39.128+0900 E/APP_CORE( 2945): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-01 12:52:39.128+0900 D/AUL_AMD ( 2858): amd_status.c: _status_update_app_info_list(456) > pid(2945) status(4)
06-01 12:52:39.128+0900 D/AUL_AMD ( 2858): amd_status.c: _status_update_app_info_list(468) > pid(2945) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
06-01 12:52:39.128+0900 D/AUL     ( 2858): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
06-01 12:52:39.128+0900 W/AUL     ( 2858): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2945, appid: org.tizen.homescreen, status: bg
06-01 12:52:39.128+0900 D/AUL_AMD ( 2858): amd_launch.c: __e17_status_handler(2891) > pid(6064) status(3)
06-01 12:52:39.128+0900 D/AUL_AMD ( 2858): amd_key.c: _key_ungrab(265) > _key_ungrab, win : c00002
06-01 12:52:39.128+0900 W/AUL_AMD ( 2858): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-01 12:52:39.128+0900 W/AUL_AMD ( 2858): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
06-01 12:52:39.128+0900 D/AUL_AMD ( 2858): amd_status.c: _status_update_app_info_list(456) > pid(6064) status(3)
06-01 12:52:39.128+0900 D/AUL_AMD ( 2858): amd_status.c: _status_update_app_info_list(468) > pid(6064) appid(org.example.example) pkgid(org.example.example) status(3)
06-01 12:52:39.128+0900 D/AUL     ( 2858): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.example
06-01 12:52:39.128+0900 W/AUL     ( 2858): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 6064, appid: org.example.example, status: fg
06-01 12:52:39.128+0900 D/RESOURCED( 2893): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 6064
06-01 12:52:39.128+0900 D/RESOURCED( 2893): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 6064, proc_name: org.example.example, cg_name: foreground, oom_score_adj: 200
06-01 12:52:39.128+0900 D/RESOURCED( 2893): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 6064
06-01 12:52:39.148+0900 D/DATA_PROVIDER_MASTER( 3009): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2945 is paused
06-01 12:52:39.148+0900 D/DATA_PROVIDER_MASTER( 3009): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
06-01 12:52:39.158+0900 I/CAPI_WIDGET_APPLICATION( 3084): widget_app.c: __provider_pause_cb(294) > widget obj was paused
06-01 12:52:39.158+0900 I/CAPI_WIDGET_APPLICATION( 3084): widget_app.c: __check_status_for_cgroup(142) > enter background group
06-01 12:52:39.158+0900 W/AUL     ( 3084): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3084, appid: org.tizen.calendar.widget, status: bg
06-01 12:52:39.188+0900 D/RESOURCED( 2893): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 6064, appname = org.example.example, pkgname = org.example.example
06-01 12:52:39.188+0900 D/RESOURCED( 2893): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 6064, appname = org.example.example
06-01 12:52:39.188+0900 D/RESOURCED( 2893): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 6064
06-01 12:52:39.188+0900 D/RESOURCED( 2893): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3084, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
06-01 12:52:39.188+0900 D/RESOURCED( 2893): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 3084
06-01 12:52:39.188+0900 D/RESOURCED( 2893): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 3084, appname = org.tizen.calendar.widget
06-01 12:52:39.188+0900 D/RESOURCED( 2893): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 3084
06-01 12:52:39.188+0900 I/RESOURCED( 2893): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
06-01 12:52:39.188+0900 I/RESOURCED( 2893): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
06-01 12:52:39.338+0900 D/AUL_AMD ( 2858): amd_launch.c: __e17_status_handler(2910) > pid(6064) status(0)
06-01 12:52:39.568+0900 D/AUL_PAD ( 3003): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
06-01 12:52:39.568+0900 D/AUL_PAD ( 6263): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
06-01 12:52:39.608+0900 D/AUL_PAD ( 3003): sigchild.h: __send_app_launch_signal(131) > send launch signal done
06-01 12:52:39.618+0900 E/RESOURCED( 2893): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.438
06-01 12:52:40.068+0900 D/AUL_AMD ( 2858): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.example /opt/usr/apps/org.example.example/bin/example
06-01 12:52:40.068+0900 D/RUA     ( 2858): rua.c: rua_add_history(179) > rua_add_history start
06-01 12:52:40.088+0900 D/RUA     ( 2858): rua.c: rua_add_history(247) > rua_add_history ok
06-01 12:52:40.368+0900 E/EFL     ( 6064): eo<6064> lib/eo/eo.c:676 _eo_call_resolve() in ../src/lib/evas/canvas/evas_common_interface.eo.c:1: func 'evas_common_evas_get' (62) could not be resolved for class 'Elm_Naviframe_Item'.
06-01 12:52:40.368+0900 E/EFL     ( 6064): eo<6064> lib/eo/eo.c:676 _eo_call_resolve() in ../src/lib/evas/canvas/evas_object.eo.c:74: func 'evas_obj_type_get' (128) could not be resolved for class 'Elm_Naviframe_Item'.
06-01 12:52:40.368+0900 E/EFL     ( 6064): elementary<6064> elm_widget.c:1101 elm_widget_sub_object_parent_add() You passed a wrong parent parameter (0x8000b85d (null)). Elementary widget's parent should be an elementary widget.
06-01 12:52:40.368+0900 E/EFL     ( 6064): <6064> lib/edje/edje_smart.c:22 edje_object_add() safety check failed: evas == NULL
06-01 12:52:40.408+0900 W/CRASH_MANAGER( 5816): worker.c: worker_job(1204) > 1106064657861149628916
