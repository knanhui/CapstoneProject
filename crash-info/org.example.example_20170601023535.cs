S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 10055
Date: 2017-06-01 02:35:35+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x14

Register Information
gs  = 0x00000033, fs  = 0xc1640000
es  = 0xffff007b, ds  = 0x0000007b
edi = 0xb9568568, esi = 0x8001a8d5
ebp = 0xbfed9078, esp = 0xbfed9040
eax = 0x00000000, ebx = 0xb72a65f0
ecx = 0x0000039b, edx = 0x00000015
eip = 0xb70fdbbf

Memory Information
MemTotal:      123 KB
MemFree:        23 KB
Buffers:         6 KB
Cached:     173092 KB
VmPeak:     100304 KB
VmSize:     100304 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       22092 KB
VmRSS:       22092 KB
VmData:      32752 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34460 KB
VmPTE:          80 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 10055 TID = 10055
10055 10056 10256 10257 

Maps Information
b2b09000 b2b13000 r-xp /usr/lib/libfeedback.so.0.1.4
b2b19000 b2b25000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2b26000 b2b47000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2b4c000 b2b4d000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2b4e000 b2b53000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2b54000 b2b55000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2b56000 b2b58000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2b59000 b2b65000 r-xp /usr/lib/libdrm.so.2.4.0
b2b66000 b2b69000 r-xp /usr/lib/libdri2.so.0.0.0
b2b6a000 b2b74000 r-xp /usr/lib/libtbm.so.1.0.0
b2b75000 b2b8a000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2b8b000 b2b9d000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b339f000 b33d0000 r-xp /usr/lib/libidn.so.11.5.44
b33d1000 b33f3000 r-xp /usr/lib/libnghttp2.so.5.4.0
b33f4000 b3404000 r-xp /usr/lib/libcares.so.2.1.0
b3405000 b340e000 r-xp /usr/lib/libeventsystem.so.0.0.1
b340f000 b3418000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3419000 b3490000 r-xp /usr/lib/libcurl.so.4.3.0
b3492000 b34a4000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b34a5000 b34c6000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b34cd000 b34ce000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b34cf000 b34d0000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b34d1000 b34d4000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b34d5000 b34d8000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b35e0000 b35e6000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b35e7000 b372b000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b373b000 b373d000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b373e000 b373f000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b3740000 b374b000 r-xp /opt/usr/apps/org.example.example/bin/example
b374d000 b3786000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b4189000 b4194000 r-xp /lib/libnss_files-2.20-2014.11.so
b4196000 b41a1000 r-xp /lib/libnss_nis-2.20-2014.11.so
b41a3000 b41ba000 r-xp /lib/libnsl-2.20-2014.11.so
b41be000 b41c6000 r-xp /lib/libnss_compat-2.20-2014.11.so
b41c8000 b41ec000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b41ed000 b41ee000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b41ef000 b41f2000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b41f3000 b41fa000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b41fb000 b4205000 r-xp /usr/lib/libsensord-share.so
b4206000 b4222000 r-xp /usr/lib/libsensor.so.1.2.0
b4224000 b422d000 r-xp /usr/lib/libappcore-common.so.1.1
b4230000 b4232000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b4247000 b4249000 r-xp /usr/lib/libXau.so.6.0.0
b424a000 b426c000 r-xp /usr/lib/libxcb.so.1.1.0
b426e000 b4277000 r-xp /lib/libcrypt-2.20-2014.11.so
b42a0000 b42a2000 r-xp /usr/lib/libiri.so
b42a3000 b42c9000 r-xp /lib/libexpat.so.1.5.2
b42cb000 b4336000 r-xp /usr/lib/libssl.so.1.0.0
b433c000 b4348000 r-xp /usr/lib/libethumb.so.1.13.0
b4349000 b434d000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b434e000 b459f000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b1a000 b5b2a000 r-xp /usr/lib/libXi.so.6.1.0
b5b2b000 b5b2d000 r-xp /usr/lib/libXgesture.so.7.0.0
b5b2e000 b5b34000 r-xp /usr/lib/libXtst.so.6.1.0
b5b35000 b5b3f000 r-xp /usr/lib/libXrender.so.1.3.0
b5b40000 b5b49000 r-xp /usr/lib/libXrandr.so.2.2.0
b5b4b000 b5b4d000 r-xp /usr/lib/libXinerama.so.1.0.0
b5b4e000 b5b53000 r-xp /usr/lib/libXfixes.so.3.1.0
b5b54000 b5b66000 r-xp /usr/lib/libXext.so.6.4.0
b5b67000 b5b69000 r-xp /usr/lib/libXdamage.so.1.1.0
b5b6a000 b5b6c000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5b6e000 b5cb0000 r-xp /usr/lib/libX11.so.6.3.0
b5cb4000 b5cbe000 r-xp /usr/lib/libXcursor.so.1.0.2
b5cbf000 b5cd5000 r-xp /usr/lib/libudev.so.1.6.0
b5cd8000 b5cdc000 r-xp /lib/libattr.so.1.1.0
b5cdd000 b5d0c000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d0e000 b5d14000 r-xp /usr/lib/libffi.so.6.0.2
b5d15000 b5d38000 r-xp /lib/libz.so.1.2.8
b5d39000 b5d3c000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5d3d000 b5e99000 r-xp /usr/lib/libxml2.so.2.9.2
b5e9f000 b5f86000 r-xp /usr/lib/libstdc++.so.6.0.20
b5f93000 b5f96000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5f97000 b5fb9000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5fba000 b5fce000 r-xp /lib/libresolv-2.20-2014.11.so
b5fd2000 b5ff6000 r-xp /usr/lib/liblzma.so.5.0.3
b5ff7000 b5ff9000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5ffb000 b6005000 r-xp /usr/lib/libembryo.so.1.13.0
b6006000 b602f000 r-xp /usr/lib/libpng12.so.0.50.0
b6030000 b6079000 r-xp /usr/lib/libjpeg.so.8.0.2
b608a000 b6091000 r-xp /lib/librt-2.20-2014.11.so
b6093000 b60b2000 r-xp /usr/lib/libector.so.1.13.0
b60b5000 b60e2000 r-xp /usr/lib/liblua-5.1.so
b60e3000 b6173000 r-xp /usr/lib/libfreetype.so.6.11.3
b6177000 b61b5000 r-xp /usr/lib/libfontconfig.so.1.8.0
b61b6000 b61cc000 r-xp /usr/lib/libfribidi.so.0.3.1
b61cd000 b6226000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6229000 b6274000 r-xp /lib/libm-2.20-2014.11.so
b6276000 b6288000 r-xp /usr/lib/libeio.so.1.13.0
b6289000 b628c000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b628d000 b6293000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b6294000 b62b7000 r-xp /usr/lib/libefreet.so.1.13.0
b62ba000 b62e5000 r-xp /usr/lib/libeldbus.so.1.13.0
b62e6000 b631a000 r-xp /usr/lib/libecore_con.so.1.13.0
b631c000 b6325000 r-xp /usr/lib/libecore_imf.so.1.13.0
b6326000 b632f000 r-xp /usr/lib/libethumb_client.so.1.13.0
b6330000 b6343000 r-xp /usr/lib/libeo.so.1.13.0
b6345000 b6358000 r-xp /usr/lib/libecore_input.so.1.13.0
b6359000 b6360000 r-xp /usr/lib/libecore_file.so.1.13.0
b6361000 b6384000 r-xp /usr/lib/libecore_evas.so.1.13.0
b6385000 b63b1000 r-xp /usr/lib/libeet.so.1.13.0
b63ba000 b6425000 r-xp /usr/lib/libeina.so.1.13.0
b6428000 b643f000 r-xp /usr/lib/libefl.so.1.13.0
b6441000 b65a8000 r-xp /usr/lib/libicuuc.so.51.1
b65b6000 b67c2000 r-xp /usr/lib/libicui18n.so.51.1
b67ca000 b6819000 r-xp /usr/lib/libecore_x.so.1.13.0
b681b000 b6835000 r-xp /lib/libgcc_s-4.9.so.1
b6837000 b683b000 r-xp /lib/libcap.so.2.21
b683c000 b6882000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6883000 b688a000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b688c000 b68de000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b68e0000 b6a6b000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6a70000 b6b3e000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6b41000 b6b45000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6b46000 b6b55000 r-xp /usr/lib/libvconf.so.0.2.45
b6b56000 b6b59000 r-xp /usr/lib/libvasum.so.0.3.1
b6b5a000 b6b5d000 r-xp /usr/lib/libttrace.so.1.1
b6b5f000 b6b63000 r-xp /usr/lib/libiniparser.so.0
b6b64000 b6b94000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6b95000 b6b9e000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6b9f000 b6bc4000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6bc5000 b6bd5000 r-xp /usr/lib/libunwind.so.8.0.1
b6bdf000 b6d8d000 r-xp /lib/libc-2.20-2014.11.so
b6d95000 b6ed8000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6eda000 b6f32000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6f33000 b6f67000 r-xp /usr/lib/libsystemd.so.0.4.0
b6f6a000 b703e000 r-xp /usr/lib/libedje.so.1.13.0
b7041000 b706d000 r-xp /usr/lib/libecore.so.1.13.0
b707e000 b72a4000 r-xp /usr/lib/libevas.so.1.13.0
b72cc000 b72e4000 r-xp /lib/libpthread-2.20-2014.11.so
b72e8000 b7662000 r-xp /usr/lib/libelementary.so.1.13.0
b7682000 b7686000 r-xp /usr/lib/libsmack.so.1.0.0
b7687000 b7690000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7691000 b7694000 r-xp /usr/lib/libdlog.so.0.0.0
b7695000 b769a000 r-xp /usr/lib/libbundle.so.0.1.22
b769b000 b769e000 r-xp /lib/libdl-2.20-2014.11.so
b76a0000 b76c5000 r-xp /usr/lib/libaul.so.0.1.0
b76c8000 b76ca000 r-xp /usr/lib/libappsvc.so.0.1.0
b76cb000 b76d0000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b76d1000 b76d8000 r-xp /usr/lib/libappcore-efl.so.1.1
b76da000 b76df000 r-xp /usr/lib/libsys-assert.so
b76e2000 b76e3000 r-xp [vdso]
b76e3000 b7705000 r-xp /lib/ld-2.20-2014.11.so
b7707000 b770f000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:10055)
Call Stack Count: 41
 0: (0xb70fdbbf) [/usr/lib/libevas.so.1] + 0x7fbbf
 1: (0xb70efce8) [/usr/lib/libevas.so.1] + 0x71ce8
 2: evas_obj_size_hint_min_set + 0xb9 (0xb70ea629) [/usr/lib/libevas.so.1] + 0x6c629
 3: evas_object_size_hint_min_set + 0x60 (0xb70f7fa0) [/usr/lib/libevas.so.1] + 0x79fa0
 4: (0xb74fbd29) [/usr/lib/libelementary.so.1] + 0x213d29
 5: elm_obj_layout_sizing_eval + 0x99 (0xb7493559) [/usr/lib/libelementary.so.1] + 0x1ab559
 6: (0xb749a205) [/usr/lib/libelementary.so.1] + 0x1b2205
 7: evas_obj_smart_add + 0x99 (0xb7108809) [/usr/lib/libevas.so.1] + 0x8a809
 8: (0xb748c79a) [/usr/lib/libelementary.so.1] + 0x1a479a
 9: evas_obj_smart_add + 0x99 (0xb7108809) [/usr/lib/libevas.so.1] + 0x8a809
10: (0xb750027b) [/usr/lib/libelementary.so.1] + 0x21827b
11: evas_obj_smart_add + 0x99 (0xb7108809) [/usr/lib/libevas.so.1] + 0x8a809
12: (0xb710bd8b) [/usr/lib/libevas.so.1] + 0x8dd8b
13: eo_constructor + 0x99 (0xb633a899) [/usr/lib/libeo.so.1] + 0xa899
14: (0xb75594a6) [/usr/lib/libelementary.so.1] + 0x2714a6
15: eo_constructor + 0x99 (0xb633a899) [/usr/lib/libeo.so.1] + 0xa899
16: (0xb749bc37) [/usr/lib/libelementary.so.1] + 0x1b3c37
17: eo_constructor + 0x99 (0xb633a899) [/usr/lib/libeo.so.1] + 0xa899
18: (0xb748c879) [/usr/lib/libelementary.so.1] + 0x1a4879
19: eo_constructor + 0x99 (0xb633a899) [/usr/lib/libeo.so.1] + 0xa899
20: (0xb75007c2) [/usr/lib/libelementary.so.1] + 0x2187c2
21: eo_constructor + 0x99 (0xb633a899) [/usr/lib/libeo.so.1] + 0xa899
22: elm_scroller_add + 0x77 (0xb74fedb7) [/usr/lib/libelementary.so.1] + 0x216db7
23: setting_view_cb + 0x3f (0xb374856f) [/opt/usr/apps/org.example.example/bin/example] + 0x856f
24: (0xb70b2449) [/usr/lib/libevas.so.1] + 0x34449
25: (0xb633e319) [/usr/lib/libeo.so.1] + 0xe319
26: eo_event_callback_call + 0xb3 (0xb633bd63) [/usr/lib/libeo.so.1] + 0xbd63
27: (0xb70b2a62) [/usr/lib/libevas.so.1] + 0x34a62
28: (0xb70c1441) [/usr/lib/libevas.so.1] + 0x43441
29: evas_canvas_event_feed_mouse_down + 0xcf (0xb70cb20f) [/usr/lib/libevas.so.1] + 0x4d20f
30: evas_event_feed_mouse_down + 0x6a (0xb70d1c2a) [/usr/lib/libevas.so.1] + 0x53c2a
31: (0xb434b49c) [/usr/lib/libecore_input_evas.so.1] + 0x249c
32: (0xb704e055) [/usr/lib/libecore.so.1] + 0xd055
33: (0xb70571b9) [/usr/lib/libecore.so.1] + 0x161b9
34: ecore_main_loop_begin + 0x57 (0xb7057587) [/usr/lib/libecore.so.1] + 0x16587
35: elm_run + 0x2d (0xb74b022d) [/usr/lib/libelementary.so.1] + 0x1c822d
36: appcore_efl_main + 0x4de (0xb76d4dde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
37: ui_app_main + 0x140 (0xb76cdc80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
38: main + 0x2a5 (0xb3747675) [/opt/usr/apps/org.example.example/bin/example] + 0x7675
39: (0xb7709148) [/opt/usr/apps/org.example.example/bin/example] + 0xb7709148
40: __libc_start_main + 0xde (0xb6bf6e4e) [/lib/libc.so.6] + 0x17e4e
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
iew( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Email] pos[2, 2] pageId[100001]
06-01 02:35:31.991+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[5]
06-01 02:35:31.991+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[6], [2, 2]
06-01 02:35:31.991+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[6], [2, 2]
06-01 02:35:31.991+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 02:35:31.991+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.emailui] Name[emailui] Icon[/opt/usr/apps/org.example.emailui/shared/res/emailui.png] enable[1] system[0]
06-01 02:35:31.991+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.emailui'], count[0]
06-01 02:35:31.991+0900 E/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.example.emailui][-17956860][0]
06-01 02:35:31.991+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.example.emailui]
06-01 02:35:31.991+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[emailui] pos[3, 2] pageId[100001]
06-01 02:35:31.991+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[15]
06-01 02:35:31.991+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[7], [3, 2]
06-01 02:35:31.991+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[7], [3, 2]
06-01 02:35:31.991+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 02:35:31.991+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.example] Name[forpet] Icon[/opt/usr/apps/org.example.example/shared/res/1.jpg] enable[1] system[0]
06-01 02:35:31.991+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.example'], count[0]
06-01 02:35:31.991+0900 E/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.example.example][-17956860][0]
06-01 02:35:31.991+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.example.example]
06-01 02:35:31.991+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[forpet] pos[4, 2] pageId[100001]
06-01 02:35:31.991+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[0]
06-01 02:35:31.991+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(787) >  AddBoxToMenuView
06-01 02:35:31.991+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: AddBoxToMenuView(347) >  AddBox Name[forpet] pageid[100001] pos[4, 2]
06-01 02:35:31.991+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: AddBoxToMenuView(354) >  menuPage.GetPageId() = 100001, boxPageId = 100001
06-01 02:35:31.991+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: AddBoxToPage(112) >  void ClusterHome3D::Internal::CMainMenuPage::AddBoxToPage(std::shared_ptr<CMainMenuBoxData>) : 112
06-01 02:35:31.991+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: AddBoxToPage(122) >  void ClusterHome3D::Internal::CMainMenuPage::AddBoxToPage(std::shared_ptr<CMainMenuBoxData>) : 122
06-01 02:35:31.991+0900 D/test-log( 2904): mainmenu-page-impl.cpp: AddBoxToPage(123) >  create box[org.example.example] [4,2]
06-01 02:35:31.991+0900 D/test-log( 2904): mainmenu-box-impl.cpp: CMainMenuBox(148) >  create box
06-01 02:35:32.001+0900 D/test-log( 2904): mainmenu-box-impl.cpp: SetPosition(459) >  cut Animation : forpet
06-01 02:35:32.001+0900 D/test-log( 2904): mainmenu-page-impl.cpp: AddBoxToPage(177) >  add created box
06-01 02:35:32.001+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.gallery] Name[Gallery] Icon[/usr/share/icons/default/small/org.tizen.gallery.png] enable[1] system[1]
06-01 02:35:32.001+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.gallery'], count[0]
06-01 02:35:32.001+0900 E/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.gallery][-17956860][0]
06-01 02:35:32.001+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.gallery]
06-01 02:35:32.001+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Gallery] pos[1, 3] pageId[100001]
06-01 02:35:32.001+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[6]
06-01 02:35:32.001+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[9], [1, 3]
06-01 02:35:32.001+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[8], [4, 2]
06-01 02:35:32.001+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 02:35:32.001+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.browser] Name[Internet] Icon[/usr/share/icons/default/small/org.tizen.browser.png] enable[1] system[1]
06-01 02:35:32.001+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.browser'], count[0]
06-01 02:35:32.001+0900 E/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.browser][-17956860][0]
06-01 02:35:32.001+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.browser]
06-01 02:35:32.001+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Internet] pos[2, 3] pageId[100001]
06-01 02:35:32.001+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[1]
06-01 02:35:32.001+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[10], [2, 3]
06-01 02:35:32.001+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 02:35:32.001+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 02:35:32.001+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.message] Name[Messages] Icon[/usr/share/icons/default/small/org.tizen.message.png] enable[1] system[1]
06-01 02:35:32.001+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.message'], count[1]
06-01 02:35:32.001+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.message]
06-01 02:35:32.001+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Messages] pos[3, 3] pageId[100001]
06-01 02:35:32.001+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[7]
06-01 02:35:32.001+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[11], [3, 3]
06-01 02:35:32.001+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 02:35:32.001+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 02:35:32.001+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.music-player] Name[Music] Icon[/usr/share/icons/default/small/org.tizen.music-player.png] enable[1] system[1]
06-01 02:35:32.001+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.music-player'], count[0]
06-01 02:35:32.001+0900 E/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.music-player][-17956860][0]
06-01 02:35:32.001+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.music-player]
06-01 02:35:32.001+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Music] pos[4, 3] pageId[100001]
06-01 02:35:32.001+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[8]
06-01 02:35:32.001+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[12], [4, 3]
06-01 02:35:32.001+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 02:35:32.001+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 02:35:32.001+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.myfile] Name[My Files] Icon[/usr/share/icons/default/small/org.tizen.myfile.png] enable[1] system[1]
06-01 02:35:32.021+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.myfile'], count[0]
06-01 02:35:32.021+0900 E/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.myfile][-17956860][0]
06-01 02:35:32.021+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.myfile]
06-01 02:35:32.021+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[My Files] pos[1, 4] pageId[100001]
06-01 02:35:32.021+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[9]
06-01 02:35:32.021+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[13], [1, 4]
06-01 02:35:32.021+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 02:35:32.021+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 02:35:32.021+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.phone] Name[Phone] Icon[/usr/share/icons/default/small/org.tizen.phone.png] enable[1] system[1]
06-01 02:35:32.021+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.phone'], count[0]
06-01 02:35:32.021+0900 E/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.phone][-17956860][0]
06-01 02:35:32.021+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.phone]
06-01 02:35:32.021+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Phone] pos[2, 4] pageId[100001]
06-01 02:35:32.021+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[10]
06-01 02:35:32.021+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[14], [2, 4]
06-01 02:35:32.021+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 02:35:32.021+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 02:35:32.021+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.setting] Name[Settings] Icon[/usr/share/icons/default/small/org.tizen.setting.png] enable[1] system[1]
06-01 02:35:32.021+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.setting'], count[0]
06-01 02:35:32.021+0900 E/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.setting][-17956860][0]
06-01 02:35:32.021+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.setting]
06-01 02:35:32.021+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Settings] pos[3, 4] pageId[100001]
06-01 02:35:32.021+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[11]
06-01 02:35:32.021+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[15], [3, 4]
06-01 02:35:32.021+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 02:35:32.021+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 02:35:32.021+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.uibuildernavigationview] Name[uibuildernavigationview] Icon[/opt/usr/apps/org.example.uibuildernavigationview/shared/res/uibuildernavigationview.png] enable[1] system[0]
06-01 02:35:32.021+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.uibuildernavigationview'], count[0]
06-01 02:35:32.021+0900 E/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.example.uibuildernavigationview][-17956860][0]
06-01 02:35:32.021+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.example.uibuildernavigationview]
06-01 02:35:32.021+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[uibuildernavigationview] pos[4, 4] pageId[100001]
06-01 02:35:32.021+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[14]
06-01 02:35:32.021+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[16], [4, 4]
06-01 02:35:32.021+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 02:35:32.021+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 02:35:32.021+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.videos] Name[Video] Icon[/usr/share/icons/default/small/org.tizen.videos.png] enable[1] system[1]
06-01 02:35:32.021+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.videos'], count[0]
06-01 02:35:32.021+0900 E/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.videos][-17956860][0]
06-01 02:35:32.021+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.videos]
06-01 02:35:32.021+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Video] pos[1, 5] pageId[100001]
06-01 02:35:32.021+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[12]
06-01 02:35:32.021+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[17], [1, 5]
06-01 02:35:32.021+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 02:35:32.021+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 02:35:32.021+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: RearrangeItems(243) >  view type [1]
06-01 02:35:32.391+0900 D/rpm-installer(10197): rpm-installer-privilege.c: __ri_privilege_perm_end(55) > [smack] perm_end, result=[0]
06-01 02:35:32.391+0900 D/rpm-installer(10197): rpm-appcore-intf.c: main(259) > ------------------------------------------------
06-01 02:35:32.391+0900 D/rpm-installer(10197): rpm-appcore-intf.c: main(260) >  [END] rpm-installer: result=[0]
06-01 02:35:32.391+0900 D/rpm-installer(10197): rpm-appcore-intf.c: main(261) > ------------------------------------------------
06-01 02:35:32.391+0900 D/PKGMGR_SERVER(10183): pkgmgr-server.c: sighandler(387) > child exit [10197]
06-01 02:35:32.391+0900 E/PKGMGR_SERVER(10183): pkgmgr-server.c: sighandler(402) > child NORMAL exit [10197]
06-01 02:35:33.001+0900 E/PKGMGR_SERVER(10183): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-01 02:35:33.001+0900 E/PKGMGR_SERVER(10183): pkgmgr-server.c: main(2265) > package manager server terminated.
06-01 02:35:33.191+0900 D/AUL_AMD ( 2773): amd_request.c: __request_handler(838) > __request_handler: 0
06-01 02:35:33.191+0900 D/AUL_AMD ( 2773): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.example
06-01 02:35:33.191+0900 D/PKGMGR_INFO( 2773): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-01 02:35:33.191+0900 D/PKGMGR_INFO( 2773): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-01 02:35:33.191+0900 I/AUL     ( 2773): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
06-01 02:35:33.191+0900 D/AUL     ( 2773): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 10250, pid = 10252
06-01 02:35:33.191+0900 D/PKGMGR_INFO( 2773): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-01 02:35:33.191+0900 D/PKGMGR_INFO( 2773): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-01 02:35:33.191+0900 I/AUL     ( 2773): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
06-01 02:35:33.191+0900 E/AUL_AMD ( 2773): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
06-01 02:35:33.191+0900 W/AUL_AMD ( 2773): amd_launch.c: _start_app(2233) > caller pid : 10252
06-01 02:35:33.191+0900 E/AUL_AMD ( 2773): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
06-01 02:35:33.191+0900 W/AUL_AMD ( 2773): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.example) pkgid(org.example.example) attribute(600)
06-01 02:35:33.211+0900 D/AUL_AMD ( 2773): amd_launch.c: _start_app(2648) > process_pool: false
06-01 02:35:33.211+0900 D/AUL_AMD ( 2773): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
06-01 02:35:33.211+0900 D/AUL_AMD ( 2773): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.example
06-01 02:35:33.211+0900 W/AUL_AMD ( 2773): amd_launch.c: _start_app(2665) > pad pid(-5)
06-01 02:35:33.211+0900 D/AUL_AMD ( 2773): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
06-01 02:35:33.211+0900 D/AUL_AMD ( 2773): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
06-01 02:35:33.211+0900 D/AUL     ( 2773): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
06-01 02:35:33.211+0900 D/AUL_PAD ( 2951): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
06-01 02:35:33.211+0900 D/AUL_PAD ( 2951): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
06-01 02:35:33.211+0900 D/AUL_PAD ( 2951): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-01 02:35:33.211+0900 D/AUL_PAD ( 2951): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-01 02:35:33.211+0900 D/AUL_PAD ( 2951): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-01 02:35:33.211+0900 D/AUL_PAD ( 2951): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-01 02:35:33.211+0900 D/AUL_PAD ( 2951): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-01 02:35:33.211+0900 D/AUL_PAD ( 2951): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
06-01 02:35:33.211+0900 D/AUL_PAD ( 2951): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
06-01 02:35:33.211+0900 D/AUL_PAD ( 2951): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
06-01 02:35:33.211+0900 D/AUL_PAD ( 2951): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
06-01 02:35:33.211+0900 D/AUL_PAD ( 2951): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
06-01 02:35:33.211+0900 D/AUL_PAD ( 2951): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
06-01 02:35:33.211+0900 D/AUL_PAD ( 2951): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
06-01 02:35:33.211+0900 W/AUL_PAD ( 2951): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
06-01 02:35:33.211+0900 D/AUL     ( 2951): process_pool.c: __send_pkt_raw_data(219) > send(11) : 624 / 624
06-01 02:35:33.211+0900 D/AUL_PAD ( 2951): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 10055, bin path: /opt/usr/apps/org.example.example/bin/example
06-01 02:35:33.211+0900 W/AUL_PAD ( 2951): launchpad.c: __send_result_to_caller(265) > Check app launching
06-01 02:35:33.211+0900 D/AUL_PAD ( 2951): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
06-01 02:35:33.211+0900 D/AUL_PAD (10055): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
06-01 02:35:33.211+0900 D/AUL_PAD (10055): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 624, pkt->len: 616
06-01 02:35:33.211+0900 D/AUL_PAD (10055): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
06-01 02:35:33.211+0900 D/AUL_PAD (10055): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
06-01 02:35:33.211+0900 D/AUL_PAD (10055): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
06-01 02:35:33.211+0900 D/AUL_PAD (10055): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
06-01 02:35:33.211+0900 D/AUL     (10055): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (10056) is sent.
06-01 02:35:33.211+0900 D/AUL     (10055): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 10056, signo: 10
06-01 02:35:33.211+0900 D/AUL     (10055): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
06-01 02:35:33.211+0900 D/AUL_PAD (10055): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
06-01 02:35:33.211+0900 D/AUL_PAD (10055): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
06-01 02:35:33.211+0900 D/AUL_PAD (10055): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
06-01 02:35:33.211+0900 D/AUL_PAD (10055): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
06-01 02:35:33.211+0900 D/AUL_PAD (10055): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0OTYyNTIxMzMvMTk4NTA4AA==##
06-01 02:35:33.211+0900 D/AUL_PAD (10055): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
06-01 02:35:33.211+0900 D/AUL_PAD (10055): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KQAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAYAAAAxMDI1MgA=##
06-01 02:35:33.211+0900 D/AUL_PAD (10055): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
06-01 02:35:33.211+0900 D/AUL_PAD (10055): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
06-01 02:35:33.211+0900 D/AUL_PAD (10055): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 8
06-01 02:35:33.211+0900 D/AUL_PAD (10055): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
06-01 02:35:33.211+0900 D/AUL_PAD (10055): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
06-01 02:35:33.221+0900 D/RESOURCED( 2886): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
06-01 02:35:33.221+0900 D/RESOURCED( 2886): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 1
06-01 02:35:33.221+0900 E/RESOURCED( 2886): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-01 02:35:33.221+0900 I/CAPI_APPFW_APPLICATION(10055): app_main.c: ui_app_main(788) > app_efl_main
06-01 02:35:33.221+0900 D/LAUNCH  (10055): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
06-01 02:35:33.221+0900 D/APP_CORE(10055): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
06-01 02:35:33.221+0900 D/APP_CORE(10055): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
06-01 02:35:33.221+0900 D/APP_CORE(10055): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
06-01 02:35:33.231+0900 D/APP_CORE(10055): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
06-01 02:35:33.231+0900 D/AUL     (10055): app_sock.c: __create_server_sock(156) > pg path - already exists
06-01 02:35:33.231+0900 D/APP_CORE(10055): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb422d520
06-01 02:35:33.231+0900 D/LAUNCH  (10055): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
06-01 02:35:33.231+0900 I/CAPI_APPFW_APPLICATION(10055): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
06-01 02:35:33.301+0900 D/AUL_PAD ( 2951): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
06-01 02:35:33.301+0900 W/AUL     ( 2773): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 10055, appid: org.example.example
06-01 02:35:33.301+0900 D/AUL     ( 2773): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
06-01 02:35:33.301+0900 E/AUL     ( 2773): simple_util.c: __trm_app_info_send_socket(330) > access
06-01 02:35:33.301+0900 D/AUL_AMD ( 2773): amd_launch.c: _start_app(2700) > add app group info
06-01 02:35:33.301+0900 E/AUL     ( 2773): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
06-01 02:35:33.301+0900 D/AUL_AMD ( 2773): amd_status.c: _status_add_app_info_list(427) > pid(10055) appid(org.example.example) pkgid(org.example.example) comp(uiapp)
06-01 02:35:33.311+0900 D/RESOURCED( 2886): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.example, 10055
06-01 02:35:33.311+0900 D/RESOURCED( 2886): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.example with pkgname
06-01 02:35:33.311+0900 E/RESOURCED( 2886): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.example
06-01 02:35:33.311+0900 D/RESOURCED( 2886): proc-main.c: resourced_proc_status_change(888) > available memory = 296
06-01 02:35:33.341+0900 D/LAUNCH  (10055): appcore-efl.c: __before_loop(1154) > [example:Application:create:done]
06-01 02:35:33.351+0900 D/APP_CORE(10055): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
06-01 02:35:33.351+0900 E/E17     ( 2798): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x01200002)
06-01 02:35:33.401+0900 E/E17     ( 2798): e_border.c: e_border_show(2088) > BD_SHOW(0x01200002)
06-01 02:35:33.411+0900 D/APP_CORE(10055): appcore.c: __aul_handler(587) > [APP 10055]     AUL event: AUL_START
06-01 02:35:33.411+0900 I/APP_CORE(10055): appcore-efl.c: __do_app(496) > [APP 10055] Event: RESET State: CREATED
06-01 02:35:33.411+0900 D/APP_CORE(10055): appcore-efl.c: __do_app(527) > [APP 10055] RESET
06-01 02:35:33.411+0900 D/LAUNCH  (10055): appcore-efl.c: __do_app(529) > [example:Application:reset:start]
06-01 02:35:33.411+0900 D/APP_CORE(10055): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
06-01 02:35:33.411+0900 D/APP_CORE(10055): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-01 02:35:33.411+0900 I/CAPI_APPFW_APPLICATION(10055): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
06-01 02:35:33.411+0900 D/AUL     (10055): service.c: __set_bundle(186) > __set_bundle
06-01 02:35:33.411+0900 D/LAUNCH  (10055): appcore-efl.c: __do_app(544) > [example:Application:reset:done]
06-01 02:35:33.411+0900 D/APP_CORE(10055): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
06-01 02:35:33.411+0900 E/EFL     (10055): edje<10055> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 02:35:33.411+0900 E/EFL     (10055): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 02:35:33.431+0900 E/EFL     (10055): edje<10055> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 02:35:33.431+0900 E/EFL     (10055): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 02:35:33.431+0900 E/EFL     (10055): edje<10055> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 02:35:33.431+0900 E/EFL     (10055): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 02:35:33.431+0900 E/EFL     (10055): edje<10055> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 02:35:33.431+0900 E/EFL     (10055): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 02:35:33.431+0900 E/EFL     (10055): edje<10055> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 02:35:33.431+0900 E/EFL     (10055): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 02:35:33.431+0900 W/PROCESSMGR( 2798): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=10055
06-01 02:35:33.441+0900 W/APP_CORE(10055): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1200002
06-01 02:35:33.441+0900 D/APP_CORE(10055): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:1200002
06-01 02:35:33.441+0900 D/APP_CORE(10055): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
06-01 02:35:33.441+0900 D/AUL     (10055): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
06-01 02:35:33.441+0900 D/AUL_AMD ( 2773): amd_request.c: __request_handler(838) > __request_handler: 34
06-01 02:35:33.441+0900 E/EFL     ( 2798): eo<2798> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-01 02:35:33.441+0900 E/EFL     ( 2798): eo<2798> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-01 02:35:33.461+0900 D/INDICATOR( 2891): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
06-01 02:35:33.461+0900 D/AUL_AMD ( 2773): amd_request.c: __request_handler(838) > __request_handler: 15
06-01 02:35:33.471+0900 D/PKGMGR_INFO( 2773): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-01 02:35:33.471+0900 D/PKGMGR_INFO( 2773): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-01 02:35:33.471+0900 D/INDICATOR( 2891): util.c: util_signal_emit_by_win(116) > emission bg.opaque
06-01 02:35:33.471+0900 D/AUL_AMD ( 2773): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 10055 is org.example.example
06-01 02:35:33.471+0900 D/AUL_AMD ( 2773): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 10055 : 0
06-01 02:35:33.471+0900 D/AUL     ( 2966): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
06-01 02:35:33.491+0900 D/INDICATOR( 2891): main.c: _rotate_window(229) > Indicator angle is 0 degree
06-01 02:35:33.491+0900 D/INDICATOR( 2891): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
06-01 02:35:33.491+0900 D/INDICATOR( 2891): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
06-01 02:35:33.491+0900 D/INDICATOR( 2891): main.c: _rotate_window(252) > port :: hide more icon
06-01 02:35:33.771+0900 D/APP_CORE(10055): appcore.c: __prt_ltime(236) > [APP 10055] first idle after reset: 591 msec
06-01 02:35:33.861+0900 E/E17     ( 2798): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
06-01 02:35:33.871+0900 D/APP_CORE( 2904): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
06-01 02:35:33.871+0900 D/APP_CORE( 2904): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
06-01 02:35:33.871+0900 D/APP_CORE( 2904): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
06-01 02:35:33.871+0900 I/APP_CORE( 2904): appcore-efl.c: __do_app(496) > [APP 2904] Event: PAUSE State: RUNNING
06-01 02:35:33.871+0900 D/APP_CORE( 2904): appcore-efl.c: __do_app(565) > [APP 2904] PAUSE
06-01 02:35:33.871+0900 I/CAPI_APPFW_APPLICATION( 2904): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
06-01 02:35:33.871+0900 E/cluster-home( 2904): homescreen.cpp: OnPause(84) >  app pause
06-01 02:35:33.871+0900 D/cluster-view( 2904): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
06-01 02:35:33.871+0900 D/cluster-view( 2904): homescreen-view-manager.cpp: AppPause(923) >  END
06-01 02:35:33.871+0900 D/APP_CORE( 2904): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-01 02:35:33.871+0900 E/APP_CORE( 2904): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-01 02:35:33.881+0900 D/AUL_AMD ( 2773): amd_status.c: _status_update_app_info_list(456) > pid(2904) status(4)
06-01 02:35:33.881+0900 D/AUL_AMD ( 2773): amd_status.c: _status_update_app_info_list(468) > pid(2904) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
06-01 02:35:33.881+0900 D/AUL     ( 2773): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
06-01 02:35:33.881+0900 W/AUL     ( 2773): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2904, appid: org.tizen.homescreen, status: bg
06-01 02:35:33.881+0900 D/DATA_PROVIDER_MASTER( 2954): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2904 is paused
06-01 02:35:33.881+0900 D/DATA_PROVIDER_MASTER( 2954): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
06-01 02:35:33.901+0900 I/CAPI_WIDGET_APPLICATION( 3032): widget_app.c: __provider_pause_cb(294) > widget obj was paused
06-01 02:35:33.901+0900 I/CAPI_WIDGET_APPLICATION( 3032): widget_app.c: __check_status_for_cgroup(142) > enter background group
06-01 02:35:33.901+0900 W/AUL     ( 3032): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3032, appid: org.tizen.calendar.widget, status: bg
06-01 02:35:33.901+0900 D/AUL_AMD ( 2773): amd_launch.c: __e17_status_handler(2891) > pid(10055) status(3)
06-01 02:35:33.901+0900 D/AUL_AMD ( 2773): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
06-01 02:35:33.901+0900 D/RESOURCED( 2886): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3032, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
06-01 02:35:33.901+0900 D/RESOURCED( 2886): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 3032
06-01 02:35:33.901+0900 D/RESOURCED( 2886): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 3032, appname = org.tizen.calendar.widget
06-01 02:35:33.901+0900 D/RESOURCED( 2886): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 3032
06-01 02:35:33.911+0900 W/AUL_AMD ( 2773): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-01 02:35:33.911+0900 W/AUL_AMD ( 2773): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
06-01 02:35:33.911+0900 D/AUL_AMD ( 2773): amd_status.c: _status_update_app_info_list(456) > pid(10055) status(3)
06-01 02:35:33.911+0900 D/AUL_AMD ( 2773): amd_status.c: _status_update_app_info_list(468) > pid(10055) appid(org.example.example) pkgid(org.example.example) status(3)
06-01 02:35:33.911+0900 D/AUL     ( 2773): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.example
06-01 02:35:33.911+0900 W/AUL     ( 2773): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 10055, appid: org.example.example, status: fg
06-01 02:35:33.911+0900 D/RESOURCED( 2886): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 10055
06-01 02:35:33.911+0900 D/RESOURCED( 2886): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 10055, proc_name: org.example.example, cg_name: foreground, oom_score_adj: 200
06-01 02:35:33.911+0900 D/RESOURCED( 2886): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 10055
06-01 02:35:33.951+0900 D/APP_CORE(10055): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1200002 fully_obscured 0
06-01 02:35:33.951+0900 D/APP_CORE(10055): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
06-01 02:35:33.951+0900 D/APP_CORE(10055): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
06-01 02:35:33.951+0900 I/APP_CORE(10055): appcore-efl.c: __do_app(496) > [APP 10055] Event: RESUME State: CREATED
06-01 02:35:33.951+0900 D/LAUNCH  (10055): appcore-efl.c: __do_app(597) > [example:Application:resume:start]
06-01 02:35:33.951+0900 D/APP_CORE(10055): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
06-01 02:35:33.951+0900 D/APP_CORE(10055): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-01 02:35:33.951+0900 D/APP_CORE(10055): appcore-efl.c: __do_app(607) > [APP 10055] RESUME
06-01 02:35:33.951+0900 I/APP_CORE(10055): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
06-01 02:35:33.951+0900 I/APP_CORE(10055): appcore-efl.c: __do_app(614) > [APP 10055] Initial Launching, call the resume_cb
06-01 02:35:33.951+0900 I/CAPI_APPFW_APPLICATION(10055): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
06-01 02:35:33.951+0900 D/LAUNCH  (10055): appcore-efl.c: __do_app(636) > [example:Application:resume:done]
06-01 02:35:33.951+0900 D/LAUNCH  (10055): appcore-efl.c: __do_app(638) > [example:Application:Launching:done]
06-01 02:35:33.951+0900 D/APP_CORE(10055): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-01 02:35:33.951+0900 E/APP_CORE(10055): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-01 02:35:33.991+0900 D/RESOURCED( 2886): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 10055, appname = org.example.example, pkgname = org.example.example
06-01 02:35:33.991+0900 D/RESOURCED( 2886): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 10055, appname = org.example.example
06-01 02:35:33.991+0900 D/RESOURCED( 2886): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 10055
06-01 02:35:33.991+0900 I/RESOURCED( 2886): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
06-01 02:35:33.991+0900 I/RESOURCED( 2886): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
06-01 02:35:34.031+0900 D/AUL_AMD ( 2773): amd_launch.c: __e17_status_handler(2910) > pid(10055) status(0)
06-01 02:35:34.311+0900 D/AUL_PAD ( 2951): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
06-01 02:35:34.311+0900 D/AUL_PAD (10260): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
06-01 02:35:34.341+0900 D/AUL_PAD ( 2951): sigchild.h: __send_app_launch_signal(131) > send launch signal done
06-01 02:35:34.821+0900 D/AUL_AMD ( 2773): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.example /opt/usr/apps/org.example.example/bin/example
06-01 02:35:34.821+0900 D/RUA     ( 2773): rua.c: rua_add_history(179) > rua_add_history start
06-01 02:35:34.881+0900 D/RUA     ( 2773): rua.c: rua_add_history(247) > rua_add_history ok
06-01 02:35:35.361+0900 D/AUL_PAD (10260): launchpad_loader.c: main(588) > sleeping 1 sec...
06-01 02:35:35.361+0900 D/AUL_PAD (10260): preload.h: __preload_init(52) > max_cmdline_size = 1053
06-01 02:35:35.401+0900 D/AUL_PAD (10260): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b9434760
06-01 02:35:35.401+0900 D/AUL_PAD (10260): preload.h: __preload_init(69) > get pre-initialization function
06-01 02:35:35.401+0900 D/AUL_PAD (10260): preload.h: __preload_init(73) > get shutdown function
06-01 02:35:35.401+0900 D/AUL_PAD (10260): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b9434a40
06-01 02:35:35.411+0900 D/AUL_PAD (10260): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b9436640
06-01 02:35:35.411+0900 D/AUL_PAD (10260): preload.h: __preload_init(69) > get pre-initialization function
06-01 02:35:35.411+0900 D/AUL_PAD (10260): preload.h: __preload_init(73) > get shutdown function
06-01 02:35:35.411+0900 D/AUL_PAD (10260): preexec.h: __preexec_init(76) > preexec start
06-01 02:35:35.411+0900 D/AUL_PAD (10260): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
06-01 02:35:35.411+0900 D/AUL     (10260): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
06-01 02:35:35.411+0900 D/AUL     (10260): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
06-01 02:35:35.411+0900 D/AUL     (10260): process_pool.c: __connect_to_launchpad(132) > send(10260) : 4
06-01 02:35:35.411+0900 D/AUL     (10260): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
06-01 02:35:35.421+0900 D/AUL_PAD ( 2951): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
06-01 02:35:35.421+0900 D/AUL_PAD ( 2951): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
06-01 02:35:35.421+0900 D/AUL_PAD ( 2951): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-01 02:35:35.421+0900 D/AUL_PAD ( 2951): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-01 02:35:35.421+0900 D/AUL_PAD ( 2951): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-01 02:35:35.421+0900 D/AUL_PAD ( 2951): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-01 02:35:35.421+0900 D/AUL_PAD ( 2951): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-01 02:35:35.421+0900 D/AUL_PAD ( 2951): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
06-01 02:35:35.421+0900 D/AUL_PAD ( 2951): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 10260
06-01 02:35:35.691+0900 E/EFL     (10055): eo<10055> lib/eo/eo.c:676 _eo_call_resolve() in ../src/lib/evas/canvas/evas_common_interface.eo.c:1: func 'evas_common_evas_get' (62) could not be resolved for class 'Elm_Naviframe_Item'.
06-01 02:35:35.691+0900 E/EFL     (10055): eo<10055> lib/eo/eo.c:676 _eo_call_resolve() in ../src/lib/evas/canvas/evas_object.eo.c:74: func 'evas_obj_type_get' (128) could not be resolved for class 'Elm_Naviframe_Item'.
06-01 02:35:35.691+0900 E/EFL     (10055): elementary<10055> elm_widget.c:1101 elm_widget_sub_object_parent_add() You passed a wrong parent parameter (0x8000b85d (null)). Elementary widget's parent should be an elementary widget.
06-01 02:35:35.691+0900 E/EFL     (10055): <10055> lib/edje/edje_smart.c:22 edje_object_add() safety check failed: evas == NULL
06-01 02:35:35.771+0900 D/AUL_PAD ( 2951): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
06-01 02:35:35.771+0900 D/AUL_PAD ( 2951): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
06-01 02:35:35.771+0900 D/AUL_PAD ( 2951): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-01 02:35:35.771+0900 D/AUL_PAD ( 2951): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-01 02:35:35.771+0900 D/AUL_PAD ( 2951): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-01 02:35:35.771+0900 D/AUL_PAD ( 2951): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-01 02:35:35.771+0900 D/AUL_PAD ( 2951): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-01 02:35:35.771+0900 I/AUL_PAD ( 2951): sigchild.h: __launchpad_process_sigchld(161) > dead_pid = 10055 pgid = 10055
06-01 02:35:35.771+0900 I/AUL_PAD ( 2951): sigchild.h: __sigchild_action(142) > dead_pid(10055)
06-01 02:35:35.771+0900 W/CRASH_MANAGER(10262): worker.c: worker_job(1204) > 1110055657861149625213
